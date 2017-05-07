using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoAdministrativo.Model
{
    [Table("Usuarios", Schema = "Facturacion")]
    public class Usuarios
    {
        [Key]
        public int usrId { get; set; }

        public string usrUsuario { get; set; }

        public string usrClave { get; set; }
    }
}
