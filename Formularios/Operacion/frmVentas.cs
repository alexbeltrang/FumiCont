using FumiCont.Database;
using FumiCont.Entidades;
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
    public partial class frmVentas : Form
    {
        int intCodigoProducto = 0;
        int intCodigoCliente = 0;
        Int64 intCodigoPadreEncabezado = 0;
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
            lblProductoSeleccionado.Text = string.Empty;
            cargaCombos();
            llenaGrilla();
            ocultaPanel(false);
        }

        private void llenaGrilla()
        {
            dtgProductos.DataSource = clsConnection.listaCultivos.OrderBy(x => x.NombreCultivo).ToList();
        }
        private void cargaCombos()
        {
            CondicionPago condicionPago = new CondicionPago();
            condicionPago.CondicionId = 0;
            condicionPago.NombreCondicion = "Seleccione...";
            List<CondicionPago> ListcondicionPagos = DatabaseHelper.Read<CondicionPago>().Where(x => x.isDelete == false).ToList();
            ListcondicionPagos.Add(condicionPago);
            ListcondicionPagos = ListcondicionPagos.OrderBy(y => y.CondicionId).ToList();
            cboCondicionPago.DataSource = ListcondicionPagos;
            cboCondicionPago.ValueMember = "CondicionId";
            cboCondicionPago.DisplayMember = "NombreCondicion";
            cboCondicionPago.SelectedIndex = 0;

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

        private void txtClienteBusq_TextChanged(object sender, EventArgs e)
        {
            List<Clientes> listaFilt = clsConnection.listaClientes.Where(x => x.NombreCliente.ToUpper().Contains(txtClienteBusq.Text.ToUpper())).ToList();
            dtgClientes.DataSource = listaFilt.OrderBy(x => x.NombreCliente).ToList();
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClienteBusq.Text = string.Empty;
            intCodigoCliente = Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ClienteId"].Value.ToString());
            lblClienteSeleccionado.Text = dtgClientes.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
            txtRetefuente.Focus();
        }

        private void btnRegistrarEncabezado_Click(object sender, EventArgs e)
        {
            if (validaCamposEnzacezado())
            {
                var res = DatabaseHelper.InsertOther<EncabezadoFactura>(new EncabezadoFactura
                {
                    ClienteId = intCodigoCliente,
                    CondicionId = Convert.ToInt32(cboCondicionPago.SelectedValue.ToString()),
                    FechaFactura = dtpFechaControl.Value,
                    Observaciones = txtObservaciones.Text,
                    PorcentajeRetefuente = Convert.ToDecimal(txtRetefuente.Text)
                });
                if (res != null)
                {
                    EncabezadoFactura encabezadoFactura = new EncabezadoFactura();
                    encabezadoFactura = (EncabezadoFactura)res;
                    intCodigoPadreEncabezado = ((EncabezadoFactura)res).EncabezadoId;
                    ocultaPanel(true);
                }
            }
        }

        private bool validaCamposEnzacezado()
        {
            if (cboCondicionPago.SelectedIndex == 0)
            {
                cboCondicionPago.Focus();
                MessageBox.Show("Seleccione la condición de pago para la venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (intCodigoCliente == 0)
            {
                txtClienteBusq.Focus();
                MessageBox.Show("Seleccione el cliente ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtRetefuente.Text == string.Empty || txtRetefuente.Text == null)
            {
                txtRetefuente.Focus();
                MessageBox.Show("Ingrese el porcentaje de retención en la fuente que le aplicarán a la venta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void txtProductoBusq_TextChanged(object sender, EventArgs e)
        {
            List<Cultivo> listaFilt = clsConnection.listaCultivos.Where(x => x.NombreCultivo.ToUpper().Contains(txtProductoBusq.Text.ToUpper())).ToList();
            dtgProductos.DataSource = listaFilt.OrderBy(x => x.NombreCultivo).ToList();
        }

        private void dtgDetalleControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detalleFactura = DatabaseHelper.Read<DetalleFactura>().Where(x => x.DetalleId == Convert.ToInt32(dtgDetalleControl.Rows[e.RowIndex].Cells["DetalleId"].Value.ToString())).FirstOrDefault();
            if (detalleFactura != null)
            {
                txtCantidadProd.Text = detalleFactura.Cantidad.ToString();
                cboUnidadMedida.SelectedValue = Convert.ToInt32(detalleFactura.MedidaId.ToString());
                Cultivo producto = DatabaseHelper.Read<Cultivo>().Where(x => x.CultivoId == detalleFactura.CultivoId).FirstOrDefault();
                lblProductoSeleccionado.Text = producto.NombreCultivo;
                txtValorUnitario.Text = detalleFactura.ValorUnitario.ToString();
                txtIva.Text = detalleFactura.PorcIva.ToString();
                txtProductoBusq.Focus();
            }
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (detalleFactura == null)
            {
                intCodigoProducto = Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["CultivoId"].Value.ToString());
                lblProductoSeleccionado.Text = dtgProductos.Rows[e.RowIndex].Cells["NombreCultivo"].Value.ToString();
                txtProductoBusq.Text = string.Empty;
                txtCantidadProd.Focus();
            }
            else
            {
                detalleFactura.CultivoId = Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["CultivoId"].Value.ToString());
                lblProductoSeleccionado.Text = dtgProductos.Rows[e.RowIndex].Cells["NombreCultivo"].Value.ToString();
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
            if (detalleFactura != null)
            {
                detalleFactura.Cantidad = Convert.ToDecimal(txtCantidadProd.Text);
            }
        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (detalleFactura != null)
            {
                detalleFactura.ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text);
            }
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (detalleFactura != null)
            {
                detalleFactura.PorcIva = Convert.ToDecimal(txtIva.Text);
            }
        }

        private void btnRegistraDetalle_Click(object sender, EventArgs e)
        {
            grabaDetalle();
        }


        private bool grabaDetalle()
        {
            decimal valorBruto = Convert.ToDecimal(txtValorUnitario.Text) * Convert.ToDecimal(txtCantidadProd.Text);
            decimal valorRetefuente = txtRetefuente.Text == "0" ? 0 : ((valorBruto * Convert.ToDecimal(txtRetefuente.Text)) / 100);
            decimal valorIva = txtIva.Text == string.Empty || txtIva.Text == "0" || txtIva.Text == null ? 0 : (valorBruto * (1 + (Convert.ToDecimal(txtIva.Text) / 100)));
            if (validaCamposDetalle())
            {
                try
                {
                    if (detalleFactura == null)
                    {
                        DatabaseHelper.Insert<DetalleFactura>(new DetalleFactura
                        {
                            Cantidad = Convert.ToDecimal(txtCantidadProd.Text),
                            CultivoId = intCodigoProducto,
                            EncabezadoId = intCodigoPadreEncabezado,
                            isDelete = false,
                            MedidaId = Convert.ToInt32(cboUnidadMedida.SelectedValue.ToString()),
                            ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text),
                            PorcIva = txtIva.Text == string.Empty ? 0 : Convert.ToDecimal(txtIva.Text),
                            ValorBruto = valorBruto,
                            ValorRetefuente = valorRetefuente,
                            ValorTotal = valorBruto + valorRetefuente + valorIva
                        });
                        detalleFactura = null;
                    }
                    else
                    {
                        DatabaseHelper.Update<DetalleFactura>(detalleFactura);
                        detalleFactura = null;
                    }
                    llenaGrillaDetalle();
                    limpiaCamposDetalle();
                    txtProductoBusq.Focus();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool validaCamposDetalle()
        {
            if (intCodigoProducto == 0 &&
               (txtCantidadProd.Text == string.Empty || txtCantidadProd.Text == null) &&
               cboUnidadMedida.SelectedIndex == 0 &&
               (txtValorUnitario.Text == string.Empty || txtValorUnitario.Text == null) &&
               (txtIva.Text == string.Empty || txtIva.Text == null)) { return true; }
            else if (intCodigoProducto == 0)
            {
                txtProductoBusq.Focus();
                MessageBox.Show("Seleccione un producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtCantidadProd.Text == string.Empty || txtCantidadProd.Text == null)
            {
                txtCantidadProd.Focus();
                MessageBox.Show("Ingrese la cantidad de producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cboUnidadMedida.SelectedIndex == 0)
            {
                cboUnidadMedida.Focus();
                MessageBox.Show("Selecciones la unidad de medida para el producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtValorUnitario.Text == string.Empty || txtValorUnitario.Text == null)
            {
                txtCantidadProd.Focus();
                MessageBox.Show("Ingresevalor unitario del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cboUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detalleFactura != null)
            {
                if (cboUnidadMedida.SelectedValue != null)
                {
                    detalleFactura.MedidaId = Convert.ToInt32(cboUnidadMedida.SelectedValue.ToString());
                }
            }
        }


        private void llenaGrillaDetalle()
        {
            dtgDetalleControl.DataSource = DatabaseQueryLDB.getDetalleVenta(intCodigoPadreEncabezado);
        }
        private void limpiaCamposDetalle()
        {
            intCodigoProducto = 0;
            txtProductoBusq.Text = string.Empty;
            lblProductoSeleccionado.Text = string.Empty;
            txtCantidadProd.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            txtIva.Text = string.Empty;
            cboUnidadMedida.SelectedIndex = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (grabaDetalle())
            {
                ocultaPanel(false);
                intCodigoPadreEncabezado = 0;
                limpiaCamposEnzabezado();
                dtgProductos.DataSource = null;
            }

        }

        private void limpiaCamposEnzabezado()
        {
            cboCondicionPago.SelectedIndex = 0;
            txtClienteBusq.Text = string.Empty;
            txtRetefuente.Text = string.Empty;
            lblClienteSeleccionado.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }
    }
}
