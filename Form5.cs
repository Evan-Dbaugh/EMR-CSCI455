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
    public partial class nurseForm : Form
    {
        private int loggedUserID;
        public nurseForm(int userID)
        {
            InitializeComponent();
            this.FormClosing += Form_FormClosing;
            loggedUserID = userID;
        }

        private void nurseForm_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";
            string query = "SELECT FirstName, LastName FROM Nurses WHERE UserID = @userID";

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
    }
}
