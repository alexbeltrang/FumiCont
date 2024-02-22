using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.ModelosRespuestas
{
    public class RespuestaDetalleControl
    {
        public long ControlFumigacionDetId { get; set; }
        public string Descripcion {  get; set; }
        public string NombreTipoControl { get; set; }
        public string CantidadProducto { get; set; }
        public string NombreMedida { get; set; }

    }
}
