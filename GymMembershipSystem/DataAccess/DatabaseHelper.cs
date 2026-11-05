using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GymMembershipSystem.DataAccess
{
    public class DatabaseHelper
    {
        // Update the password to match your MySQL root password
        private readonly string connectionString = "Server=localhost;Database=GymMembershipSystem;Uid=root;Pwd=root123;";

        // Method to open a connection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Helper method specifically for SELECT queries (Viewing Data)
        public DataTable ExecuteSelect(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        // Helper method for INSERT, UPDATE, and DELETE queries
        public bool ExecuteAction(string query)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing action: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}