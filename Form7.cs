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
    public partial class newAppointmentForm : Form
    {
        private int userID;
        private patientForm parentForm;
        public newAppointmentForm(int userID, patientForm parent)
        {
            InitializeComponent();
            this.userID = userID;
            parentForm = parent;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=455emr;port=3306;password=admin;";

            try
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                string selectedTime = timeBox.SelectedItem?.ToString();
                string type = typeBox.SelectedItem?.ToString();

                if (selectedTime == null || type == null)
                {
                    MessageBox.Show("Please select time and type.");
                    return;
                }

                // Format appointment string
                string appointmentEntry = selectedDate.ToString("yyyy-MM-dd") +
                                          " - " + selectedTime +
                                          " - " + type;

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"UPDATE Patients 
                             SET Appointments = 
                                CASE 
                                    WHEN Appointments IS NULL OR Appointments = '' 
                                    THEN @newAppt
                                    ELSE CONCAT(Appointments, '\n', @newAppt)
                                END
                             WHERE UserID = @userID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@newAppt", appointmentEntry);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    cmd.ExecuteNonQuery();
                }

                //MessageBox.Show("Appointment Scheduled!");
                parentForm.LoadAppointments();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
