using PetClinic.Controller;
using PetClinic.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetClinic.View
{
    public partial class RegisterForm : Form
    {
        private DoctorController controller;
        private LoginForm loginForm;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\PetClinic1\\PetClinic\\PetClinicDB.mdf;Integrated Security=True";

        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            controller = new DoctorController();
            this.loginForm = loginForm;
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm.EnableReturnButton();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string userType = comboBoxSignUp.SelectedItem.ToString();
            string username = usernameRegisterTxt.Text;
            string password = passwordRegisterTxt.Text;
            string role = comboBoxSignUp.SelectedItem != null ? comboBoxSignUp.SelectedItem.ToString() : string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (string.IsNullOrEmpty(userType))
                    {
                        MessageBox.Show("Please choose a role!");
                        return;
                    }

                    connection.Open();

                    if (userType == "Doctor")
                    {
                        string query = "INSERT INTO Doctors (Username, Password) VALUES (@Username, @Password)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (userType == "Client")
                    {
                        string query = "INSERT INTO Clients (Username, Password) VALUES (@Username, @Password)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid role selected!");
                        return;
                    }
                }

                    MessageBox.Show("Credentials saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoginForm login = new LoginForm();
            login.EnableReturnButton();
            login.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ClearCredentials()
        {
            usernameRegisterTxt.Text = " ";
            passwordRegisterTxt.Text = " ";
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.ClearCredentials();
            loginForm.EnableReturnButton();
            loginForm.Show();
            this.Hide();
        }
    }
}
