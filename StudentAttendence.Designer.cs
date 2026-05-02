namespace ProjectBDB_2025CS196
{
    partial class StudentAttendence
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
            label2 = new Label();
            cmbname = new ComboBox();
            cmbstatus = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvAttendence = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendence).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 138);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 44);
            label1.Name = "label1";
            label1.Size = new Size(397, 45);
            label1.TabIndex = 0;
            label1.Text = "Attendence Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(167, 226);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // cmbname
            // 
            cmbname.FormattingEnabled = true;
            cmbname.Location = new Point(258, 223);
            cmbname.Name = "cmbname";
            cmbname.Size = new Size(182, 33);
            cmbname.TabIndex = 2;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(704, 223);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(182, 33);
            cmbstatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(584, 226);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(239, 444);
            button1.Name = "button1";
            button1.Size = new Size(171, 53);
            button1.TabIndex = 5;
            button1.Text = "Save Attendence";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Location = new Point(464, 444);
            button2.Name = "button2";
            button2.Size = new Size(191, 53);
            button2.TabIndex = 6;
            button2.Text = "Update Attendence";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(704, 444);
            button3.Name = "button3";
            button3.Size = new Size(171, 53);
            button3.TabIndex = 7;
            button3.Text = "Delete Attendence";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgvAttendence
            // 
            dgvAttendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendence.Dock = DockStyle.Bottom;
            dgvAttendence.Location = new Point(0, 538);
            dgvAttendence.Name = "dgvAttendence";
            dgvAttendence.RowHeadersWidth = 62;
            dgvAttendence.Size = new Size(1011, 156);
            dgvAttendence.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(426, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(320, 330);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Date";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 444);
            button5.Name = "button5";
            button5.Size = new Size(172, 54);
            button5.TabIndex = 19;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // StudentAttendence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 694);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvAttendence);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbstatus);
            Controls.Add(label3);
            Controls.Add(cmbname);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "StudentAttendence";
            Text = "StudentAttendence";
            Load += StudentAttendence_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendence).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cmbname;
        private ComboBox cmbstatus;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvAttendence;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button5;
    }
}