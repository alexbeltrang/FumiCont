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
    public partial class frmRegistroLotes : Form
    {
        Lote GestionLotes = new Lote();
        public frmRegistroLotes()
        {
            InitializeComponent();
        }

        private void frmLotes_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionLotes = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            List<Lote> Lotes = DatabaseQueryLDB.getListaLotesAll(true, false, false);
            List<Lote> LotesMasterEdit = new List<Lote>();
            foreach (var itemLote in Lotes)
            {
                Lote LotesMaster = new Lote();
                LotesMaster.isDelete = itemLote.isDelete;
                LotesMaster.NombreLote = itemLote.NombreLote;
                LotesMaster.LoteId = itemLote.LoteId;
                LotesMasterEdit.Add(LotesMaster);
            }
            dtgLotes.DataSource = LotesMasterEdit;
        }

        private void limpiaCampos()
        {
            txtNombreLote.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void dtgLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                GestionLotes = DatabaseQueryLDB.getLotexId(Convert.ToInt32(dtgLotes.Rows[e.RowIndex].Cells["LoteId"].Value.ToString()));
                txtNombreLote.Text = GestionLotes.NombreLote;

                if (GestionLotes.isDelete)
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
            GestionLotes = null;
        }

        private bool validaCampos()
        {
            if (txtNombreLote.Text == string.Empty || txtNombreLote.Text == null)
            {
                txtNombreLote.Focus();
                MessageBox.Show("Ingrese el nombre del Lote", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                if (GestionLotes != null)
                {
                    bool deleted = false;
                    GestionLotes.NombreLote = txtNombreLote.Text.ToUpper();
                    if (rbnActivo.Checked)
                    {
                        deleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        deleted = true;
                    }

                    var res = DatabaseHelper.Update<Lote>(new Lote
                    {
                        isDelete = deleted,
                        NombreLote = txtNombreLote.Text.ToUpper(),
                        LoteId = GestionLotes.LoteId

                    });

                    if (res)
                    {
                        GestionLotes = null;
                        txtNombreLote.Focus();
                        // MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionLotes = null;
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
                    var res = DatabaseHelper.Insert(new Lote
                    {
                        isDelete = activo,
                        NombreLote = txtNombreLote.Text,
                        LoteId = 0
                    });

                    if (res)
                    {
                        GestionLotes = null;
                        txtNombreLote.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionLotes = null;
                        MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void txtNombreLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
