using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Proveedores")]
    public class Proveedor
    {
        [PrimaryKey, AutoIncrement, Column("ProveedorId")]
        public int ProveedorId { get; set; }
        [MaxLength(100)]
        public string NombreProveedor { get; set; }
        [MaxLength(200)]
        public string DireccionProveedor { get; set; }
        [MaxLength(15)]
        public string TelefonoCelular { get; set; }
        public bool IsDelete { get; set; }
    }
}
