using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI455_EMR
{
    public partial class adminForm : Form
    {
        private int loggedUserID;
        int selectedUserID;
        string docFolder = @"C:\EMRDocs\";
        public adminForm(int userID)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            loggedUserID = userID;
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

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
            string username = searchUserBox.Text.Trim();
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            try
            {
                using(MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string userQuery = "SELECT UserID, Role FROM UserAccounts WHERE Username = @username";

                    MySqlCommand userCMD = new MySqlCommand(userQuery, conn);
                    userCMD.Parameters.AddWithValue("@username", username);
                    MySqlDataReader reader = userCMD.ExecuteReader();

                    if(!reader.Read())
                    {
                        MessageBox.Show("User Not Found");
                        reader.Close();
                        return;
                    }

                    int userID = Convert.ToInt32(reader["UserID"]);
                    selectedUserID = userID;
                    string role = reader["Role"].ToString();
                    reader.Close();

                    LoadDocuments(selectedUserID);

                    string name = "";
                    string email = "";
                    string address = "";

                    if(role == "PATIENT")
                    {
                        string query = "SELECT FirstName, LastName, Email, Address FROM Patients WHERE UserID = @userID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userID);

                        MySqlDataReader r = cmd.ExecuteReader();

                        if (r.Read())
                        {
                            name = r["FirstName"].ToString() + " " + r["LastName"].ToString();
                            email = r["Email"].ToString();
                            address = r["Address"].ToString();
                        }

                        r.Close();
                    }
                    else if(role == "NURSE")
                    {
                        string query = "SELECT FirstName, LastName, Email FROM Nurses WHERE UserID = @userID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userID);

                        MySqlDataReader r = cmd.ExecuteReader();

                        if (r.Read())
                        {
                            name = r["FirstName"] + " " + r["LastName"];
                            email = r["Email"].ToString();
                            address = "N/A";
                        }

                        r.Close();
                    }
                    else if(role == "DOCTOR")
                    {
                        string query = "SELECT FirstName, LastName, Email FROM Doctors WHERE UserID = @userID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userID);

                        MySqlDataReader r = cmd.ExecuteReader();

                        if (r.Read())
                        {
                            name = r["FirstName"] + " " + r["LastName"];
                            email = r["Email"].ToString();
                            address = "N/A";
                        }

                        r.Close();
                    }
                    else if(role == "ADMIN")
                    {
                        name = username;
                        email = "";
                        address = "";
                    }

                    pInfoBox.Text = "Name: " + name + Environment.NewLine + Environment.NewLine +
                                    "Email: " + email + Environment.NewLine + Environment.NewLine +
                                    "Address: " + address + Environment.NewLine + Environment.NewLine +
                                    "Role: " + role;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e) //actually view
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

        private void button2_Click(object sender, EventArgs e)//upload file
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

        private void button4_Click(object sender, EventArgs e) //download file
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
