using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.ModelosRespuestas
{
    public class UsuariosMasterEdit
    {
        public long UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public bool isDelete { get; set; }
    }
}
