namespace ProjectBDB_2025CS196
{
    partial class Rubrics
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
            txtdetails = new TextBox();
            cmbclos = new ComboBox();
            dgvrubrics = new DataGridView();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            label2 = new Label();
            label3 = new Label();
            btnrubriclevel = new Button();
            button1 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrubrics).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 44);
            label1.Name = "label1";
            label1.Size = new Size(338, 45);
            label1.TabIndex = 0;
            label1.Text = "Rubrics Management";
            // 
            // txtdetails
            // 
            txtdetails.Location = new Point(486, 251);
            txtdetails.Name = "txtdetails";
            txtdetails.Size = new Size(150, 31);
            txtdetails.TabIndex = 1;
            // 
            // cmbclos
            // 
            cmbclos.FormattingEnabled = true;
            cmbclos.Location = new Point(486, 300);
            cmbclos.Name = "cmbclos";
            cmbclos.Size = new Size(182, 33);
            cmbclos.TabIndex = 2;
            // 
            // dgvrubrics
            // 
            dgvrubrics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvrubrics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrubrics.Dock = DockStyle.Bottom;
            dgvrubrics.Location = new Point(0, 589);
            dgvrubrics.Name = "dgvrubrics";
            dgvrubrics.RowHeadersWidth = 62;
            dgvrubrics.Size = new Size(1059, 177);
            dgvrubrics.TabIndex = 3;
            dgvrubrics.CellContentClick += dgvrubrics_CellContentClick;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.Info;
            btnadd.Location = new Point(470, 486);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(112, 34);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Teal;
            btnupdate.Location = new Point(635, 486);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(112, 34);
            btnupdate.TabIndex = 5;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Location = new Point(815, 486);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 34);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 257);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 8;
            label2.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 308);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 9;
            label3.Text = "CLO's";
            // 
            // btnrubriclevel
            // 
            btnrubriclevel.BackColor = Color.FromArgb(255, 192, 255);
            btnrubriclevel.Location = new Point(0, 265);
            btnrubriclevel.Name = "btnrubriclevel";
            btnrubriclevel.Size = new Size(165, 68);
            btnrubriclevel.TabIndex = 10;
            btnrubriclevel.Text = "Rubric Levels";
            btnrubriclevel.UseVisualStyleBackColor = false;
            btnrubriclevel.Click += btnrubriclevel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Location = new Point(77, 477);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 11;
            button1.Text = "View Rubrics";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 351);
            button5.Name = "button5";
            button5.Size = new Size(165, 54);
            button5.TabIndex = 18;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Rubrics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 766);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(btnrubriclevel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(dgvrubrics);
            Controls.Add(cmbclos);
            Controls.Add(txtdetails);
            Controls.Add(panel1);
            Name = "Rubrics";
            Text = "Rubrics";
            Load += Rubrics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrubrics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtdetails;
        private ComboBox cmbclos;
        private DataGridView dgvrubrics;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private Label label2;
        private Label label3;
        private Button btnrubriclevel;
        private Button button1;
        private Button button5;
    }
}