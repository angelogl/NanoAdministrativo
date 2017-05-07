namespace NanoAdministrativo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mbIngresar = new MetroFramework.Controls.MetroButton();
            this.mtbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbClave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbIngresar
            // 
            this.mbIngresar.Location = new System.Drawing.Point(416, 163);
            this.mbIngresar.Name = "mbIngresar";
            this.mbIngresar.Size = new System.Drawing.Size(75, 23);
            this.mbIngresar.TabIndex = 2;
            this.mbIngresar.Text = "Ingresar";
            this.mbIngresar.UseSelectable = true;
            this.mbIngresar.Click += new System.EventHandler(this.mbIngresar_Click);
            // 
            // mtbUsuario
            // 
            // 
            // 
            // 
            this.mtbUsuario.CustomButton.Image = null;
            this.mtbUsuario.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.mtbUsuario.CustomButton.Name = "";
            this.mtbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUsuario.CustomButton.TabIndex = 1;
            this.mtbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbUsuario.CustomButton.UseSelectable = true;
            this.mtbUsuario.CustomButton.Visible = false;
            this.mtbUsuario.Lines = new string[0];
            this.mtbUsuario.Location = new System.Drawing.Point(165, 99);
            this.mtbUsuario.MaxLength = 32767;
            this.mtbUsuario.Name = "mtbUsuario";
            this.mtbUsuario.PasswordChar = '\0';
            this.mtbUsuario.PromptText = "Usuario";
            this.mtbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUsuario.SelectedText = "";
            this.mtbUsuario.SelectionLength = 0;
            this.mtbUsuario.SelectionStart = 0;
            this.mtbUsuario.ShortcutsEnabled = true;
            this.mtbUsuario.ShowClearButton = true;
            this.mtbUsuario.Size = new System.Drawing.Size(326, 23);
            this.mtbUsuario.TabIndex = 0;
            this.mtbUsuario.UseSelectable = true;
            this.mtbUsuario.WaterMark = "Usuario";
            this.mtbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbUsuario.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mtbClave
            // 
            // 
            // 
            // 
            this.mtbClave.CustomButton.Image = null;
            this.mtbClave.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.mtbClave.CustomButton.Name = "";
            this.mtbClave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbClave.CustomButton.TabIndex = 1;
            this.mtbClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbClave.CustomButton.UseSelectable = true;
            this.mtbClave.CustomButton.Visible = false;
            this.mtbClave.Lines = new string[0];
            this.mtbClave.Location = new System.Drawing.Point(165, 134);
            this.mtbClave.MaxLength = 32767;
            this.mtbClave.Name = "mtbClave";
            this.mtbClave.PasswordChar = '*';
            this.mtbClave.PromptText = "Clave";
            this.mtbClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbClave.SelectedText = "";
            this.mtbClave.SelectionLength = 0;
            this.mtbClave.SelectionStart = 0;
            this.mtbClave.ShortcutsEnabled = true;
            this.mtbClave.Size = new System.Drawing.Size(326, 23);
            this.mtbClave.TabIndex = 1;
            this.mtbClave.UseSelectable = true;
            this.mtbClave.WaterMark = "Clave";
            this.mtbClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(165, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(270, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Bienvenido, por favor ingrese usuario y clave";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.mbIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 225);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtbClave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtbUsuario);
            this.Controls.Add(this.mbIngresar);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbIngresar;
        private MetroFramework.Controls.MetroTextBox mtbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtbClave;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

