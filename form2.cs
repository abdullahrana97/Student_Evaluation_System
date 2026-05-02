using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace ProjectBDB_2025CS196
{
    public partial class form2 : Form
    {

        Form dashboard;

        public form2(Form dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (!txtemail.Text.Contains("@") || !txtemail.Text.Contains(".com"))
            {
                errorProvider1.SetError(txtemail, "Invalid email !");
            }
            errorProvider1.SetError(txtemail, "");
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

           
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtfirstname.Text))
            {
                errorProvider1.SetError(txtfirstname, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtregno.Text))
            {
                errorProvider1.SetError(txtregno, "Registration number is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text) || !txtemail.Text.Contains("@") || !txtemail.Text.Contains(".com"))
            {
                errorProvider1.SetError(txtemail, "Please enter a valid email address !");
                isValid = false;
            }

         
            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                errorProvider1.SetError(txtphone, "Phone number is required !");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cmbstatus.Text))
            {
                errorProvider1.SetError(txtphone, "Status is required !");
                isValid = false;
            }


            return isValid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string selectedStatus = cmbstatus.SelectedItem.ToString();
                int status = (selectedStatus == "Active") ? 5 : 6;

                Student s = new Student(txtfirstname.Text, txtlastname.Text, txtregno.Text, txtphone.Text, txtemail.Text, status);
                s.addStudent();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtregno.Clear();
            txtemail.Clear();
            txtphone.Clear();
            cmbstatus.SelectedIndex = -1;
            txtfirstname.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentupdate studentupdate = new studentupdate(this);

            studentupdate.Show();

            this.Hide();

        }

        private void form2_Load(object sender, EventArgs e)
        {
            cmbstatus.DataSource = DatabaseHelper.Instance.getdataintable("Select Name,LookupId From lookup Where LookupId = 5 Or LookupId = 6");
            cmbstatus.DisplayMember = "Name";
            cmbstatus.ValueMember = "LookupId";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            studentupdate studentupdate = new studentupdate(this);
            studentupdate.Show();
            this.Hide();
        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }
    }
}
