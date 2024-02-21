using FumiCont.Database;
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
    public partial class frmControlFumigacion : Form
    {
        public frmControlFumigacion()
        {
            InitializeComponent();
        }

        private void ControlFumigacion_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            cargaCombos();
        }

        private void cargaCombos()
        {
            Lote lotes = new Lote();
            lotes.LoteId = 0;
            lotes.NombreLote = "Seleccione...";
            List<Lote> ListLotes = DatabaseHelper.Read<Lote>().Where(x => x.isDelete == false).ToList();
            ListLotes.Add(lotes);
            ListLotes = ListLotes.OrderBy(y => y.LoteId).ToList();

            cboLote.DataSource = ListLotes;
            cboLote.ValueMember = "LoteId";
            cboLote.DisplayMember = "NombreLote";
            cboLote.SelectedIndex = 0;


            Cultivo Cultivos = new Cultivo();
            Cultivos.CultivoId = 0;
            Cultivos.NombreCultivo = "Seleccione...";
            List<Cultivo> ListCultivos = DatabaseHelper.Read<Cultivo>().Where(x => x.isDelete == false).ToList();
            ListCultivos.Add(Cultivos);
            ListCultivos = ListCultivos.OrderBy(y => y.CultivoId).ToList();

            cboCultivo.DataSource = ListCultivos;
            cboCultivo.ValueMember = "CultivoId";
            cboCultivo.DisplayMember = "NombreCultivo";
            cboCultivo.SelectedIndex = 0;


            Empleado Empleados = new Empleado();
            Empleados.EmpleadoId = 0;
            Empleados.NombreEmpleado = "Seleccione...";
            List<Empleado> ListEmpleados = DatabaseHelper.Read<Empleado>().Where(x => x.isDeleted == false).ToList();
            ListEmpleados.Add(Empleados);
            ListEmpleados = ListEmpleados.OrderBy(y => y.EmpleadoId).ToList();

            cboEmpleado.DataSource = ListEmpleados;
            cboEmpleado.ValueMember = "EmpleadoId";
            cboEmpleado.DisplayMember = "NombreEmpleado";
            cboEmpleado.SelectedIndex = 0;

        }

        private void txtTotalCanecas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
