using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Reporting.WinForms;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class Result : Form
    {

        Form dashboard;
        public Result(Form dashboard)
        {
            InitializeComponent();

            cmbassessment.DataSource = DatabaseHelper.Instance.getdataintable("SELECT Id, Title FROM Assessment");
            cmbassessment.DisplayMember = "Title";
            cmbassessment.ValueMember = "Id";

            cmbCLO.DataSource = DatabaseHelper.Instance.getdataintable("SELECT Id, Name FROM clo");
            cmbCLO.DisplayMember = "Name";
            cmbCLO.ValueMember = "Id";
            this.dashboard = dashboard;
        }

        private string connString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";

        private void btnviewresult_Click(object sender, EventArgs e)
        {
            if (cmbassessment.SelectedValue == null) return;

            int assessmentId = Convert.ToInt32(cmbassessment.SelectedValue);

            string query = @"SELECT CONCAT(S.FirstName, ' ', S.LastName) AS Name, 
                     S.RegistrationNumber, 
                     AC.Name AS ComponentName, 
                     RL.MeasurementLevel, 
                     ((RL.MeasurementLevel / 4.0) * AC.TotalMarks) AS ObtainedMarks 
                     FROM StudentResult SR
                     JOIN Student S ON SR.StudentId = S.Id
                     JOIN AssessmentComponent AC ON SR.AssessmentComponentId = AC.Id
                     JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id
                     WHERE AC.AssessmentId = @assessmentId";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@assessmentId", assessmentId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvresult.DataSource = dt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbassessment.SelectedValue == null) return;

            int assessmentId = Convert.ToInt32(cmbassessment.SelectedValue);

    
            string query = @"SELECT CONCAT(S.FirstName, ' ', S.LastName) AS StudentName, 
                           S.RegistrationNumber, 
                           AC.Name AS ComponentName, 
                           ((CAST(RL.MeasurementLevel AS DECIMAL) / 4.0) * AC.TotalMarks) AS ObtainedMarks, 
                           AC.TotalMarks 
                    FROM StudentResult SR 
                    JOIN Student S ON SR.StudentId = S.Id 
                    JOIN AssessmentComponent AC ON SR.AssessmentComponentId = AC.Id 
                    JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id 
                    WHERE AC.AssessmentId = @assessmentId";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@assessmentId", assessmentId);
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("The database returned 0 rows for this Assessment ID!");
                        return;
                    }

                    assessmentreportviewer reportForm = new assessmentreportviewer();

                    
                    reportForm.LoadData(dt, "AssessmentData", "Assesment Wise Report.rdlc");

                    reportForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            if (cmbCLO.SelectedValue == null)
            {
                MessageBox.Show("Please select a CLO first.");
                return;
            }

            int cloId = Convert.ToInt32(cmbCLO.SelectedValue);

         

            string query = @"SELECT CLO.Name AS CLOName, 
                                 CONCAT(S.FirstName, ' ', S.LastName) AS StudentName, 
                                  S.RegistrationNumber, 
                                AC.Name AS Component, 
                                 RL.MeasurementLevel as MeasurementLevel
                                FROM StudentResult SR
                               JOIN Student S ON SR.StudentId = S.Id
                               JOIN AssessmentComponent AC ON SR.AssessmentComponentId = AC.Id
                               JOIN Rubric R ON AC.RubricId = R.Id
                               JOIN clo CLO ON R.CloId = CLO.Id
                               JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id
                             WHERE CLO.Id = @cloId";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@cloId", cloId);
                    da.Fill(dt);

                 
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No student results found for this CLO.");
                        return;
                    }

                   
                    assessmentreportviewer frm = new assessmentreportviewer();


                    frm.LoadData(dt, "clodata", "CloWiseReport.rdlc");

                    frm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
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


    

