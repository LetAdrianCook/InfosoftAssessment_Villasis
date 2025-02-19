namespace InfosoftAssessment_Villasis
{
    using InfosoftAssessment_Villasis.Pages;
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;
        public partial class Login : Form
        {
            private Dbconn dbconn;

            public Login()
            {
                InitializeComponent();
                dbconn = new Dbconn();
            }

            private void loginBtn_Click(object sender, EventArgs e)
            {
                string username = userName.Text.Trim();
                string password = passWord.Text.Trim();

                if (checkLoginCredential(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);           
                    this.Hide();
                    Home homepage = new Home(); 
                    homepage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool checkLoginCredential(string username, string password)
            {
                using (var connection = dbconn.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM adminuser WHERE userName = @username AND passWord = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        try
                        {
                            connection.Open();
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            return count > 0; //isa ra maretrieve na data sa db
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database error: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
        }
    }