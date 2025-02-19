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
    public partial class ClientPage : UserControl
    {

        private Dbconn dbConnection;
        private DataTable dtClients;
        public ClientPage()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                maleRbtn.Checked = true;
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

                    string query = "SELECT * FROM clients WHERE lastName LIKE @searchLastname";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchLastname", "%" + searchBarTxt.Text + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            clientGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering Client by lastname: " + ex.Message);
            }
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
            {
                return;
            }
            string birthDateValue = birthDate.Value.ToString("yyyy-MM-dd");
            string gender = string.Empty;

            if (maleRbtn.Checked)
            {
                gender = "Male";
            }
            else if (femaleRbtn.Checked)
            {
                gender = "Female";
            }

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    MySqlCommand createUserCommand = new MySqlCommand("INSERT INTO clients (firstName, middleName, lastName, gender, birthDate, dateCreated) " +
                        "VALUES (@firstName, @middleName, @lastName, @gender, @birthDate, @dateCreated)", mysqlConnection);

                    createUserCommand.Parameters.AddWithValue("@firstName", firstName.Text);
                    createUserCommand.Parameters.AddWithValue("@middleName", middleName.Text);
                    createUserCommand.Parameters.AddWithValue("@lastName", lastName.Text);
                    createUserCommand.Parameters.AddWithValue("@gender", gender);
                    createUserCommand.Parameters.AddWithValue("@birthDate", birthDateValue); 
                    createUserCommand.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString("yyyy-MM-dd"));

                    createUserCommand.ExecuteNonQuery();

                    MessageBox.Show("Client: " + firstName.Text + " " + middleName.Text + " " + lastName.Text + " Successfully Added");
                    ClearFields();
                    BindData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message);
            }
        }


        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand view = new MySqlCommand("SELECT clientID, firstName, middleName, lastName, gender, birthDate, dateCreated FROM clients", mysqlConnection);
                    MySqlDataAdapter clientTable = new MySqlDataAdapter(view);
                    dtClients = new DataTable();
                    clientTable.Fill(dtClients);
                    clientGridView.DataSource = dtClients;

                    clientGridView.Columns["clientID"].HeaderText = "ID";
                    clientGridView.Columns["firstName"].HeaderText = "First Name";
                    clientGridView.Columns["middleName"].HeaderText = "Middle Name";
                    clientGridView.Columns["lastName"].HeaderText = "last Name";
                    clientGridView.Columns["gender"].HeaderText = "Gender";
                    clientGridView.Columns["birthDate"].HeaderText = "Birth Date";
                    clientGridView.Columns["dateCreated"].HeaderText = "Date Created";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from clients table: " + ex.Message);
            }
        }

        bool checkInputs()
        {
            if (string.IsNullOrWhiteSpace(firstName.Text))
            {
                MessageBox.Show("First name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(middleName.Text))
            {
                MessageBox.Show("Middle name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName.Text))
            {
                MessageBox.Show("Last name cannot be empty.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            firstName.Clear();
            middleName.Clear();
            lastName.Clear();
            maleRbtn.Checked = true;
            femaleRbtn.Checked = false;
            birthDate.Value = DateTime.Now;
        }

        private void clientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            {
                return;
            }

            int rowIndex = e.RowIndex;

        
            firstName.Text = clientGridView.Rows[rowIndex].Cells["firstName"].Value?.ToString() ?? "";
            middleName.Text = clientGridView.Rows[rowIndex].Cells["middleName"].Value?.ToString() ?? "";
            lastName.Text = clientGridView.Rows[rowIndex].Cells["lastName"].Value?.ToString() ?? "";
            string gender = clientGridView.Rows[rowIndex].Cells["gender"].Value?.ToString();

            if (gender == "Male")
            {
                maleRbtn.Checked = true;
                femaleRbtn.Checked = false;
            }
            else if (gender == "Female")
            {
                femaleRbtn.Checked = true;
                maleRbtn.Checked = false;
            }
            else
            {
                maleRbtn.Checked = false;
                femaleRbtn.Checked = false;
            }

            if (clientGridView.Rows[rowIndex].Cells["birthDate"].Value != null)
            {
                DateTime parsedDate;
                if (DateTime.TryParse(clientGridView.Rows[rowIndex].Cells["birthDate"].Value.ToString(), out parsedDate))
                {
                    birthDate.Value = parsedDate; 
                }
                else
                {
                    birthDate.Value = DateTime.Now; 
                }
            }

            if (clientGridView.Rows[rowIndex].Cells["clientID"].Value != null)
            {
                int clientID;
                if (int.TryParse(clientGridView.Rows[rowIndex].Cells["clientID"].Value.ToString(), out clientID))
                {
                    editBtn.Tag = clientID;
                }
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Tag != null)
            {
                int clientID = (int)editBtn.Tag; 
                string birthDateValue = birthDate.Value.ToString("yyyy-MM-dd"); // Correct C# syntax
                string gender = string.Empty;

                if (maleRbtn.Checked)
                {
                    gender = "Male";
                }
                else if (femaleRbtn.Checked)
                {
                    gender = "Female";
                }

                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE clients SET firstName = @firstName, middleName = @middleName, lastName = @lastName, gender = @gender, birthDate = @birthDate WHERE clientID = @clientID", mysqlConnection);
                    updateCommand.Parameters.AddWithValue("@firstName", firstName.Text);
                    updateCommand.Parameters.AddWithValue("@middleName", middleName.Text);
                    updateCommand.Parameters.AddWithValue("@lastName", lastName.Text);
                    updateCommand.Parameters.AddWithValue("@gender", gender);
                    updateCommand.Parameters.AddWithValue("@birthdate", birthDateValue);
                    updateCommand.Parameters.AddWithValue("@clientID", clientID);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client edited successfully!");
                        ClearFields();
                        BindData(); 
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }
    }
}
