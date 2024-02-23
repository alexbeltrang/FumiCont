using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("CondicionesPago")]
    public class CondicionPago
    {
        [PrimaryKey, AutoIncrement, Column("CondicionId")]
        public long CondicionId { get; set; }
        [MaxLength(100)]
        public string NombreCondicion { get; set; }
        public int DiasPlazoCondicion { get; set; }
        public bool isDelete { get; set; }
    }
}
