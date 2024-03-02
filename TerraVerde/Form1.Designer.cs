namespace TerraVerde
{
    partial class HomeScreen
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
            this.login1 = new TerraVerde.Login();
            this.signup1 = new TerraVerde.Signup();
            this.forgetPassword1 = new TerraVerde.ForgetPassword();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(-125, -12);
            this.login1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.login1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1920, 1080);
            this.login1.TabIndex = 0;
            // 
            // signup1
            // 
            this.signup1.Location = new System.Drawing.Point(-142, 12);
            this.signup1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.signup1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.signup1.Name = "signup1";
            this.signup1.Size = new System.Drawing.Size(1920, 1080);
            this.signup1.TabIndex = 2;
            this.signup1.Visible = false;
            // 
            // forgetPassword1
            // 
            this.forgetPassword1.Location = new System.Drawing.Point(1044, 24);
            this.forgetPassword1.MaximumSize = new System.Drawing.Size(700, 700);
            this.forgetPassword1.MinimumSize = new System.Drawing.Size(700, 700);
            this.forgetPassword1.Name = "forgetPassword1";
            this.forgetPassword1.Size = new System.Drawing.Size(700, 700);
            this.forgetPassword1.TabIndex = 3;
            this.forgetPassword1.Visible = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.forgetPassword1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.signup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Login login1;
        private Signup signup1;
        private ForgetPassword forgetPassword1;
    }
}

