namespace ProjectBDB_2025CS196
{
    partial class CLO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            txtcloname = new TextBox();
            cloname = new Label();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            dgvCLO = new DataGridView();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCLO).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 47);
            label1.Name = "label1";
            label1.Size = new Size(322, 45);
            label1.TabIndex = 0;
            label1.Text = "CLO MANAGEMENT";
            // 
            // txtcloname
            // 
            txtcloname.Location = new Point(558, 292);
            txtcloname.Name = "txtcloname";
            txtcloname.Size = new Size(150, 31);
            txtcloname.TabIndex = 1;
            // 
            // cloname
            // 
            cloname.AutoSize = true;
            cloname.Location = new Point(378, 295);
            cloname.Name = "cloname";
            cloname.Size = new Size(96, 25);
            cloname.TabIndex = 2;
            cloname.Text = "CLO Name";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(192, 192, 255);
            btnadd.Location = new Point(468, 447);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 3;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(255, 192, 128);
            btnupdate.Location = new Point(655, 447);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(112, 34);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(255, 128, 128);
            btndelete.Location = new Point(852, 447);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 34);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // dgvCLO
            // 
            dgvCLO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCLO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCLO.Dock = DockStyle.Bottom;
            dgvCLO.Location = new Point(0, 552);
            dgvCLO.Name = "dgvCLO";
            dgvCLO.ReadOnly = true;
            dgvCLO.RowHeadersWidth = 62;
            dgvCLO.Size = new Size(1138, 208);
            dgvCLO.TabIndex = 7;
            dgvCLO.CellClick += dgvCLO_CellClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 447);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 13;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // CLO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 760);
            Controls.Add(button5);
            Controls.Add(dgvCLO);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(cloname);
            Controls.Add(txtcloname);
            Controls.Add(panel1);
            Name = "CLO";
            Text = "CLO";
            Load += CLO_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCLO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtcloname;
        private Label cloname;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private System.Windows.Forms.DataGridView dgvCLO;
        private Button button5;
    }
}