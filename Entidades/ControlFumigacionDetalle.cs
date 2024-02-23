using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("ControlFumigacionDetalles")]
    public class ControlFumigacionDetalle
    {
        [PrimaryKey, AutoIncrement, Column("ControlFumigacionDetId")]
        public long ControlFumigacionDetId { get; set; }

        [ForeignKey(typeof(ControlFumigacionEncabezado))]
        public long ControlFumigacionId { get; set; }
        public virtual ControlFumigacionEncabezado ControlFumigacionEncabezado { get; set; }

        [ForeignKey(typeof(Productos))]
        public long ProductoId { get; set; }
        public virtual Productos Productos { get; set; }

        public decimal CantidadProducto { get; set; }
        [ForeignKey(typeof(TipoControl))]
        public int TipoControlId { get; set; }

        [ForeignKey(typeof(UnidadMedida))]
        public int MedidaId { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
    }
}
