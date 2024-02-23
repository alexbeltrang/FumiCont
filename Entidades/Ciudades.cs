using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Entidades
{
    [Table("Ciudades")]
    public class Ciudades
    {
        [PrimaryKey, Column("CiudadId")]
        [MaxLength(3)]
        public string CiudadId { get; set; }
        [MaxLength(150)]
        public string NombreCiudad { get; set; }
        public bool isDelete { get; set; }
        [ForeignKey(typeof(Departamentos))]
        public string DepartamentoId { get; set; }
    }
}
