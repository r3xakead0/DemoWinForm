namespace Demo.Seguridad
{
    partial class FrmUsuarioMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioMant));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblContrasenha = new System.Windows.Forms.Label();
            this.txtContrasenha = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioAsterisk = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.lblNombreAsterisk = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.lblEmailAsterisk = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LblContrasenha2 = new System.Windows.Forms.Label();
            this.lblContrasenhaAsterisk = new System.Windows.Forms.Label();
            this.txtContrasenha2 = new System.Windows.Forms.TextBox();
            this.lblBloqueadoAsterisk = new System.Windows.Forms.Label();
            this.cbxBloqueado = new System.Windows.Forms.CheckBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlInferior, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 261);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblContrasenha);
            this.panel1.Controls.Add(this.txtContrasenha);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.lblUsuarioAsterisk);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.lblNombreAsterisk);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.lblEmailAsterisk);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.LblContrasenha2);
            this.panel1.Controls.Add(this.lblContrasenhaAsterisk);
            this.panel1.Controls.Add(this.txtContrasenha2);
            this.panel1.Controls.Add(this.lblBloqueadoAsterisk);
            this.panel1.Controls.Add(this.cbxBloqueado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 205);
            this.panel1.TabIndex = 16;
            // 
            // LblContrasenha
            // 
            this.LblContrasenha.AutoSize = true;
            this.LblContrasenha.Location = new System.Drawing.Point(27, 111);
            this.LblContrasenha.Name = "LblContrasenha";
            this.LblContrasenha.Size = new System.Drawing.Size(64, 13);
            this.LblContrasenha.TabIndex = 33;
            this.LblContrasenha.Text = "Contraseña:";
            // 
            // txtContrasenha
            // 
            this.txtContrasenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenha.Location = new System.Drawing.Point(145, 108);
            this.txtContrasenha.Name = "txtContrasenha";
            this.txtContrasenha.PasswordChar = '*';
            this.txtContrasenha.Size = new System.Drawing.Size(116, 20);
            this.txtContrasenha.TabIndex = 35;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(27, 23);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 15;
            this.LblUsuario.Text = "Usuario:";
            // 
            // lblUsuarioAsterisk
            // 
            this.lblUsuarioAsterisk.AutoSize = true;
            this.lblUsuarioAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioAsterisk.Location = new System.Drawing.Point(131, 23);
            this.lblUsuarioAsterisk.Name = "lblUsuarioAsterisk";
            this.lblUsuarioAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblUsuarioAsterisk.TabIndex = 16;
            this.lblUsuarioAsterisk.Text = "*";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(145, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 20);
            this.txtUsuario.TabIndex = 17;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(27, 55);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 18;
            this.LblNombre.Text = "Nombre:";
            // 
            // lblNombreAsterisk
            // 
            this.lblNombreAsterisk.AutoSize = true;
            this.lblNombreAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblNombreAsterisk.Location = new System.Drawing.Point(131, 55);
            this.lblNombreAsterisk.Name = "lblNombreAsterisk";
            this.lblNombreAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblNombreAsterisk.TabIndex = 19;
            this.lblNombreAsterisk.Text = "*";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(145, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(27, 83);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 21;
            this.LblEmail.Text = "Email:";
            // 
            // lblEmailAsterisk
            // 
            this.lblEmailAsterisk.AutoSize = true;
            this.lblEmailAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblEmailAsterisk.Location = new System.Drawing.Point(131, 83);
            this.lblEmailAsterisk.Name = "lblEmailAsterisk";
            this.lblEmailAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblEmailAsterisk.TabIndex = 23;
            this.lblEmailAsterisk.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(145, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // LblContrasenha2
            // 
            this.LblContrasenha2.AutoSize = true;
            this.LblContrasenha2.Location = new System.Drawing.Point(27, 139);
            this.LblContrasenha2.Name = "LblContrasenha2";
            this.LblContrasenha2.Size = new System.Drawing.Size(101, 13);
            this.LblContrasenha2.TabIndex = 24;
            this.LblContrasenha2.Text = "Repetir Contraseña:";
            // 
            // lblContrasenhaAsterisk
            // 
            this.lblContrasenhaAsterisk.AutoSize = true;
            this.lblContrasenhaAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblContrasenhaAsterisk.Location = new System.Drawing.Point(131, 111);
            this.lblContrasenhaAsterisk.Name = "lblContrasenhaAsterisk";
            this.lblContrasenhaAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblContrasenhaAsterisk.TabIndex = 25;
            this.lblContrasenhaAsterisk.Text = "*";
            // 
            // txtContrasenha2
            // 
            this.txtContrasenha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasenha2.Location = new System.Drawing.Point(145, 136);
            this.txtContrasenha2.Name = "txtContrasenha2";
            this.txtContrasenha2.PasswordChar = '*';
            this.txtContrasenha2.Size = new System.Drawing.Size(116, 20);
            this.txtContrasenha2.TabIndex = 26;
            // 
            // lblBloqueadoAsterisk
            // 
            this.lblBloqueadoAsterisk.AutoSize = true;
            this.lblBloqueadoAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblBloqueadoAsterisk.Location = new System.Drawing.Point(131, 139);
            this.lblBloqueadoAsterisk.Name = "lblBloqueadoAsterisk";
            this.lblBloqueadoAsterisk.Size = new System.Drawing.Size(11, 13);
            this.lblBloqueadoAsterisk.TabIndex = 28;
            this.lblBloqueadoAsterisk.Text = "*";
            // 
            // cbxBloqueado
            // 
            this.cbxBloqueado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBloqueado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxBloqueado.Location = new System.Drawing.Point(145, 164);
            this.cbxBloqueado.Name = "cbxBloqueado";
            this.cbxBloqueado.Size = new System.Drawing.Size(116, 20);
            this.cbxBloqueado.TabIndex = 29;
            this.cbxBloqueado.Text = "Bloqueado";
            this.cbxBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.BtnSave);
            this.pnlInferior.Controls.Add(this.BtnCancel);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInferior.Location = new System.Drawing.Point(3, 214);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(298, 44);
            this.pnlInferior.TabIndex = 17;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(189, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 30);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(83, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmUsuarioMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUsuarioMant";
            this.Text = "Mantenimiento de Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label LblUsuario;
        internal System.Windows.Forms.Label lblUsuarioAsterisk;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.Label lblNombreAsterisk;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label LblEmail;
        internal System.Windows.Forms.Label lblEmailAsterisk;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label LblContrasenha2;
        internal System.Windows.Forms.Label lblContrasenhaAsterisk;
        internal System.Windows.Forms.TextBox txtContrasenha2;
        internal System.Windows.Forms.Label lblBloqueadoAsterisk;
        internal System.Windows.Forms.CheckBox cbxBloqueado;
        private System.Windows.Forms.Panel pnlInferior;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Label LblContrasenha;
        internal System.Windows.Forms.TextBox txtContrasenha;
    }
}