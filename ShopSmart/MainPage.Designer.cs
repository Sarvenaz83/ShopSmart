namespace ShopSmart
{
    partial class FrmMainPage
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
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.Controls.Add(this.button1);
            this.panelMenuBar.Controls.Add(this.buttonProfile);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(497, 52);
            this.panelMenuBar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ShopSmart.Properties.Resources.shoplist;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(447, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImage = global::ShopSmart.Properties.Resources.profile;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonProfile.Location = new System.Drawing.Point(395, 5);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(47, 44);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.panelMenuBar);
            this.Name = "FrmMainPage";
            this.Text = "MainPage";
            this.panelMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button button1;
    }
}