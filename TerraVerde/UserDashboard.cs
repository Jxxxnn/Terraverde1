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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\Em-jay\Desktop\male.jpg"; 
            Image image = Image.FromFile(imagePath);
            img_profile.Image = image;        
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to logout?", "Confirm logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Hide();
                HomeScreen home = new HomeScreen();
                home.Show();
            }
        }
    }
}
