using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProjectBDB_2025CS196
{
    internal class DatabaseHelper
    {
        private string connString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";

        private static DatabaseHelper instance;

        public static DatabaseHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseHelper();
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            return conn;
        }

        public int Update(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
        public int ExecuteParameterized(string query, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the command
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }

        }
        
        public MySqlDataReader GetData(string query)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader();
        }

        public DataTable getdataintable(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                   
                    // Use an adapter to bridge the gap between MySQL and the DataTable
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
