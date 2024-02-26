using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.ModelosRespuestas
{
    public class RespuestaDetalleFactura
    {
        public long DetalleId { get; set; }
        public string NombreCultivo { get; set; }
        public decimal Cantidad { get; set; }
        public string NombreMedida { get; set; }
    }
}
