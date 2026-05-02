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
    public partial class assesmentcomponents : Form
    {

        private int selectedAssessmentId;


        Form dashboard;
        public assesmentcomponents(int selectedAssessmentId, Form dashboard)
        {
            InitializeComponent();

            this.selectedAssessmentId = selectedAssessmentId;
            this.dashboard = dashboard;
        }


        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";
        private void components_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id, Details FROM Rubric";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbrubric.DataSource = dt;
                cmbrubric.DisplayMember = "Details"; 
                cmbrubric.ValueMember = "Id"; 
            }

            LoadComponents();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO AssessmentComponent (Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) " +
                               "VALUES (@name, @rubricId, @marks, @date, @date, @assessmentId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@rubricId", cmbrubric.SelectedValue);
                cmd.Parameters.AddWithValue("@marks", txtCompMarks.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@assessmentId", selectedAssessmentId); // From parent form 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Component Added!");
                LoadComponents();
            }
        }

        public void LoadComponents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    
                    string query = "SELECT Id, Name, RubricId, TotalMarks, DateCreated FROM AssessmentComponent WHERE AssessmentId = @assessmentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@assessmentId", selectedAssessmentId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvcomponent.DataSource = dt;

               
                    if (dgvcomponent.Columns["Id"] != null)
                        dgvcomponent.Columns["Id"].Visible = false;
                    if (dgvcomponent.Columns["RubricId"] != null)
                        dgvcomponent.Columns["RubricId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading components: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvcomponent.CurrentRow != null)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE AssessmentComponent SET Name = @name, RubricId = @rubId, TotalMarks = @marks, DateUpdated = @date WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@rubId", cmbrubric.SelectedValue);
                    cmd.Parameters.AddWithValue("@marks", txtCompMarks.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvcomponent.CurrentRow.Cells["Id"].Value));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Component updated!");
                    LoadComponents();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvcomponent.CurrentRow != null)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM AssessmentComponent WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvcomponent.CurrentRow.Cells["Id"].Value));

                    cmd.ExecuteNonQuery();
                    LoadComponents();
                }
            }
        }

        private void dgvcomponent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                  
                    DataGridViewRow row = dgvcomponent.Rows[e.RowIndex];

                   
                    txtname.Text = row.Cells["Name"].Value.ToString();
                    txtCompMarks.Text = row.Cells["TotalMarks"].Value.ToString();

                    
                    int rubricId = Convert.ToInt32(row.Cells["RubricId"].Value);
                    cmbrubric.SelectedValue = rubricId;
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Error selecting record: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show(); 
            this.Close();
        }
    }
}
