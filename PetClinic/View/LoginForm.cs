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
using static System.Windows.Forms.LinkLabel;

namespace PetClinic.View
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\PetClinic1\\PetClinic\\PetClinicDB.mdf;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxLogin.SelectedItem == null)
            {
                MessageBox.Show("Please choose a role.");
                return;
            }

            string userType = comboBoxLogin.SelectedItem.ToString();
            string username = UsernameLb.Text;
            string password = PasswordLb.Text;

            if (AuthenticateClients(username, password))
            {
                if (userType == "Doctor")
                {
                    DoctorDashboard doctorDashboard = new DoctorDashboard();
                    doctorDashboard.Show();
                }
                else if (userType == "Client")
                {
                    ClientDashboard clientDashboard = new ClientDashboard();
                    clientDashboard.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateClients(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Clients WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
