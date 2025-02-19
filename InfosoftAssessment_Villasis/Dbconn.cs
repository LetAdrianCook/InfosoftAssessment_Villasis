using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosoftAssessment_Villasis
{
    internal class Dbconn
    {
        private string connectionString;

        public Dbconn()
        {
            connectionString = "server=127.0.1.1;user=root;database=alexis;password=;port=3306;";
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }  
        public bool TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return true; // Connection successful
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false; // Connection failed
                }
            }
        }
    }
}
