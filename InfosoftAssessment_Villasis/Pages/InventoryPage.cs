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

namespace InfosoftAssessment_Villasis.Pages
{
    public partial class InventoryPage : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtEquipments;
        public InventoryPage()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
                BindData();
                LoadServiceNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void LoadServiceNames() //para sa combobox value
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    string query = "SELECT serviceName FROM services";
                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        typeCbx.Items.Clear();
                        while (reader.Read())
                        {
                            typeCbx.Items.Add(reader["serviceName"].ToString());
                        }
                    }
                }

                if (typeCbx.Items.Count > 0)
                {
                    typeCbx.SelectedIndex = 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
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

                    string query = "SELECT * FROM equipments WHERE equipmentName LIKE @searchEquipmentname";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchEquipmentname", "%" + searchBarTxt.Text + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            equipmentGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering equipment by equipment name: " + ex.Message);
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand view = new MySqlCommand("SELECT equipmentID, equipmentName, serviceType, quantity, dateCreated FROM equipments", mysqlConnection);
                    MySqlDataAdapter clientTable = new MySqlDataAdapter(view);
                    dtEquipments = new DataTable();
                    clientTable.Fill(dtEquipments);
                    equipmentGridView.DataSource = dtEquipments;

                    equipmentGridView.Columns["equipmentID"].HeaderText = "ID";
                    equipmentGridView.Columns["equipmentName"].HeaderText = "Equipment Name";
                    equipmentGridView.Columns["serviceType"].HeaderText = "Service Type";
                    equipmentGridView.Columns["quantity"].HeaderText = "Quantity";
                    equipmentGridView.Columns["dateCreated"].HeaderText = "Date Created";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from equipment table: " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(equipmentNameTxt.Text))
            {
                MessageBox.Show("Equipment name cannot be empty.");
                return;
            }

            if (typeCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type.");
                return;
            }

            if (!int.TryParse(quantityTxt.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid number.");
                return;
            }

            string equipmentName = equipmentNameTxt.Text.Trim();
            string serviceType = typeCbx.SelectedItem.ToString();

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    string query = "INSERT INTO equipments (equipmentName, serviceType, quantity, dateCreated) VALUES (@equipmentName, @serviceType, @quantity, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@equipmentName", equipmentName);
                        cmd.Parameters.AddWithValue("@serviceType", serviceType);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Equipment added successfully!");
                BindData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding equipment: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            equipmentNameTxt.Clear();
            quantityTxt.Clear();
            typeCbx.SelectedIndex = 0; 
        }
    }
}
