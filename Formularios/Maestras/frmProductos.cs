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
    public partial class frmProductos : Form
    {
        int intCodigoProductoId = 0;
        Productos Gestionproducto = new Productos();
        clsConnection objConexion = new clsConnection();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            totCampos.Active = clsConnection.blnAyudaEnlinea;
            Gestionproducto = null;
            cargaCombos();
            llenaGrilla();
            txtCodigoProducto.Focus();
        }

        private void cargaCombos()
        {

            //clsCategoriaProductos clsCategoriaProductos = new clsCategoriaProductos();
            //CategoriaProductos categoriaProductos = new CategoriaProductos();
            //categoriaProductos.CategoriaId = 0;
            //categoriaProductos.CategoriaNombre = "Seleccione...";

            //List<CategoriaProductos> categorias = clsCategoriaProductos.getCategoriaCombos(strConexion);
            //categorias.Add(categoriaProductos);

            //categorias = categorias.OrderBy(y => y.CategoriaId).ToList();

            //cboCategoria.DataSource = categorias;
            //cboCategoria.ValueMember = "CategoriaId";
            //cboCategoria.DisplayMember = "CategoriaNombre";
            //cboCategoria.SelectedIndex = 0;



            //clsLineaInventarios clsLineaInventarios = new clsLineaInventarios();
            //LineaInventario lineaInventario = new LineaInventario();
            //lineaInventario.LineaInventarioId = 0;
            //lineaInventario.LineaInventarioNombre = "Seleccione...";

            //List<LineaInventario> inventarios = clsLineaInventarios.getLineaInventariosCombos(strConexion);
            //inventarios.Add(lineaInventario);

            //inventarios = inventarios.OrderBy(y => y.LineaInventarioId).ToList();

            //cboLineaInventario.DataSource = inventarios;
            //cboLineaInventario.ValueMember = "LineaInventarioId";
            //cboLineaInventario.DisplayMember = "LineaInventarioNombre";
            //cboLineaInventario.SelectedIndex = 0;



        }


        private void llenaGrilla()
        {
            var productos = DatabaseQueryLDB.GetListaProductos(true, false, false);
            dtgProductos.DataSource = productos;
        }

        private bool validaCampos()
        {
            if (txtCodigoProducto.Text == string.Empty || txtCodigoProducto.Text == null)
            {
                txtCodigoProducto.Focus();
                MessageBox.Show("Ingrese el código del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtNombreProducto.Text == string.Empty || txtNombreProducto.Text == null)
            {
                txtNombreProducto.Focus();
                MessageBox.Show("Ingrese el nombre del producto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiaCampos()
        {
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            rbnActivo.Checked = false;
            rbnInactivo.Checked = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                Productos clsProductos = new Productos();
                bool delete = false;
                if (Gestionproducto != null)
                {

                    Gestionproducto.Referencia = txtCodigoProducto.Text;
                    if (rbnActivo.Checked)
                    {
                        delete = false;
                    }
                    else if (rbnInactivo.Checked)
                    {
                        delete = true;
                    }


                    var res = DatabaseHelper.Update<Productos>(new Productos
                    {
                        Descripcion = txtNombreProducto.Text,
                        ProductoId = Gestionproducto.ProductoId,
                        Referencia = txtCodigoProducto.Text,
                        IsDelete = delete,
                    });


                    if (res)
                    {
                        Gestionproducto = null;
                        txtCodigoProducto.Focus();
                        //MessageBox.Show("Registro Actualizado exitosamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        Gestionproducto = null;
                        MessageBox.Show("Error al actualizar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

                    var res = DatabaseHelper.Insert<Productos>(new Productos
                    {
                        Descripcion = txtNombreProducto.Text,
                        Referencia = txtCodigoProducto.Text,
                        IsDelete = activo,
                    });
                    if (res)
                    {
                        Gestionproducto = null;
                        txtCodigoProducto.Focus();
                        //MessageBox.Show("Registro creado exitosamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        Gestionproducto = null;
                        MessageBox.Show("Error al crear producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                limpiaCampos();
                llenaGrilla();
            }
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Gestionproducto = DatabaseQueryLDB.getProductoxId(Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString()));

                txtNombreProducto.Text = Gestionproducto.Descripcion;
                txtCodigoProducto.Text = Gestionproducto.Referencia;
                if (Gestionproducto.IsDelete)
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
            Gestionproducto = null;
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
