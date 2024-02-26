namespace FumiCont.Formularios.Maestras
{
    partial class frmCondicionesPago
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
            this.pnlDatosCiudad = new System.Windows.Forms.Panel();
            this.txtCondicionNombre = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.dtgCondiciones = new System.Windows.Forms.DataGridView();
            this.totCampos = new System.Windows.Forms.ToolTip(this.components);
            this.txtDiasPlazo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatosCiudad.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosCiudad
            // 
            this.pnlDatosCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosCiudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDatosCiudad.Controls.Add(this.txtDiasPlazo);
            this.pnlDatosCiudad.Controls.Add(this.label1);
            this.pnlDatosCiudad.Controls.Add(this.txtCondicionNombre);
            this.pnlDatosCiudad.Controls.Add(this.Label5);
            this.pnlDatosCiudad.Controls.Add(this.btnNuevo);
            this.pnlDatosCiudad.Controls.Add(this.btnGrabar);
            this.pnlDatosCiudad.Controls.Add(this.Label2);
            this.pnlDatosCiudad.Controls.Add(this.GroupBox1);
            this.pnlDatosCiudad.Location = new System.Drawing.Point(18, 15);
            this.pnlDatosCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatosCiudad.Name = "pnlDatosCiudad";
            this.pnlDatosCiudad.Size = new System.Drawing.Size(1033, 160);
            this.pnlDatosCiudad.TabIndex = 64;
            // 
            // txtCondicionNombre
            // 
            this.txtCondicionNombre.Location = new System.Drawing.Point(155, 20);
            this.txtCondicionNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondicionNombre.MaxLength = 80;
            this.txtCondicionNombre.Name = "txtCondicionNombre";
            this.txtCondicionNombre.Size = new System.Drawing.Size(599, 22);
            this.txtCondicionNombre.TabIndex = 1;
            this.txtCondicionNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondicionNombre_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(84, 23);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 16);
            this.Label5.TabIndex = 64;
            this.Label5.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(470, 124);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(362, 124);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(88, 97);
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
            this.GroupBox1.Location = new System.Drawing.Point(155, 83);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(181, 39);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.Location = new System.Drawing.Point(91, 12);
            this.rbnInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(74, 20);
            this.rbnInactivo.TabIndex = 4;
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
            this.rbnActivo.TabIndex = 3;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "&Activo";
            this.rbnActivo.UseVisualStyleBackColor = true;
            // 
            // dtgCondiciones
            // 
            this.dtgCondiciones.AllowUserToAddRows = false;
            this.dtgCondiciones.AllowUserToDeleteRows = false;
            this.dtgCondiciones.AllowUserToOrderColumns = true;
            this.dtgCondiciones.AllowUserToResizeRows = false;
            this.dtgCondiciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCondiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCondiciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCondiciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCondiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCondiciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCondiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCondiciones.Location = new System.Drawing.Point(18, 184);
            this.dtgCondiciones.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCondiciones.MultiSelect = false;
            this.dtgCondiciones.Name = "dtgCondiciones";
            this.dtgCondiciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCondiciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCondiciones.RowHeadersVisible = false;
            this.dtgCondiciones.RowHeadersWidth = 51;
            this.dtgCondiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCondiciones.ShowEditingIcon = false;
            this.dtgCondiciones.Size = new System.Drawing.Size(1035, 364);
            this.dtgCondiciones.TabIndex = 63;
            this.dtgCondiciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCondiciones_CellDoubleClick);
            // 
            // totCampos
            // 
            this.totCampos.AutoPopDelay = 3000;
            this.totCampos.InitialDelay = 20;
            this.totCampos.IsBalloon = true;
            this.totCampos.ReshowDelay = 100;
            this.totCampos.ShowAlways = true;
            // 
            // txtDiasPlazo
            // 
            this.txtDiasPlazo.Location = new System.Drawing.Point(155, 53);
            this.txtDiasPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasPlazo.MaxLength = 3;
            this.txtDiasPlazo.Name = "txtDiasPlazo";
            this.txtDiasPlazo.Size = new System.Drawing.Size(74, 22);
            this.txtDiasPlazo.TabIndex = 65;
            this.txtDiasPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasPlazo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Días Plazo:";
            // 
            // frmCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 563);
            this.Controls.Add(this.pnlDatosCiudad);
            this.Controls.Add(this.dtgCondiciones);
            this.Name = "frmCondicionesPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración Condiciones de Pago";
            this.Load += new System.EventHandler(this.frmCondicionesPago_Load);
            this.pnlDatosCiudad.ResumeLayout(false);
            this.pnlDatosCiudad.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCondiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlDatosCiudad;
        internal System.Windows.Forms.TextBox txtCondicionNombre;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbnInactivo;
        internal System.Windows.Forms.RadioButton rbnActivo;
        internal System.Windows.Forms.DataGridView dtgCondiciones;
        internal System.Windows.Forms.ToolTip totCampos;
        internal System.Windows.Forms.TextBox txtDiasPlazo;
        internal System.Windows.Forms.Label label1;
    }
}