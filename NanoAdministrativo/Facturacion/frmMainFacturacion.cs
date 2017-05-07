using ModernUISample.metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoAdministrativo.Facturacion
{
    public partial class frmMainFacturacion : MetroFramework.Forms.MetroForm
    {
        bool bLogout;
        public frmMainFacturacion()
        {
            InitializeComponent();
            if (MetroUI.DesignMode == false)
            {
                MetroUI.Style.PropertyChanged += Style_PropertyChanged;
                MetroUI.Style.DarkStyle = true;
            }
        }

        void Style_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "DarkStyle")
            {
                BackColor = MetroUI.Style.BackColor;
                Refresh();
            }
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos frm = new frmDepartamentos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mbMantenimento_Click(object sender, EventArgs e)
        {
        }

        private void mfbMantenimiento_Click(object sender, EventArgs e)
        {
        }

        private void frmMainFacturacion_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void mlLogout_Click(object sender, EventArgs e)
        {
            bLogout = true;
            this.Close();
            frmMain.Instance.Show();
            frmMain.Instance.Activate();
        }

        private void frmMainFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!bLogout)
                Application.Exit();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos frm = new frmDepartamentos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
