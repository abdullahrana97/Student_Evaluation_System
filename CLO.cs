using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectBDB_2025CS196
{
    public partial class CLO : Form
    {

        Form dashboard;
        public CLO(Form dashboard)
        {
           
            InitializeComponent();
            this.dashboard = dashboard;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcloname.Text))
            {
                MessageBox.Show("Enter Clo name first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            CLO_DL clo = new CLO_DL();
            clo.AddCLO(txtcloname.Text);


            txtcloname.Clear();
            LoadData();

        }
        CLO_DL d1 = new CLO_DL();



        void LoadData()
        {
            try
            {
                
                if (dgvCLO == null)
                {
                    MessageBox.Show("The DataGridView 'dgvCLO' was not found on the form.", "UI Error");
                    return;
                }

              
                DataTable dt = d1.GetAllCLOs();
                dgvCLO.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Database Error");
            }

        }




        int selectedid = -1;



        private void dgvCLO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCLO.Rows[e.RowIndex];

                selectedid = Convert.ToInt32(row.Cells["Id"].Value);
                txtcloname.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedid == -1)
            {
                MessageBox.Show("Select a CLO first");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcloname.Text))
            {
                MessageBox.Show("Enter CLO name");
                return;
            }

            d1.UpdateCLO(selectedid, txtcloname.Text);

            LoadData();             
            txtcloname.Clear();
            selectedid = -1;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedid == -1)
            {
                MessageBox.Show("Select a CLO first");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                d1.DeleteCLO(selectedid);

                LoadData();
                txtcloname.Clear();
                selectedid = -1;
            }
        }

        private void btnviewclo_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CLO_Load(object sender, EventArgs e)
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
