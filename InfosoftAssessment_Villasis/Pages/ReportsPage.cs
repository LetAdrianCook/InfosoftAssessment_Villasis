using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace InfosoftAssessment_Villasis.Pages
{
 
    public partial class ReportsPage: UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtSchedules;
        public ReportsPage()
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

                    string query = "SELECT * FROM schedule WHERE clientID LIKE @searchClientID";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchClientID", "%" + searchBarTxt.Text + "%");

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
                MessageBox.Show("Error filtering billings by client id: " + ex.Message);
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


    }
}
