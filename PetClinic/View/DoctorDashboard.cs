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
        public DoctorDashboard()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }
        private void InitializeDataGridView()
        {
            
            dataGridView1.AutoGenerateColumns = true;
        }
        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PetClinicDB.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection opened successfully.");

                    string query = @"
                    SELECT Clients.Username, ClientDashboard.PetName, ClientDashboard.Date, ClientDashboard.Description
                    FROM Clients
                    INNER JOIN ClientDashboard ON Clients.Id = ClientDashboard.ClientId";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Data loaded successfully.");
                            dataGridView1.DataSource = dataTable;

                            dataGridView1.AutoResizeColumns();
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            dataGridView1.Columns[0].HeaderText = "Username";
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
