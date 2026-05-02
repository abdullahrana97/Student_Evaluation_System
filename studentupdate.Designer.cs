namespace ProjectBDB_2025CS196
{
    partial class studentupdate
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
            label3 = new Label();
            label2 = new Label();
            email = new Label();
            lastname = new Label();
            phone = new Label();
            firstname = new Label();
            cmbstatus = new ComboBox();
            txtregno = new TextBox();
            txtphone = new MaskedTextBox();
            txtemail = new TextBox();
            txtlastname = new TextBox();
            txtfirstname = new TextBox();
            dgvstudent = new DataGridView();
            txtsearch = new TextBox();
            btnsearch = new Button();
            btnUPDATE = new Button();
            btndelete = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvstudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 137);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 41);
            label1.Name = "label1";
            label1.Size = new Size(443, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Management Portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 504);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 20;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 347);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 19;
            label2.Text = "Reg No";
            // 
            // email
            // 
            email.AutoSize = true;
            email.FlatStyle = FlatStyle.Popup;
            email.Location = new Point(562, 449);
            email.Name = "email";
            email.Size = new Size(54, 25);
            email.TabIndex = 18;
            email.Text = "Email";
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.FlatStyle = FlatStyle.Popup;
            lastname.Location = new Point(560, 284);
            lastname.Name = "lastname";
            lastname.Size = new Size(95, 25);
            lastname.TabIndex = 17;
            lastname.Text = "Last Name";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.FlatStyle = FlatStyle.Popup;
            phone.Location = new Point(560, 394);
            phone.Name = "phone";
            phone.Size = new Size(73, 25);
            phone.TabIndex = 16;
            phone.Text = "Contact";
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.FlatStyle = FlatStyle.Popup;
            firstname.Location = new Point(560, 228);
            firstname.Name = "firstname";
            firstname.Size = new Size(97, 25);
            firstname.TabIndex = 15;
            firstname.Text = "First Name";
            // 
            // cmbstatus
            // 
            cmbstatus.DisplayMember = "Active";
            cmbstatus.FlatStyle = FlatStyle.Flat;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Active", "InActive" });
            cmbstatus.Location = new Point(705, 501);
            cmbstatus.MaxDropDownItems = 2;
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(187, 33);
            cmbstatus.TabIndex = 26;
            // 
            // txtregno
            // 
            txtregno.Location = new Point(705, 344);
            txtregno.Name = "txtregno";
            txtregno.Size = new Size(187, 31);
            txtregno.TabIndex = 25;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(705, 391);
            txtphone.Mask = "0000-0000000";
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(187, 31);
            txtphone.TabIndex = 24;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(705, 443);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(187, 31);
            txtemail.TabIndex = 23;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(705, 281);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(187, 31);
            txtlastname.TabIndex = 22;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(705, 225);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(187, 31);
            txtfirstname.TabIndex = 21;
            // 
            // dgvstudent
            // 
            dgvstudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvstudent.Dock = DockStyle.Bottom;
            dgvstudent.Location = new Point(0, 638);
            dgvstudent.Name = "dgvstudent";
            dgvstudent.RowHeadersWidth = 62;
            dgvstudent.Size = new Size(1216, 81);
            dgvstudent.TabIndex = 27;
            dgvstudent.CellContentClick += dgvstudent_CellContentClick;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(38, 211);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(150, 31);
            txtsearch.TabIndex = 28;
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Right;
            btnsearch.BackColor = Color.Linen;
            btnsearch.ForeColor = SystemColors.ActiveCaptionText;
            btnsearch.Location = new Point(255, 209);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 29;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.BackColor = Color.Cyan;
            btnUPDATE.Location = new Point(874, 559);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(132, 53);
            btnUPDATE.TabIndex = 30;
            btnUPDATE.Text = "Update";
            btnUPDATE.UseVisualStyleBackColor = false;
            btnUPDATE.Click += btnUPDATE_Click_1;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(255, 128, 128);
            btndelete.Location = new Point(1050, 559);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(132, 53);
            btndelete.TabIndex = 31;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 558);
            button5.Name = "button5";
            button5.Size = new Size(172, 54);
            button5.TabIndex = 32;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // studentupdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1216, 719);
            Controls.Add(button5);
            Controls.Add(btndelete);
            Controls.Add(btnUPDATE);
            Controls.Add(btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(dgvstudent);
            Controls.Add(cmbstatus);
            Controls.Add(txtregno);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(lastname);
            Controls.Add(phone);
            Controls.Add(firstname);
            Controls.Add(panel1);
            Name = "studentupdate";
            Text = "studentupdate";
            Load += studentupdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvstudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label email;
        private Label lastname;
        private Label phone;
        private Label firstname;
        private ComboBox cmbstatus;
        private TextBox txtregno;
        private MaskedTextBox txtphone;
        private TextBox txtemail;
        private TextBox txtlastname;
        private TextBox txtfirstname;
        private DataGridView dgvstudent;
        private TextBox txtsearch;
        private Button btnsearch;
        private Button btnUPDATE;
        private Button btndelete;
        private Button button5;
    }
}