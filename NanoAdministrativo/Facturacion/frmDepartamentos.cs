using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoAdministrativo.Facturacion
{
    public partial class frmDepartamentos : MaterialSkin.Controls.MaterialForm
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            bindData();
            this.Activate();
            tbBuscar.Select();
            //msltfBuscar.Text = this.ActiveControl.Name;
        }

        private void bindData()
        {
            using (Model.db_Entities db = new Model.db_Entities())
            {
                /*var dtContex = db.Departamentos.ToList();
                DataTable dt = ConvertToDataTable(dtContex);
                mgDepartamentos.DataSource = dt;*/
                mgDepartamentos.DataSource = db.Departamentos.OrderBy(c => c.depCodigo).ToList();

            }

            /*var context = new Model.db_Entities();
            BindingSource bi = new BindingSource();
            bi.DataSource = context.Departamentos.ToList();
            mgDepartamentos.DataSource = bi;
            mgDepartamentos.Refresh();*/
            //   this.tbCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", departamentosBindingSource, "depCodigo", true));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (Model.db_Entities db = new Model.db_Entities()) {
                if (String.IsNullOrEmpty(tbId.Text))
                {
                    Model.Departamentos dpto = new Model.Departamentos()
                    {
                        depCodigo = tbCodigo.Text,
                        depDescripcion = msltfDescripcion.Text
                    };
                    db.Departamentos.Add(dpto);
                }
                else
                {
                    Model.Departamentos dpto = new Model.Departamentos()
                    {
                        depId = Int32.Parse(tbId.Text),
                        depCodigo = tbCodigo.Text,
                        depDescripcion = msltfDescripcion.Text
                    };
                    db.Departamentos.Add(dpto);
                    db.Entry(dpto).State = EntityState.Modified;

                }
                db.SaveChanges();
            }
            bindData();
            tbBuscar.Clear();
            tbBuscar.Select();
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                       row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                       table.Rows.Add(row);
                }
            return table;
        }

        private void mgDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in mgDepartamentos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tbId.Text = row.Cells["depId"].Value.ToString();
                tbCodigo.Text = row.Cells["depCodigo"].Value.ToString();
                msltfDescripcion.Text = row.Cells["depDescripcion"].Value.ToString();
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            tbId.Text = null;
            tbCodigo.Clear();
            msltfDescripcion.Clear();
            tbCodigo.Focus();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var strMensaje = String.Format("Confirme que desea eliminar {0}", msltfDescripcion.Text.Trim());
            if (MetroMessageBox.Show(this, strMensaje, "Mensaje de confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (Model.db_Entities db = new Model.db_Entities())
                {
                    int depId = Int32.Parse(tbId.Text);
                    var departamento =  db.Departamentos.Find(depId); //specify the AuthodId
                    db.Departamentos.Remove(departamento); //removes the entity from the Authors Entities/Collections
                    db.SaveChanges();
                }
                bindData();
            };
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            using (Model.db_Entities db = new Model.db_Entities())
            {
                mgDepartamentos.DataSource = db.Departamentos
                    .Where(c => c.depDescripcion.Contains(tbBuscar.Text))
                    .OrderBy(c => c.depCodigo)
                    .ToList();
            }
        }
    }
}
