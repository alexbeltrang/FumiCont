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

namespace FumiCont.Formularios.Administracion
{
    public partial class frmUsuarios : Form
    {
        int intUsuarioId = 0;
        Usuario GestionUsuarios = new Usuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);

            GestionUsuarios = null;
            cargaCombos();
            llenaGrilla();
        }

        private void cargaCombos()
        {

            Perfil perfiles = new Perfil();
            perfiles.PerfilId = 0;
            perfiles.NombrePerfil = "Seleccione...";

            List<Perfil> Listperfiles = DatabaseHelper.Read<Perfil>().Where(x => x.isDelete == false).ToList();
            Listperfiles.Add(perfiles);
            Listperfiles = Listperfiles.OrderBy(y => y.PerfilId).ToList();

            cboPerfil.DataSource = Listperfiles;
            cboPerfil.ValueMember = "PerfilId";
            cboPerfil.DisplayMember = "NombrePerfil";
            cboPerfil.SelectedIndex = 0;
        }
        private void llenaGrilla()
        {
            List<Usuario> usuarios = DatabaseHelper.Read<Usuario>().ToList();

            List<UsuariosMasterEdit> usuariosMasterEdit = new List<UsuariosMasterEdit>();
            foreach (var itemUsu in usuarios)
            {
                UsuariosMasterEdit usuariosMaster = new UsuariosMasterEdit();
                usuariosMaster.isDelete = itemUsu.isDelete;
                usuariosMaster.NombreUsuario = itemUsu.Nombres + " " + itemUsu.Apellidos;
                usuariosMaster.EmailUsuario = itemUsu.Email;
                usuariosMaster.UsuarioId = itemUsu.idUser;
                usuariosMasterEdit.Add(usuariosMaster);
            }
            dtgUsuarios.DataSource = usuariosMasterEdit;
        }

        private bool validaCampos()
        {
            if (txtLogin.Text == string.Empty || txtLogin.Text == null)
            {
                txtLogin.Focus();
                MessageBox.Show("Ingrese el login del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtPassword.Text == string.Empty || txtPassword.Text == null)
            {
                txtPassword.Focus();
                MessageBox.Show("Ingrese un password temporal para el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtNombres.Text == string.Empty || txtNombres.Text == null)
            {
                txtNombres.Focus();
                MessageBox.Show("Ingrese el nombre del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtApellidos.Text == string.Empty || txtApellidos.Text == null)
            {
                txtApellidos.Focus();
                MessageBox.Show("Ingrese los apellidos del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtEmail.Text == string.Empty || txtEmail.Text == null)
            {
                txtEmail.Focus();
                MessageBox.Show("Ingrese el email del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cboPerfil.SelectedIndex == 0)
            {
                cboPerfil.Focus();
                MessageBox.Show("Seleccione un perfil válido para el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiaCampos()
        {
            txtApellidos.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLogin.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
            txtNombres.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboPerfil.SelectedIndex = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (GestionUsuarios != null)
                {
                    bool delete = false;
                    if (rbnActivo.Checked)
                    {
                        delete = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        delete = true;
                    }


                    var res = DatabaseHelper.Update<Usuario>(new Usuario
                    {
                        Apellidos = txtApellidos.Text,
                        Email = txtEmail.Text,
                        UserName = FunctionsEncrip.Cifrado(1, txtLogin.Text),
                        Nombres = txtNombres.Text,
                        password = FunctionsEncrip.Cifrado(1, txtPassword.Text),
                        idUser = GestionUsuarios.idUser,
                        PerfilId = Convert.ToInt32(cboPerfil.SelectedValue.ToString()),
                        isDelete = delete,
                        DisplayName = txtNombres.Text + " " + txtApellidos.Text
                    });
                    GestionUsuarios = null;
                    txtLogin.Focus();
                    //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

                    var res = DatabaseHelper.Insert<Usuario>(new Usuario
                    {
                        Apellidos = txtApellidos.Text,
                        Email = txtEmail.Text,
                        UserName = FunctionsEncrip.Cifrado(1, txtLogin.Text),
                        Nombres = txtNombres.Text,
                        password = FunctionsEncrip.Cifrado(1, txtPassword.Text),
                        idUser = intUsuarioId,
                        PerfilId = Convert.ToInt32(cboPerfil.SelectedValue.ToString()),
                        isDelete = activo,
                        DisplayName = txtNombres.Text + " " + txtApellidos.Text
                    });

                    GestionUsuarios = null;
                    txtLogin.Focus();
                    //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GestionUsuarios = DatabaseHelper.Read<Usuario>().Where(x => x.idUser == Convert.ToInt32(dtgUsuarios.Rows[e.RowIndex].Cells["UsuarioId"].Value.ToString())).FirstOrDefault();

                txtApellidos.Text = GestionUsuarios.Apellidos;
                txtEmail.Text = GestionUsuarios.Email;
                txtLogin.Text = FunctionsEncrip.Cifrado(2, GestionUsuarios.UserName);
                txtNombres.Text = GestionUsuarios.Nombres;
                txtPassword.Text = FunctionsEncrip.Cifrado(2, GestionUsuarios.password);
                cboPerfil.SelectedValue = GestionUsuarios.PerfilId;
                if (GestionUsuarios.isDelete)
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
            GestionUsuarios = null;
        }
    }
}
