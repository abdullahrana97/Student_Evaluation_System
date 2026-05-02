namespace ProjectBDB_2025CS196
{
    partial class form2
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
            components = new System.ComponentModel.Container();
            firstname = new Label();
            phone = new Label();
            lastname = new Label();
            email = new Label();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            txtemail = new TextBox();
            txtphone = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            label2 = new Label();
            txtregno = new TextBox();
            button2 = new Button();
            label3 = new Label();
            cmbstatus = new ComboBox();
            btnupdate = new Button();
            button3 = new Button();
            button5 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.FlatStyle = FlatStyle.Popup;
            firstname.Location = new Point(511, 279);
            firstname.Name = "firstname";
            firstname.Size = new Size(97, 25);
            firstname.TabIndex = 1;
            firstname.Text = "First Name";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.FlatStyle = FlatStyle.Popup;
            phone.Location = new Point(513, 445);
            phone.Name = "phone";
            phone.Size = new Size(73, 25);
            phone.TabIndex = 2;
            phone.Text = "Contact";
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.FlatStyle = FlatStyle.Popup;
            lastname.Location = new Point(511, 335);
            lastname.Name = "lastname";
            lastname.Size = new Size(95, 25);
            lastname.TabIndex = 3;
            lastname.Text = "Last Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.FlatStyle = FlatStyle.Popup;
            email.Location = new Point(517, 494);
            email.Name = "email";
            email.Size = new Size(54, 25);
            email.TabIndex = 4;
            email.Text = "Email";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(655, 273);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(187, 31);
            txtfirstname.TabIndex = 5;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(655, 329);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(187, 31);
            txtlastname.TabIndex = 6;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(655, 491);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(187, 31);
            txtemail.TabIndex = 8;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(655, 439);
            txtphone.Mask = "0000-0000000";
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(187, 31);
            txtphone.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(511, 649);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 395);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 11;
            label2.Text = "Reg No";
            // 
            // txtregno
            // 
            txtregno.Location = new Point(655, 392);
            txtregno.Name = "txtregno";
            txtregno.Size = new Size(187, 31);
            txtregno.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Location = new Point(730, 649);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 552);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 14;
            label3.Text = "Status";
            // 
            // cmbstatus
            // 
            cmbstatus.DisplayMember = "Active";
            cmbstatus.FlatStyle = FlatStyle.Flat;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(655, 549);
            cmbstatus.MaxDropDownItems = 2;
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(187, 33);
            cmbstatus.TabIndex = 15;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.LightBlue;
            btnupdate.Location = new Point(2, 392);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(206, 64);
            btnupdate.TabIndex = 16;
            btnupdate.Text = "Update Record";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Location = new Point(2, 315);
            button3.Name = "button3";
            button3.Size = new Size(206, 64);
            button3.TabIndex = 18;
            button3.Text = "Delete Record";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(2, 473);
            button5.Name = "button5";
            button5.Size = new Size(206, 67);
            button5.TabIndex = 19;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 47);
            label1.Name = "label1";
            label1.Size = new Size(443, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Management Portal";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 136);
            panel1.TabIndex = 20;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1188, 692);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(btnupdate);
            Controls.Add(cmbstatus);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(txtregno);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(email);
            Controls.Add(lastname);
            Controls.Add(phone);
            Controls.Add(firstname);
            Name = "form2";
            Text = "form2";
            Load += form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label firstname;
        private Label phone;
        private Label lastname;
        private Label email;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private TextBox txtemail;
        private MaskedTextBox txtphone;
        private ErrorProvider errorProvider1;
        private Button button1;
        private Label label2;
        private TextBox txtregno;
        private Button button2;
        private ComboBox cmbstatus;
        private Label label3;
        private Button btnupdate;
        private Button button3;
        private Button button5;
        private Label label1;
        private Panel panel1;
    }
}