namespace TerraVerde
{
    partial class UserAccount
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
            this.img_profile = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // img_profile
            // 
            this.img_profile.Location = new System.Drawing.Point(19, 18);
            this.img_profile.Name = "img_profile";
            this.img_profile.Size = new System.Drawing.Size(177, 148);
            this.img_profile.TabIndex = 0;
            this.img_profile.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(60, 183);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Juan Dela Cruz";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(221, 49);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(77, 16);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Not Verified";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Under Review";
            // 
            // lbl_status3
            // 
            this.lbl_status3.AutoSize = true;
            this.lbl_status3.Location = new System.Drawing.Point(674, 49);
            this.lbl_status3.Name = "lbl_status3";
            this.lbl_status3.Size = new System.Drawing.Size(53, 16);
            this.lbl_status3.TabIndex = 5;
            this.lbl_status3.Text = "Verified";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(224, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 16);
            this.panel1.TabIndex = 6;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_status3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.img_profile);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(879, 524);
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_profile;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status3;
        private System.Windows.Forms.Panel panel1;
    }
}
