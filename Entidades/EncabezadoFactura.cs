using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("EncabezadoFactura")]
    public class EncabezadoFactura
    {
        [PrimaryKey, AutoIncrement, Column("EncabezadoId")]
        public long EncabezadoId { get; set; }
        public DateTime FechaFactura { get; set; }
        [ForeignKey(typeof(CondicionPago))]
        public int CondicionId { get; set; }
        [ForeignKey(typeof(Clientes))]
        public int ClienteId { get; set; }
        public decimal PorcentajeRetefuente { get; set; }
        [MaxLength(500)]
        public string Observaciones { get; set; }
        [MaxLength(50)]
        public string DocSoporteCliente { get; set; }
        public DateTime fechaEntregaCliente { get; set; }
        public bool isDelete { get; set; }

    }
}
