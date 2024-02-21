using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("TipoControles")]
    public class TipoControl
    {
        [PrimaryKey, AutoIncrement, Column("TipoControlId")]
        public long TipoControlId { get; set; }
        [MaxLength(100)]
        public string NombreTipoControl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
