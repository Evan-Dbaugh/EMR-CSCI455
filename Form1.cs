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
        MySqlConnection conn;
        public loginForm()
        {
            InitializeComponent();
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            } catch(Exception ex) {
                    MessageBox.Show("DB Connection Failed", "DBCONN");
            }
        }

        //Form 1 = login
        //Form 2 = register page
        //form 3 = patient
        //form 4 = doctor
        //form 5 = nurse
        //form 6 = admin

        /*
         * Default Roles
         * grantm, password, patient
         * navyo, password, nurse
         * evand, password, doctor
         * admin1, admin1, admin
         */

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e) //login button (idk why it need to be called search)
        {
            string username = usernameTBox.Text;
            string password = passwordTBox.Text;

            string query = "SELECT Role FROM UserAccounts " + "WHERE Username = @username AND Password = @password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            object result = cmd.ExecuteScalar();

            if(result != null)
            {
                string role = result.ToString();
                MessageBox.Show("Login Sucessful");

                if (role == "ADMIN")
                {
                    adminForm adminView = new adminForm();
                    adminView.Show();
                    this.Hide();
                }
                else if (role == "PATIENT")
                {
                    patientForm patientView = new patientForm();
                    patientView.Show();
                    this.Hide();
                }
                else if (role == "DOCTOR")
                {
                    doctorForm doctorView = new doctorForm();
                    doctorView.Show();
                    this.Hide();
                }
                else if (role == "NURSE")
                {
                    nurseForm nurseView = new nurseForm();
                    nurseView.Show();
                    this.Hide();
                }
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            newPatForm newPatView = new newPatForm();
            newPatView.Show();
            this.Hide();
        }
    }
}
