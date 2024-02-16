
namespace FumiCont.Formularios.Administracion
{
    partial class frmAsignaModulosPerfil
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
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.chbModulosAsignados = new System.Windows.Forms.CheckedListBox();
            this.chbModulosDisponibles = new System.Windows.Forms.CheckedListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.ItemHeight = 13;
            this.cboPerfiles.Location = new System.Drawing.Point(77, 26);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(359, 21);
            this.cboPerfiles.TabIndex = 2;
            this.cboPerfiles.SelectedIndexChanged += new System.EventHandler(this.cboPerfiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Perfil:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDesasignar);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Controls.Add(this.chbModulosAsignados);
            this.panel1.Controls.Add(this.chbModulosDisponibles);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 376);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modulos Asignados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modulos Disponibles";
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Image = global::FumiCont.Properties.Resources.arrow_left;
            this.btnDesasignar.Location = new System.Drawing.Point(424, 147);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(56, 23);
            this.btnDesasignar.TabIndex = 3;
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // chbModulosAsignados
            // 
            this.chbModulosAsignados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chbModulosAsignados.FormattingEnabled = true;
            this.chbModulosAsignados.Location = new System.Drawing.Point(533, 18);
            this.chbModulosAsignados.Name = "chbModulosAsignados";
            this.chbModulosAsignados.Size = new System.Drawing.Size(393, 349);
            this.chbModulosAsignados.TabIndex = 1;
            // 
            // chbModulosDisponibles
            // 
            this.chbModulosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chbModulosDisponibles.FormattingEnabled = true;
            this.chbModulosDisponibles.Location = new System.Drawing.Point(6, 21);
            this.chbModulosDisponibles.Name = "chbModulosDisponibles";
            this.chbModulosDisponibles.Size = new System.Drawing.Size(376, 349);
            this.chbModulosDisponibles.TabIndex = 0;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::FumiCont.Properties.Resources.arrow_right;
            this.btnAsignar.Location = new System.Drawing.Point(424, 101);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(56, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmAsignaModulosPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPerfiles);
            this.Name = "frmAsignaModulosPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de módulos del sistema a perfiles  de usuario";
            this.Load += new System.EventHandler(this.frmAsignaModulosPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboPerfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox chbModulosAsignados;
        private System.Windows.Forms.CheckedListBox chbModulosDisponibles;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}