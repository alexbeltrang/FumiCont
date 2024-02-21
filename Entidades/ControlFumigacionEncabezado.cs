using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("ControlFumigacionEncabezados")]
    public class ControlFumigacionEncabezado
    {
        [PrimaryKey, AutoIncrement, Column("ControlFumigacionId")]
        public long ControlFumigacionId { get; set; }
        [ForeignKey(typeof(Lote))]
        public int LoteId { get; set; }
        [ForeignKey(typeof(Cultivo))]
        public int CultivoId { get; set; }
        [ForeignKey(typeof(Empleado))]
        public int EmpleadoId { get; set; }
        public DateTime FechaControlFumigacion { get; set; }
        public int CantidadCanecas { get; set; }
        public bool isDelete { get; set; }
    }
}
