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

    public partial class frmCultivos : Form
    {
        Cultivo GestionCultivos = new Cultivo();
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionCultivos = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            List<Cultivo> Cultivos = DatabaseHelper.Read<Cultivo>().ToList();
            List<Cultivo> CultivosMasterEdit = new List<Cultivo>();
            foreach (var itemCultivo in Cultivos)
            {
                Cultivo CultivosMaster = new Cultivo();
                CultivosMaster.isDelete = itemCultivo.isDelete;
                CultivosMaster.NombreCultivo = itemCultivo.NombreCultivo;
                CultivosMaster.CultivoId = itemCultivo.CultivoId;
                CultivosMasterEdit.Add(CultivosMaster);
            }
            dtgCultivos.DataSource = CultivosMasterEdit;
        }

        private void limpiaCampos()
        {
            txtNombreCultivo.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void dtgCultivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                GestionCultivos = DatabaseHelper.Read<Cultivo>().Where(x => x.CultivoId == Convert.ToInt32(dtgCultivos.Rows[e.RowIndex].Cells["CultivoId"].Value.ToString())).FirstOrDefault();
                txtNombreCultivo.Text = GestionCultivos.NombreCultivo;

                if (GestionCultivos.isDelete)
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
            GestionCultivos = null;
        }

        private bool validaCampos()
        {
            if (txtNombreCultivo.Text == string.Empty || txtNombreCultivo.Text == null)
            {
                txtNombreCultivo.Focus();
                MessageBox.Show("Ingrese el nombre del cultivo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                if (GestionCultivos != null)
                {
                    bool deleted = false;
                    GestionCultivos.NombreCultivo = txtNombreCultivo.Text.ToUpper();
                    if (rbnActivo.Checked)
                    {
                        deleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        deleted = true;
                    }

                    var res = DatabaseHelper.Update<Cultivo>(new Cultivo
                    {
                        isDelete = deleted,
                        NombreCultivo = txtNombreCultivo.Text.ToUpper(),
                        CultivoId = GestionCultivos.CultivoId

                    });

                    if (res)
                    {
                        GestionCultivos = null;
                        txtNombreCultivo.Focus();
                        // MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionCultivos = null;
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
                    var res = DatabaseHelper.Insert(new Cultivo
                    {
                        isDelete = activo,
                        NombreCultivo = txtNombreCultivo.Text,
                        CultivoId = 0
                    });

                    if (res)
                    {
                        GestionCultivos = null;
                        txtNombreCultivo.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionCultivos = null;
                        MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }
    }
}
