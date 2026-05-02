namespace ProjectBDB_2025CS196
{
    partial class assesmentcomponents
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            cmbrubric = new ComboBox();
            label8 = new Label();
            txtCompMarks = new TextBox();
            label7 = new Label();
            txtname = new TextBox();
            label6 = new Label();
            dgvcomponent = new DataGridView();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcomponent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 119);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 28);
            label1.Name = "label1";
            label1.Size = new Size(588, 45);
            label1.TabIndex = 0;
            label1.Text = "Assesment Componenet Management";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(715, 329);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 26;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(505, 329);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 25;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(309, 329);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 24;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbrubric
            // 
            cmbrubric.FormattingEnabled = true;
            cmbrubric.Location = new Point(842, 202);
            cmbrubric.Name = "cmbrubric";
            cmbrubric.Size = new Size(182, 33);
            cmbrubric.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(671, 212);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 22;
            label8.Text = "Rubric";
            // 
            // txtCompMarks
            // 
            txtCompMarks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCompMarks.Location = new Point(467, 209);
            txtCompMarks.Name = "txtCompMarks";
            txtCompMarks.Size = new Size(150, 31);
            txtCompMarks.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 215);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 20;
            label7.Text = "Component Marks";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtname.Location = new Point(90, 212);
            txtname.Name = "txtname";
            txtname.Size = new Size(150, 31);
            txtname.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 212);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 18;
            label6.Text = "Name";
            // 
            // dgvcomponent
            // 
            dgvcomponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcomponent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcomponent.Dock = DockStyle.Bottom;
            dgvcomponent.Location = new Point(0, 450);
            dgvcomponent.Name = "dgvcomponent";
            dgvcomponent.RowHeadersWidth = 62;
            dgvcomponent.Size = new Size(1119, 129);
            dgvcomponent.TabIndex = 27;
            dgvcomponent.CellContentClick += dgvcomponent_CellContentClick;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 364);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 28;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // assesmentcomponents
            // 
            ClientSize = new Size(1119, 579);
            Controls.Add(button5);
            Controls.Add(dgvcomponent);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbrubric);
            Controls.Add(label8);
            Controls.Add(txtCompMarks);
            Controls.Add(label7);
            Controls.Add(txtname);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "assesmentcomponents";
            Load += components_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcomponent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox cmbrubric;
        private Label label8;
        private TextBox txtCompMarks;
        private Label label7;
        private TextBox txtname;
        private Label label6;
        private DataGridView dgvcomponent;
        private Button button5;
    }
}