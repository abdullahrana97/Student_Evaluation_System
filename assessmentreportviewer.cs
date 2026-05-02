using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectBDB_2025CS196
{
    public partial class assessmentreportviewer : Form
    {
        public ReportViewer reportViewer;

        public assessmentreportviewer()
        {
            InitializeComponent();
            if (this.reportViewer1 != null)
            {
                
                this.reportViewer1.Parent = this;

              
                this.reportViewer1.Dock = DockStyle.Fill;

           
                this.reportViewer1.BringToFront();
            }

        }

        public void LoadData(DataTable dt,string dataset, string reportFileName)
        {
     
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource(dataset, dt);
            reportViewer1.LocalReport.DataSources.Add(rds);

 
            string reportPath = Path.Combine(Application.StartupPath, reportFileName);
            reportViewer1.LocalReport.ReportPath = reportPath;

        
            reportViewer1.RefreshReport();
        }


     
        private void assessmentreportviewer_Load(object sender, EventArgs e)
        {

        }
    }
}
    
