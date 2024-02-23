using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Departamentos")]
    public class Departamentos
    {
        [PrimaryKey, Column("DepartamentoId")]
        [MaxLength(3)]
        public string DepartamentoId { get; set; }
        [MaxLength(150)]
        public string NombreDepartamento { get; set; }
        public bool isDelete { get; set; }
    }
}
