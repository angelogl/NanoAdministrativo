namespace NanoAdministrativo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.mlLogout = new MetroFramework.Controls.MetroLink();
            this.mlUserInfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(62, 77);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(108, 102);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "&Facturación";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(185, 77);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(108, 102);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(62, 196);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(231, 102);
            this.metroTile4.TabIndex = 2;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(332, 196);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(231, 102);
            this.metroTile6.TabIndex = 6;
            this.metroTile6.Text = "metroTile6";
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(455, 77);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(108, 102);
            this.metroTile7.TabIndex = 5;
            this.metroTile7.Text = "metroTile7";
            this.metroTile7.UseSelectable = true;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(332, 77);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(108, 102);
            this.metroTile8.TabIndex = 4;
            this.metroTile8.Text = "metroTile8";
            this.metroTile8.UseSelectable = true;
            // 
            // mlLogout
            // 
            this.mlLogout.Image = ((System.Drawing.Image)(resources.GetObject("mlLogout.Image")));
            this.mlLogout.ImageSize = 32;
            this.mlLogout.Location = new System.Drawing.Point(10, 17);
            this.mlLogout.Name = "mlLogout";
            this.mlLogout.Size = new System.Drawing.Size(35, 36);
            this.mlLogout.TabIndex = 8;
            this.mlLogout.UseSelectable = true;
            this.mlLogout.Click += new System.EventHandler(this.mlLogout_Click);
            // 
            // mlUserInfo
            // 
            this.mlUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlUserInfo.AutoSize = true;
            this.mlUserInfo.Location = new System.Drawing.Point(552, 34);
            this.mlUserInfo.Name = "mlUserInfo";
            this.mlUserInfo.Size = new System.Drawing.Size(66, 19);
            this.mlUserInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.mlUserInfo.TabIndex = 9;
            this.mlUserInfo.Text = "Usuario: ?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 509);
            this.Controls.Add(this.mlUserInfo);
            this.Controls.Add(this.mlLogout);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "frmMain";
            this.Text = "     Aplicaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroLink mlLogout;
        private MetroFramework.Controls.MetroLabel mlUserInfo;
    }
}