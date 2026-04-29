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
    public partial class newPatForm : Form
    {
        string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

        public newPatForm()
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string username = usernameTBox.Text;
            string password = passwordTBox.Text;
            string firstName = fNameTBox.Text;
            string lastName = lNameTBox.Text;
            string dob = dobTBox.Text;
            string email = emailTBox.Text;
            string address = addressTBox.Text;
            string eContact = emergcontTBox.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    //MessageBox.Show("Connection Open");
                    string userQuery = "INSERT INTO UserAccounts (Username, Password, Role) " + "VALUES (@username, @password, 'PATIENT')";

                    //adding new patient to user accounts table
                    MySqlCommand userCMD = new MySqlCommand(userQuery, conn);
                    userCMD.Parameters.AddWithValue("@username", username);
                    userCMD.Parameters.AddWithValue("@password", password);
                    userCMD.ExecuteNonQuery();

                    //getting new user ID
                    int userID = (int)userCMD.LastInsertedId;

                    //adding new patient to patients table

                    string patientQuery = "INSERT INTO Patients " +
                                            "(UserID, FirstName, LastName, DOB, Email, Address, EmergencyContact) " +
                                            "VALUES (@userID, @firstName, @lastName, @dob, @email, @address, @emergencyContact)";
                    MySqlCommand patientCMD = new MySqlCommand(patientQuery, conn);
                    patientCMD.Parameters.AddWithValue("@userID", userID);
                    patientCMD.Parameters.AddWithValue("@firstName", firstName);
                    patientCMD.Parameters.AddWithValue("@lastName", lastName);
                    patientCMD.Parameters.AddWithValue("@dob", dob);
                    patientCMD.Parameters.AddWithValue("@email", email);
                    patientCMD.Parameters.AddWithValue("@address", address);
                    patientCMD.Parameters.AddWithValue("@emergencyContact", eContact);

                    patientCMD.ExecuteNonQuery();
                    MessageBox.Show("Patient Account Created");

                    loginForm login = new loginForm();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering as new patient: " + ex.Message);
            }

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
