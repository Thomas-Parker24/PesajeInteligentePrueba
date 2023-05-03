using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Departamento { get; set; }
        [Required]
        public string Pais { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Modificacion { get; set; }
    }
}
