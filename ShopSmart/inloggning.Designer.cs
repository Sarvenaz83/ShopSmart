namespace ShopSmart
{
    partial class FrmLogin
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
            this.pnlInloggning = new System.Windows.Forms.Panel();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.lblDontHaveAccount = new System.Windows.Forms.Label();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.picBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInloggning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInloggning
            // 
            this.pnlInloggning.Controls.Add(this.checkBoxShowPassword);
            this.pnlInloggning.Controls.Add(this.lblDontHaveAccount);
            this.pnlInloggning.Controls.Add(this.picBoxClose);
            this.pnlInloggning.Controls.Add(this.btnLogin);
            this.pnlInloggning.Controls.Add(this.txtBoxPassword);
            this.pnlInloggning.Controls.Add(this.txtBoxUsername);
            this.pnlInloggning.Controls.Add(this.picBoxPassword);
            this.pnlInloggning.Controls.Add(this.picBoxUsername);
            this.pnlInloggning.Controls.Add(this.pictureBox1);
            this.pnlInloggning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInloggning.Location = new System.Drawing.Point(0, 0);
            this.pnlInloggning.Name = "pnlInloggning";
            this.pnlInloggning.Size = new System.Drawing.Size(285, 293);
            this.pnlInloggning.TabIndex = 8;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(130, 199);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxShowPassword.Size = new System.Drawing.Size(114, 19);
            this.checkBoxShowPassword.TabIndex = 16;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // lblDontHaveAccount
            // 
            this.lblDontHaveAccount.AutoSize = true;
            this.lblDontHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDontHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHaveAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDontHaveAccount.Location = new System.Drawing.Point(52, 251);
            this.lblDontHaveAccount.Name = "lblDontHaveAccount";
            this.lblDontHaveAccount.Size = new System.Drawing.Size(165, 16);
            this.lblDontHaveAccount.TabIndex = 15;
            this.lblDontHaveAccount.Text = "Don\'t Have An Account";
            this.lblDontHaveAccount.Click += new System.EventHandler(this.lblDontHaveAccount_Click);
            this.lblDontHaveAccount.MouseEnter += new System.EventHandler(this.lblDontHaveAccount_MouseEnter);
            this.lblDontHaveAccount.MouseLeave += new System.EventHandler(this.lblDontHaveAccount_MouseLeave);
            // 
            // picBoxClose
            // 
            this.picBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxClose.Image = global::ShopSmart.Properties.Resources.X;
            this.picBoxClose.Location = new System.Drawing.Point(266, 3);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(16, 16);
            this.picBoxClose.TabIndex = 14;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogin.Location = new System.Drawing.Point(98, 221);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtBoxPassword.Location = new System.Drawing.Point(55, 169);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPassword.Multiline = true;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(189, 25);
            this.txtBoxPassword.TabIndex = 12;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtBoxUsername.Location = new System.Drawing.Point(55, 141);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(189, 25);
            this.txtBoxUsername.TabIndex = 11;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = global::ShopSmart.Properties.Resources.key_24;
            this.picBoxPassword.Location = new System.Drawing.Point(27, 169);
            this.picBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(24, 23);
            this.picBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassword.TabIndex = 10;
            this.picBoxPassword.TabStop = false;
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = global::ShopSmart.Properties.Resources.user_24__2_;
            this.picBoxUsername.Location = new System.Drawing.Point(27, 141);
            this.picBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(24, 23);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsername.TabIndex = 9;
            this.picBoxUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopSmart.Properties.Resources.MicrosoftTeams_image__5_;
            this.pictureBox1.Location = new System.Drawing.Point(89, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(285, 293);
            this.Controls.Add(this.pnlInloggning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlInloggning.ResumeLayout(false);
            this.pnlInloggning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInloggning;
        private System.Windows.Forms.Label lblDontHaveAccount;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.PictureBox picBoxUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}

