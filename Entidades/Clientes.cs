using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Clientes")]
    public class Clientes
    {
        [PrimaryKey, AutoIncrement, Column("ClienteId")]
        public int ClienteId { get; set; }
        [MaxLength(150)]
        public string NombreCliente { get; set; }
        [MaxLength(250)]
        public string DireccionCliente { get; set; }
        [MaxLength(20)]
        public string TelefonoFijoCliente { get; set; }
        [MaxLength(20)]
        public string TelefonoCelularCliente { get; set; }
        public bool isDelete { get; set; }

        [ForeignKey(typeof(Ciudades))]
        public string CiudadId { get; set; }
    }
}
