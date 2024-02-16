using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Productos")]
    public class Productos
    {
        [PrimaryKey, AutoIncrement, Column("ProductoId")]
        public int ProductoId { get; set; }
        [MaxLength(150)]
        public string Descripcion { get; set; }
        [MaxLength(20)]
        public string Referencia { get; set; }
        public bool IsDelete { get; set; }
    }
}
