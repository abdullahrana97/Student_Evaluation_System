using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjectBDB_2025CS196
{
    public partial class Evaluation : Form
    {

        Form dashboard;
        public Evaluation(Form dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private string connString = "server=localhost;user id=root;password=2025cs196;database=projectbdb26;";
        private void Evaluation_Load(object sender, EventArgs e)
        {
            LoadStudents();
            cmbstudents.DisplayMember = "Name";
            cmbstudents.ValueMember = "Id";

            LoadAssesments();
            cmbassesments.DisplayMember = "Title";
            cmbassesments.ValueMember = "Id";

            LoadRubrics();
            cmbrubric.DisplayMember = "Details";
            cmbrubric.ValueMember = "Id";

            loadData();
        }

        public void LoadStudents()
        {
            cmbstudents.DataSource = DatabaseHelper.Instance.getdataintable("SELECT Id,concat(FirstName,' ',LastName) as Name FROM Student");
        }

        public void LoadAssesments()
        {
            cmbassesments.DataSource = DatabaseHelper.Instance.getdataintable("SELECT Id, Title FROM Assessment");
        }

        public void LoadRubrics()
        {
            cmbrubric.DataSource = DatabaseHelper.Instance.getdataintable("SELECT Id, Details FROM Rubric");
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbstudents.SelectedValue == null ||
        cmbcomponent.SelectedValue == null ||
        cmblevel.SelectedValue == null)
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            int sid = Convert.ToInt32(cmbstudents.SelectedValue);
            int cid = Convert.ToInt32(cmbcomponent.SelectedValue);
            int lid = Convert.ToInt32(cmblevel.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO studentresult 
                        ( StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate)
                        VALUES ( @sid, @cid, @lid, @date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@lid", lid);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

            loadData();

            MessageBox.Show("Saved Successfully");
        }

        public DataTable GetComponentsByAssessment(int aid)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Id, Name, TotalMarks FROM AssessmentComponent WHERE AssessmentId = @aid";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@aid", aid);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        private void cmbassesments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbassesments.SelectedValue == null)
                return;

            int aid;

            if (!int.TryParse(cmbassesments.SelectedValue.ToString(), out aid))
                return;

            cmbcomponent.DataSource = null;               //this is done to refersh the components combobox
            cmbcomponent.DataSource = GetComponentsByAssessment(aid);
            cmbcomponent.DisplayMember = "Name";
            cmbcomponent.ValueMember = "Id";
        }


        public DataTable GetLevelsByRubric(int rid)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Id, MeasurementLevel FROM RubricLevel WHERE RubricId = @rid";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rid", rid);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        private void cmbrubric_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbrubric.SelectedValue == null)
                return;

            int rid;

            if (!int.TryParse(cmbrubric.SelectedValue.ToString(), out rid))
                return;

            cmblevel.DataSource = null;
            cmblevel.DataSource = GetLevelsByRubric(rid);
            cmblevel.DisplayMember = "MeasurementLevel";
            cmblevel.ValueMember = "Id";

        }


        public DataTable forGrid()
        {
            DataTable dt = new DataTable();

            string query = "Select concat(s.FirstName,' ',s.LastName) as Name , s.RegistrationNumber as RegNo, ac.Name as Component," +
                "rl.MeasurementLevel , ((rl.MeasurementLevel / 4.0) * ac.TotalMarks) as ObtainedMarks,sr.EvaluationDate " +
                "From studentresult sr inner join student s on sr.StudentId = s.Id " +
                "inner join assessmentcomponent ac on sr.AssessmentComponentId = ac.Id inner join rubriclevel rl on sr.RubricMeasurementId = rl.Id";


            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;

            }
        }


        public void loadData()
        {
            dgvevaluation.DataSource = forGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show(); 
            this.Close();
        }
    }
}


