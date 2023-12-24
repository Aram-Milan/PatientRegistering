using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PatientRegistering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadPatientData()
        {
            string connectionString = @"Data Source=.;Initial Catalog=PatientDB;Integrated Security=True";
            string query = "SELECT * FROM Patients";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewPatients.DataSource = table; // Replace with your actual Data Grid View name
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=PatientDB;Integrated Security=True";
            string query = "INSERT INTO Patients (Name, Surname, DateOfBirth, Sexuality, Education, Occupation, TelephoneNumber) VALUES (@Name, @Surname, @DateOfBirth, @Sexuality, @Education, @Occupation, @TelephoneNumber)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", nametxtbox.Text);
                        cmd.Parameters.AddWithValue("@Surname", surenametxtbox.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dobtxtbox.Text);
                        cmd.Parameters.AddWithValue("@Sexuality", sextxtbox.Text);
                        cmd.Parameters.AddWithValue("@Education", edutxtbox.Text);
                        cmd.Parameters.AddWithValue("@Occupation", occuptxtbox.Text);
                        cmd.Parameters.AddWithValue("@TelephoneNumber", teltxtbox.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        // con.Close();
                    }

                    MessageBox.Show("Patient registered successfully!");

                    // Load the updated data into the Data Grid View
                    LoadPatientData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the updated data into the Data Grid View
            LoadPatientData();
        }
    }
}
