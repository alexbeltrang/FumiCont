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

namespace FumiCont.Formularios.Maestras
{
    public partial class frmProveedores : Form
    {
        Proveedor GestionProveedor = new Proveedor();
        clsConnection objConexion = new clsConnection();

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionProveedor = null;
            llenaGrilla();
            txtNombreProveedor.Focus();
        }

        private void llenaGrilla()
        {
            Proveedor clsProveedores = new Proveedor();
            List<Proveedor> proveedores = DatabaseHelper.Read<Proveedor>().ToList();
            dtgProveedores.DataSource = proveedores;
        }

        private void limpiaCampos()
        {
            txtDireccion.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
            txtNombreProveedor.Text = string.Empty;
            txtTelefonoCelular.Text = string.Empty;
        }

        private void dtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GestionProveedor = DatabaseHelper.Read<Proveedor>().Where(x => x.ProveedorId == Convert.ToInt32(dtgProveedores.Rows[e.RowIndex].Cells["ProveedorId"].Value.ToString())).FirstOrDefault();
                txtDireccion.Text = GestionProveedor.DireccionProveedor;
                txtNombreProveedor.Text = GestionProveedor.NombreProveedor;
                txtTelefonoCelular.Text = GestionProveedor.TelefonoCelular;
                if (GestionProveedor.IsDelete)
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
            GestionProveedor = null;
        }

        private bool validaCampos()
        {
            if (txtNombreProveedor.Text == string.Empty || txtNombreProveedor.Text == null)
            {
                txtNombreProveedor.Focus();
                MessageBox.Show("Ingrese el nombre del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtDireccion.Text == string.Empty || txtDireccion.Text == null)
            {
                txtDireccion.Focus();
                MessageBox.Show("Ingrese la Dirección de ubicación del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtTelefonoCelular.Text == string.Empty || txtTelefonoCelular.Text == null)
            {
                txtTelefonoCelular.Focus();
                MessageBox.Show("Ingrese el número telefónico celular del proveedor", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                if (GestionProveedor != null)
                {
                    GestionProveedor.DireccionProveedor = txtDireccion.Text;
                    GestionProveedor.NombreProveedor = txtNombreProveedor.Text;
                    GestionProveedor.TelefonoCelular = txtTelefonoCelular.Text;
                    if (rbnActivo.Checked)
                    {
                        GestionProveedor.IsDelete = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        GestionProveedor.IsDelete = true;
                    }

                    var res = DatabaseHelper.Update<Proveedor>(new Proveedor
                    {
                        DireccionProveedor = txtDireccion.Text,
                        NombreProveedor = txtNombreProveedor.Text,
                        ProveedorId = GestionProveedor.ProveedorId,
                        TelefonoCelular = txtTelefonoCelular.Text,
                        IsDelete = GestionProveedor.IsDelete
                    });
                    if (res)
                    {
                        GestionProveedor = null;
                        txtNombreProveedor.Focus();
                        //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionProveedor = null;
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

                    var res = DatabaseHelper.Insert<Proveedor>(new Proveedor
                    {
                        NombreProveedor = txtNombreProveedor.Text,
                        DireccionProveedor = txtDireccion.Text,
                        IsDelete = activo,
                        TelefonoCelular = txtTelefonoCelular.Text
                    });



                    if (res)
                    {
                        txtNombreProveedor.Focus();
                        GestionProveedor = null;
                        // MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionProveedor = null;
                        MessageBox.Show("Error al crear proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
