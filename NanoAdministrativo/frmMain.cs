using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoAdministrativo
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        bool bLogout;
        static frmMain _instance;

        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }

        }

        public frmMain(string strUserInfo)
        {
            InitializeComponent();
            mlUserInfo.Text = strUserInfo;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void mlLogout_Click(object sender, EventArgs e)
        {
            bLogout = true;
            this.Close();
            frmLogin.Instance.Show();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!bLogout)
                Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Facturacion.frmMainFacturacion frm = new Facturacion.frmMainFacturacion();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            this.Activate();
        }
    }
}
