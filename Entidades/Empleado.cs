using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Empleado")]
    public class Empleado
    {
        [PrimaryKey, AutoIncrement, Column("EmpleadoId")]
        public int EmpleadoId { get; set; }
        [MaxLength(150)]
        public string NombreEmpleado { get; set; }
        [MaxLength(20)]
        public string TelefonoCelularEmpleado { get; set; }
        public bool isDeleted { get; set; }
    }
}
