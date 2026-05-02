namespace ProjectBDB_2025CS196
{
    partial class loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            label1 = new Label();
            txtusername = new TextBox();
            label3 = new Label();
            txtpassword = new TextBox();
            btnlogin = new Button();
            button1 = new Button();
            label2 = new Label();
            loginpanel = new Panel();
            pictureBox1 = new PictureBox();
            loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(428, 240);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "username ";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.MenuBar;
            txtusername.Location = new Point(606, 240);
            txtusername.MaxLength = 10;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(219, 31);
            txtusername.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 309);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 3;
            label3.Text = "password";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Menu;
            txtpassword.Location = new Point(606, 312);
            txtpassword.MaxLength = 5;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(219, 31);
            txtpassword.TabIndex = 4;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.AutoSize = true;
            btnlogin.BackColor = Color.FromArgb(128, 255, 128);
            btnlogin.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnlogin.Location = new Point(796, 429);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(125, 55);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(555, 429);
            button1.Name = "button1";
            button1.Size = new Size(125, 55);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(426, 28);
            label2.Name = "label2";
            label2.Size = new Size(254, 60);
            label2.TabIndex = 0;
            label2.Text = "Login Page";
            // 
            // loginpanel
            // 
            loginpanel.BackColor = SystemColors.ActiveCaption;
            loginpanel.BorderStyle = BorderStyle.Fixed3D;
            loginpanel.Controls.Add(label2);
            loginpanel.Dock = DockStyle.Top;
            loginpanel.Location = new Point(0, 0);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(1113, 123);
            loginpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1113, 595);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(loginpanel);
            Controls.Add(label1);
            Name = "loginform";
            Text = "Login";
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusername;
        private Label label3;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button button1;
        private Label label2;
        private Panel loginpanel;
        private PictureBox pictureBox1;
    }
}
