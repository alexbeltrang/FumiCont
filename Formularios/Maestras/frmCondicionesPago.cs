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
    public partial class frmCondicionesPago : Form
    {
        CondicionPago GestionCondiciones = new CondicionPago();
        public frmCondicionesPago()
        {
            InitializeComponent();
        }

        private void frmCondicionesPago_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            GestionCondiciones = null;
            llenaGrilla();
        }

        private void llenaGrilla()
        {
            List<CondicionPago> CondicionPagos = DatabaseHelper.Read<CondicionPago>().ToList();
            List<CondicionPago> CondicionPagosMasterEdit = new List<CondicionPago>();
            foreach (var itemCondicionPago in CondicionPagos)
            {
                CondicionPago CondicionPagosMaster = new CondicionPago();
                CondicionPagosMaster.isDelete = itemCondicionPago.isDelete;
                CondicionPagosMaster.NombreCondicion = itemCondicionPago.NombreCondicion;
                CondicionPagosMaster.CondicionId = itemCondicionPago.CondicionId;
                CondicionPagosMaster.DiasPlazoCondicion = itemCondicionPago.DiasPlazoCondicion;
                CondicionPagosMasterEdit.Add(CondicionPagosMaster);
            }
            dtgCondiciones.DataSource = CondicionPagosMasterEdit;
        }

        private void limpiaCampos()
        {
            txtCondicionNombre.Text = string.Empty;
            txtDiasPlazo.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (GestionCondiciones != null)
                {
                    bool deleted = false;
                    GestionCondiciones.NombreCondicion = txtCondicionNombre.Text.ToUpper();
                    GestionCondiciones.DiasPlazoCondicion = Convert.ToInt32(txtDiasPlazo.Text);
                    if (rbnActivo.Checked)
                    {
                        deleted = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        deleted = true;
                    }

                    var res = DatabaseHelper.Update<CondicionPago>(new CondicionPago
                    {
                        isDelete = deleted,
                        NombreCondicion = txtCondicionNombre.Text.ToUpper(),
                        CondicionId = GestionCondiciones.CondicionId,
                        DiasPlazoCondicion = GestionCondiciones.DiasPlazoCondicion
                    });

                    if (res)
                    {
                        GestionCondiciones = null;
                        txtCondicionNombre.Focus();
                        // MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionCondiciones = null;
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
                    var res = DatabaseHelper.Insert(new CondicionPago
                    {
                        isDelete = activo,
                        NombreCondicion = txtCondicionNombre.Text,
                        CondicionId = 0,
                        DiasPlazoCondicion = Convert.ToInt32(txtDiasPlazo.Text),
                    });

                    if (res)
                    {
                        GestionCondiciones = null;
                        txtCondicionNombre.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        GestionCondiciones = null;
                        MessageBox.Show("Error al crear registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }


                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaCampos();
            GestionCondiciones = null;
        }

        private bool validaCampos()
        {
            if (txtCondicionNombre.Text == string.Empty || txtCondicionNombre.Text == null)
            {
                txtCondicionNombre.Focus();
                MessageBox.Show("Ingrese el nombre de la condición de pago", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtDiasPlazo.Text == string.Empty || txtDiasPlazo.Text == null)
            {
                txtCondicionNombre.Focus();
                MessageBox.Show("Ingrese el número de días para la condición de pago", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtCondicionNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtDiasPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgCondiciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GestionCondiciones = DatabaseHelper.Read<CondicionPago>().Where(x => x.CondicionId == Convert.ToInt32(dtgCondiciones.Rows[e.RowIndex].Cells["CondicionId"].Value.ToString())).FirstOrDefault();
                txtCondicionNombre.Text = GestionCondiciones.NombreCondicion;
                txtDiasPlazo.Text = GestionCondiciones.DiasPlazoCondicion.ToString();
                if (GestionCondiciones.isDelete)
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
    }
}
