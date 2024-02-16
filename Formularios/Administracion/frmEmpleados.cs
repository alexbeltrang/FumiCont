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
    public partial class frmEmpleados : Form
    {
        int intEmpleadoId = 0;
        Empleados GestionEmpleados = new Empleados();
        FunctionsEncrip encipta = new FunctionsEncrip();
        clsConnection objConexion = new clsConnection();
        string strConexion = string.Empty;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            strConexion = encipta.Cifrado(2, appsettings["BDSQL"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionEmpleados = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            clsEmpleados clsEmpleados = new clsEmpleados();
            List<Empleados> Empleados = clsEmpleados.getListaEmpleados(strConexion);
            dtgEmpleados.DataSource = Empleados;
        }

        private void limpiaCampos()
        {
            txtNombreEmpleado.Text = string.Empty;
            txtTelefonoCelular.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void dtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clsEmpleados clsEmpleados = new clsEmpleados();
                intEmpleadoId = Convert.ToInt32(dtgEmpleados.Rows[e.RowIndex].Cells["EmpleadoId"].Value.ToString());
                GestionEmpleados = clsEmpleados.getEmpleadosId(intEmpleadoId, strConexion);
                txtNombreEmpleado.Text = GestionEmpleados.NombreEmpleado;
                txtTelefonoCelular.Text = GestionEmpleados.TelefonoCelularEmpleado;

                if (GestionEmpleados.isDeleted)
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
            GestionEmpleados = null;
        }

        private bool validaCampos()
        {
            if (txtNombreEmpleado.Text == string.Empty || txtNombreEmpleado.Text == null)
            {
                txtNombreEmpleado.Focus();
                MessageBox.Show("Ingrese el Nombre del empleado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                clsEmpleados clsEmpleados = new clsEmpleados();
                if (GestionEmpleados != null)
                {
                    GestionEmpleados.NombreEmpleado = txtNombreEmpleado.Text;
                    GestionEmpleados.TelefonoCelularEmpleado = txtTelefonoCelular.Text;
                    if (rbnActivo.Checked)
                    {
                        GestionEmpleados.isDeleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        GestionEmpleados.isDeleted = true;
                    }
                    var res = clsEmpleados.iuEmpleados(GestionEmpleados, strConexion);
                    if (objConexion.IsNumeric(res))
                    {
                        GestionEmpleados = null;
                        MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionEmpleados = null;
                        MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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



                    Empleados empleados = new Empleados();
                    empleados.isDeleted = activo;
                    empleados.EmpleadoId = 0;
                    empleados.NombreEmpleado = txtNombreEmpleado.Text;
                    empleados.TelefonoCelularEmpleado = txtTelefonoCelular.Text;

                    var res = clsEmpleados.iuEmpleados(empleados, strConexion);
                    if (objConexion.IsNumeric(res))
                    {
                        GestionEmpleados = null;
                        MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionEmpleados = null;
                        MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
    }
}
