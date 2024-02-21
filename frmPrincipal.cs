using FumiCont.Database;
using FumiCont.Formularios.Administracion;
using FumiCont.Formularios.Maestras;
using FumiCont.Formularios.Operacion;
using FumiCont.Properties;
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
    public partial class frmPrincipal : Form
    {
        string strConexion = string.Empty;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolFecha.Text = "Fecha y Hora:     " + Strings.Format(DateTime.Now, "G");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            var appsettings = ConfigurationManager.AppSettings;
            this.BackColor = ColorTranslator.FromHtml(appsettings["color"]);
            strConexion = FunctionsEncrip.Cifrado(2, appsettings["NameLDB"]);
            toolBD.Text = "Base de Datos: " + strConexion.Replace("'", "");


            tmrAlertasStock.Interval = Convert.ToInt32(appsettings["intervalAlert"]);
            ToolFecha.Text = "Fecha y Hora:     " + Strings.Format(DateTime.Now, "G");
            ToolUser.Text = "Usuario: " + clsConnection.strNombreUsuario;
            tmrAlertasStock.Start();
            Timer1.Start();
            cargaModuloPadre();
            this.MaximizeBox = true;
        }

        private void cargaModuloPadre()
        {
            var moduloPadre = DatabaseQueryLDB.getModuloPadre(clsConnection.intCodigoPerfil);
            foreach (ToolStripItem toolItem in MenuStrip1.Items)
            {
                foreach (var modulo in moduloPadre)
                {
                    if (toolItem.Name == modulo.NombreMenuApp)
                    {
                        toolItem.Visible = true;
                    }
                }
            }
            foreach (var padre in moduloPadre)
            {
                treeMenu.Nodes.Add(padre.ModuloId.ToString(), padre.Descripcion);
                ImageList myImageList = new ImageList();
                myImageList.Images.Add(Resources.resultset_next);
                myImageList.Images.Add(Resources.basedatos1);
                treeMenu.ImageIndex = 0;
                treeMenu.SelectedImageIndex = 0;
                treeMenu.ImageList = myImageList;
                DataTable dttHijo = new DataTable();
                var moduloHijo = DatabaseQueryLDB.getModuloHijo(clsConnection.intCodigoPerfil, padre.ModuloId);
                foreach (var hijo in moduloHijo)
                {
                    TreeNode[] MyNode;
                    MyNode = treeMenu.Nodes.Find(padre.ModuloId.ToString(), true);
                    TreeNode nodo1 = new TreeNode();
                    nodo1.Text = hijo.Descripcion;
                    nodo1.Name = hijo.ModuloId.ToString();
                    MyNode[0].Nodes.Add(nodo1);
                    treeMenu.ImageIndex = 0;
                    treeMenu.SelectedImageIndex = 0;

                }
                List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
                foreach (ToolStripMenuItem toolItem in MenuStrip1.Items)
                {
                    allItems.Add(toolItem);
                    //add sub items
                    allItems.AddRange(GetItems(toolItem));
                }

                foreach (ToolStripItem toolItem in allItems)
                {
                    foreach (var moduloh in moduloHijo)
                    {
                        if (toolItem.Name == moduloh.NombreMenuApp)
                        {
                            toolItem.Visible = true;
                        }
                    }
                }
            }


        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
            {
                if (dropDownItem.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                        yield return subItem;
                }
                yield return dropDownItem;
            }
        }


        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            treeMenu.Enabled = true;
        }

        private void PerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void cargaFormulario(Form fh)
        {
            pnlFormulario.Controls.Clear();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(fh);
            pnlFormulario.Tag = fh;
            fh.Show();
        }



        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeMenu_DoubleClick(object sender, EventArgs e)
        {
            var menuItem = treeMenu.SelectedNode;
            muestraFormularios(menuItem.Text);
        }


        private void muestraFormularios(string strNombreNodo)
        {
            switch (strNombreNodo)
            {
                case "PRODUCTOS":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmProductos objFormulario = new frmProductos();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmProductos frmProductos = new frmProductos();
                            frmProductos.Show();
                        }
                        break;
                    }
                case "PROVEEDORES":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmProveedores objFormulario = new frmProveedores();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmProveedores FrmProveedores = new frmProveedores();
                            FrmProveedores.Show();
                        }
                        break;
                    }
                case "UNIDAD MEDIDA":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmUnidadMedida objFormulario = new frmUnidadMedida();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmUnidadMedida frmUnidadMedida = new frmUnidadMedida();
                            frmUnidadMedida.Show();
                        }
                        break;
                    }
                case "USUARIOS":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmUsuarios objFormulario = new frmUsuarios();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmUsuarios FrmUsuarios = new frmUsuarios();
                            FrmUsuarios.Show();
                        }
                        break;
                    }
                case "CONTROL FUMIGACION":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmControlFumigacion objFormulario = new frmControlFumigacion();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmControlFumigacion FrmUsuarios = new frmControlFumigacion();
                            FrmUsuarios.Show();
                        }
                        break;
                    }
                case "EMPLEADOS":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmEmpleados objFormulario = new frmEmpleados();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmEmpleados FrmEmpleados = new frmEmpleados();
                            FrmEmpleados.Show();
                        }
                        break;
                    }
                //    case "SALIDAS DE INVENTARIO":
                //        {
                //            if (clsConnection.blnVentanasEnbebidas)
                //            {
                //                frmSalidasInventario objFormulario = new frmSalidasInventario();
                //                cargaFormulario(objFormulario);
                //            }
                //            else
                //            {
                //                frmSalidasInventario FrmEmpleados = new frmSalidasInventario();
                //                FrmEmpleados.Show();
                //            }
                //            break;
                //        }
                case "REGISTRO LOTES":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmRegistroLotes objFormulario = new frmRegistroLotes();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmRegistroLotes frmHabilitaControl = new frmRegistroLotes();
                            frmHabilitaControl.Show();
                        }
                        break;
                    }
                //    case "GENERA TOMA INV FISICO":
                //        {
                //            if (clsConnection.blnVentanasEnbebidas)
                //            {
                //                frmGeneraPlantillaInvFisico objFormulario = new frmGeneraPlantillaInvFisico();
                //                cargaFormulario(objFormulario);
                //            }
                //            else
                //            {
                //                frmGeneraPlantillaInvFisico frmGeneraPlantillaInvFisico = new frmGeneraPlantillaInvFisico();
                //                frmGeneraPlantillaInvFisico.Show();
                //            }
                //            break;
                //        }
                //    case "CARGA INVENTARIO FISICO":
                //        {
                //            if (clsConnection.blnVentanasEnbebidas)
                //            {
                //                frmCargaInventarioFisico objFormulario = new frmCargaInventarioFisico();
                //                cargaFormulario(objFormulario);
                //            }
                //            else
                //            {
                //                frmCargaInventarioFisico frmCargaInventarioFisico = new frmCargaInventarioFisico();
                //                frmCargaInventarioFisico.Show();
                //            }
                //            break;
                //        }
                //    case "CONTROL MES INVENTARIO":
                //        {
                //            if (clsConnection.blnVentanasEnbebidas)
                //            {
                //                frmControlInventario objFormulario = new frmControlInventario();
                //                cargaFormulario(objFormulario);
                //            }
                //            else
                //            {
                //                frmControlInventario frmControlInventario = new frmControlInventario();
                //                frmControlInventario.Show();
                //            }
                //            break;
                //        }
                //    case "CONSULTA CONSUMOS":
                //        {
                //            if (clsConnection.blnVentanasEnbebidas)
                //            {
                //                frmConsultaMovimientoProd objFormulario = new frmConsultaMovimientoProd();
                //                cargaFormulario(objFormulario);
                //            }
                //            else
                //            {
                //                frmConsultaMovimientoProd FrmProveedores = new frmConsultaMovimientoProd();
                //                FrmProveedores.Show();
                //            }
                //            break;
                //        }
                case "ASIGNACION MODULOS PERFIL":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmAsignaModulosPerfil objFormulario = new frmAsignaModulosPerfil();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmAsignaModulosPerfil frmControlInventario = new frmAsignaModulosPerfil();
                            frmControlInventario.Show();
                        }
                        break;
                    }
                case "PERFILES":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmPerfiles objFormulario = new frmPerfiles();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmPerfiles frmPerfiles = new frmPerfiles();
                            frmPerfiles.Show();
                        }
                        break;
                    }
                case "CULTIVOS":
                    {
                        if (clsConnection.blnVentanasEnbebidas)
                        {
                            frmCultivos objFormulario = new frmCultivos();
                            cargaFormulario(objFormulario);
                        }
                        else
                        {
                            frmCultivos frmfrmCultivos = new frmCultivos();
                            frmfrmCultivos.Show();
                        }
                        break;
                    }
                    //    case "REPORTE SIIGO":
                    //        {
                    //            if (clsConnection.blnVentanasEnbebidas)
                    //            {
                    //                frmGeneraInformeSIIGO objFormulario = new frmGeneraInformeSIIGO();
                    //                cargaFormulario(objFormulario);
                    //            }
                    //            else
                    //            {
                    //                frmGeneraInformeSIIGO frmGeneraInformeSIIGO = new frmGeneraInformeSIIGO();
                    //                frmGeneraInformeSIIGO.Show();
                    //            }
                    //            break;
                    //        }
            }
        }

        private void ObjetosSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AsignaPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmUnidadMedida objFormulario = new frmUnidadMedida();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmUnidadMedida objFormulario = new frmUnidadMedida();
            //    objFormulario.Show();
            //}
        }


        private void TipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmProveedores objFormulario = new frmProveedores();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmProveedores objFormulario = new frmProveedores();
                objFormulario.Show();
            }
        }

        private void UnidadesMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmUnidadMedida objFormulario = new frmUnidadMedida();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmUnidadMedida objFormulario = new frmUnidadMedida();
                objFormulario.Show();
            }
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmUsuarios objFormulario = new frmUsuarios();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmUsuarios objFormulario = new frmUsuarios();
                objFormulario.Show();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmEmpleados objFormulario = new frmEmpleados();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmEmpleados objFormulario = new frmEmpleados();
                objFormulario.Show();
            }
        }

        private void salidasDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmSalidasInventario objFormulario = new frmSalidasInventario();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmSalidasInventario objFormulario = new frmSalidasInventario();
            //    objFormulario.Show();
            //}
        }

        private void aperturaDeLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmRegistroLotes objFormulario = new frmRegistroLotes();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmRegistroLotes objFormulario = new frmRegistroLotes();
                objFormulario.Show();
            }
        }

        private void generaArchivoInvFísicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmGeneraPlantillaInvFisico objFormulario = new frmGeneraPlantillaInvFisico();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmGeneraPlantillaInvFisico objFormulario = new frmGeneraPlantillaInvFisico();
            //    objFormulario.Show();
            //}
        }

        private void cargarInventarioFísicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmCargaInventarioFisico objFormulario = new frmCargaInventarioFisico();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmCargaInventarioFisico objFormulario = new frmCargaInventarioFisico();
            //    objFormulario.Show();
            //}
        }

        private void tmrAlertasStock_Tick(object sender, EventArgs e)
        {
            //clsProductos clsProductos = new clsProductos();
            //List<ProductoStockExporta> productosAlertas = clsProductos.getListaAlertasProductos(strConexion);
            //if (MessageBox.Show("Existen productos que llegaron al stock mínimo, desea revisar?", "Límite Stock", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    frmRevisionStockProductos frmRevisionStockProductos = new frmRevisionStockProductos();
            //    frmRevisionStockProductos.listProductos = productosAlertas;
            //    frmRevisionStockProductos.Show();
            //}
        }

        private void consultaConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmConsultaMovimientoProd objFormulario = new frmConsultaMovimientoProd();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmConsultaMovimientoProd objFormulario = new frmConsultaMovimientoProd();
            //    objFormulario.Show();
            //}
        }

        private void controlMesesInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmControlInventario objFormulario = new frmControlInventario();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmControlInventario objFormulario = new frmControlInventario();
            //    objFormulario.Show();
            //}
        }

        private void asignarModulosPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmAsignaModulosPerfil objFormulario = new frmAsignaModulosPerfil();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmAsignaModulosPerfil objFormulario = new frmAsignaModulosPerfil();
                objFormulario.Show();
            }
        }

        private void perfilesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmPerfiles objFormulario = new frmPerfiles();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmPerfiles objFormulario = new frmPerfiles();
                objFormulario.Show();
            }
        }

        private void inventarioInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargaInventarioInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmCargaInvInicial objFormulario = new frmCargaInvInicial();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmCargaInvInicial objFormulario = new frmCargaInvInicial();
            //    objFormulario.Show();
            //}
        }

        private void cargaLotesInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmCargaLoteInicial objFormulario = new frmCargaLoteInicial();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmCargaLoteInicial objFormulario = new frmCargaLoteInicial();
            //    objFormulario.Show();
            //}
        }

        private void reporteSIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (clsConnection.blnVentanasEnbebidas)
            //{
            //    frmGeneraInformeSIIGO objFormulario = new frmGeneraInformeSIIGO();
            //    cargaFormulario(objFormulario);
            //}
            //else
            //{
            //    frmGeneraInformeSIIGO objFormulario = new frmGeneraInformeSIIGO();
            //    objFormulario.Show();
            //}
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmCultivos objFormulario = new frmCultivos();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmCultivos objFormulario = new frmCultivos();
                objFormulario.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmProductos objFormulario = new frmProductos();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmProductos objFormulario = new frmProductos();
                objFormulario.Show();
            }
        }

        private void ControlFumigacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsConnection.blnVentanasEnbebidas)
            {
                frmControlFumigacion objFormulario = new frmControlFumigacion();
                cargaFormulario(objFormulario);
            }
            else
            {
                frmControlFumigacion objFormulario = new frmControlFumigacion();
                objFormulario.Show();
            }
        }
    }
}
