using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class rubricmanage : Form
    {

        private int currentRubricId;

        Form Rubrics;
        public rubricmanage(int rubricId, Form rubrics)
        {
            InitializeComponent();
            this.currentRubricId = rubricId; 

            LoadRubricLevels();
            Rubrics = rubrics;
        }



        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";


        private void LoadRubricLevels()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id, Details, MeasurementLevel FROM RubricLevel WHERE RubricId = @rubricId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rubricId", currentRubricId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvrubricmanage.DataSource = dt;
            }
        }

        private void rubricmanage_Load(object sender, EventArgs e)
        {
            cmbmeasurement.Items.Add(1);
            cmbmeasurement.Items.Add(2);
            cmbmeasurement.Items.Add(3);
            cmbmeasurement.Items.Add(4);
            cmbmeasurement.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvrubricmanage.CurrentRow != null)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                    
                        string query = "UPDATE RubricLevel SET Details = @details, MeasurementLevel = @level WHERE Id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        int selectedId = Convert.ToInt32(dgvrubricmanage.CurrentRow.Cells["Id"].Value);

                        cmd.Parameters.AddWithValue("@details", txtdetails.Text);
                        cmd.Parameters.AddWithValue("@level", cmbmeasurement.SelectedItem);
                        cmd.Parameters.AddWithValue("@id", selectedId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Rubric Level updated successfully!");
                        LoadRubricLevels();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvrubricmanage.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this level?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM RubricLevel WHERE Id = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            int selectedId = Convert.ToInt32(dgvrubricmanage.CurrentRow.Cells["Id"].Value);
                            cmd.Parameters.AddWithValue("@id", selectedId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Level deleted successfully!");
                            LoadRubricLevels();
                        }
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show("Delete Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvrubricmanage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvrubricmanage.Rows[e.RowIndex];
                txtdetails.Text = row.Cells["Details"].Value.ToString();
                cmbmeasurement.SelectedItem = Convert.ToInt32(row.Cells["MeasurementLevel"].Value);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO rubriclevel (RubricId,Details, MeasurementLevel) VALUES ( @rubricId,@details, @level)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@details", txtdetails.Text);
                    cmd.Parameters.AddWithValue("@rubricId", currentRubricId);
     
                    cmd.Parameters.AddWithValue("@level", cmbmeasurement.SelectedItem);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Level added successfully!");
                    LoadRubricLevels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rubrics.Show();
            this.Close();
        }
    }
}
