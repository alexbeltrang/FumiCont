using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("UnidadMedida")]
    public class UnidadMedida
    {
        [PrimaryKey, AutoIncrement, Column("MedidaId")]
        public int MedidaId { get; set; }
        [MaxLength(60)]
        public string NombreMedida { get; set; }
        [MaxLength(6)]
        public string Notacion { get; set; }
        public bool IsDeleted { get; set; }
    }
}
