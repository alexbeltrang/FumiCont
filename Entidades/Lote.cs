using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Lotes")]
    public class Lote
    {
        [PrimaryKey, AutoIncrement, Column("LoteId")]
        public int LoteId { get; set; }
        [MaxLength(150)]
        public string NombreLote { get; set; }
        public bool isDelete { get; set; }
    }
}
