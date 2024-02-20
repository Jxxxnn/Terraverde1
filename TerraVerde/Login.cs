using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Mail;

namespace TerraVerde
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string otp;
        public static string email;


        public static class BetterRandom
        {
            private static readonly ThreadLocal<System.Security.Cryptography.RandomNumberGenerator> crng = new ThreadLocal<System.Security.Cryptography.RandomNumberGenerator>(() => System.Security.Cryptography.RandomNumberGenerator.Create());
            private static readonly ThreadLocal<byte[]> bytes = new ThreadLocal<byte[]>(() => new byte[sizeof(int)]);
            public static int NextInt()
            {
                crng.Value.GetBytes(bytes.Value);
                return BitConverter.ToInt32(bytes.Value, 0) & int.MaxValue;
            }
            public static double NextDouble()
            {
                while (true)
                {
                    long x = NextInt() & 0x001FFFFF;
                    x <<= 31;
                    x |= (long)NextInt();
                    double n = x;
                    const double d = 1L << 52;
                    double q = n / d;
                    if (q != 1.0)
                        return q;
                }
            }
        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            signup1.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            UserDashboard userdb = new UserDashboard();
            userdb.Show();
            this.Hide();
        }

        private void lbl_fpass_Click(object sender, EventArgs e)
        {
            email = txt_username.Text;
            otp = (BetterRandom.NextInt() % 1000000).ToString("000000");
            string fromMail = "terraverde.corp@gmail.com";
            string fromPassword = "pkcqnkbtvzyzouki";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Forget Password - One-Time Password";
            message.To.Add(new MailAddress(email));
            message.Body = "Hello, '" + otp + "' is your one-time password (OTP) to reset your password";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
