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
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.IO;
using System.Windows.Forms;



namespace InfosoftAssessment_Villasis.Pages
{
    public partial class BookingPage : UserControl
    {
        private Dbconn dbConnection;
        private DataTable dtServices;
        private DataTable dtClients;
        private DataTable dtSelectedservices;
        private int selectedServiceID;
        private decimal selectedHourlyRate;
        private int selectedRowIndex = -1;

        public BookingPage()
        {
            InitializeComponent();
            try
            {
                dbConnection = new Dbconn();
                searchBarTxt.TextChanged += new EventHandler(searchBarTxt_TextChanged);
                searchBarTxt2.TextChanged += new EventHandler(searchBarTxt2_TextChanged);
                BindData();
                BindData2();
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

        private void searchBarTxt2_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView2();
        }

        private void FilterDataGridView2()
        {
            try
            {
                using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
                {
                    mysqlConnection.Open();

                    string query = "SELECT * FROM services WHERE serviceName LIKE @searchServicename";

                    using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchServicename", "%" + searchBarTxt2.Text + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt2 = new DataTable();
                            adapter.Fill(dt2);
                            serviceGridView.DataSource = dt2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering services by service name: " + ex.Message);
            }
        }
        private void BindData() //sa service table na data
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

        private void BindData2() //sa client table na data
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

        private void clientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int rowIndex = e.RowIndex;


            clientName.Text = string.Format("{0} {1} {2}",
            clientGridView.Rows[rowIndex].Cells["firstName"].Value?.ToString() ?? "",
            clientGridView.Rows[rowIndex].Cells["middleName"].Value?.ToString() ?? "",
            clientGridView.Rows[rowIndex].Cells["lastName"].Value?.ToString() ?? "").Trim();


            if (clientGridView.Rows[rowIndex].Cells["clientID"].Value != null)
            {
                int clientID;
                if (int.TryParse(clientGridView.Rows[rowIndex].Cells["clientID"].Value.ToString(), out clientID))
                {
                    selectedClient.Text = clientID.ToString();
                    // clientTag.Tag = clientID;
                }
            }
        }

        private void serviceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedServiceID = Convert.ToInt32(serviceGridView.Rows[e.RowIndex].Cells["serviceID"].Value);
            string serviceName = serviceGridView.Rows[e.RowIndex].Cells["serviceName"].Value.ToString();
            selectedHourlyRate = Convert.ToDecimal(serviceGridView.Rows[e.RowIndex].Cells["hourlyRate"].Value);

            selectedService.Text = serviceName;
        }

