namespace ProjectBDB_2025CS196
{
    partial class assesment
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
            txttitle = new TextBox();
            label3 = new Label();
            txttotalmarks = new TextBox();
            label4 = new Label();
            txtweightage = new TextBox();
            dgvassesment = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvassesment).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 27);
            label1.Name = "label1";
            label1.Size = new Size(386, 45);
            label1.TabIndex = 0;
            label1.Text = "Assesment Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 228);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(523, 222);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(150, 31);
            txttitle.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 318);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 3;
            label3.Text = "Total Marks";
            // 
            // txttotalmarks
            // 
            txttotalmarks.Location = new Point(523, 315);
            txttotalmarks.Name = "txttotalmarks";
            txttotalmarks.Size = new Size(150, 31);
            txttotalmarks.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 398);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 5;
            label4.Text = "Total Weightage";
            // 
            // txtweightage
            // 
            txtweightage.Location = new Point(523, 392);
            txtweightage.Name = "txtweightage";
            txtweightage.Size = new Size(150, 31);
            txtweightage.TabIndex = 6;
            // 
            // dgvassesment
            // 
            dgvassesment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvassesment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvassesment.Dock = DockStyle.Bottom;
            dgvassesment.Location = new Point(0, 577);
            dgvassesment.Name = "dgvassesment";
            dgvassesment.ReadOnly = true;
            dgvassesment.RowHeadersWidth = 62;
            dgvassesment.Size = new Size(1167, 161);
            dgvassesment.TabIndex = 7;
            dgvassesment.CellContentClick += dgvassesment_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(641, 500);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(815, 500);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(995, 500);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Location = new Point(0, 300);
            button4.Name = "button4";
            button4.Size = new Size(211, 61);
            button4.TabIndex = 11;
            button4.Text = "Manage Components";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Location = new Point(33, 487);
            button5.Name = "button5";
            button5.Size = new Size(131, 47);
            button5.TabIndex = 12;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // assesment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 738);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvassesment);
            Controls.Add(txtweightage);
            Controls.Add(label4);
            Controls.Add(txttotalmarks);
            Controls.Add(label3);
            Controls.Add(txttitle);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "assesment";
            Text = "assesment";
            Load += assesment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvassesment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txttitle;
        private Label label3;
        private TextBox txttotalmarks;
        private Label label4;
        private TextBox txtweightage;
        private DataGridView dgvassesment;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}