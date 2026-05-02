namespace ProjectBDB_2025CS196
{
    partial class Result
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
            dgvresult = new DataGridView();
            cmbassessment = new ComboBox();
            label2 = new Label();
            btnviewresult = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            cmbCLO = new ComboBox();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvresult).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 138);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 49);
            label1.Name = "label1";
            label1.Size = new Size(332, 45);
            label1.TabIndex = 0;
            label1.Text = "Results AND Reports";
            // 
            // dgvresult
            // 
            dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvresult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvresult.Dock = DockStyle.Bottom;
            dgvresult.Location = new Point(0, 421);
            dgvresult.Name = "dgvresult";
            dgvresult.RowHeadersWidth = 62;
            dgvresult.Size = new Size(982, 153);
            dgvresult.TabIndex = 1;
            // 
            // cmbassessment
            // 
            cmbassessment.FormattingEnabled = true;
            cmbassessment.Location = new Point(337, 214);
            cmbassessment.Name = "cmbassessment";
            cmbassessment.Size = new Size(182, 33);
            cmbassessment.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 217);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 3;
            label2.Text = "Assessment";
            // 
            // btnviewresult
            // 
            btnviewresult.BackColor = Color.Green;
            btnviewresult.Location = new Point(199, 342);
            btnviewresult.Name = "btnviewresult";
            btnviewresult.Size = new Size(128, 51);
            btnviewresult.TabIndex = 4;
            btnviewresult.Text = "View Result";
            btnviewresult.UseVisualStyleBackColor = false;
            btnviewresult.Click += btnviewresult_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Location = new Point(418, 342);
            button2.Name = "button2";
            button2.Size = new Size(213, 51);
            button2.TabIndex = 5;
            button2.Text = "Assessment wise Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Location = new Point(685, 342);
            button1.Name = "button1";
            button1.Size = new Size(213, 51);
            button1.TabIndex = 6;
            button1.Text = "CLO wise Report";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 217);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 8;
            label3.Text = "CLO";
            // 
            // cmbCLO
            // 
            cmbCLO.FormattingEnabled = true;
            cmbCLO.Location = new Point(716, 214);
            cmbCLO.Name = "cmbCLO";
            cmbCLO.Size = new Size(182, 33);
            cmbCLO.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 342);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 16;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 574);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(cmbCLO);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnviewresult);
            Controls.Add(label2);
            Controls.Add(cmbassessment);
            Controls.Add(dgvresult);
            Controls.Add(panel1);
            Name = "Result";
            Text = "Result";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvresult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvresult;
        private ComboBox cmbassessment;
        private Label label2;
        private Button btnviewresult;
        private Button button2;
        private Button button1;
        private Label label3;
        private ComboBox cmbCLO;
        private Button button5;
    }
}