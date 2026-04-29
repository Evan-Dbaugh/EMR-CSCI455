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
    public partial class adminForm : Form
    {
        private int loggedUserID;
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
                        return;
                    }

                    int userID = Convert.ToInt32(reader["UserID"]);
                    string role = reader["Role"].ToString();
                    reader.Close();

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
                            name = r["FirstName"] + " " + r["LastName"];
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





    }
}
