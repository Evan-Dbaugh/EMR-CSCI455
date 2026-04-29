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
    public partial class loginForm : Form
    {
        string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

        public loginForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }

        //Form 1 = login
        //Form 2 = register page
        //form 3 = patient
        //form 4 = doctor
        //form 5 = nurse
        //form 6 = admin
        //form 7 = Schedule Appointment

        /*
         * Starting username, password, role
         * grantm, password, PATIENT
         * navyo, password, NURSE
         * evand, password, DOCTOR
         * admin1, admin1, ADMIN
         */

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e) //login button (idk why it need to be called search)
        {
            string username = usernameTBox.Text;
            string password = passwordTBox.Text;

            string query = "SELECT UserID, Role FROM UserAccounts " + "WHERE Username = @username AND Password = @password";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int userID = Convert.ToInt32(reader["UserID"]);
                        string role = reader["Role"].ToString();
                        if (role == "ADMIN")
                        {
                            adminForm adminView = new adminForm(userID);
                            adminView.Show();
                            this.Hide();
                        }
                        else if (role == "PATIENT")
                        {
                            patientForm patientView = new patientForm(userID);
                            patientView.Show();
                            this.Hide();
                        }
                        else if (role == "DOCTOR")
                        {
                            doctorForm doctorView = new doctorForm(userID);
                            doctorView.Show();
                            this.Hide();
                        }
                        else if (role == "NURSE")
                        {
                            nurseForm nurseView = new nurseForm(userID);
                            nurseView.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            newPatForm newPatView = new newPatForm();
            newPatView.Show();
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
