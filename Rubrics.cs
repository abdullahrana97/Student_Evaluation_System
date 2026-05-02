using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class Rubrics : Form
    {
        Form dashboard;
        public Rubrics(Form dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        Rubric r = new Rubric();
        public void LoadData()
        {
            try
            {
                if (dgvrubrics == null)
                {
                    MessageBox.Show("No Data to Show ", "Error");
                    return;

                }

                DataTable dt = r.GetAllRubrics();
                dgvrubrics.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to load the grid" + ex.Message + "Error");

            }
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdetails.Text))
            {
                MessageBox.Show("Enter details");
                return;
            }

            if (cmbclos.SelectedValue == null)
            {
                MessageBox.Show("Please select a CLO");
                return;
            }
            int cloId = Convert.ToInt32(cmbclos.SelectedValue);

            r.AddRubric(txtdetails.Text, cloId);

            LoadData();
            txtdetails.Clear();
            txtdetails.Focus();
        }


        int selectedid = -1;
        private void dgvrubrics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvrubrics.Rows[e.RowIndex];

                selectedid = Convert.ToInt32(row.Cells["Id"].Value);
                txtdetails.Text = row.Cells["Details"].Value.ToString();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedid == -1)
            {
                MessageBox.Show("Select a row");
                return;
            }

            r.DeleteRubric(selectedid);

            LoadData();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedid == -1)
            {
                MessageBox.Show("Select a row");
                return;
            }

            int cloId = Convert.ToInt32(cmbclos.SelectedValue);

            r.UpdateRubric(selectedid, txtdetails.Text, cloId);

            LoadData();
        }




        CLO_DL dL = new CLO_DL();
        private void Rubrics_Load(object sender, EventArgs e)
        {
            DataTable dt = dL.GetAllCLOs();

            cmbclos.DataSource = dt;
            cmbclos.DisplayMember = "Name";  
        }

        private void btnrubriclevel_Click(object sender, EventArgs e)
        {
            if (dgvrubrics.CurrentRow != null)
            {
         
                int selectedId = Convert.ToInt32(dgvrubrics.CurrentRow.Cells["Id"].Value);

                rubricmanage levelForm = new rubricmanage(selectedId,this);
                levelForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a Rubric first!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }
    }
}
