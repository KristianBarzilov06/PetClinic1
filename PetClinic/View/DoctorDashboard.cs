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
    public partial class DoctorDashboard : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PetClinicDB.mdf;Integrated Security=True";

        public DoctorDashboard()
        {
            InitializeComponent();
            InitializeDataGridView();
            ComboBoxDoctor.Items.AddRange(new string[] { "Doctor", "Client" });
            SearchBtn.Click += new EventHandler(SearchBtn_Click_1);
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT Clients.Username AS ClientUsername, ClientDashboard.PetName, ClientDashboard.Date, ClientDashboard.Description
                    FROM ClientDashboard
                    INNER JOIN Clients ON ClientDashboard.ClientId = Clients.Id";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;

                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            dataGridView1.Columns[0].HeaderText = "Client Username";
                            dataGridView1.Columns[1].HeaderText = "Pet Name";
                            dataGridView1.Columns[2].HeaderText = "Date";
                            dataGridView1.Columns[3].HeaderText = "Description";
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            Console.WriteLine("Column: " + column.ColumnName);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                Console.WriteLine("Item: " + item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            if (ComboBoxDoctor.SelectedItem == null)
            {
                MessageBox.Show("Please select a role from the dropdown.");
                return;
            }

            string role = ComboBoxDoctor.SelectedItem.ToString();
            string name = UsernameLb.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name in the label.");
                return;
            }

            UsernameLb.Text = name;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command;
                    if (role == "Doctor")
                    {
                        command = new SqlCommand(@"
                        SELECT Doctors.Id, Doctors.Username, Doctors.Password,
                        FROM Doctors
                        INNER JOIN ClientDashboard ON Doctors.Id = ClientDashboard.DoctorId
                        WHERE Doctors.Username = @Name", connection);
                    }
                    else
                    {
                        command = new SqlCommand(@"
                        SELECT ClientDashboard.Id, Clients.Username AS ClientName, ClientDashboard.PetName, ClientDashboard.Description, ClientDashboard.Date 
                        FROM Clients
                        INNER JOIN ClientDashboard ON Clients.Id = ClientDashboard.ClientId
                        WHERE Clients.Username = @Name", connection);
                    }
                    command.Parameters.AddWithValue("@Name", name);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable newTable = new DataTable();
                    adapter.Fill(newTable);

                    dataGridView1.DataSource = null;

                    dataGridView1.DataSource = newTable;

                    if (newTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT Clients.Username AS ClientUsername, ClientDashboard.PetName, ClientDashboard.Date, ClientDashboard.Description
                    FROM ClientDashboard
                    INNER JOIN Clients ON ClientDashboard.ClientId = Clients.Id";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;

                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            dataGridView1.Columns[0].HeaderText = "Client Username";
                            dataGridView1.Columns[1].HeaderText = "Pet Name";
                            dataGridView1.Columns[2].HeaderText = "Date";
                            dataGridView1.Columns[3].HeaderText = "Description";
                            dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            Console.WriteLine("Column: " + column.ColumnName);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                Console.WriteLine("Item: " + item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UsernameLb.Text;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    DELETE FROM Clients WHERE Username = @Username;
                    DELETE FROM ClientDashboard WHERE ClientId = (SELECT Id FROM Clients WHERE Username = @Username);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No record found with that username.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (AddNewAccount addAccountForm = new AddNewAccount())
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    string username = addAccountForm.Username;
                    string password = addAccountForm.Password;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO Clients (Username, Password) VALUES (@Username, @Password)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Client account created successfully.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to create client account.");
                            }
                        }
                    }
                }
            }
        }
    }
}
