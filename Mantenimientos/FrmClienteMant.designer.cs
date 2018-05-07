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
            this.lblEdad = new MaterialSkin.Controls.MaterialLabel();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.chkActivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSexo = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombres = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblApellidos = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaNacimiento = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNroDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNroDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.Window;
            this.lblEdad.Depth = 0;
            this.lblEdad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEdad.Location = new System.Drawing.Point(422, 212);
            this.lblEdad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 19);
            this.lblEdad.TabIndex = 128;
            this.lblEdad.Text = "Edad :";
            // 
            // cboSexo
            // 
            this.cboSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(153, 236);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(358, 21);
            this.cboSexo.TabIndex = 129;
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.SystemColors.Window;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Depth = 0;
            this.chkActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkActivo.Location = new System.Drawing.Point(442, 263);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Ripple = true;
            this.chkActivo.Size = new System.Drawing.Size(69, 30);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = false;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.Location = new System.Drawing.Point(479, 210);
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
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(153, 79);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(358, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.Depth = 0;
            this.txtNombres.Hint = "";
            this.txtNombres.Location = new System.Drawing.Point(153, 105);
            this.txtNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.SelectedText = "";
            this.txtNombres.SelectionLength = 0;
            this.txtNombres.SelectionStart = 0;
            this.txtNombres.Size = new System.Drawing.Size(358, 23);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.UseSystemPasswordChar = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.SystemColors.Window;
            this.lblSexo.Depth = 0;
            this.lblSexo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSexo.Location = new System.Drawing.Point(22, 239);
            this.lblSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 19);
            this.lblSexo.TabIndex = 130;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombres.Depth = 0;
            this.lblNombres.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombres.Location = new System.Drawing.Point(22, 108);
            this.lblNombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(79, 19);
            this.lblNombres.TabIndex = 72;
            this.lblNombres.Text = "Nombres :";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(153, 131);
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(358, 23);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.UseSystemPasswordChar = false;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidos.Depth = 0;
            this.lblApellidos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidos.Location = new System.Drawing.Point(22, 134);
            this.lblApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(128, 19);
            this.lblApellidos.TabIndex = 87;
            this.lblApellidos.Text = "Apellido Paterno :";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaNacimiento.Depth = 0;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(22, 213);
            this.lblFechaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(95, 19);
            this.lblFechaNacimiento.TabIndex = 124;
            this.lblFechaNacimiento.Text = "Nacimiento :";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(153, 210);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaNacimiento.TabIndex = 122;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroDocumento.Depth = 0;
            this.txtNroDocumento.Hint = "";
            this.txtNroDocumento.Location = new System.Drawing.Point(153, 184);
            this.txtNroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.PasswordChar = '\0';
            this.txtNroDocumento.SelectedText = "";
            this.txtNroDocumento.SelectionLength = 0;
            this.txtNroDocumento.SelectionStart = 0;
            this.txtNroDocumento.Size = new System.Drawing.Size(358, 23);
            this.txtNroDocumento.TabIndex = 5;
            this.txtNroDocumento.UseSystemPasswordChar = false;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.lblNroDocumento.Depth = 0;
            this.lblNroDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroDocumento.Location = new System.Drawing.Point(22, 187);
            this.lblNroDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(124, 19);
            this.lblNroDocumento.TabIndex = 90;
            this.lblNroDocumento.Text = "Nro Documento :";
            // 
            // cboDocumento
            // 
            this.cboDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(153, 157);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(358, 21);
            this.cboDocumento.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(22, 82);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 19);
            this.lblCodigo.TabIndex = 98;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.lblDocumento.Depth = 0;
            this.lblDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocumento.Location = new System.Drawing.Point(22, 160);
            this.lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(95, 19);
            this.lblDocumento.TabIndex = 112;
            this.lblDocumento.Text = "Documento :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(426, 317);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(320, 317);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
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
            this.ClientSize = new System.Drawing.Size(538, 359);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNroDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteMant";
            this.Text = "Mantenimiento de Cliente";
            this.Load += new System.EventHandler(this.FrmClienteMant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        public MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        internal MaterialSkin.Controls.MaterialLabel lblNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        internal MaterialSkin.Controls.MaterialLabel lblApellidos;
        private MaterialSkin.Controls.MaterialCheckBox chkActivo;
        internal MaterialSkin.Controls.MaterialLabel lblNroDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroDocumento;
        internal MaterialSkin.Controls.MaterialLabel lblCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private System.Windows.Forms.ComboBox cboDocumento;
        internal MaterialSkin.Controls.MaterialLabel lblDocumento;
        internal MaterialSkin.Controls.MaterialLabel lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        internal MaterialSkin.Controls.MaterialLabel lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboSexo;
        internal MaterialSkin.Controls.MaterialLabel lblSexo;
    }
}