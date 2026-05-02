using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectBDB_2025CS196
{
    internal class CLO_DL
    {

        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";

        public void AddCLO(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) 

            {
                string query = "INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@name, @created, @updated)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@created", DateTime.Now);
                cmd.Parameters.AddWithValue("@updated", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateCLO(int id, string name)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Clo SET Name=@name, DateUpdated=@updated WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllCLOs()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM clo";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void DeleteCLO(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            { 
                string query = "Delete from Clo where Id = @cloid";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@cloid", id);
                con.Open();

                cmd.ExecuteNonQuery ();
            }
        }
    }
}