        private void CalculateTotalAmount()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in selectedGridView.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["total"].Value);
            }

            totalAmount.Text = sum.ToString("0.00");
        }
        private void selectedGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void removeServicebtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < selectedGridView.Rows.Count)
            {
                selectedGridView.Rows.RemoveAt(selectedRowIndex);
                selectedRowIndex = -1;

                CalculateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select a service to remove.");
            }
        }

        private void addServicebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedService.Text) || string.IsNullOrWhiteSpace(hourRendered.Text))
            {
                MessageBox.Show("Please select a service and enter hours rendered.");
                return;
            }

            if (!int.TryParse(hourRendered.Text, out int hours))
            {
                MessageBox.Show("Please enter a valid number for hours rendered.");
                return;
            }

            decimal total = selectedHourlyRate * hours; // Calculate total cost

            // Ensure columns exist before adding rows
            if (selectedGridView.Columns.Count == 0)
            {
                selectedGridView.Columns.Add("serviceID", "Service ID");
                selectedGridView.Columns.Add("serviceName", "Service Name");
                selectedGridView.Columns.Add("hourlyRate", "Hourly Rate");
                selectedGridView.Columns.Add("hoursRendered", "Hours Rendered");
                selectedGridView.Columns.Add("total", "Total");
            }

            // Add the selected service to selectedGridView
            selectedGridView.Rows.Add(selectedServiceID, selectedService.Text, selectedHourlyRate, hourRendered.Text, total);

            // Clear selection fields
            selectedService.Clear();
            hourRendered.Clear();
            selectedServiceID = 0;
            selectedHourlyRate = 0;

            // Update total amount
            CalculateTotalAmount();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedClient.Text) || string.IsNullOrWhiteSpace(clientName.Text))
            {
                MessageBox.Show("Please select a client before scheduling.");
                return;
            }

            if (selectedGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add services before scheduling.");
                return;
            }

            DateTime scheduledDate = scheduledVisit.Value;
            int clientID = int.Parse(selectedClient.Text);
            decimal totalAmount = 0;
            int billingID = 0; 

            using (MySqlConnection mysqlConnection = dbConnection.GetConnection())
            {
                mysqlConnection.Open();


                string checkQuery = "SELECT COUNT(*) FROM schedule WHERE DATE(scheduledDate) = @scheduledDate"; //para sa 3.a sched validation
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, mysqlConnection))
                {
                    checkCmd.Parameters.AddWithValue("@scheduledDate", scheduledDate.Date); 

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("A schedule already exists for this date. Please choose another date.");
                        return;
                    }
                }


                foreach (DataGridViewRow row in selectedGridView.Rows)
                {
                    if (row.Cells["total"].Value != null)
                    {
                        totalAmount += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                }

                string insertScheduleQuery = "INSERT INTO schedule (clientID, scheduledDate, totalAmount, dateCreated, status) VALUES (@clientID, @scheduledDate, @totalAmount, NOW(), @status)";
                using (MySqlCommand scheduleCmd = new MySqlCommand(insertScheduleQuery, mysqlConnection))
                {
                    scheduleCmd.Parameters.AddWithValue("@clientID", clientID);
                    scheduleCmd.Parameters.AddWithValue("@scheduledDate", scheduledDate);
                    scheduleCmd.Parameters.AddWithValue("@totalAmount", totalAmount); 
                    scheduleCmd.Parameters.AddWithValue("@status", "UNPAID"); 
                    scheduleCmd.ExecuteNonQuery();
                    billingID = (int)scheduleCmd.LastInsertedId; 
                }

                string insertServiceQuery = "INSERT INTO selectedservices (billingID, serviceID, hourlyRate, hoursRendered, total, date) VALUES (@billingID, @serviceID, @hourlyRate, @hoursRendered, @total, NOW())";

                foreach (DataGridViewRow row in selectedGridView.Rows)
                {
                    if (row.Cells["serviceID"].Value != null)
                    {
                        int serviceID = Convert.ToInt32(row.Cells["serviceID"].Value);
                        decimal hourlyRate = Convert.ToDecimal(row.Cells["hourlyRate"].Value);
                        int hoursRendered = Convert.ToInt32(row.Cells["hoursRendered"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["total"].Value);

                        using (MySqlCommand cmd = new MySqlCommand(insertServiceQuery, mysqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@billingID", billingID);
                            cmd.Parameters.AddWithValue("@serviceID", serviceID);
                            cmd.Parameters.AddWithValue("@hourlyRate", hourlyRate);
                            cmd.Parameters.AddWithValue("@hoursRendered", hoursRendered);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                PrintReceipt(billingID, clientID, clientName.Text, selectedGridView, totalAmount);

                MessageBox.Show("Schedule successfully created!");
                ClearFilters();
                selectedGridView.Rows.Clear();
            }
        }

        private void ClearFilters()
        {
            selectedClient.Clear();
            clientName.Clear();
            hourRendered.Clear();
            selectedService.Clear();
            scheduledVisit.Value = DateTime.Now; 
            searchBarTxt.Clear();
            searchBarTxt2.Clear();
            totalAmount.Clear();
        }



        private void PrintReceipt(int billingID, int clientID, string clientName, DataGridView selectedGridView, decimal totalAmount)
        {
            PrintDocument printDoc = new PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.StartPosition = FormStartPosition.CenterScreen;

            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 300, 2000);

            printDoc.PrintPage += (sender, e) =>
            {
                Font font = new Font("Courier New", 8);
                float yPos = 10;
                float leftMargin = 10;

                e.Graphics.DrawString("Alexis Construction", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString("Billing Receipt", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString($"Billing ID: {billingID}", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString($"Client ID: {clientID}", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString($"Client Name: {clientName}", font, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                e.Graphics.DrawString("ID    Service   Rate    Hours    Total", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                e.Graphics.DrawString("----------------------------------------", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;

                foreach (DataGridViewRow row in selectedGridView.Rows)
                {
                    if (row.Cells["serviceID"].Value != null)
                    {
                        string serviceID = row.Cells["serviceID"].Value.ToString().PadRight(5);
                        string serviceName = row.Cells["serviceName"].Value.ToString().PadRight(12);
                        string hourlyRate = row.Cells["hourlyRate"].Value.ToString().PadRight(5);
                        string hoursRendered = row.Cells["hoursRendered"].Value.ToString().PadRight(5);
                        string total = row.Cells["total"].Value.ToString().PadRight(5);

                        e.Graphics.DrawString($"{serviceID} {serviceName} {hourlyRate} {hoursRendered} {total}", font, Brushes.Black, leftMargin, yPos);
                        yPos += 20;
                    }
                }

                yPos += 10;
                e.Graphics.DrawString("----------------------------------------", font, Brushes.Black, leftMargin, yPos);
                yPos += 20;

                e.Graphics.DrawString($"Total Amount: {totalAmount:C}", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            };

            previewDialog.ShowDialog();
        }

    }
}
