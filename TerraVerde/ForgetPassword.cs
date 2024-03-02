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
    public partial class ForgetPassword : UserControl
    {
        public ForgetPassword()
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

        private void lbl_code_Click(object sender, EventArgs e)
        {
            //if email is existing do this
            timer_code.Start();

            email = txt_input1.Text;
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

            //if email is not exisiting
        }

        int seconds = 60;
        private void timer_code_Tick(object sender, EventArgs e)
        {
            lbl_code.ForeColor = Color.DimGray;
            lbl_code.Text = "Sent (" + seconds.ToString("00") + "s)"; 
            seconds--;
            if (seconds == 0) { timer_code.Stop(); lbl_code.Text = "Send Code"; seconds = 10; lbl_code.ForeColor = Color.DimGray; }
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
