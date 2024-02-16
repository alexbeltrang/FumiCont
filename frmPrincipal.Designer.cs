
namespace FumiCont
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdministraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlMesesInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarModulosPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnidadesMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cultivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimeintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntradasAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaArchivoInvFísicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarInventarioFísicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteSIIGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.tmrAlertasStock = new System.Windows.Forms.Timer(this.components);
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperturaDeLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBD,
            this.ToolUser,
            this.ToolFecha});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 650);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1194, 22);
            this.StatusStrip1.TabIndex = 8;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // toolBD
            // 
            this.toolBD.AutoSize = false;
            this.toolBD.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolBD.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolBD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBD.Name = "toolBD";
            this.toolBD.Size = new System.Drawing.Size(300, 17);
            this.toolBD.Text = "Base De Datos:";
            // 
            // ToolUser
            // 
            this.ToolUser.AutoSize = false;
            this.ToolUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ToolUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ToolUser.Name = "ToolUser";
            this.ToolUser.Size = new System.Drawing.Size(300, 17);
            this.ToolUser.Text = "Usuario:";
            // 
            // ToolFecha
            // 
            this.ToolFecha.AutoSize = false;
            this.ToolFecha.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ToolFecha.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.ToolFecha.Name = "ToolFecha";
            this.ToolFecha.Size = new System.Drawing.Size(300, 17);
            this.ToolFecha.Text = "Fecha:";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministraciónToolStripMenuItem1,
            this.MaestrasToolStripMenuItem,
            this.MantenimeintoToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.MenuStrip1.TabIndex = 9;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // AdministraciónToolStripMenuItem1
            // 
            this.AdministraciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.controlMesesInventarioToolStripMenuItem,
            this.asignarModulosPerfilToolStripMenuItem});
            this.AdministraciónToolStripMenuItem1.Name = "AdministraciónToolStripMenuItem1";
            this.AdministraciónToolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.AdministraciónToolStripMenuItem1.Text = "&Administración";
            this.AdministraciónToolStripMenuItem1.Visible = false;
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.UsuariosToolStripMenuItem.Text = "&Usuarios";
            this.UsuariosToolStripMenuItem.Visible = false;
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.perfilesToolStripMenuItem.Text = "&Perfiles";
            this.perfilesToolStripMenuItem.Visible = false;
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click_1);
            // 
            // controlMesesInventarioToolStripMenuItem
            // 
            this.controlMesesInventarioToolStripMenuItem.Name = "controlMesesInventarioToolStripMenuItem";
            this.controlMesesInventarioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.controlMesesInventarioToolStripMenuItem.Text = "&Control Meses Inventario";
            this.controlMesesInventarioToolStripMenuItem.Visible = false;
            this.controlMesesInventarioToolStripMenuItem.Click += new System.EventHandler(this.controlMesesInventarioToolStripMenuItem_Click);
            // 
            // asignarModulosPerfilToolStripMenuItem
            // 
            this.asignarModulosPerfilToolStripMenuItem.Name = "asignarModulosPerfilToolStripMenuItem";
            this.asignarModulosPerfilToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.asignarModulosPerfilToolStripMenuItem.Text = "Asignar Modulos Perfil";
            this.asignarModulosPerfilToolStripMenuItem.Visible = false;
            this.asignarModulosPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignarModulosPerfilToolStripMenuItem_Click);
            // 
            // MaestrasToolStripMenuItem
            // 
            this.MaestrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.ProveedoresToolStripMenuItem,
            this.UnidadesMedidaToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.cultivosToolStripMenuItem,
            this.aperturaDeLotesToolStripMenuItem});
            this.MaestrasToolStripMenuItem.Name = "MaestrasToolStripMenuItem";
            this.MaestrasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.MaestrasToolStripMenuItem.Text = "&Maestras";
            this.MaestrasToolStripMenuItem.Visible = false;
            // 
            // ProveedoresToolStripMenuItem
            // 
            this.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem";
            this.ProveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProveedoresToolStripMenuItem.Text = "P&roveedores";
            this.ProveedoresToolStripMenuItem.Visible = false;
            this.ProveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // UnidadesMedidaToolStripMenuItem
            // 
            this.UnidadesMedidaToolStripMenuItem.Name = "UnidadesMedidaToolStripMenuItem";
            this.UnidadesMedidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UnidadesMedidaToolStripMenuItem.Text = "&Unidades Medida";
            this.UnidadesMedidaToolStripMenuItem.Visible = false;
            this.UnidadesMedidaToolStripMenuItem.Click += new System.EventHandler(this.UnidadesMedidaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "&Empleados";
            this.empleadosToolStripMenuItem.Visible = false;
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // cultivosToolStripMenuItem
            // 
            this.cultivosToolStripMenuItem.Name = "cultivosToolStripMenuItem";
            this.cultivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cultivosToolStripMenuItem.Text = "&Cultivos";
            this.cultivosToolStripMenuItem.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // MantenimeintoToolStripMenuItem
            // 
            this.MantenimeintoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntradasAlmacenToolStripMenuItem,
            this.salidasDeInventarioToolStripMenuItem});
            this.MantenimeintoToolStripMenuItem.Name = "MantenimeintoToolStripMenuItem";
            this.MantenimeintoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.MantenimeintoToolStripMenuItem.Text = "&Operación";
            this.MantenimeintoToolStripMenuItem.Visible = false;
            // 
            // EntradasAlmacenToolStripMenuItem
            // 
            this.EntradasAlmacenToolStripMenuItem.Name = "EntradasAlmacenToolStripMenuItem";
            this.EntradasAlmacenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.EntradasAlmacenToolStripMenuItem.Text = "&Entradas de Almacén";
            this.EntradasAlmacenToolStripMenuItem.Visible = false;
            this.EntradasAlmacenToolStripMenuItem.Click += new System.EventHandler(this.EquivalenciasToolStripMenuItem_Click);
            // 
            // salidasDeInventarioToolStripMenuItem
            // 
            this.salidasDeInventarioToolStripMenuItem.Name = "salidasDeInventarioToolStripMenuItem";
            this.salidasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salidasDeInventarioToolStripMenuItem.Text = "&Salidas de Inventario";
            this.salidasDeInventarioToolStripMenuItem.Visible = false;
            this.salidasDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.salidasDeInventarioToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generaArchivoInvFísicoToolStripMenuItem,
            this.cargarInventarioFísicoToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventariosToolStripMenuItem.Text = "&Inventarios";
            this.inventariosToolStripMenuItem.Visible = false;
            // 
            // generaArchivoInvFísicoToolStripMenuItem
            // 
            this.generaArchivoInvFísicoToolStripMenuItem.Name = "generaArchivoInvFísicoToolStripMenuItem";
            this.generaArchivoInvFísicoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generaArchivoInvFísicoToolStripMenuItem.Text = "&Genera archivo Inv. Físico";
            this.generaArchivoInvFísicoToolStripMenuItem.Visible = false;
            this.generaArchivoInvFísicoToolStripMenuItem.Click += new System.EventHandler(this.generaArchivoInvFísicoToolStripMenuItem_Click);
            // 
            // cargarInventarioFísicoToolStripMenuItem
            // 
            this.cargarInventarioFísicoToolStripMenuItem.Name = "cargarInventarioFísicoToolStripMenuItem";
            this.cargarInventarioFísicoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cargarInventarioFísicoToolStripMenuItem.Text = "&Cargar Inventario Físico";
            this.cargarInventarioFísicoToolStripMenuItem.Visible = false;
            this.cargarInventarioFísicoToolStripMenuItem.Click += new System.EventHandler(this.cargarInventarioFísicoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaConsumoToolStripMenuItem,
            this.reporteSIIGOToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "C&onsultas";
            this.consultasToolStripMenuItem.Visible = false;
            // 
            // consultaConsumoToolStripMenuItem
            // 
            this.consultaConsumoToolStripMenuItem.Name = "consultaConsumoToolStripMenuItem";
            this.consultaConsumoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultaConsumoToolStripMenuItem.Text = "Consulta &Consumo";
            this.consultaConsumoToolStripMenuItem.Visible = false;
            this.consultaConsumoToolStripMenuItem.Click += new System.EventHandler(this.consultaConsumoToolStripMenuItem_Click);
            // 
            // reporteSIIGOToolStripMenuItem
            // 
            this.reporteSIIGOToolStripMenuItem.Name = "reporteSIIGOToolStripMenuItem";
            this.reporteSIIGOToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reporteSIIGOToolStripMenuItem.Text = "&Reporte SIIGO";
            this.reporteSIIGOToolStripMenuItem.Click += new System.EventHandler(this.reporteSIIGOToolStripMenuItem_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeMenu.Location = new System.Drawing.Point(0, 26);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(227, 619);
            this.treeMenu.TabIndex = 10;
            this.treeMenu.DoubleClick += new System.EventHandler(this.treeMenu_DoubleClick);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormulario.Location = new System.Drawing.Point(231, 26);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(962, 617);
            this.pnlFormulario.TabIndex = 11;
            // 
            // tmrAlertasStock
            // 
            this.tmrAlertasStock.Tick += new System.EventHandler(this.tmrAlertasStock_Tick);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "&Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // aperturaDeLotesToolStripMenuItem
            // 
            this.aperturaDeLotesToolStripMenuItem.Name = "aperturaDeLotesToolStripMenuItem";
            this.aperturaDeLotesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aperturaDeLotesToolStripMenuItem.Text = "&Apertura de Lotes";
            this.aperturaDeLotesToolStripMenuItem.Visible = false;
            this.aperturaDeLotesToolStripMenuItem.Click += new System.EventHandler(this.aperturaDeLotesToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 672);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.treeMenu);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1210, 711);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventarios ReactInv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolFecha;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem AdministraciónToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.TreeView treeMenu;
        internal System.Windows.Forms.Panel pnlFormulario;
        internal System.Windows.Forms.ToolStripStatusLabel toolBD;
        internal System.Windows.Forms.ToolStripStatusLabel ToolUser;
        internal System.Windows.Forms.ToolStripMenuItem MaestrasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ProveedoresToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UnidadesMedidaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MantenimeintoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EntradasAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaArchivoInvFísicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarInventarioFísicoToolStripMenuItem;
        private System.Windows.Forms.Timer tmrAlertasStock;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlMesesInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarModulosPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteSIIGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cultivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperturaDeLotesToolStripMenuItem;
    }
}