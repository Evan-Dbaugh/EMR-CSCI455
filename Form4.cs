using MySql.Data.MySqlClient;
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
    public partial class doctorForm : Form
    {
        private int loggedUserID;
        int selectedUserID;
        string docFolder = @"C:\EMRDocs\";
        public doctorForm(int userID)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            loggedUserID = userID;
        }

        private void doctorForm_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            string query = "SELECT FirstName, LastName FROM Doctors WHERE UserID = @userID";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", loggedUserID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        welcomeLabel.Text = "Welcome " + fullName;
                    }
                }
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string patientName = searchPatientBox.Text;
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            string query = "SELECT UserID, FirstName, LastName, DOB, Email, Address, EmergencyContact, Prescriptions, Appointments FROM PATIENTS " +
                            "WHERE FirstName = @name OR lastName = @name";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", patientName);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        string fullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        pInfoBox.Text = "Name: " + fullName + Environment.NewLine + Environment.NewLine +
                                        "DOB: " + reader["DOB"].ToString() + Environment.NewLine + Environment.NewLine +
                                        "Email: " + reader["Email"].ToString() + Environment.NewLine + Environment.NewLine +
                                        "Address: " + reader["Address"].ToString() + Environment.NewLine + Environment.NewLine +
                                        "Emergency Contact: " + reader["EmergencyContact"].ToString();
                        prescBox.Text = reader["Prescriptions"].ToString();
                        appointmentsBox.Text = reader["Appointments"].ToString();
                        vitalsTBox.Text = "BP: 120/79";
                        int userID = Convert.ToInt32(reader["UserID"]);
                        selectedUserID = userID;
                    }
                    else
                    {
                        MessageBox.Show("Patient Not Found");
                        pInfoBox.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }

            LoadDocuments(selectedUserID);
        }

        private void downloadButton_Click(object sender, EventArgs e) //view
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

        private void button1_Click(object sender, EventArgs e)//download
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

        private void button2_Click(object sender, EventArgs e)//upload
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

                    cmd.Parameters.AddWithValue("@pid", selectedUserID);
                    cmd.Parameters.AddWithValue("@name", fileName);
                    cmd.Parameters.AddWithValue("@path", destPath);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Uploaded!");
            }

            LoadDocuments(selectedUserID);
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







    }
}
