using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TerraVerde
{
    public partial class Signup : UserControl
    {
        //SQL CONNECTION
        public MySqlConnection conn;
        string connstr;
        public string sql;
        string lvl;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        //GLOBAL VAR
        public static string gender;
        public static int atype;
        public static bool legalage;
        

        public Signup()
        {
            InitializeComponent();
            connstr = "server=localhost;user=root;password='';database=terraverde_db";
            conn = new MySqlConnection(connstr);

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void reset_txt()
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text)) { txt_fname.Text = "First Name"; txt_fname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_mname.Text)) { txt_mname.Text = "Middle Name"; txt_mname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_lname.Text)) { txt_lname.Text = "Last Name"; txt_lname.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_address.Text)) { txt_address.Text = "Address"; txt_address.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_pnum.Text)) { txt_pnum.Text = "Phone Number"; txt_pnum.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_email.Text)) { txt_email.Text = "Email Address"; txt_email.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_username.Text)) { txt_username.Text = "Username"; txt_username.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_pass.Text)) { txt_pass.Text = "Password"; txt_pass.ForeColor = SystemColors.ButtonShadow; }
            if (string.IsNullOrWhiteSpace(txt_cpass.Text)) { txt_cpass.Text = "Confirm Password"; txt_cpass.ForeColor = SystemColors.ButtonShadow; }

        }

        //ENTERS
        private void txt_fname_Enter(object sender, EventArgs e) { reset_txt(); txt_fname.ForeColor = Color.Black; if (txt_fname.Text == "First Name") { txt_fname.Text = ""; } }
        private void txt_mname_Enter(object sender, EventArgs e) { reset_txt(); txt_mname.ForeColor = Color.Black; if (txt_mname.Text == "Middle Name") { txt_mname.Text = ""; } }
        private void txt_lname_Enter(object sender, EventArgs e) { reset_txt(); txt_lname.ForeColor = Color.Black; if (txt_lname.Text == "Last Name") { txt_lname.Text = ""; } }
        private void txt_address_Enter(object sender, EventArgs e) { reset_txt(); txt_address.ForeColor = Color.Black; if (txt_address.Text == "Address") { txt_address.Text = ""; } }
        private void txt_pnum_Enter(object sender, EventArgs e) { reset_txt(); txt_pnum.ForeColor = Color.Black; if (txt_pnum.Text == "Phone Number") { txt_pnum.Text = ""; } }
        private void txt_email_Enter(object sender, EventArgs e) { reset_txt(); txt_email.ForeColor = Color.Black; if (txt_email.Text == "Email Address") { txt_email.Text = ""; } }
        private void txt_username_Enter(object sender, EventArgs e) { reset_txt(); txt_username.ForeColor = Color.Black; if (txt_username.Text == "Username") { txt_username.Text = ""; } }
        private void txt_pass_Enter(object sender, EventArgs e) { reset_txt(); txt_pass.ForeColor = Color.Black; if (txt_pass.Text == "Password") { txt_pass.Text = ""; } }
        private void txt_cpass_Enter(object sender, EventArgs e) { reset_txt(); txt_cpass.ForeColor = Color.Black; if (txt_cpass.Text == "Confirm Password") { txt_cpass.Text = ""; }}
       
        //SELECT
        private void rb_male_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Male"; }
        private void rb_female_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Female"; }
        private void rb_others_CheckedChanged(object sender, EventArgs e) { reset_txt(); gender = "Others"; }
        private void rb_client_CheckedChanged(object sender, EventArgs e) { reset_txt(); atype = 1; }
        private void rb_seller_CheckedChanged(object sender, EventArgs e) { reset_txt(); atype = 2; }

        private void lbl_fname_Validating(object sender, CancelEventArgs e)
        {
            if (txt_fname.Text == "First Name") {
                e.Cancel = true;
                txt_fname.Focus();
                error_fname.SetError(lbl_fname, "This field is required!");
            }
            if (txt_mname.Text == "Middle Name")
            {
                e.Cancel = true;
                txt_mname.Focus();
                error_mname.SetError(lbl_mname, "This field is required!");
            }
            else
            {
                e.Cancel = true;
                error_fname.SetError(lbl_fname, null);
                error_mname.SetError(lbl_mname, null);

            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog uploadImg = new OpenFileDialog())
            {
                uploadImg.Filter = "choose image(*.jpg;*.png;)|*.jpg;*.png";
                if (uploadImg.ShowDialog() == DialogResult.OK)
                {
                    Image userDP = Image.FromFile(uploadImg.FileName);
                    img_dp.BackgroundImage = userDP;
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            reset_txt();
            //if (ValidateChildren(ValidationConstraints.Enabled)) { }
            DateTime birthday = txt_bdate.Value;
            int age = ageCalculator(birthday);
            if (age >= 18) { legalage = true; }

            if (!(txt_fname.Text == "First Name" || txt_mname.Text == "Middle Name" || txt_lname.Text == "Last Name" || txt_fname.Text == "First Name" || legalage == true || txt_address.Text == "Address" || txt_pnum.Text == "Phone Number" || txt_email.Text == "Email Address" || txt_username.Text == "Username" || txt_pass.Text == "Password" || txt_cpass.Text == "Confirm Password")) //add atype and gender 
            { 
            
            }

        }
        public int ageCalculator(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            if (DateTime.Now.Month < birthdate.Month || (DateTime.Now.Month == birthdate.Month && DateTime.Now.Day < birthdate.Day)) { age = age - 1; }
            return age;
        }


    }
}
