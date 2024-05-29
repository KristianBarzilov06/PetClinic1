using PetClinic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic.View
{
    public partial class ClientDashboard : Form
    {

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\PetClinic1\\PetClinic\\PetClinicDB.mdf;Integrated Security=True";

        public class AppointmentDataAccess
        {
            private string connectionString;

            public AppointmentDataAccess(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public void AddAppointment(string petName, string description, DateTime appointmentDate)
            {
                string query = "INSERT INTO ClientDashboard (PetName, Description, Date) " +
                   "VALUES (@PetName, @Description, @Date)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PetName", petName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Date", appointmentDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public ClientDashboard()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearFields()
        {
            PetTextBox.Text = "";
            DescBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string petName = PetTextBox.Text;
            string desc = DescBox.Text;
            DateTime Date = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(petName) || string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                AppointmentDataAccess appointmentDataAccess = new AppointmentDataAccess(connectionString);

                appointmentDataAccess.AddAppointment(petName, desc, Date);

                ClearFields();

                MessageBox.Show("Appointment saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
