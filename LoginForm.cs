using FumiCont.Database;
using FumiCont.Entidades;
using FumiCont.Utilidades;
using Microsoft.VisualBasic;
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

namespace FumiCont
{
    public partial class LoginForm : Form
    {
        string strMensaje = string.Empty;
        string strConexion = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creaBaseLocal();
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            strConexion = appsettings["BDSQL"];
            clsConnection.listaProductos = DatabaseHelper.Read<Productos>().Where(x => x.IsDelete == false).ToList();
        }

        private void creaBaseLocal()
        {
            DatabaseHelper.Create<Departamentos>();
            DatabaseHelper.Create<Ciudades>();
            DatabaseHelper.Create<Perfil>();
            DatabaseHelper.Create<CondicionPago>();
            DatabaseHelper.Create<Clientes>();
            DatabaseHelper.Create<TipoControl>();
            DatabaseHelper.Create<Lote>();
            DatabaseHelper.Create<Cultivo>();
            DatabaseHelper.Create<Productos>();
            DatabaseHelper.Create<Proveedor>();
            DatabaseHelper.Create<UnidadMedida>();
            DatabaseHelper.Create<Modulo>();
            DatabaseHelper.Create<PerfilModulo>();
            DatabaseHelper.Create<Usuario>();
            DatabaseHelper.Create<ControlFumigacionEncabezado>();
            DatabaseHelper.Create<ControlFumigacionDetalle>();
            DatabaseHelper.Create<Clientes>();
            DatabaseHelper.Create<EncabezadoFactura>();
            DatabaseHelper.Create<DetalleFactura>();


            var control = DatabaseHelper.Read<TipoControl>().Where(x => x.NombreTipoControl == "Fertilización").FirstOrDefault();

            if (control is null)
            {
                DatabaseHelper.Insert<TipoControl>(new TipoControl
                {
                    NombreTipoControl = "Fertilización",
                    IsDeleted = false
                });
            }
            var controlPlaga = DatabaseHelper.Read<TipoControl>().Where(x => x.NombreTipoControl == "Control Plagas").FirstOrDefault();
            if (controlPlaga is null)
            {
                DatabaseHelper.Insert<TipoControl>(new TipoControl
                {
                    NombreTipoControl = "Control Plagas",
                    IsDeleted = false
                });
            }
            var controlDesintoxicacion = DatabaseHelper.Read<TipoControl>().Where(x => x.NombreTipoControl == "Desintoxicación").FirstOrDefault();
            if (controlDesintoxicacion is null)
            {
                DatabaseHelper.Insert<TipoControl>(new TipoControl
                {
                    NombreTipoControl = "Desintoxicación",
                    IsDeleted = false
                });
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DataTable dttConexion = new DataTable();
                if (chkAyudaEnLinea.Checked)
                {
                    clsConnection.blnAyudaEnlinea = true;
                }
                else
                {
                    clsConnection.blnAyudaEnlinea = false;
                }

                if (chkVentanas.Checked)
                {
                    clsConnection.blnVentanasEnbebidas = true;
                }
                else
                {
                    clsConnection.blnVentanasEnbebidas = false;
                }
                ingresaAplicativo(UsernameTextBox.Text, PasswordTextBox.Text);
            }
        }

        private void ingresaAplicativo(string strUser, string strPassword)
        {
            string usrCif = FunctionsEncrip.Cifrado(1, strUser);
            string pwdCif = FunctionsEncrip.Cifrado(1, strPassword);

            var resp = DatabaseQueryLDB.Login(usrCif, pwdCif);
            if (!resp.esValido)
            {
                MessageBox.Show(resp.respuesta, "Error Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsConnection.idUser = resp.Usuario.idUser;
                clsConnection.intCodigoPerfil = resp.Usuario.PerfilId;
                clsConnection.strNombreUsuario = resp.Usuario.DisplayName;
                clsConnection.strEmailUsuario = resp.Usuario.Email.ToLower();
                this.Visible = false;
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
            }
        }

        private bool validaCampos()
        {
            if (UsernameTextBox.Text == "" | UsernameTextBox.Text == null)
            {
                strMensaje = "Digite el " + UsernameLabel.Text;
                MessageBox.Show(strMensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (PasswordTextBox.Text == "" | PasswordTextBox.Text == null)
            {
                strMensaje = "Digite la " + PasswordLabel.Text;
                MessageBox.Show(strMensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.SelectAll();
            PasswordTextBox.Focus();
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            UsernameTextBox.SelectAll();
            UsernameTextBox.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
