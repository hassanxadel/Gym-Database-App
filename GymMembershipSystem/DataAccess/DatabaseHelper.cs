using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GymMembershipSystem.DataAccess
{
    public class DatabaseHelper
    {
        // Connection string lives in App.config (connectionStrings/GymDb) so it can be
        // changed without recompiling. Falls back to the original default if missing.
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["GymDb"]?.ConnectionString
            ?? "Server=localhost;Database=GymMembershipSystem;Uid=root;Pwd=root123;";

        // Method to open a connection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Helper method specifically for SELECT queries (Viewing Data)
        public DataTable ExecuteSelect(string query, params MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
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
        public bool ExecuteAction(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
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