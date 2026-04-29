using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSCI455_EMR
{
    public partial class doctorForm : Form
    {
        private int loggedUserID;
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
            string query = "SELECT FirstName, LastName, DOB, Email, Address, EmergencyContact, Prescriptions, Appointments FROM PATIENTS " +
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

        }
    }
}
