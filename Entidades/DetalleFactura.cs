using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("DetalleFactura")]
    public class DetalleFactura
    {
        [PrimaryKey, AutoIncrement, Column("DetalleId")]
        public long DetalleId { get; set; }
        [ForeignKey(typeof(EncabezadoFactura))]
        public long EncabezadoId { get; set; }
        [ForeignKey(typeof(Productos))]
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorRetefuente { get; set; }
        public decimal ValorTotal { get; set; }
        public bool isDelete { get; set; }
    }
}
