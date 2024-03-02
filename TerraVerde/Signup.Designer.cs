namespace TerraVerde
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_pnum = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_others = new System.Windows.Forms.RadioButton();
            this.txt_cpass = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_mname = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_pnum = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.img_dp = new System.Windows.Forms.PictureBox();
            this.lbl_registration = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_cpass = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.error_fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_mname = new System.Windows.Forms.ErrorProvider(this.components);
            this.rb_seller = new System.Windows.Forms.RadioButton();
            this.rb_client = new System.Windows.Forms.RadioButton();
            this.usertype_group = new System.Windows.Forms.Panel();
            this.lbl_accounttype = new System.Windows.Forms.Label();
            this.txt_bdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_bdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_dp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mname)).BeginInit();
            this.usertype_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_fname.Location = new System.Drawing.Point(69, 81);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(362, 26);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.Text = "First Name";
            this.txt_fname.Enter += new System.EventHandler(this.txt_fname_Enter);
            // 
            // txt_mname
            // 
            this.txt_mname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_mname.Location = new System.Drawing.Point(69, 147);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(362, 26);
            this.txt_mname.TabIndex = 1;
            this.txt_mname.Text = "Middle Name";
            this.txt_mname.Enter += new System.EventHandler(this.txt_mname_Enter);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_lname.Location = new System.Drawing.Point(69, 209);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(362, 26);
            this.txt_lname.TabIndex = 2;
            this.txt_lname.Text = "Last Name";
            this.txt_lname.Enter += new System.EventHandler(this.txt_lname_Enter);
            // 
            // txt_pnum
            // 
            this.txt_pnum.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnum.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_pnum.Location = new System.Drawing.Point(69, 532);
            this.txt_pnum.MaxLength = 11;
            this.txt_pnum.Name = "txt_pnum";
            this.txt_pnum.Size = new System.Drawing.Size(362, 26);
            this.txt_pnum.TabIndex = 4;
            this.txt_pnum.Text = "Phone Number";
            this.txt_pnum.Enter += new System.EventHandler(this.txt_pnum_Enter);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_address.Location = new System.Drawing.Point(69, 434);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(362, 58);
            this.txt_address.TabIndex = 3;
            this.txt_address.Text = "Address";
            this.txt_address.Enter += new System.EventHandler(this.txt_address_Enter);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(69, 371);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(62, 22);
            this.rb_male.TabIndex = 6;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.rb_male_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(203, 371);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(78, 22);
            this.rb_female.TabIndex = 7;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.CheckedChanged += new System.EventHandler(this.rb_female_CheckedChanged);
            // 
            // rb_others
            // 
            this.rb_others.AutoSize = true;
            this.rb_others.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_others.Location = new System.Drawing.Point(345, 371);
            this.rb_others.Name = "rb_others";
            this.rb_others.Size = new System.Drawing.Size(73, 22);
            this.rb_others.TabIndex = 8;
            this.rb_others.TabStop = true;
            this.rb_others.Text = "Others";
            this.rb_others.UseVisualStyleBackColor = true;
            this.rb_others.CheckedChanged += new System.EventHandler(this.rb_others_CheckedChanged);
            // 
            // txt_cpass
            // 
            this.txt_cpass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_cpass.Location = new System.Drawing.Point(924, 371);
            this.txt_cpass.Name = "txt_cpass";
            this.txt_cpass.Size = new System.Drawing.Size(362, 26);
            this.txt_cpass.TabIndex = 11;
            this.txt_cpass.Text = "Confirm Password";
            this.txt_cpass.Enter += new System.EventHandler(this.txt_cpass_Enter);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_pass.Location = new System.Drawing.Point(924, 310);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(362, 26);
            this.txt_pass.TabIndex = 10;
            this.txt_pass.Text = "Password";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_username.Location = new System.Drawing.Point(924, 247);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(362, 26);
            this.txt_username.TabIndex = 9;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(66, 62);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(86, 18);
            this.lbl_fname.TabIndex = 12;
            this.lbl_fname.Text = "First Name:";
            this.lbl_fname.Validating += new System.ComponentModel.CancelEventHandler(this.lbl_fname_Validating);
            // 
            // lbl_mname
            // 
            this.lbl_mname.AutoSize = true;
            this.lbl_mname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mname.Location = new System.Drawing.Point(66, 128);
            this.lbl_mname.Name = "lbl_mname";
            this.lbl_mname.Size = new System.Drawing.Size(101, 18);
            this.lbl_mname.TabIndex = 13;
            this.lbl_mname.Text = "Middle Name:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(66, 342);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(59, 18);
            this.lbl_gender.TabIndex = 14;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(66, 190);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(85, 18);
            this.lbl_lname.TabIndex = 15;
            this.lbl_lname.Text = "Last Name:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(66, 415);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(67, 18);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_pnum
            // 
            this.lbl_pnum.AutoSize = true;
            this.lbl_pnum.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnum.Location = new System.Drawing.Point(66, 513);
            this.lbl_pnum.Name = "lbl_pnum";
            this.lbl_pnum.Size = new System.Drawing.Size(111, 18);
            this.lbl_pnum.TabIndex = 17;
            this.lbl_pnum.Text = "Phone Number:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(66, 589);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(109, 18);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email Address:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(921, 228);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(80, 18);
            this.lbl_username.TabIndex = 19;
            this.lbl_username.Text = "Username:";
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(1059, 152);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(96, 44);
            this.btn_upload.TabIndex = 20;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(1059, 494);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(110, 41);
            this.btn_register.TabIndex = 21;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // img_dp
            // 
            this.img_dp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.img_dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_dp.Location = new System.Drawing.Point(1041, 39);
            this.img_dp.Name = "img_dp";
            this.img_dp.Size = new System.Drawing.Size(129, 107);
            this.img_dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_dp.TabIndex = 22;
            this.img_dp.TabStop = false;
            // 
            // lbl_registration
            // 
            this.lbl_registration.AutoSize = true;
            this.lbl_registration.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registration.Location = new System.Drawing.Point(16, 19);
            this.lbl_registration.Name = "lbl_registration";
            this.lbl_registration.Size = new System.Drawing.Size(106, 22);
            this.lbl_registration.TabIndex = 23;
            this.lbl_registration.Text = "Registration";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(921, 289);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(78, 18);
            this.lbl_pass.TabIndex = 24;
            this.lbl_pass.Text = "Password:";
            // 
            // lbl_cpass
            // 
            this.lbl_cpass.AutoSize = true;
            this.lbl_cpass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpass.Location = new System.Drawing.Point(923, 350);
            this.lbl_cpass.Name = "lbl_cpass";
            this.lbl_cpass.Size = new System.Drawing.Size(135, 18);
            this.lbl_cpass.TabIndex = 25;
            this.lbl_cpass.Text = "Confirm Password:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_email.Location = new System.Drawing.Point(69, 610);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(362, 26);
            this.txt_email.TabIndex = 5;
            this.txt_email.Text = "Email Address";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            // 
            // error_fname
            // 
            this.error_fname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_fname.ContainerControl = this;
            // 
            // error_mname
            // 
            this.error_mname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_mname.ContainerControl = this;
            // 
            // rb_seller
            // 
            this.rb_seller.AutoSize = true;
            this.rb_seller.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_seller.Location = new System.Drawing.Point(115, 42);
            this.rb_seller.Name = "rb_seller";
            this.rb_seller.Size = new System.Drawing.Size(67, 22);
            this.rb_seller.TabIndex = 27;
            this.rb_seller.TabStop = true;
            this.rb_seller.Text = "Seller";
            this.rb_seller.UseVisualStyleBackColor = true;
            this.rb_seller.CheckedChanged += new System.EventHandler(this.rb_seller_CheckedChanged);
            // 
            // rb_client
            // 
            this.rb_client.AutoSize = true;
            this.rb_client.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_client.Location = new System.Drawing.Point(7, 42);
            this.rb_client.Name = "rb_client";
            this.rb_client.Size = new System.Drawing.Size(68, 22);
            this.rb_client.TabIndex = 26;
            this.rb_client.TabStop = true;
            this.rb_client.Text = "Client";
            this.rb_client.UseVisualStyleBackColor = true;
            this.rb_client.CheckedChanged += new System.EventHandler(this.rb_client_CheckedChanged);
            // 
            // usertype_group
            // 
            this.usertype_group.Controls.Add(this.lbl_accounttype);
            this.usertype_group.Controls.Add(this.rb_client);
            this.usertype_group.Controls.Add(this.rb_seller);
            this.usertype_group.Location = new System.Drawing.Point(926, 405);
            this.usertype_group.Name = "usertype_group";
            this.usertype_group.Size = new System.Drawing.Size(360, 83);
            this.usertype_group.TabIndex = 28;
            // 
            // lbl_accounttype
            // 
            this.lbl_accounttype.AutoSize = true;
            this.lbl_accounttype.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accounttype.Location = new System.Drawing.Point(3, 12);
            this.lbl_accounttype.Name = "lbl_accounttype";
            this.lbl_accounttype.Size = new System.Drawing.Size(103, 18);
            this.lbl_accounttype.TabIndex = 29;
            this.lbl_accounttype.Text = "Account Type:";
            // 
            // txt_bdate
            // 
            this.txt_bdate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_bdate.Location = new System.Drawing.Point(69, 281);
            this.txt_bdate.Name = "txt_bdate";
            this.txt_bdate.Size = new System.Drawing.Size(362, 26);
            this.txt_bdate.TabIndex = 29;
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bdate.Location = new System.Drawing.Point(66, 260);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(72, 18);
            this.lbl_bdate.TabIndex = 30;
            this.lbl_bdate.Text = "Birthdate:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_bdate);
            this.Controls.Add(this.txt_bdate);
            this.Controls.Add(this.usertype_group);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_cpass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_registration);
            this.Controls.Add(this.img_dp);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_pnum);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_mname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.txt_cpass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.rb_others);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.txt_pnum);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.txt_fname);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_dp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mname)).EndInit();
            this.usertype_group.ResumeLayout(false);
            this.usertype_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_pnum;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_others;
        private System.Windows.Forms.TextBox txt_cpass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_mname;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_pnum;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox img_dp;
        private System.Windows.Forms.Label lbl_registration;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_cpass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ErrorProvider error_fname;
        private System.Windows.Forms.ErrorProvider error_mname;
        private System.Windows.Forms.Panel usertype_group;
        private System.Windows.Forms.RadioButton rb_client;
        private System.Windows.Forms.RadioButton rb_seller;
        private System.Windows.Forms.Label lbl_accounttype;
        private System.Windows.Forms.DateTimePicker txt_bdate;
        private System.Windows.Forms.Label lbl_bdate;
    }
}
