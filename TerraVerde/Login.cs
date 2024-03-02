using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TerraVerde
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            if (ParentForm != null && ParentForm is HomeScreen)
            {
                HomeScreen mainForm = (HomeScreen)ParentForm;
                this.Visible = false;
                mainForm.showSignup();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserDashboard userdb = new UserDashboard();
            userdb.Show();
            HomeScreen mainForm = (HomeScreen)ParentForm;
            mainForm.Hide();
        }

        private void lbl_fpass_Click(object sender, EventArgs e)
        {
            if (ParentForm != null && ParentForm is HomeScreen)
            {
                HomeScreen mainForm = (HomeScreen)ParentForm;
                mainForm.showResetPass();
                //this blur
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username") { txt_username.Text = ""; txt_username.ForeColor = Color.Black; }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password") { txt_password.Text = ""; txt_password.ForeColor = Color.Black; }
        }
    }
}
