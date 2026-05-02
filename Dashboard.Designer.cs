namespace ProjectBDB_2025CS196
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Location = new Point(1, 151);
            button1.Name = "button1";
            button1.Size = new Size(243, 55);
            button1.TabIndex = 1;
            button1.Text = "Manage Students";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Location = new Point(1, 212);
            button2.Name = "button2";
            button2.Size = new Size(247, 55);
            button2.TabIndex = 2;
            button2.Text = "Manage CLO's";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Location = new Point(0, 273);
            button3.Name = "button3";
            button3.Size = new Size(252, 55);
            button3.TabIndex = 3;
            button3.Text = "Manage Rubrics";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(128, 255, 255);
            button4.Location = new Point(-5, 456);
            button4.Name = "button4";
            button4.Size = new Size(258, 55);
            button4.TabIndex = 4;
            button4.Text = "Manage Attendence";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(128, 255, 255);
            button5.Location = new Point(0, 334);
            button5.Name = "button5";
            button5.Size = new Size(251, 55);
            button5.TabIndex = 5;
            button5.Text = "Manage Assesments";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(128, 255, 255);
            button6.Location = new Point(0, 395);
            button6.Name = "button6";
            button6.Size = new Size(248, 55);
            button6.TabIndex = 6;
            button6.Text = "Evaluation";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(128, 255, 255);
            button7.Location = new Point(3, 517);
            button7.Name = "button7";
            button7.Size = new Size(245, 62);
            button7.TabIndex = 7;
            button7.Text = "View Reports Or Results";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(5, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 685);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 128);
            button8.Location = new Point(0, 600);
            button8.Name = "button8";
            button8.Size = new Size(247, 51);
            button8.TabIndex = 8;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 131);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 40);
            label1.Name = "label1";
            label1.Size = new Size(498, 45);
            label1.TabIndex = 0;
            label1.Text = "Evaluation Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(500, 380);
            label2.Name = "label2";
            label2.Size = new Size(235, 38);
            label2.TabIndex = 10;
            label2.Text = "Welcome Admin!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(500, 446);
            label3.Name = "label3";
            label3.Size = new Size(447, 38);
            label3.TabIndex = 11;
            label3.Text = "Select Option Form the Left Menu.";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1059, 785);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Dashboard";
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button8;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}