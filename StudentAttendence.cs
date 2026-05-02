using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class StudentAttendence : Form
    {

        Form dashboard;
        public StudentAttendence(Form dashboard)
        {
            InitializeComponent();
            dgvAttendence.Columns.Clear();
            dgvAttendence.Columns.Add("RegNo", "Registration #");
            dgvAttendence.Columns.Add("StudentName", "Student Name");
            dgvAttendence.Columns.Add("Status", "Attendance Status");

            dgvAttendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dashboard = dashboard;
        }

        private int currentAttendanceId = 0;


        string connectionString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";


        private void StudentAttendence_Load(object sender, EventArgs e)
        {
            cmbname.DataSource = DatabaseHelper.Instance.getdataintable("Select concat(FirstName,' ',LastName) as Name , Id From student");
            cmbname.DisplayMember = "Name";
            cmbname.ValueMember = "Id";

            cmbstatus.DataSource = DatabaseHelper.Instance.getdataintable("Select Name,LookupId From lookup where LookupId in (1,2,3,4)");
            cmbstatus.DisplayMember = "Name";
            cmbstatus.ValueMember = "LookupId";


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
               
                string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @date";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    currentAttendanceId = Convert.ToInt32(result);
                    LoadGridWithExistingData(currentAttendanceId); 
                }
                else
                {
                    currentAttendanceId = 0;
                    MessageBox.Show("No attendance found for this date. Click 'Add' to start a new one.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (cmbname.SelectedValue == null || cmbstatus.SelectedValue == null)
            {
                MessageBox.Show("Please select both a Student and a Status.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                try
                {
                   
                    if (currentAttendanceId == 0)
                    {
                        string classQuery = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@date); SELECT LAST_INSERT_ID();";
                        MySqlCommand cmdClass = new MySqlCommand(classQuery, con);
                        cmdClass.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                        currentAttendanceId = Convert.ToInt32(cmdClass.ExecuteScalar());
                    }

                    
                    string studentQuery = @"INSERT INTO StudentAttendance (AttendanceId, StudentId, AttendanceStatus) 
                                    VALUES (@attendanceId, @studentId, @status)";
                    MySqlCommand cmdStudent = new MySqlCommand(studentQuery, con);

                    cmdStudent.Parameters.AddWithValue("@attendanceId", currentAttendanceId);
                    cmdStudent.Parameters.AddWithValue("@studentId", cmbname.SelectedValue);
                    cmdStudent.Parameters.AddWithValue("@status", cmbstatus.SelectedValue);

                    cmdStudent.ExecuteNonQuery();
                    MessageBox.Show("Attendance marked for this student.");

                    // Refresh the grid to show the new entry
                    LoadGridWithExistingData(currentAttendanceId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Already marked or Error: " + ex.Message);
                }
            }

        }




        

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentAttendanceId == 0 || cmbname.SelectedValue == null)
            {
                MessageBox.Show("Please select a date and a student that already has attendance marked.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Update only the record matching the current Session and the selected Student
                    string updateQuery = @"UPDATE StudentAttendance 
                                 SET AttendanceStatus = @status 
                                 WHERE AttendanceId = @attendanceId AND StudentId = @studentId";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@status", cmbstatus.SelectedValue);
                    cmd.Parameters.AddWithValue("@attendanceId", currentAttendanceId);
                    cmd.Parameters.AddWithValue("@studentId", cmbname.SelectedValue);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status updated successfully!");
                        LoadGridWithExistingData(currentAttendanceId); // Refresh the view
                    }
                    else
                    {
                        MessageBox.Show("No existing record found for this student on this date to update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentAttendanceId == 0 || cmbname.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid date and student.");
                return;
            }

           
            var confirm = MessageBox.Show("Remove attendance for this student?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM StudentAttendance WHERE AttendanceId = @aId AND StudentId = @sId";

                        MySqlCommand cmd = new MySqlCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@aId", currentAttendanceId);
                        cmd.Parameters.AddWithValue("@sId", cmbname.SelectedValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted.");

                        LoadGridWithExistingData(currentAttendanceId); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Error: " + ex.Message);
                    }
                }
            }
        }


        public void LoadGridWithExistingData(int currentattendenceid)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
            
                string query = @"SELECT S.RegistrationNumber, 
                               CONCAT(S.FirstName, ' ', S.LastName) AS Name, 
                               L.Name AS StatusName
                        FROM StudentAttendance SA
                        JOIN Student S ON SA.StudentId = S.Id
                        JOIN lookup L ON SA.AttendanceStatus = L.LookupId
                        WHERE SA.AttendanceId = @attendanceId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@attendanceId", currentattendenceid);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttendence.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgvAttendence.Rows.Add();
                    dgvAttendence.Rows[rowIndex].Cells["RegNo"].Value = row["RegistrationNumber"];
                    dgvAttendence.Rows[rowIndex].Cells["StudentName"].Value = row["Name"];
                    dgvAttendence.Rows[rowIndex].Cells["Status"].Value = row["StatusName"];
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT Id FROM ClassAttendance WHERE AttendanceDate = @date";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                con.Open();
                object result = cmd.ExecuteScalar();

                currentAttendanceId = (result != null) ? Convert.ToInt32(result) : 0;
                LoadGridWithExistingData(currentAttendanceId);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();   
        }
    }
}

