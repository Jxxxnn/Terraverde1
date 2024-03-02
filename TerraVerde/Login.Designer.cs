namespace TerraVerde
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_noaccountmsg = new System.Windows.Forms.Label();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.lbl_fpass = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_username.Location = new System.Drawing.Point(275, 318);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(267, 28);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_password.Location = new System.Drawing.Point(275, 375);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(267, 28);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(303, 449);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(210, 34);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Sign in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(181, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 29);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_noaccountmsg
            // 
            this.lbl_noaccountmsg.AutoSize = true;
            this.lbl_noaccountmsg.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noaccountmsg.Location = new System.Drawing.Point(287, 497);
            this.lbl_noaccountmsg.Name = "lbl_noaccountmsg";
            this.lbl_noaccountmsg.Size = new System.Drawing.Size(255, 18);
            this.lbl_noaccountmsg.TabIndex = 4;
            this.lbl_noaccountmsg.Text = "Don\'t have a TerraVerde account yet?";
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.Location = new System.Drawing.Point(355, 524);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(99, 18);
            this.lbl_signup.TabIndex = 5;
            this.lbl_signup.Text = "Register now!";
            this.lbl_signup.Click += new System.EventHandler(this.lbl_signup_Click);
            // 
            // lbl_fpass
            // 
            this.lbl_fpass.AutoSize = true;
            this.lbl_fpass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fpass.Location = new System.Drawing.Point(415, 406);
            this.lbl_fpass.Name = "lbl_fpass";
            this.lbl_fpass.Size = new System.Drawing.Size(127, 18);
            this.lbl_fpass.TabIndex = 6;
            this.lbl_fpass.Text = "Forget password?";
            this.lbl_fpass.Click += new System.EventHandler(this.lbl_fpass_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(272, 295);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(134, 20);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Enter Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(272, 356);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(130, 20);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Enter Password";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(332, 220);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(58, 20);
            this.lbl_login.TabIndex = 9;
            this.lbl_login.Text = "LOGIN";
            // 
            // img_logo
            // 
            this.img_logo.Location = new System.Drawing.Point(275, 67);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(162, 129);
            this.img_logo.TabIndex = 10;
            this.img_logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_fpass);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.lbl_noaccountmsg);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_noaccountmsg;
        private System.Windows.Forms.Label lbl_signup;
        private System.Windows.Forms.Label lbl_fpass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox img_logo;
    }
}
