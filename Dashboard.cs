using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            form2 student = new form2(this);
            student.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLO clo = new CLO(this);
            clo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rubrics rubrics = new Rubrics(this);
            rubrics.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentAttendence attendence = new StudentAttendence(this);
            attendence.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            assesment assesment = new assesment(this);
            assesment.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Evaluation evaluation = new Evaluation(this);
            evaluation.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result result = new Result(this);
            result.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            login.Show();
            this.Close();
        }
    }
}
