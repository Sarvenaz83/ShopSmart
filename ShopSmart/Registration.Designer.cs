namespace ShopSmart
{
    partial class FrmRegistration
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
            this.lblHaveAnAccount = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxFirstname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.pnlInloggning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInloggning
            // 
            this.pnlInloggning.Controls.Add(this.lblPassword);
            this.pnlInloggning.Controls.Add(this.lblPostCode);
            this.pnlInloggning.Controls.Add(this.lblEmail);
            this.pnlInloggning.Controls.Add(this.lblCity);
            this.pnlInloggning.Controls.Add(this.lblUserName);
            this.pnlInloggning.Controls.Add(this.lblLastName);
            this.pnlInloggning.Controls.Add(this.textBoxPostCode);
            this.pnlInloggning.Controls.Add(this.lblFirstname);
            this.pnlInloggning.Controls.Add(this.textBoxEmail);
            this.pnlInloggning.Controls.Add(this.lblHaveAnAccount);
            this.pnlInloggning.Controls.Add(this.textBoxCity);
            this.pnlInloggning.Controls.Add(this.pictureBox2);
            this.pnlInloggning.Controls.Add(this.textBoxUserName);
            this.pnlInloggning.Controls.Add(this.btnRegister);
            this.pnlInloggning.Controls.Add(this.textBoxLastname);
            this.pnlInloggning.Controls.Add(this.txtBoxPassword);
            this.pnlInloggning.Controls.Add(this.txtBoxFirstname);
            this.pnlInloggning.Controls.Add(this.pictureBox1);
            this.pnlInloggning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInloggning.Location = new System.Drawing.Point(0, 0);
            this.pnlInloggning.Name = "pnlInloggning";
            this.pnlInloggning.Size = new System.Drawing.Size(287, 442);
            this.pnlInloggning.TabIndex = 9;
            // 
            // lblHaveAnAccount
            // 
            this.lblHaveAnAccount.AutoSize = true;
            this.lblHaveAnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHaveAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveAnAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHaveAnAccount.Location = new System.Drawing.Point(58, 399);
            this.lblHaveAnAccount.Name = "lblHaveAnAccount";
            this.lblHaveAnAccount.Size = new System.Drawing.Size(183, 16);
            this.lblHaveAnAccount.TabIndex = 15;
            this.lblHaveAnAccount.Text = "Already Have An Account";
            this.lblHaveAnAccount.Click += new System.EventHandler(this.lblHaveAnAccount_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Honeydew;
            this.btnRegister.Location = new System.Drawing.Point(104, 369);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 28);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtBoxPassword.Location = new System.Drawing.Point(87, 224);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPassword.Multiline = true;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(189, 25);
            this.txtBoxPassword.TabIndex = 12;
            // 
            // txtBoxFirstname
            // 
            this.txtBoxFirstname.BackColor = System.Drawing.Color.Honeydew;
            this.txtBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstname.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtBoxFirstname.Location = new System.Drawing.Point(87, 116);
            this.txtBoxFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxFirstname.Multiline = true;
            this.txtBoxFirstname.Name = "txtBoxFirstname";
            this.txtBoxFirstname.Size = new System.Drawing.Size(189, 25);
            this.txtBoxFirstname.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ShopSmart.Properties.Resources.X;
            this.pictureBox2.Location = new System.Drawing.Point(268, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopSmart.Properties.Resources.MicrosoftTeams_image__5_;
            this.pictureBox1.Location = new System.Drawing.Point(94, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblFirstname.Location = new System.Drawing.Point(16, 119);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(66, 16);
            this.lblFirstname.TabIndex = 16;
            this.lblFirstname.Text = "Firstname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxLastname.Location = new System.Drawing.Point(87, 149);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastname.Multiline = true;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(189, 25);
            this.textBoxLastname.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLastName.Location = new System.Drawing.Point(16, 152);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 16);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Lastname";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxUserName.Location = new System.Drawing.Point(87, 185);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(189, 25);
            this.textBoxUserName.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblUserName.Location = new System.Drawing.Point(16, 188);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 16);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "Username";
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxCity.Location = new System.Drawing.Point(87, 295);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(189, 25);
            this.textBoxCity.TabIndex = 11;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblCity.Location = new System.Drawing.Point(16, 298);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPassword.Location = new System.Drawing.Point(16, 227);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxEmail.Location = new System.Drawing.Point(87, 261);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(189, 25);
            this.textBoxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblEmail.Location = new System.Drawing.Point(16, 264);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostCode.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBoxPostCode.Location = new System.Drawing.Point(87, 334);
            this.textBoxPostCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostCode.Multiline = true;
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(189, 25);
            this.textBoxPostCode.TabIndex = 11;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPostCode.Location = new System.Drawing.Point(16, 337);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(70, 16);
            this.lblPostCode.TabIndex = 16;
            this.lblPostCode.Text = "Post Code";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(287, 442);
            this.Controls.Add(this.pnlInloggning);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.pnlInloggning.ResumeLayout(false);
            this.pnlInloggning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInloggning;
        private System.Windows.Forms.Label lblHaveAnAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxFirstname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxLastname;
    }
}