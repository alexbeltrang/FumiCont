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
    public partial class frmUnidadMedida : Form
    {
        UnidadMedida GestionUnidadMedida = new UnidadMedida();
        clsConnection objConexion = new clsConnection();
        string strConexion = string.Empty;

        public frmUnidadMedida()
        {
            InitializeComponent();
        }

        private void frmUnidadMedida_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionUnidadMedida = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            dtgUnidadMedida.DataSource = DatabaseQueryLDB.GetListaUnidadMedida(true, false, false); ;
        }

        private void limpiaCampos()
        {
            txtNombreMedida.Text = string.Empty;
            txtNotacion.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;

        }

        private void dtgUnidadMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                GestionUnidadMedida = DatabaseQueryLDB.getUnidadMedidaxId(Convert.ToInt32(dtgUnidadMedida.Rows[e.RowIndex].Cells["MedidaId"].Value.ToString()));
                txtNombreMedida.Text = GestionUnidadMedida.NombreMedida;
                txtNotacion.Text=GestionUnidadMedida.Notacion;
                if (GestionUnidadMedida.IsDeleted)
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
            GestionUnidadMedida = null;
        }

        private bool validaCampos()
        {
            if (txtNombreMedida.Text == string.Empty || txtNombreMedida.Text == null)
            {
                txtNombreMedida.Focus();
                MessageBox.Show("Ingrese el nombre de la unidad de medida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtNotacion.Text == string.Empty || txtNotacion.Text == null)
            {
                txtNotacion.Focus();
                MessageBox.Show("Ingrese la notación de la unidad de medida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                if (GestionUnidadMedida != null)
                {
                    GestionUnidadMedida.Notacion = txtNotacion.Text;
                    GestionUnidadMedida.NombreMedida = txtNombreMedida.Text;
                    if (rbnActivo.Checked)
                    {
                        GestionUnidadMedida.IsDeleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        GestionUnidadMedida.IsDeleted = true;
                    }

                    var res = DatabaseHelper.Update<UnidadMedida>(new UnidadMedida
                    {
                        Notacion = txtNotacion.Text,
                        NombreMedida = txtNombreMedida.Text,
                        IsDeleted = GestionUnidadMedida.IsDeleted,
                        MedidaId = GestionUnidadMedida.MedidaId
                    });


                    if (res)
                    {
                        GestionUnidadMedida = null;
                        txtNombreMedida.Focus();
                        //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionUnidadMedida = null;
                        MessageBox.Show("Error al actualizar registro de unidad de medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

                    var res = DatabaseHelper.Insert<UnidadMedida>(new UnidadMedida
                    {
                        Notacion = txtNotacion.Text,
                        NombreMedida = txtNombreMedida.Text,
                        IsDeleted = activo
                    });


                    if (res)
                    {
                        GestionUnidadMedida = null;
                        txtNombreMedida.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionUnidadMedida = null;
                        MessageBox.Show("Error al crear registro de unidad de medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void txtNombreMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtNotacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }
    }
}
