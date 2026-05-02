namespace ProjectBDB_2025CS196
{
    partial class rubricmanage
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
            txtdetails = new TextBox();
            label3 = new Label();
            cmbmeasurement = new ComboBox();
            dgvrubricmanage = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrubricmanage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 129);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 39);
            label1.Name = "label1";
            label1.Size = new Size(423, 45);
            label1.TabIndex = 0;
            label1.Text = "Rubric Levels Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 231);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Details";
            // 
            // txtdetails
            // 
            txtdetails.Location = new Point(421, 228);
            txtdetails.Multiline = true;
            txtdetails.Name = "txtdetails";
            txtdetails.Size = new Size(182, 46);
            txtdetails.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 312);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 3;
            label3.Text = "Measurement Level";
            // 
            // cmbmeasurement
            // 
            cmbmeasurement.FormattingEnabled = true;
            cmbmeasurement.Location = new Point(421, 304);
            cmbmeasurement.Name = "cmbmeasurement";
            cmbmeasurement.Size = new Size(182, 33);
            cmbmeasurement.TabIndex = 4;
            // 
            // dgvrubricmanage
            // 
            dgvrubricmanage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvrubricmanage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrubricmanage.Dock = DockStyle.Bottom;
            dgvrubricmanage.Location = new Point(0, 542);
            dgvrubricmanage.Name = "dgvrubricmanage";
            dgvrubricmanage.RowHeadersWidth = 62;
            dgvrubricmanage.Size = new Size(945, 114);
            dgvrubricmanage.TabIndex = 5;
            dgvrubricmanage.CellContentClick += dgvrubricmanage_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 0);
            btnAdd.Location = new Point(326, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.Location = new Point(510, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(702, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(0, 409);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 17;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // rubricmanage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 656);
            Controls.Add(button5);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvrubricmanage);
            Controls.Add(cmbmeasurement);
            Controls.Add(label3);
            Controls.Add(txtdetails);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "rubricmanage";
            Text = "rubricmanage";
            Load += rubricmanage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrubricmanage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtdetails;
        private Label label3;
        private ComboBox cmbmeasurement;
        private DataGridView dgvrubricmanage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button button5;
    }
}