using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace InfosoftAssessment_Villasis.Pages
{
    public partial class PreferencesPage : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtServices;
        public PreferencesPage()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void searchBarTxt_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void FilterDataGridView()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    string query = "SELECT * FROM services WHERE serviceName LIKE @searchServicename";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchServicename", "%" + searchBarTxt.Text + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            serviceGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering service by service name: " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
            {
                return;
            }


            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    MySqlCommand createUserCommand = new MySqlCommand("INSERT INTO services (serviceName, hourlyRate, dateCreated) " +
                        "VALUES (@serviceName, @hourlyRate, @dateCreated)", mysqlConnection);

                    createUserCommand.Parameters.AddWithValue("@serviceName", serviceName.Text);
                    createUserCommand.Parameters.AddWithValue("@hourlyRate", hourlyRate.Text);
                    createUserCommand.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString("yyyy-MM-dd"));

                    createUserCommand.ExecuteNonQuery();

                    MessageBox.Show("Service Name: " + serviceName.Text + " Hourly Rate: " + hourlyRate.Text + " Successfully Added");
                    ClearFields();
                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating service: " + ex.Message);
            }
        }

        private void serviceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int rowIndex = e.RowIndex;

            serviceName.Text = serviceGridView.Rows[rowIndex].Cells["serviceName"].Value?.ToString() ?? "";
            hourlyRate.Text = serviceGridView.Rows[rowIndex].Cells["hourlyRate"].Value?.ToString() ?? "";

            if (serviceGridView.Rows[rowIndex].Cells["serviceID"].Value != null)
            {
                int serviceID;
                if (int.TryParse(serviceGridView.Rows[rowIndex].Cells["serviceID"].Value.ToString(), out serviceID))
                {
                    editBtn.Tag = serviceID;
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Tag != null)
            {
                int serviceID = (int)editBtn.Tag;

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE services SET serviceName = @serviceName, hourlyRate = @hourlyRate WHERE serviceID = @serviceID", mysqlConnection);
                    updateCommand.Parameters.AddWithValue("@serviceName", serviceName.Text);
                    updateCommand.Parameters.AddWithValue("@hourlyRate", hourlyRate.Text);
                    updateCommand.Parameters.AddWithValue("@serviceID", serviceID);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Service edited successfully!");
                        ClearFields();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Edit failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(deleteID.Text))
            {
                MessageBox.Show("Please enter a valid service ID to delete, check the list of services at the current page to find service ID.");
                return;
            }

            int userID;
            if (!int.TryParse(deleteID.Text, out userID))
            {
                MessageBox.Show("Invalid service ID. Please enter a numeric value.");
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                "Are you sure you want to delete this service?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                    {
                        mysqlConnection.Open();

                        string query = "DELETE FROM services WHERE serviceID = @serviceID";

                        using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@serviceID", userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Service deleted successfully.");
                                deleteID.Clear();
                                ClearFields();
                                BindData(); 
                            }
                            else
                            {
                                MessageBox.Show("Service ID not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting service: " + ex.Message);
                }
            }
        }


        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand view = new MySqlCommand("SELECT serviceID, serviceName, hourlyRate, dateCreated FROM services", mysqlConnection);
                    MySqlDataAdapter clientTable = new MySqlDataAdapter(view);
                    dtServices = new DataTable();
                    clientTable.Fill(dtServices);
                    serviceGridView.DataSource = dtServices;

                    serviceGridView.Columns["serviceID"].HeaderText = "ID";
                    serviceGridView.Columns["serviceName"].HeaderText = "Service Name";
                    serviceGridView.Columns["hourlyRate"].HeaderText = "Hourly Rate";
                    serviceGridView.Columns["dateCreated"].HeaderText = "Date Created";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from services table: " + ex.Message);
            }
        }

        bool checkInputs()
        {
            if (string.IsNullOrWhiteSpace(serviceName.Text))
            {
                MessageBox.Show("Service name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(hourlyRate.Text))
            {
                MessageBox.Show("Hourly rate cannot be empty.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            serviceName.Clear();
            hourlyRate.Clear();
        }



    }
}
