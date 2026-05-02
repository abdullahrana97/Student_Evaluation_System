using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectBDB_2025CS196
{
    public partial class studentupdate : Form
    {



        private string connString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";


        Form dashboard;
        public studentupdate(Form dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string regno = txtsearch.Text.Trim();

            string query = "SELECT s.id,s.FirstName,s.LastName,s.RegistrationNumber ,s.email,s.Contact, l.name as Status FROM student s join lookup l on s.status = l.lookupid where s.RegistrationNumber like @reg;";


            using (MySqlConnection con = new MySqlConnection(connString))
            {

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@reg", regno);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvstudent.DataSource = dt;
            }
        }


        public void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT s.id,s.FirstName,s.LastName,s.RegistrationNumber ,s.email," +
                    "s.Contact, l.name as Status FROM student s join lookup l" +
                    " on s.status = l.lookupid; ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvstudent.DataSource = dt;
            }
        }


        string selectedStudentId;
        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvstudent.Rows[e.RowIndex];




                txtfirstname.Text = row.Cells["FirstName"].Value.ToString();
                txtlastname.Text = row.Cells["LastName"].Value.ToString();
                txtphone.Text = row.Cells["Contact"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtregno.Text = row.Cells["RegistrationNumber"].Value.ToString();

                selectedStudentId = row.Cells["Id"].Value.ToString();
            }
        }



        private void studentupdate_Load(object sender, EventArgs e)
        {
            txtsearch.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                MessageBox.Show("Select the record from grid first!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string query = @"UPDATE student SET FirstName = @fname,LastName = @lname,
                            Contact = @phone,
                            Email = @email,
                            RegistrationNumber = @reg,
                            Status = @status 
                        WHERE Id = @id";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@fname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@reg", txtregno.Text);

                int statusValue = (cmbstatus.Text == "Active") ? 5 : 6;
                cmd.Parameters.AddWithValue("@status", statusValue);


                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Updated Successfully");
            LoadData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                MessageBox.Show("Select the record first!");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();


                try
                {
                    // delete from evaluation
                    string q1 = "DELETE FROM studentresult WHERE StudentId = @id";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn);
                    cmd1.Parameters.AddWithValue("@id", selectedStudentId);
                    cmd1.ExecuteNonQuery();

                    // delete from attendance 
                    string q2 = "DELETE FROM StudentAttendance WHERE StudentId = @id";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn);
                    cmd2.Parameters.AddWithValue("@id", selectedStudentId);
                    cmd2.ExecuteNonQuery();

                    // delete student
                    string q3 = "DELETE FROM student WHERE Id = @id";
                    MySqlCommand cmd3 = new MySqlCommand(q3, conn);
                    cmd3.Parameters.AddWithValue("@id", selectedStudentId);
                    cmd3.ExecuteNonQuery();



                    LoadData();


                }
                catch (Exception ex)
                {
                    {

                        MessageBox.Show("Error deleting student" + ex.Message);
                        return;
                    }
                }

                MessageBox.Show("Deleted Successfully");


            }
        }

        private void btnUPDATE_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                MessageBox.Show("Select the record from grid first!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string query = @"UPDATE student SET FirstName = @fname,LastName = @lname,
                            Contact = @phone,
                            Email = @email,
                            RegistrationNumber = @reg,
                            Status = @status 
                        WHERE Id = @id";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                int statusValue = (cmbstatus.Text == "Active") ? 5 : 6;


                cmd.Parameters.AddWithValue("@fname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@reg", txtregno.Text);
                cmd.Parameters.AddWithValue("@status", statusValue);
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Updated Successfully");
            LoadData();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }
    }
}
