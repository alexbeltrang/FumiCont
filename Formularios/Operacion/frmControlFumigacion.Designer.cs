namespace FumiCont.Formularios.Operacion
{
    partial class frmControlFumigacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarEncabezado = new System.Windows.Forms.Button();
            this.txtTotalCanecas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaControl = new System.Windows.Forms.DateTimePicker();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCultivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegDetalle = new System.Windows.Forms.Panel();
            this.txtProductoBusq = new System.Windows.Forms.TextBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductoSeleccionado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.cboTipoControl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgDetalleControl = new System.Windows.Forms.DataGridView();
            this.btnRegistraDetalle = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRegDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrarEncabezado);
            this.panel1.Controls.Add(this.txtTotalCanecas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFechaControl);
            this.panel1.Controls.Add(this.cboEmpleado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCultivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboLote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 166);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrarEncabezado
            // 
            this.btnRegistrarEncabezado.Location = new System.Drawing.Point(428, 123);
            this.btnRegistrarEncabezado.Name = "btnRegistrarEncabezado";
            this.btnRegistrarEncabezado.Size = new System.Drawing.Size(86, 30);
            this.btnRegistrarEncabezado.TabIndex = 26;
            this.btnRegistrarEncabezado.Text = "&Registrar";
            this.btnRegistrarEncabezado.UseVisualStyleBackColor = true;
            this.btnRegistrarEncabezado.Click += new System.EventHandler(this.btnRegistrarEncabezado_Click);
            // 
            // txtTotalCanecas
            // 
            this.txtTotalCanecas.Location = new System.Drawing.Point(138, 90);
            this.txtTotalCanecas.MaxLength = 2;
            this.txtTotalCanecas.Name = "txtTotalCanecas";
            this.txtTotalCanecas.Size = new System.Drawing.Size(84, 22);
            this.txtTotalCanecas.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total Canecas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha:";
            // 
            // dtpFechaControl
            // 
            this.dtpFechaControl.Location = new System.Drawing.Point(553, 60);
            this.dtpFechaControl.Name = "dtpFechaControl";
            this.dtpFechaControl.Size = new System.Drawing.Size(332, 22);
            this.dtpFechaControl.TabIndex = 22;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(138, 57);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(332, 24);
            this.cboEmpleado.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empleado:";
            // 
            // cboCultivo
            // 
            this.cboCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCultivo.FormattingEnabled = true;
            this.cboCultivo.Location = new System.Drawing.Point(553, 28);
            this.cboCultivo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCultivo.Name = "cboCultivo";
            this.cboCultivo.Size = new System.Drawing.Size(332, 24);
            this.cboCultivo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cultivo:";
            // 
            // cboLote
            // 
            this.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(138, 25);
            this.cboLote.Margin = new System.Windows.Forms.Padding(4);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(332, 24);
            this.cboLote.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lote:";
            // 
            // pnlRegDetalle
            // 
            this.pnlRegDetalle.Controls.Add(this.cboUnidadMedida);
            this.pnlRegDetalle.Controls.Add(this.label9);
            this.pnlRegDetalle.Controls.Add(this.btnFinalizar);
            this.pnlRegDetalle.Controls.Add(this.btnRegistraDetalle);
            this.pnlRegDetalle.Controls.Add(this.cboTipoControl);
            this.pnlRegDetalle.Controls.Add(this.label8);
            this.pnlRegDetalle.Controls.Add(this.txtCantidadProd);
            this.pnlRegDetalle.Controls.Add(this.label7);
            this.pnlRegDetalle.Controls.Add(this.lblProductoSeleccionado);
            this.pnlRegDetalle.Controls.Add(this.label6);
            this.pnlRegDetalle.Controls.Add(this.txtProductoBusq);
            this.pnlRegDetalle.Location = new System.Drawing.Point(13, 185);
            this.pnlRegDetalle.Name = "pnlRegDetalle";
            this.pnlRegDetalle.Size = new System.Drawing.Size(1001, 172);
            this.pnlRegDetalle.TabIndex = 1;
            // 
            // txtProductoBusq
            // 
            this.txtProductoBusq.Location = new System.Drawing.Point(137, 14);
            this.txtProductoBusq.Name = "txtProductoBusq";
            this.txtProductoBusq.Size = new System.Drawing.Size(847, 22);
            this.txtProductoBusq.TabIndex = 0;
            this.txtProductoBusq.TextChanged += new System.EventHandler(this.txtProductoBusq_TextChanged);
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToOrderColumns = true;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProductos.Location = new System.Drawing.Point(1021, 13);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProductos.MultiSelect = false;
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgProductos.RowHeadersVisible = false;
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.ShowEditingIcon = false;
            this.dtgProductos.Size = new System.Drawing.Size(434, 768);
            this.dtgProductos.TabIndex = 57;
            this.dtgProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Productos:";
            // 
            // lblProductoSeleccionado
            // 
            this.lblProductoSeleccionado.AutoSize = true;
            this.lblProductoSeleccionado.Location = new System.Drawing.Point(137, 43);
            this.lblProductoSeleccionado.Name = "lblProductoSeleccionado";
            this.lblProductoSeleccionado.Size = new System.Drawing.Size(148, 16);
            this.lblProductoSeleccionado.TabIndex = 26;
            this.lblProductoSeleccionado.Text = "Producto Seleccionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cantidad:";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(140, 73);
            this.txtCantidadProd.MaxLength = 6;
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(84, 22);
            this.txtCantidadProd.TabIndex = 28;
            this.txtCantidadProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProd_KeyPress);
            // 
            // cboTipoControl
            // 
            this.cboTipoControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoControl.FormattingEnabled = true;
            this.cboTipoControl.Location = new System.Drawing.Point(336, 73);
            this.cboTipoControl.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoControl.Name = "cboTipoControl";
            this.cboTipoControl.Size = new System.Drawing.Size(253, 24);
            this.cboTipoControl.TabIndex = 30;
            this.cboTipoControl.SelectedIndexChanged += new System.EventHandler(this.cboTipoControl_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tipo Control:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgDetalleControl);
            this.panel2.Location = new System.Drawing.Point(13, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 408);
            this.panel2.TabIndex = 58;
            // 
            // dtgDetalleControl
            // 
            this.dtgDetalleControl.AllowUserToAddRows = false;
            this.dtgDetalleControl.AllowUserToDeleteRows = false;
            this.dtgDetalleControl.AllowUserToOrderColumns = true;
            this.dtgDetalleControl.AllowUserToResizeColumns = false;
            this.dtgDetalleControl.AllowUserToResizeRows = false;
            this.dtgDetalleControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDetalleControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDetalleControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDetalleControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetalleControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgDetalleControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetalleControl.DefaultCellStyle = dataGridViewCellStyle17;
            this.dtgDetalleControl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgDetalleControl.Location = new System.Drawing.Point(13, 15);
            this.dtgDetalleControl.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDetalleControl.MultiSelect = false;
            this.dtgDetalleControl.Name = "dtgDetalleControl";
            this.dtgDetalleControl.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetalleControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgDetalleControl.RowHeadersVisible = false;
            this.dtgDetalleControl.RowHeadersWidth = 51;
            this.dtgDetalleControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalleControl.ShowEditingIcon = false;
            this.dtgDetalleControl.Size = new System.Drawing.Size(971, 378);
            this.dtgDetalleControl.TabIndex = 57;
            this.dtgDetalleControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleControl_CellDoubleClick);
            // 
            // btnRegistraDetalle
            // 
            this.btnRegistraDetalle.Location = new System.Drawing.Point(338, 122);
            this.btnRegistraDetalle.Name = "btnRegistraDetalle";
            this.btnRegistraDetalle.Size = new System.Drawing.Size(107, 38);
            this.btnRegistraDetalle.TabIndex = 31;
            this.btnRegistraDetalle.Text = "R&egistrar";
            this.btnRegistraDetalle.UseVisualStyleBackColor = true;
            this.btnRegistraDetalle.Click += new System.EventHandler(this.btnRegistraDetalle_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(452, 122);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(93, 38);
            this.btnFinalizar.TabIndex = 32;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Location = new System.Drawing.Point(725, 73);
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(253, 24);
            this.cboUnidadMedida.TabIndex = 34;
            this.cboUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.cboUnidadMedida_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Unidad Medida:";
            // 
            // frmControlFumigacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.pnlRegDetalle);
            this.Controls.Add(this.panel1);
            this.Name = "frmControlFumigacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Fertilizaciomes y Fumigaciones";
            this.Load += new System.EventHandler(this.ControlFumigacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRegDetalle.ResumeLayout(false);
            this.pnlRegDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarEncabezado;
        private System.Windows.Forms.TextBox txtTotalCanecas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaControl;
        internal System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cboCultivo;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRegDetalle;
        private System.Windows.Forms.TextBox txtProductoBusq;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblProductoSeleccionado;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboTipoControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView dtgDetalleControl;
        private System.Windows.Forms.Button btnRegistraDetalle;
        private System.Windows.Forms.Button btnFinalizar;
        internal System.Windows.Forms.ComboBox cboUnidadMedida;
        private System.Windows.Forms.Label label9;
    }
}