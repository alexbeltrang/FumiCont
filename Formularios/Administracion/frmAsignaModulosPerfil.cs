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
    public partial class frmAsignaModulosPerfil : Form
    {

        public frmAsignaModulosPerfil()
        {
            InitializeComponent();
        }

        private void frmAsignaModulosPerfil_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            cargaCombos();
        }

        private void cargaCombos()
        {

            Perfil perfiles = new Perfil();
            perfiles.PerfilId = 0;
            perfiles.NombrePerfil = "Seleccione...";

            List<Perfil> Listperfiles = DatabaseQueryLDB.getListaPerfilesCombos();
            Listperfiles.Add(perfiles);
            Listperfiles = Listperfiles.OrderBy(y => y.PerfilId).ToList();

            cboPerfiles.DataSource = Listperfiles;
            cboPerfiles.ValueMember = "PerfilId";
            cboPerfiles.DisplayMember = "NombrePerfil";
            cboPerfiles.SelectedIndex = 0;
        }

        private void cboPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenaCheckBox();
        }


        private void llenaCheckBox()
        {
            if (cboPerfiles.SelectedIndex > 0)
            {
                var modulos = DatabaseQueryLDB.getModuloPerfil(Convert.ToInt32(cboPerfiles.SelectedValue.ToString()));
                var modulosLibres = DatabaseQueryLDB.getModuloDisponiblePerfil(Convert.ToInt32(cboPerfiles.SelectedValue.ToString()));
                ((ListBox)chbModulosAsignados).DataSource = modulos;
                ((ListBox)chbModulosAsignados).ValueMember = "ModuloId";
                ((ListBox)chbModulosAsignados).DisplayMember = "Descripcion";


                ((ListBox)chbModulosDisponibles).DataSource = modulosLibres;
                ((ListBox)chbModulosDisponibles).ValueMember = "ModuloId";
                ((ListBox)chbModulosDisponibles).DisplayMember = "Descripcion";

            }
            else
            {

            }
        }
        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            foreach (var item in chbModulosAsignados.CheckedItems)
            {
                PerfilModulo perfilModulo = new PerfilModulo();
                perfilModulo.isDeleted = false;
                perfilModulo.ModuloId = ((Modulo)item).ModuloId;
                perfilModulo.PerfilId = Convert.ToInt32(cboPerfiles.SelectedValue);
                DatabaseQueryLDB.delModuloPerfil(perfilModulo);
            }
            llenaCheckBox();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            foreach (var item in chbModulosDisponibles.CheckedItems)
            {
                DatabaseHelper.Insert<PerfilModulo>(new PerfilModulo
                {
                    isDeleted = false,
                    ModuloId = ((Modulo)item).ModuloId,
                    PerfilId = Convert.ToInt32(cboPerfiles.SelectedValue),
                    PerfilModuloId = 0
                });
            }
            llenaCheckBox();
        }
    }
}
