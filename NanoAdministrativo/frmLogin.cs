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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        static frmLogin _instance;
        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }

        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
            this.Activate();
            mtbUsuario.Select();
        }

        private void mbIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mtbUsuario.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "por favor, ingrese su usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbUsuario.Focus();
                return;
            }
            try
            {
                using (Model.db_Entities db = new Model.db_Entities())
                {
                    var query = from u in db.Usuarios
                                where u.usrUsuario == mtbUsuario.Text && u.usrClave == mtbClave.Text
                                select u;
                    if (query.SingleOrDefault() != null )
                    {
                        this.Hide();
                        frmMain frm = new frmMain(string.Format("Usuario: {0}",mtbUsuario.Text));
                        frm.ShowDialog();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Usuario o clave incorrectos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
