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
using Google.Protobuf.Reflection;

namespace InfosoftAssessment_Villasis.Pages
{
    public partial class ProcessPage : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtSchedules;
        public ProcessPage()
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

                    string query = "SELECT * FROM schedule WHERE billingID LIKE @searchBillID AND status = 'UNPAID'";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchBillID", "%" + searchBarTxt.Text + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            scheduleGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering billings by bill id: " + ex.Message);
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    MySqlCommand view = new MySqlCommand("SELECT billingID, clientID, scheduledDate, totalAmount, dateCreated, status FROM schedule WHERE status = 'UNPAID'", mysqlConnection);
                    MySqlDataAdapter scheduletTable = new MySqlDataAdapter(view);
                    dtSchedules = new DataTable();
                    scheduletTable.Fill(dtSchedules);
                    scheduleGridView.DataSource = dtSchedules;

                    scheduleGridView.Columns["billingID"].HeaderText = "Billing ID";
                    scheduleGridView.Columns["clientID"].HeaderText = "Client ID";
                    scheduleGridView.Columns["scheduledDate"].HeaderText = "ScheduledDate";
                    scheduleGridView.Columns["totalAmount"].HeaderText = "Total Amount";
                    scheduleGridView.Columns["status"].HeaderText = "Status";
                    scheduleGridView.Columns["dateCreated"].HeaderText = "Date Created";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from schedule table: " + ex.Message);
            }
        }


        private void scheduleGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int rowIndex = e.RowIndex;

            billingIDTxt.Text = scheduleGridView.Rows[rowIndex].Cells["billingID"].Value?.ToString() ?? "";
            totalAmount.Text = scheduleGridView.Rows[rowIndex].Cells["totalAmount"].Value?.ToString() ?? "";

            if (scheduleGridView.Rows[rowIndex].Cells["billingID"].Value != null)
            {
                int billingID;
                if (int.TryParse(scheduleGridView.Rows[rowIndex].Cells["billingID"].Value.ToString(), out billingID))
                {
                    payBtn.Tag = billingID;
                }
            }

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (payBtn.Tag == null)
            {
                MessageBox.Show("Please select a billing ID.");
                return;
            }

            if (!decimal.TryParse(receivedAmountTxt.Text, out decimal receivedAmount) || receivedAmount <= 0)
            {
                MessageBox.Show("Please enter a valid numeric amount.");
                return;
            }

            if (!decimal.TryParse(totalAmount.Text, out decimal total))
            {
                MessageBox.Show("Invalid total amount.");
                return;
            }

            if (receivedAmount < total)
            {
                MessageBox.Show("Insufficient amount. Please enter a valid amount and check the total Amount.");
                return;
            }

            decimal change = receivedAmount - total;
            int billingID = (int)payBtn.Tag;

            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();
                    string updateQuery = "UPDATE schedule SET status = 'PAID' WHERE billingID = @billingID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@billingID", billingID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Payment successful!\nChange: {change:C}");

         
                BindData();

                receivedAmountTxt.Clear();
                totalAmount.Clear();
                billingIDTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }
    }
}
