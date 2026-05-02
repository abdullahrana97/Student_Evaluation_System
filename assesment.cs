using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class assesment : Form
    {

        Form dashboard;
        public assesment(Form dash)
        {
            InitializeComponent();
            this.dashboard = dash;
        }

        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@title, @date, @marks, @weightage)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", txttitle.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now); 
                cmd.Parameters.AddWithValue("@marks", txttotalmarks.Text);
                cmd.Parameters.AddWithValue("@weightage", txtweightage.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment Created!");
                LoadAssessments(); 
            }
        }

        public void LoadAssessments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                   
                    string query = "SELECT Id, Title, DateCreated, TotalMarks, TotalWeightage FROM Assessment";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvassesment.DataSource = dt;

                    
                    if (dgvassesment.Columns["Id"] != null)
                        dgvassesment.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assessments: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvassesment.CurrentRow != null)
            {
                
                int assessmentId = Convert.ToInt32(dgvassesment.CurrentRow.Cells["Id"].Value);

                // Passing id to the new form
                assesmentcomponents compForm = new assesmentcomponents(assessmentId,this);
                compForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an assessment first!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "Update assesment Set Title = @title,TotalMarks = @totalmarks,TotalWeightage = @totalweightage  Where Id = @id";
            if (dgvassesment.CurrentRow != null)
            {

                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", txttitle.Text);
                    cmd.Parameters.AddWithValue("@totalmarks", txttotalmarks.Text);
                    cmd.Parameters.AddWithValue("@totalweightage", txtweightage.Text);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvassesment.CurrentRow.Cells["Id"].Value));

                    cmd.ExecuteNonQuery();
                    LoadAssessments();

                }
            }
        }

        private void assesment_Load(object sender, EventArgs e)
        {
            LoadAssessments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Delete From assesment where id = @id";
            if (dgvassesment.CurrentRow != null)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvassesment.CurrentRow.Cells["id"].Value));
                    cmd.ExecuteNonQuery();
                    LoadAssessments();
                }
            }
        }

        private void dgvassesment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvassesment.Rows[e.RowIndex];
                txttitle.Text = row.Cells["Title"].Value.ToString();
                txttotalmarks.Text = row.Cells["TotalMarks"].Value.ToString();
                txtweightage.Text = row.Cells["TotalWeightage"].Value.ToString();
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show(); 
            this.Close();
        }
    }
}
