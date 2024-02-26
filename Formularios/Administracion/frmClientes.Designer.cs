namespace FumiCont.Formularios.Administracion
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totCampos = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCelular = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.pnlDatosCiudad = new System.Windows.Forms.Panel();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.pnlDatosCiudad.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // totCampos
            // 
            this.totCampos.AutoPopDelay = 3000;
            this.totCampos.InitialDelay = 20;
            this.totCampos.IsBalloon = true;
            this.totCampos.ReshowDelay = 100;
            this.totCampos.ShowAlways = true;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(156, 20);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(745, 22);
            this.txtNombreCliente.TabIndex = 1;
            this.totCampos.SetToolTip(this.txtNombreCliente, "Nombre del Empleado");
            // 
            // txtTelefonoCelular
            // 
            this.txtTelefonoCelular.Location = new System.Drawing.Point(156, 80);
            this.txtTelefonoCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCelular.MaxLength = 10;
            this.txtTelefonoCelular.Name = "txtTelefonoCelular";
            this.txtTelefonoCelular.Size = new System.Drawing.Size(276, 22);
            this.txtTelefonoCelular.TabIndex = 2;
            this.totCampos.SetToolTip(this.txtTelefonoCelular, "Número Celular del empleado");
            this.txtTelefonoCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCelular_KeyPress);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(156, 50);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.MaxLength = 50;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(745, 22);
            this.txtDireccionCliente.TabIndex = 69;
            this.totCampos.SetToolTip(this.txtDireccionCliente, "Nombre del Empleado");
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(624, 80);
            this.txtTelefonoFijo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoFijo.MaxLength = 10;
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(276, 22);
            this.txtTelefonoFijo.TabIndex = 71;
            this.totCampos.SetToolTip(this.txtTelefonoFijo, "Número Celular del empleado");
            this.txtTelefonoFijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoFijo_KeyPress);
            // 
            // pnlDatosCiudad
            // 
            this.pnlDatosCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosCiudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatosCiudad.Controls.Add(this.cboCiudad);
            this.pnlDatosCiudad.Controls.Add(this.label7);
            this.pnlDatosCiudad.Controls.Add(this.cboDepartamento);
            this.pnlDatosCiudad.Controls.Add(this.label4);
            this.pnlDatosCiudad.Controls.Add(this.label3);
            this.pnlDatosCiudad.Controls.Add(this.txtTelefonoFijo);
            this.pnlDatosCiudad.Controls.Add(this.txtDireccionCliente);
            this.pnlDatosCiudad.Controls.Add(this.label1);
            this.pnlDatosCiudad.Controls.Add(this.label6);
            this.pnlDatosCiudad.Controls.Add(this.txtNombreCliente);
            this.pnlDatosCiudad.Controls.Add(this.Label5);
            this.pnlDatosCiudad.Controls.Add(this.btnNuevo);
            this.pnlDatosCiudad.Controls.Add(this.btnGrabar);
            this.pnlDatosCiudad.Controls.Add(this.Label2);
            this.pnlDatosCiudad.Controls.Add(this.GroupBox1);
            this.pnlDatosCiudad.Controls.Add(this.txtTelefonoCelular);
            this.pnlDatosCiudad.Location = new System.Drawing.Point(16, 11);
            this.pnlDatosCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatosCiudad.Name = "pnlDatosCiudad";
            this.pnlDatosCiudad.Size = new System.Drawing.Size(1033, 213);
            this.pnlDatosCiudad.TabIndex = 62;
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(568, 110);
            this.cboCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(332, 24);
            this.cboCiudad.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Ciudad:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(156, 110);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(283, 24);
            this.cboDepartamento.TabIndex = 74;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Teléfono Fijo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Dirección Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Teléfono Celular:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(46, 25);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 16);
            this.Label5.TabIndex = 64;
            this.Label5.Text = "Nombre Cliente:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(490, 161);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(382, 161);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(95, 150);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 16);
            this.Label2.TabIndex = 57;
            this.Label2.Text = "Estado:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbnInactivo);
            this.GroupBox1.Controls.Add(this.rbnActivo);
            this.GroupBox1.Location = new System.Drawing.Point(156, 138);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(181, 39);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.Location = new System.Drawing.Point(91, 12);
            this.rbnInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(74, 20);
            this.rbnInactivo.TabIndex = 5;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "&Inactivo";
            this.rbnInactivo.UseVisualStyleBackColor = true;
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.Location = new System.Drawing.Point(9, 12);
            this.rbnActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(65, 20);
            this.rbnActivo.TabIndex = 4;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "&Activo";
            this.rbnActivo.UseVisualStyleBackColor = true;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToOrderColumns = true;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgClientes.Location = new System.Drawing.Point(16, 232);
            this.dtgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgClientes.MultiSelect = false;
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.ShowEditingIcon = false;
            this.dtgClientes.Size = new System.Drawing.Size(1035, 436);
            this.dtgClientes.TabIndex = 61;
            this.dtgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellDoubleClick);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 678);
            this.Controls.Add(this.pnlDatosCiudad);
            this.Controls.Add(this.dtgClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Maestro Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlDatosCiudad.ResumeLayout(false);
            this.pnlDatosCiudad.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ToolTip totCampos;
        internal System.Windows.Forms.Panel pnlDatosCiudad;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNombreCliente;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbnInactivo;
        internal System.Windows.Forms.RadioButton rbnActivo;
        internal System.Windows.Forms.TextBox txtTelefonoCelular;
        internal System.Windows.Forms.DataGridView dtgClientes;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtTelefonoFijo;
        internal System.Windows.Forms.TextBox txtDireccionCliente;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label4;
    }
}