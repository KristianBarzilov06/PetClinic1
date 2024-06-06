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
        int userId = -1;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\PetClinic1\\PetClinic\\PetClinicDB.mdf;Integrated Security=True";

        public class AppointmentDataAccess
        {
            private int userId;
            private string connectionString;

            public AppointmentDataAccess(string connectionString, int userId)
            {
                this.connectionString = connectionString;
                this.userId = userId;
            }

            public void AddAppointment(string petName, string description, DateTime appointmentDate)
            {
                string query = "INSERT INTO ClientDashboard (PetName, Description, Date, ClientId) " +
                   "VALUES (@PetName, @Description, @Date, @ClientId)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PetName", petName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Date", appointmentDate);
                    command.Parameters.AddWithValue("@ClientId", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private LoginForm loginForm;
        public ClientDashboard(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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
                userId = (int)Tag;
                AppointmentDataAccess appointmentDataAccess = new AppointmentDataAccess(connectionString, userId);

                appointmentDataAccess.AddAppointment(petName, desc, Date);

                ClearFields();

                MessageBox.Show("Appointment saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            loginForm.EnableReturnButton();
            loginForm.Show();
            this.Hide();
        }
    }
}
