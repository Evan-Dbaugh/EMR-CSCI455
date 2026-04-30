using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI455_EMR
{
    public partial class patientForm : Form
    {
        private int loggedUserID;
        string docFolder = @"C:\EMRDocs\";
        public patientForm(int userID)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            loggedUserID = userID;
        }

        private void patientForm_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            string query = "SELECT FirstName, LastName, Appointments FROM Patients WHERE UserID = @userID";

            try
            {
                using(MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", loggedUserID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        patientLabel.Text = "Welcome " + fullName;
                        LoadAppointments();
                    }
                }
                LoadDocuments(loggedUserID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Patient Data: " + ex.Message);
            }


        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (documentsList.SelectedItem == null) return;
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            string selected = documentsList.SelectedItem.ToString();
            int docID = int.Parse(selected.Split('-')[0].Trim());

            string query = "SELECT FilePath FROM Documents WHERE DocumentID = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", docID);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("File not found in database.");
                    return;
                }

                string sourcePath = result.ToString();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = Path.GetFileName(sourcePath);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(sourcePath, sfd.FileName, true);
                    MessageBox.Show("Downloaded!");
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);

                if (!Directory.Exists(docFolder))
                {
                    Directory.CreateDirectory(docFolder);
                }

                string destPath = Path.Combine(docFolder, fileName);

                File.Copy(ofd.FileName, destPath, true);

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO Documents (PatientID, FileName, FilePath) VALUES (@pid, @name, @path)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@pid", loggedUserID);
                    cmd.Parameters.AddWithValue("@name", fileName);
                    cmd.Parameters.AddWithValue("@path", destPath);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Uploaded!");
            }

            LoadDocuments(loggedUserID);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (documentsList.SelectedItem == null) return;

            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            string selected = documentsList.SelectedItem.ToString();
            int docID = int.Parse(selected.Split('-')[0].Trim());

            string query = "SELECT FilePath FROM Documents WHERE DocumentID = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", docID);

                string path = cmd.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
        }

        private void LoadDocuments(int userID)
        {
            documentsList.Items.Clear();
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT DocumentID, FileName FROM Documents WHERE PatientID = @userID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    documentsList.Items.Add(
                        reader["DocumentID"].ToString() + " - " + reader["FileName"].ToString()
                    );
                }
            }
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            newAppointmentForm newAF = new newAppointmentForm(loggedUserID, this);
            newAF.Show();
        }

        public void LoadAppointments()
        {
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Appointments FROM Patients WHERE UserID = @userID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", loggedUserID);

                object result = cmd.ExecuteScalar();

                if (result == null || string.IsNullOrWhiteSpace(result.ToString()))
                {
                    appointmentsBox.Text = "No appointments.";
                    return;
                }

                // Split into lines
                string[] lines = result.ToString()
                                       .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Sort by date
                var sorted = lines
                    .Select(line =>
                    {
                        try
                        {
                            // Format: yyyy-MM-dd - time - type
                            string datePart = line.Split('-')[0].Trim();
                            DateTime date = DateTime.Parse(datePart);
                            return new { Line = line, Date = date };
                        }
                        catch
                        {
                            return new { Line = line, Date = DateTime.MaxValue };
                        }
                    })
                    .OrderBy(x => x.Date)
                    .Select(x => x.Line);

                // Display nicely
                appointmentsBox.Text = string.Join(Environment.NewLine, sorted);
            }
        }
    }
}
