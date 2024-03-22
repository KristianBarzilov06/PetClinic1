using PetClinic.Controller;
using PetClinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic.View
{
    public partial class RegisterForm : Form
    {
        private DoctorController controller;

        public RegisterForm()
        {
            InitializeComponent();
            controller = new DoctorController();
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string userType = comboBoxSignUp.SelectedItem.ToString();
            string username = usernameRegisterTxt.Text;
            string password = passwordRegisterTxt.Text;

            Doctor doctor = new Doctor();
            doctor.Username = username;
            doctor.Password = password;
            if (userType == "Doctor")
            {
                controller.AddDoctor(doctor);
            }
        }
    }
}
