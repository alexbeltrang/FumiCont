using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Cultivos")]
    public class Cultivo
    {
        [PrimaryKey, AutoIncrement, Column("CultivoId")]
        public int CultivoId { get; set; }
        [MaxLength(150)]
        public string NombreCultivo { get; set; }
        public bool isDelete { get; set; }
    }
}
