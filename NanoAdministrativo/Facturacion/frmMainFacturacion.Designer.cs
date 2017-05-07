namespace NanoAdministrativo.Facturacion
{
    partial class frmMainFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainFacturacion));
            this.mlLogout = new MetroFramework.Controls.MetroLink();
            this.metroMenuStrip1 = new ModernUISample.metro.MetroMenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlLogout
            // 
            this.mlLogout.Image = ((System.Drawing.Image)(resources.GetObject("mlLogout.Image")));
            this.mlLogout.ImageSize = 32;
            this.mlLogout.Location = new System.Drawing.Point(10, 17);
            this.mlLogout.Name = "mlLogout";
            this.mlLogout.Size = new System.Drawing.Size(35, 36);
            this.mlLogout.TabIndex = 9;
            this.mlLogout.UseSelectable = true;
            this.mlLogout.Click += new System.EventHandler(this.mlLogout_Click);
            // 
            // metroMenuStrip1
            // 
            this.metroMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.metroMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.metroMenuStrip1.Location = new System.Drawing.Point(20, 60);
            this.metroMenuStrip1.Name = "metroMenuStrip1";
            this.metroMenuStrip1.Size = new System.Drawing.Size(650, 28);
            this.metroMenuStrip1.TabIndex = 10;
            this.metroMenuStrip1.Text = "metroMenuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.devoluciónVentasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.devoluciónComprasToolStripMenuItem});
            this.operacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.operacionesToolStripMenuItem.Text = "&Operaciones";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // devoluciónVentasToolStripMenuItem
            // 
            this.devoluciónVentasToolStripMenuItem.Name = "devoluciónVentasToolStripMenuItem";
            this.devoluciónVentasToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.devoluciónVentasToolStripMenuItem.Text = "Devolución Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // devoluciónComprasToolStripMenuItem
            // 
            this.devoluciónComprasToolStripMenuItem.Name = "devoluciónComprasToolStripMenuItem";
            this.devoluciónComprasToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.devoluciónComprasToolStripMenuItem.Text = "Devolución Compras";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.depósitosToolStripMenuItem1});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mantenimientoToolStripMenuItem.Text = "&Mantenimiento";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.departamentosToolStripMenuItem.Text = "&Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // depósitosToolStripMenuItem1
            // 
            this.depósitosToolStripMenuItem1.Name = "depósitosToolStripMenuItem1";
            this.depósitosToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.depósitosToolStripMenuItem1.Text = "D&epósitos";
            // 
            // frmMainFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 447);
            this.Controls.Add(this.mlLogout);
            this.Controls.Add(this.metroMenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMainFacturacion";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "   Módulo de Facturación";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainFacturacion_FormClosed);
            this.Load += new System.EventHandler(this.frmMainFacturacion_Load);
            this.metroMenuStrip1.ResumeLayout(false);
            this.metroMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlLogout;
        private ModernUISample.metro.MetroMenuStrip metroMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluciónVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluciónComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitosToolStripMenuItem1;
    }
}