using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjectBDB_2025CS196
{
    internal class Rubric
    {

        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";

        public void AddRubric(string details, int cloId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                conn.Open();

                
                string getIdQuery = "SELECT IFNULL(MAX(Id), 0) + 1 FROM Rubric";
                MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);

                int newId = Convert.ToInt32(getIdCmd.ExecuteScalar());


                string query = "INSERT INTO Rubric (Id, Details, CloId) VALUES (@id, @details, @cloId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", newId);
                cmd.Parameters.AddWithValue("@details", details);
                cmd.Parameters.AddWithValue("@cloId", cloId);

                
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllRubrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT r.Id, r.Details, c.Name AS CLO FROM Rubric r JOIN Clo c ON r.CloId = c.Id";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void UpdateRubric(int id, string details, int cloId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Rubric SET Details=@details, CloId=@cloId WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@details", details);
                cmd.Parameters.AddWithValue("@cloId", cloId);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRubric(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "Delete From Rubric where Id = @id ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
