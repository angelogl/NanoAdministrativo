namespace NanoAdministrativo.Facturacion
{
    partial class frmDepartamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mgDepartamentos = new MetroFramework.Controls.MetroGrid();
            this.depId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbGuardar = new MetroFramework.Controls.MetroButton();
            this.tbId = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.msltfDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.depCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mgDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 406);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(826, 10);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.TabStop = false;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(343, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Código:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(343, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Descripción:";
            // 
            // mgDepartamentos
            // 
            this.mgDepartamentos.AllowUserToAddRows = false;
            this.mgDepartamentos.AllowUserToDeleteRows = false;
            this.mgDepartamentos.AllowUserToResizeRows = false;
            this.mgDepartamentos.AutoGenerateColumns = false;
            this.mgDepartamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depId,
            this.depCodigo,
            this.depDescripcion});
            this.mgDepartamentos.DataSource = this.departamentosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgDepartamentos.EnableHeadersVisualStyles = false;
            this.mgDepartamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDepartamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDepartamentos.Location = new System.Drawing.Point(12, 96);
            this.mgDepartamentos.Name = "mgDepartamentos";
            this.mgDepartamentos.ReadOnly = true;
            this.mgDepartamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDepartamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgDepartamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDepartamentos.Size = new System.Drawing.Size(336, 304);
            this.mgDepartamentos.TabIndex = 1;
            this.mgDepartamentos.SelectionChanged += new System.EventHandler(this.mgDepartamentos_SelectionChanged);
            // 
            // depId
            // 
            this.depId.DataPropertyName = "depId";
            this.depId.HeaderText = "depId";
            this.depId.Name = "depId";
            this.depId.ReadOnly = true;
            this.depId.Visible = false;
            // 
            // mbGuardar
            // 
            this.mbGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbGuardar.Location = new System.Drawing.Point(135, 427);
            this.mbGuardar.Name = "mbGuardar";
            this.mbGuardar.Size = new System.Drawing.Size(97, 37);
            this.mbGuardar.TabIndex = 4;
            this.mbGuardar.Text = "&Guardar";
            this.mbGuardar.UseSelectable = true;
            this.mbGuardar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(509, 112);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 9;
            this.tbId.TabStop = false;
            this.tbId.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Location = new System.Drawing.Point(32, 427);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 37);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "&Nuevo";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(699, 427);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 37);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "&Eliminar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(12, 67);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(51, 23);
            this.metroLink1.TabIndex = 10;
            this.metroLink1.Text = "&Buscar";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(69, 70);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(279, 20);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.ForeColor = System.Drawing.Color.White;
            this.tbCodigo.Location = new System.Drawing.Point(428, 113);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(75, 20);
            this.tbCodigo.TabIndex = 2;
            // 
            // msltfDescripcion
            // 
            this.msltfDescripcion.Depth = 0;
            this.msltfDescripcion.Hint = "";
            this.msltfDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.msltfDescripcion.Location = new System.Drawing.Point(428, 142);
            this.msltfDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfDescripcion.Name = "msltfDescripcion";
            this.msltfDescripcion.PasswordChar = '\0';
            this.msltfDescripcion.SelectedText = "";
            this.msltfDescripcion.SelectionLength = 0;
            this.msltfDescripcion.SelectionStart = 0;
            this.msltfDescripcion.Size = new System.Drawing.Size(387, 23);
            this.msltfDescripcion.TabIndex = 3;
            this.msltfDescripcion.TabStop = false;
            this.msltfDescripcion.UseSystemPasswordChar = false;
            // 
            // depCodigo
            // 
            this.depCodigo.DataPropertyName = "depCodigo";
            this.depCodigo.HeaderText = "Código";
            this.depCodigo.Name = "depCodigo";
            this.depCodigo.ReadOnly = true;
            this.depCodigo.Width = 50;
            // 
            // depDescripcion
            // 
            this.depDescripcion.DataPropertyName = "depDescripcion";
            this.depDescripcion.HeaderText = "Descripción";
            this.depDescripcion.Name = "depDescripcion";
            this.depDescripcion.ReadOnly = true;
            this.depDescripcion.Width = 200;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataSource = typeof(NanoAdministrativo.Model.Departamentos);
            this.departamentosBindingSource.Sort = "";
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 476);
            this.Controls.Add(this.msltfDescripcion);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.mbGuardar);
            this.Controls.Add(this.mgDepartamentos);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Name = "frmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Departamentos";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid mgDepartamentos;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private MetroFramework.Controls.MetroButton mbGuardar;
        private System.Windows.Forms.TextBox tbId;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depId;
        private System.Windows.Forms.DataGridViewTextBoxColumn depCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn depDescripcion;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.TextBox tbCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfDescripcion;
    }
}