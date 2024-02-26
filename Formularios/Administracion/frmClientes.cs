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

namespace FumiCont.Formularios.Administracion
{
    public partial class frmClientes : Form
    {
        int intClienteId = 0;
        Clientes GestionClientes = new Clientes();
        string strConexion = string.Empty;

        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionClientes = null;
            llenaGrilla();
            cargaCombos();
        }

        private void llenaGrilla()
        {
            List<Clientes> Clientes = DatabaseHelper.Read<Clientes>().ToList();
            dtgClientes.DataSource = Clientes;

        }

        private void cargaCombos()
        {
            Departamentos departamentos = new Departamentos();
            departamentos.DepartamentoId = "0";
            departamentos.NombreDepartamento = "Seleccione...";
            List<Departamentos> ListDepartamento = DatabaseHelper.Read<Departamentos>().Where(x => x.isDelete == false).ToList();
            ListDepartamento.Add(departamentos);
            ListDepartamento = ListDepartamento.OrderBy(y => y.DepartamentoId).ToList();

            cboDepartamento.DataSource = ListDepartamento;
            cboDepartamento.ValueMember = "DepartamentoId";
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.SelectedIndex = 0;
        }

        private void cargaComboCiudad(string idDepto)
        {
            Ciudades ciudades = new Ciudades();
            ciudades.CiudadId = "0";
            ciudades.NombreCiudad = "Seleccione...";
            List<Ciudades> ListCiudades = DatabaseHelper.Read<Ciudades>().Where(x => x.isDelete == false && x.DepartamentoId == idDepto).ToList();
            ListCiudades.Add(ciudades);
            ListCiudades = ListCiudades.OrderBy(y => y.CiudadId).ToList();

            cboCiudad.DataSource = ListCiudades;
            cboCiudad.ValueMember = "CiudadId";
            cboCiudad.DisplayMember = "NombreCiudad";
            cboCiudad.SelectedIndex = 0;

        }
        private void limpiaCampos()
        {
            txtNombreCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtTelefonoCelular.Text = string.Empty;
            txtTelefonoFijo.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
            cboDepartamento.SelectedIndex = 0;
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                intClienteId = Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ClienteId"].Value.ToString());
                GestionClientes = DatabaseHelper.Read<Clientes>().Where(x => x.ClienteId == intClienteId).FirstOrDefault();
                txtNombreCliente.Text = GestionClientes.NombreCliente;
                txtDireccionCliente.Text = GestionClientes.DireccionCliente;
                txtTelefonoCelular.Text = GestionClientes.TelefonoCelularCliente;
                txtTelefonoFijo.Text = GestionClientes.TelefonoFijoCliente;
                var ciudad = DatabaseHelper.Read<Ciudades>().Where(x => x.CiudadId == GestionClientes.CiudadId).FirstOrDefault();
                cboDepartamento.SelectedValue = ciudad.DepartamentoId;
                cboCiudad.SelectedValue = ciudad.CiudadId;

                if (GestionClientes.isDelete)
                {
                    rbnActivo.Checked = false;
                    rbnInactivo.Checked = true;
                }
                else
                {
                    rbnActivo.Checked = true;
                    rbnInactivo.Checked = false;
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaCampos();
            GestionClientes = null;
        }

        private bool validaCampos()
        {
            if (txtNombreCliente.Text == string.Empty || txtNombreCliente.Text == null)
            {
                txtNombreCliente.Focus();
                MessageBox.Show("Ingrese el Nombre del Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtDireccionCliente.Text == string.Empty || txtDireccionCliente.Text == null)
            {
                txtNombreCliente.Focus();
                MessageBox.Show("Ingrese la dirección del Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (GestionClientes != null)
                {
                    GestionClientes.NombreCliente = txtNombreCliente.Text;
                    GestionClientes.TelefonoCelularCliente = txtTelefonoCelular.Text;
                    GestionClientes.DireccionCliente = txtDireccionCliente.Text;
                    GestionClientes.TelefonoFijoCliente = txtTelefonoFijo.Text;
                    GestionClientes.CiudadId = cboCiudad.SelectedValue.ToString();
                    if (rbnActivo.Checked)
                    {
                        GestionClientes.isDelete = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        GestionClientes.isDelete = true;
                    }
                    var res = DatabaseHelper.Update<Clientes>(new Clientes
                    {
                        ClienteId = intClienteId,
                        isDelete = GestionClientes.isDelete,
                        NombreCliente = txtNombreCliente.Text,
                        TelefonoCelularCliente = txtTelefonoCelular.Text,
                        CiudadId = GestionClientes.CiudadId,
                        DireccionCliente = txtDireccionCliente.Text,
                        TelefonoFijoCliente = txtTelefonoFijo.Text
                    });
                    if (res)
                    {
                        GestionClientes = null;
                        txtNombreCliente.Focus();
                        //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionClientes = null;
                        MessageBox.Show("Error al actualizar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    bool activo = false;
                    if (rbnActivo.Checked)
                    {
                        activo = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        activo = true;
                    }

                    var res = DatabaseHelper.Insert<Clientes>(new Clientes
                    {
                        isDelete = activo,
                        NombreCliente = txtNombreCliente.Text,
                        TelefonoCelularCliente = txtTelefonoCelular.Text,
                        CiudadId = cboCiudad.SelectedValue.ToString(),
                        DireccionCliente = txtDireccionCliente.Text,
                        TelefonoFijoCliente = txtTelefonoFijo.Text
                    });


                    if (res)
                    {
                        GestionClientes = null;
                        txtNombreCliente.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionClientes = null;
                        MessageBox.Show("Error al crear Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void txtTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex != -1)
            {
                cargaComboCiudad(cboDepartamento.SelectedValue.ToString());
            }
        }

        private void txtTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
