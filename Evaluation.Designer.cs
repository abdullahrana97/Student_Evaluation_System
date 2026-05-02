namespace ProjectBDB_2025CS196
{
    partial class Evaluation
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
            cmbstudents = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbassesments = new ComboBox();
            cmblevel = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbcomponent = new ComboBox();
            cmbrubric = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnadd = new Button();
            dgvevaluation = new DataGridView();
            button5 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvevaluation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 45);
            label1.Name = "label1";
            label1.Size = new Size(301, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Evaluation";
            // 
            // cmbstudents
            // 
            cmbstudents.FormattingEnabled = true;
            cmbstudents.Location = new Point(171, 52);
            cmbstudents.Name = "cmbstudents";
            cmbstudents.Size = new Size(182, 36);
            cmbstudents.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 2;
            label2.Text = "student name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 124);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 3;
            label3.Text = "assesment";
            // 
            // cmbassesments
            // 
            cmbassesments.FormattingEnabled = true;
            cmbassesments.Location = new Point(171, 121);
            cmbassesments.Name = "cmbassesments";
            cmbassesments.Size = new Size(182, 36);
            cmbassesments.TabIndex = 4;
            cmbassesments.SelectedIndexChanged += cmbassesments_SelectedIndexChanged;
            // 
            // cmblevel
            // 
            cmblevel.FormattingEnabled = true;
            cmblevel.Location = new Point(146, 182);
            cmblevel.Name = "cmblevel";
            cmblevel.Size = new Size(182, 36);
            cmblevel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 185);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 7;
            label4.Text = "rubriclevel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 55);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 6;
            label5.Text = "component";
            // 
            // cmbcomponent
            // 
            cmbcomponent.FormattingEnabled = true;
            cmbcomponent.Location = new Point(146, 52);
            cmbcomponent.Name = "cmbcomponent";
            cmbcomponent.Size = new Size(182, 36);
            cmbcomponent.TabIndex = 5;
            // 
            // cmbrubric
            // 
            cmbrubric.FormattingEnabled = true;
            cmbrubric.Location = new Point(146, 121);
            cmbrubric.Name = "cmbrubric";
            cmbrubric.Size = new Size(182, 36);
            cmbrubric.TabIndex = 10;
            cmbrubric.SelectedIndexChanged += cmbrubric_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 124);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 9;
            label6.Text = "rubric";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbstudents);
            groupBox1.Controls.Add(cmbassesments);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 232);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student And Assesment";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbcomponent);
            groupBox2.Controls.Add(cmbrubric);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmblevel);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(511, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 232);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Evaluation Details";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Lime;
            btnadd.Location = new Point(692, 435);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(147, 51);
            btnadd.TabIndex = 13;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // dgvevaluation
            // 
            dgvevaluation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvevaluation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvevaluation.Dock = DockStyle.Bottom;
            dgvevaluation.Location = new Point(0, 537);
            dgvevaluation.Name = "dgvevaluation";
            dgvevaluation.RowHeadersWidth = 62;
            dgvevaluation.Size = new Size(994, 159);
            dgvevaluation.TabIndex = 14;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(-1, 452);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 15;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Evaluation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 696);
            Controls.Add(button5);
            Controls.Add(dgvevaluation);
            Controls.Add(btnadd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Evaluation";
            Text = "Evaluation";
            Load += Evaluation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvevaluation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cmbstudents;
        private Label label2;
        private Label label3;
        private ComboBox cmbassesments;
        private ComboBox cmblevel;
        private Label label4;
        private Label label5;
        private ComboBox cmbcomponent;
        private ComboBox cmbrubric;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnadd;
        private DataGridView dgvevaluation;
        private Button button5;
    }
}