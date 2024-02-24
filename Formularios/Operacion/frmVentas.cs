using FumiCont.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FumiCont.Formularios.Operacion
{
    public partial class frmVentas : Form
    {
        int intCodigoProducto = 0;
        Int64 intCodigoPadreControl = 0;
        DetalleFactura detalleFactura = new DetalleFactura();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            detalleFactura = null;
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
        }
    }
}
