namespace Demo.Mantenimientos
{
    partial class FrmClienteMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteMant));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.grpDatosGenerales = new System.Windows.Forms.GroupBox();
            this.lblDatosGenerales = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblSexoAsterisco = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNombresAsterisco = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNacimientoAsterisco = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellidosAsterisco = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.lblNroDocumentoAsterisco = new System.Windows.Forms.Label();
            this.lblDocumentoAsterisco = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.grpDatosGenerales.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlPrincipal, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlInferior, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPrincipal.Size = new System.Drawing.Size(642, 314);
            this.tlpPrincipal.TabIndex = 16;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.grpDatosGenerales);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(3, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(636, 258);
            this.pnlPrincipal.TabIndex = 16;
            // 
            // grpDatosGenerales
            // 
            this.grpDatosGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosGenerales.Controls.Add(this.lblDatosGenerales);
            this.grpDatosGenerales.Controls.Add(this.lblEdad);
            this.grpDatosGenerales.Controls.Add(this.cboSexo);
            this.grpDatosGenerales.Controls.Add(this.chkActivo);
            this.grpDatosGenerales.Controls.Add(this.txtEdad);
            this.grpDatosGenerales.Controls.Add(this.txtCodigo);
            this.grpDatosGenerales.Controls.Add(this.lblSexoAsterisco);
            this.grpDatosGenerales.Controls.Add(this.txtNombres);
            this.grpDatosGenerales.Controls.Add(this.lblSexo);
            this.grpDatosGenerales.Controls.Add(this.lblNombres);
            this.grpDatosGenerales.Controls.Add(this.lblNombresAsterisco);
            this.grpDatosGenerales.Controls.Add(this.txtApellidos);
            this.grpDatosGenerales.Controls.Add(this.lblNacimientoAsterisco);
            this.grpDatosGenerales.Controls.Add(this.lblApellidos);
            this.grpDatosGenerales.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosGenerales.Controls.Add(this.lblApellidosAsterisco);
            this.grpDatosGenerales.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosGenerales.Controls.Add(this.txtNroDocumento);
            this.grpDatosGenerales.Controls.Add(this.lblNroDocumento);
            this.grpDatosGenerales.Controls.Add(this.cboDocumento);
            this.grpDatosGenerales.Controls.Add(this.lblNroDocumentoAsterisco);
            this.grpDatosGenerales.Controls.Add(this.lblDocumentoAsterisco);
            this.grpDatosGenerales.Controls.Add(this.lblCodigo);
            this.grpDatosGenerales.Controls.Add(this.lblDocumento);
            this.grpDatosGenerales.Controls.Add(this.label1);
            this.grpDatosGenerales.Location = new System.Drawing.Point(9, 9);
            this.grpDatosGenerales.Name = "grpDatosGenerales";
            this.grpDatosGenerales.Size = new System.Drawing.Size(618, 240);
            this.grpDatosGenerales.TabIndex = 132;
            this.grpDatosGenerales.TabStop = false;
            this.grpDatosGenerales.Text = "Plan";
            // 
            // lblDatosGenerales
            // 
            this.lblDatosGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosGenerales.BackColor = System.Drawing.Color.Navy;
            this.lblDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosGenerales.ForeColor = System.Drawing.Color.White;
            this.lblDatosGenerales.Location = new System.Drawing.Point(-3, 0);
            this.lblDatosGenerales.Name = "lblDatosGenerales";
            this.lblDatosGenerales.Size = new System.Drawing.Size(621, 13);
            this.lblDatosGenerales.TabIndex = 104;
            this.lblDatosGenerales.Text = "Datos Generales";
            this.lblDatosGenerales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(533, 153);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 128;
            this.lblEdad.Text = "Edad :";
            // 
            // cboSexo
            // 
            this.cboSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(105, 177);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(507, 21);
            this.cboSexo.TabIndex = 129;
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(556, 204);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.Location = new System.Drawing.Point(580, 150);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(32, 20);
            this.txtEdad.TabIndex = 123;
            this.txtEdad.TabStop = false;
            this.txtEdad.Text = "18";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(105, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(507, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblSexoAsterisco
            // 
            this.lblSexoAsterisco.AutoSize = true;
            this.lblSexoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblSexoAsterisco.Location = new System.Drawing.Point(91, 180);
            this.lblSexoAsterisco.Name = "lblSexoAsterisco";
            this.lblSexoAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblSexoAsterisco.TabIndex = 131;
            this.lblSexoAsterisco.Text = "*";
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.Location = new System.Drawing.Point(105, 46);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(507, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(6, 180);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 13);
            this.lblSexo.TabIndex = 130;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(6, 49);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(55, 13);
            this.lblNombres.TabIndex = 72;
            this.lblNombres.Text = "Nombres :";
            // 
            // lblNombresAsterisco
            // 
            this.lblNombresAsterisco.AutoSize = true;
            this.lblNombresAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblNombresAsterisco.Location = new System.Drawing.Point(91, 49);
            this.lblNombresAsterisco.Name = "lblNombresAsterisco";
            this.lblNombresAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblNombresAsterisco.TabIndex = 81;
            this.lblNombresAsterisco.Text = "*";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.Location = new System.Drawing.Point(105, 72);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(507, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // lblNacimientoAsterisco
            // 
            this.lblNacimientoAsterisco.AutoSize = true;
            this.lblNacimientoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblNacimientoAsterisco.Location = new System.Drawing.Point(91, 156);
            this.lblNacimientoAsterisco.Name = "lblNacimientoAsterisco";
            this.lblNacimientoAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblNacimientoAsterisco.TabIndex = 127;
            this.lblNacimientoAsterisco.Text = "*";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 75);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(90, 13);
            this.lblApellidos.TabIndex = 87;
            this.lblApellidos.Text = "Apellido Paterno :";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 154);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(66, 13);
            this.lblFechaNacimiento.TabIndex = 124;
            this.lblFechaNacimiento.Text = "Nacimiento :";
            // 
            // lblApellidosAsterisco
            // 
            this.lblApellidosAsterisco.AutoSize = true;
            this.lblApellidosAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblApellidosAsterisco.Location = new System.Drawing.Point(91, 75);
            this.lblApellidosAsterisco.Name = "lblApellidosAsterisco";
            this.lblApellidosAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblApellidosAsterisco.TabIndex = 88;
            this.lblApellidosAsterisco.Text = "*";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(105, 151);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaNacimiento.TabIndex = 122;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocumento.Location = new System.Drawing.Point(105, 125);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(507, 20);
            this.txtNroDocumento.TabIndex = 5;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(6, 128);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(88, 13);
            this.lblNroDocumento.TabIndex = 90;
            this.lblNroDocumento.Text = "Nro Documento :";
            // 
            // cboDocumento
            // 
            this.cboDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(105, 98);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(507, 21);
            this.cboDocumento.TabIndex = 4;
            // 
            // lblNroDocumentoAsterisco
            // 
            this.lblNroDocumentoAsterisco.AutoSize = true;
            this.lblNroDocumentoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblNroDocumentoAsterisco.Location = new System.Drawing.Point(91, 128);
            this.lblNroDocumentoAsterisco.Name = "lblNroDocumentoAsterisco";
            this.lblNroDocumentoAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblNroDocumentoAsterisco.TabIndex = 91;
            this.lblNroDocumentoAsterisco.Text = "*";
            // 
            // lblDocumentoAsterisco
            // 
            this.lblDocumentoAsterisco.AutoSize = true;
            this.lblDocumentoAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lblDocumentoAsterisco.Location = new System.Drawing.Point(91, 101);
            this.lblDocumentoAsterisco.Name = "lblDocumentoAsterisco";
            this.lblDocumentoAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lblDocumentoAsterisco.TabIndex = 113;
            this.lblDocumentoAsterisco.Text = "*";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 98;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(6, 101);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(68, 13);
            this.lblDocumento.TabIndex = 112;
            this.lblDocumento.Text = "Documento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "*";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnGuardar);
            this.pnlInferior.Controls.Add(this.btnCancelar);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInferior.Location = new System.Drawing.Point(3, 267);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(636, 44);
            this.pnlInferior.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(527, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(421, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmClienteMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 314);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteMant";
            this.Text = "Mantenimiento de Cliente";
            this.Load += new System.EventHandler(this.FrmClienteMant_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.grpDatosGenerales.ResumeLayout(false);
            this.grpDatosGenerales.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlInferior;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        internal System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.CheckBox chkActivo;
        internal System.Windows.Forms.Label lblNombresAsterisco;
        internal System.Windows.Forms.Label lblApellidosAsterisco;
        internal System.Windows.Forms.Label lblNroDocumentoAsterisco;
        internal System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboDocumento;
        internal System.Windows.Forms.Label lblDocumentoAsterisco;
        internal System.Windows.Forms.Label lblDocumento;
        internal System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        internal System.Windows.Forms.Label lblNacimientoAsterisco;
        internal System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboSexo;
        internal System.Windows.Forms.Label lblSexoAsterisco;
        internal System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox grpDatosGenerales;
        internal System.Windows.Forms.Label lblDatosGenerales;
    }
}