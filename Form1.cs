using System.Xml.Linq;

namespace ProjectBDB_2025CS196
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Invalid Login Credentials .", " Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                MessageBox.Show("Welcome back!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginpanel.Visible = false;
                
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Login Credentials .", " Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }
    }
}
