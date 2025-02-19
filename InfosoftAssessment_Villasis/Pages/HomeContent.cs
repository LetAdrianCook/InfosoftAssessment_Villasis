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
    public partial class HomeContent: UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtSchedules;
        public HomeContent()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void BindData()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    string query = @"
                SELECT 
                    s.billingID, 
                    s.clientID, 
                    CONCAT(c.firstName, ' ', 
                           IFNULL(CONCAT(c.middleName, ' '), ''), 
                           c.lastName) AS fullName, 
                    s.scheduledDate, 
                    s.totalAmount, 
                    s.status, 
                    s.dateCreated 
                FROM schedule s
                JOIN clients c ON s.clientID = c.clientID
                WHERE WEEK(s.scheduledDate) = WEEK(CURDATE()) 
                AND YEAR(s.scheduledDate) = YEAR(CURDATE())";

                    MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                    MySqlDataAdapter scheduleTable = new MySqlDataAdapter(cmd);
                    dtSchedules = new DataTable();
                    scheduleTable.Fill(dtSchedules);
                    scheduleGridView.DataSource = dtSchedules;

                    scheduleGridView.Columns["billingID"].HeaderText = "Billing ID";
                    scheduleGridView.Columns["clientID"].HeaderText = "Client ID";
                    scheduleGridView.Columns["fullName"].HeaderText = "Client Name";
                    scheduleGridView.Columns["scheduledDate"].HeaderText = "Scheduled Date";
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
