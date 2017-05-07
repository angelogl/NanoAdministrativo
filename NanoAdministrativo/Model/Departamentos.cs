using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoAdministrativo.Model
{
    [Table("Departamentos", Schema = "Facturacion")]
    public class Departamentos
    {
        [Key]
        public int depId { get; set; }

        public string depCodigo { get; set; }

        public string depDescripcion { get; set; }
    }
}
