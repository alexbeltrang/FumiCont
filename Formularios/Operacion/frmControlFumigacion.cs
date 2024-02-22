using FumiCont.Database;
using FumiCont.Entidades;
using FumiCont.ModelosRespuestas;
using FumiCont.Utilidades;
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
        int intCodigoProducto = 0;
        Int64 intCodigoPadreControl = 0;
        ControlFumigacionDetalle fumigacionDetalle = new ControlFumigacionDetalle();
        public frmControlFumigacion()
        {
            InitializeComponent();
        }

        private void ControlFumigacion_Load(object sender, EventArgs e)
        {
            fumigacionDetalle = null;
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            lblProductoSeleccionado.Text = string.Empty;
            cargaCombos();
            llenaGrilla();
            ocultaPanel(false);
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

            TipoControl TipoControls = new TipoControl();
            TipoControls.TipoControlId = 0;
            TipoControls.NombreTipoControl = "Seleccione...";
            List<TipoControl> ListTipoControls = DatabaseHelper.Read<TipoControl>().Where(x => x.IsDeleted == false).ToList();
            ListTipoControls.Add(TipoControls);
            ListTipoControls = ListTipoControls.OrderBy(y => y.TipoControlId).ToList();

            cboTipoControl.DataSource = ListTipoControls;
            cboTipoControl.ValueMember = "TipoControlId";
            cboTipoControl.DisplayMember = "NombreTipoControl";
            cboTipoControl.SelectedIndex = 0;


            UnidadMedida UnidadMedidas = new UnidadMedida();
            UnidadMedidas.MedidaId = 0;
            UnidadMedidas.NombreMedida = "Seleccione...";
            List<UnidadMedida> ListUnidadMedidas = DatabaseHelper.Read<UnidadMedida>().Where(x => x.IsDeleted == false).ToList();
            ListUnidadMedidas.Add(UnidadMedidas);
            ListUnidadMedidas = ListUnidadMedidas.OrderBy(y => y.MedidaId).ToList();

            cboUnidadMedida.DataSource = ListUnidadMedidas;
            cboUnidadMedida.ValueMember = "MedidaId";
            cboUnidadMedida.DisplayMember = "NombreMedida";
            cboUnidadMedida.SelectedIndex = 0;
        }


        private void llenaGrilla()
        {
            dtgProductos.DataSource = clsConnection.listaProductos.OrderBy(x => x.Descripcion).ToList(); 
        }

        private void llenaGrillaDetalle()
        {
            dtgDetalleControl.DataSource = DatabaseQueryLDB.getDetalleControl(intCodigoPadreControl);
        }


        private void txtTotalCanecas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProductoBusq_TextChanged(object sender, EventArgs e)
        {
            List<Productos> listaFilt = clsConnection.listaProductos.Where(x => x.Descripcion.Contains(txtProductoBusq.Text.ToUpper())).ToList();
            dtgProductos.DataSource = listaFilt.OrderBy(x => x.Descripcion).ToList();
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fumigacionDetalle == null)
            {
                intCodigoProducto = Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());
                lblProductoSeleccionado.Text = dtgProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtProductoBusq.Text = string.Empty;
                txtCantidadProd.Focus();
            }
            else
            {
                fumigacionDetalle.ProductoId = Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());
                lblProductoSeleccionado.Text = dtgProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtProductoBusq.Text = string.Empty;
                txtCantidadProd.Focus();
            }
        }

        private void txtCantidadProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (fumigacionDetalle != null)
            {
                fumigacionDetalle.CantidadProducto = Convert.ToDecimal(txtCantidadProd.Text);
            }
        }

        private void btnRegistraDetalle_Click(object sender, EventArgs e)
        {
            if (validaCamposDetalle())
            {
                if (fumigacionDetalle == null)
                {
                    DatabaseHelper.Insert<ControlFumigacionDetalle>(new ControlFumigacionDetalle
                    {
                        CantidadProducto = Convert.ToDecimal(txtCantidadProd.Text),
                        ControlFumigacionId = intCodigoPadreControl,
                        ProductoId = intCodigoProducto,
                        TipoControlId = Convert.ToInt32(cboTipoControl.SelectedValue.ToString()),
                        MedidaId = Convert.ToInt32(cboUnidadMedida.SelectedValue.ToString())
                    });
                    fumigacionDetalle = null;
                }
                else
                {
                    DatabaseHelper.Update<ControlFumigacionDetalle>(fumigacionDetalle);
                    fumigacionDetalle = null;
                }
                llenaGrillaDetalle();
                limpiaCamposDetalle();
                txtProductoBusq.Focus();
            }
        }

        private bool validaCamposDetalle()
        {
            if (intCodigoProducto == 0)
            {
                txtProductoBusq.Focus();
                MessageBox.Show("Seleccione un producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtCantidadProd.Text == string.Empty || txtCantidadProd.Text == null)
            {
                txtCantidadProd.Focus();
                MessageBox.Show("Ingrese la cantidad de producto que se usó", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cboTipoControl.SelectedIndex == 0)
            {
                cboTipoControl.Focus();
                MessageBox.Show("Selecciones el tipo de Control que se hizo al cultivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRegistrarEncabezado_Click(object sender, EventArgs e)
        {
            if (validaCamposEnzacezado())
            {
                var res = DatabaseHelper.InsertOther<ControlFumigacionEncabezado>(new ControlFumigacionEncabezado
                {
                    CantidadCanecas = Convert.ToInt32(txtTotalCanecas.Text),
                    CultivoId = Convert.ToInt32(cboCultivo.SelectedValue.ToString()),
                    EmpleadoId = Convert.ToInt32(cboEmpleado.SelectedValue.ToString()),
                    FechaControlFumigacion = dtpFechaControl.Value,
                    isDelete = false,
                    LoteId = Convert.ToInt32(cboLote.SelectedValue.ToString())
                });
                if (res != null)
                {
                    ControlFumigacionEncabezado controlFumigacionEncabezado = new ControlFumigacionEncabezado();
                    controlFumigacionEncabezado = (ControlFumigacionEncabezado)res;
                    intCodigoPadreControl = ((ControlFumigacionEncabezado)res).ControlFumigacionId;
                    ocultaPanel(true);
                }
            }
        }

        private bool validaCamposEnzacezado()
        {
            if (cboLote.SelectedIndex == 0)
            {
                cboLote.Focus();
                MessageBox.Show("Seleccione el Lote a controlar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cboCultivo.SelectedIndex == 0)
            {
                cboCultivo.Focus();
                MessageBox.Show("Seleccione el cultivo que tiene sembrado el lote a controlar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cboEmpleado.SelectedIndex == 0)
            {
                cboEmpleado.Focus();
                MessageBox.Show("Seleccione el empleado que va a realizar el control", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtTotalCanecas.Text == string.Empty || txtTotalCanecas.Text == null)
            {
                cboEmpleado.Focus();
                MessageBox.Show("Inrese el total de canecas de 200 litros que se usan en el control", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ocultaPanel(bool estado)
        {
            pnlRegDetalle.Visible = estado;
            panel2.Visible = estado;
            dtgProductos.Visible = estado;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ocultaPanel(false);
            intCodigoPadreControl = 0;
            limpiaCamposEnzabezado();
        }

        private void limpiaCamposDetalle()
        {
            txtProductoBusq.Text = string.Empty;
            lblProductoSeleccionado.Text = string.Empty;
            txtCantidadProd.Text = string.Empty;
            cboTipoControl.SelectedIndex = 0;
            cboUnidadMedida.SelectedIndex = 0;
        }
        private void limpiaCamposEnzabezado()
        {
            cboLote.SelectedIndex = 0;
            cboCultivo.SelectedIndex = 0;
            cboEmpleado.SelectedIndex = 0;
            txtTotalCanecas.Text = string.Empty;
        }

        private void dtgDetalleControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fumigacionDetalle = DatabaseHelper.Read<ControlFumigacionDetalle>().Where(x => x.ControlFumigacionDetId == Convert.ToInt32(dtgDetalleControl.Rows[e.RowIndex].Cells["ControlFumigacionDetId"].Value.ToString())).FirstOrDefault();
            if (fumigacionDetalle != null)
            {
                txtCantidadProd.Text = fumigacionDetalle.CantidadProducto.ToString();
                cboTipoControl.SelectedValue = Convert.ToInt64(fumigacionDetalle.TipoControlId.ToString());
                cboUnidadMedida.SelectedValue = Convert.ToInt32(fumigacionDetalle.MedidaId.ToString());
                Productos producto = DatabaseHelper.Read<Productos>().Where(x => x.ProductoId == fumigacionDetalle.ProductoId).FirstOrDefault();
                lblProductoSeleccionado.Text = producto.Descripcion;
                txtProductoBusq.Focus();
            }
        }

        private void cboTipoControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fumigacionDetalle != null)
            {
                if (cboTipoControl.SelectedValue != null)
                {
                    fumigacionDetalle.TipoControlId = Convert.ToInt32(cboTipoControl.SelectedValue.ToString());
                }
            }
        }

        private void cboUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fumigacionDetalle != null)
            {
                if (cboUnidadMedida.SelectedValue != null)
                {
                    fumigacionDetalle.MedidaId = Convert.ToInt32(cboUnidadMedida.SelectedValue.ToString());
                }
            }
        }
    }
}
