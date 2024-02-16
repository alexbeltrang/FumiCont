using FumiCont.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.ModelosRespuestas
{
    public class RespuestaUsuarioLogin
    {
        public bool esValido { get; set; }
        public string respuesta { get; set; }
        public Usuario Usuario { get; set; }
    }
}
