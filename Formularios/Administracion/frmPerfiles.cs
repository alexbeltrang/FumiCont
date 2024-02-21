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
    public partial class frmPerfiles : Form
    {
        Perfil GestionPerfiles = new Perfil();
        public frmPerfiles()
        {
            InitializeComponent();
        }

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionPerfiles = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            List<Perfil> Perfiles = DatabaseHelper.Read<Perfil>().ToList();
            List<Perfil> PerfilesMasterEdit = new List<Perfil>();
            foreach (var itemMedida in Perfiles)
            {
                Perfil PerfilesMaster = new Perfil();
                PerfilesMaster.isDelete = itemMedida.isDelete;
                PerfilesMaster.NombrePerfil = itemMedida.NombrePerfil;
                PerfilesMaster.PerfilId = itemMedida.PerfilId;
                PerfilesMasterEdit.Add(PerfilesMaster);
            }
            dtgPerfiles.DataSource = PerfilesMasterEdit;
        }

        private void limpiaCampos()
        {
            txtNombrePerfil.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void dtgUnidadMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                GestionPerfiles = DatabaseHelper.Read<Perfil>().Where(x => x.PerfilId == Convert.ToInt32(dtgPerfiles.Rows[e.RowIndex].Cells["PerfilId"].Value.ToString())).FirstOrDefault();


                txtNombrePerfil.Text = GestionPerfiles.NombrePerfil;

                if (GestionPerfiles.isDelete)
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
            GestionPerfiles = null;
        }

        private bool validaCampos()
        {
            if (txtNombrePerfil.Text == string.Empty || txtNombrePerfil.Text == null)
            {
                txtNombrePerfil.Focus();
                MessageBox.Show("Ingrese el nombre de la unidad de medida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                if (GestionPerfiles != null)
                {
                    bool deleted = false;
                    GestionPerfiles.NombrePerfil = txtNombrePerfil.Text.ToUpper();
                    if (rbnActivo.Checked)
                    {
                        deleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        deleted = true;
                    }

                    var res = DatabaseHelper.Update<Perfil>(new Perfil
                    {
                        isDelete = deleted,
                        NombrePerfil = txtNombrePerfil.Text.ToUpper(),
                        PerfilId = GestionPerfiles.PerfilId

                    });

                    if (res)
                    {
                        GestionPerfiles = null;
                        txtNombrePerfil.Focus();
                        //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionPerfiles = null;
                        MessageBox.Show("Error al actualizar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    bool activo = false;
                    bool SeleccionaUsuarios = false;
                    if (rbnActivo.Checked)
                    {
                        activo = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        activo = true;
                    }
                    var res = DatabaseHelper.Insert(new Perfil
                    {
                        isDelete = activo,
                        NombrePerfil = txtNombrePerfil.Text,
                        PerfilId = 0
                    });

                    if (res)
                    {
                        GestionPerfiles = null;
                        txtNombrePerfil.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionPerfiles = null;
                        MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }
    }
}
