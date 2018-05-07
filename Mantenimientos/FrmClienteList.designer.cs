namespace Demo.Mantenimientos
{
    partial class FrmClienteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteList));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNroRegistros = new System.Windows.Forms.TextBox();
            this.lblNroRegistros = new MaterialSkin.Controls.MaterialLabel();
            this.btnFiltro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFiltro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new MaterialSkin.Controls.MaterialLabel();
            this.tltExportarCsv = new System.Windows.Forms.ToolTip(this.components);
            this.fbdExportarCsv = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 100);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(646, 180);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportarCsv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportarCsv.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarCsv.Image")));
            this.btnExportarCsv.Location = new System.Drawing.Point(12, 329);
            this.btnExportarCsv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(35, 30);
            this.btnExportarCsv.TabIndex = 19;
            this.tltExportarCsv.SetToolTip(this.btnExportarCsv, "Exportar a CSV");
            this.btnExportarCsv.UseVisualStyleBackColor = true;
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(558, 329);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(346, 329);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(452, 329);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNroRegistros
            // 
            this.txtNroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNroRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroRegistros.Location = new System.Drawing.Point(617, 286);
            this.txtNroRegistros.Name = "txtNroRegistros";
            this.txtNroRegistros.ReadOnly = true;
            this.txtNroRegistros.Size = new System.Drawing.Size(41, 20);
            this.txtNroRegistros.TabIndex = 112;
            this.txtNroRegistros.Text = "0";
            this.txtNroRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNroRegistros
            // 
            this.lblNroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroRegistros.AutoSize = true;
            this.lblNroRegistros.BackColor = System.Drawing.SystemColors.Window;
            this.lblNroRegistros.Depth = 0;
            this.lblNroRegistros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNroRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroRegistros.Location = new System.Drawing.Point(497, 286);
            this.lblNroRegistros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroRegistros.Name = "lblNroRegistros";
            this.lblNroRegistros.Size = new System.Drawing.Size(114, 19);
            this.lblNroRegistros.TabIndex = 111;
            this.lblNroRegistros.Text = "Nro. Registros :";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Depth = 0;
            this.btnFiltro.Location = new System.Drawing.Point(592, 71);
            this.btnFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Primary = true;
            this.btnFiltro.Size = new System.Drawing.Size(66, 23);
            this.btnFiltro.TabIndex = 19;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Depth = 0;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Hint = "";
            this.txtFiltro.Location = new System.Drawing.Point(249, 71);
            this.txtFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.Size = new System.Drawing.Size(337, 23);
            this.txtFiltro.TabIndex = 113;
            this.txtFiltro.UseSystemPasswordChar = false;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(70, 73);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(173, 21);
            this.cboFiltro.TabIndex = 113;
            this.cboFiltro.SelectionChangeCommitted += new System.EventHandler(this.cboFiltro_SelectionChangeCommitted);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.lblFiltro.Depth = 0;
            this.lblFiltro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFiltro.Location = new System.Drawing.Point(12, 72);
            this.lblFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 19);
            this.lblFiltro.TabIndex = 112;
            this.lblFiltro.Text = "Filtro :";
            // 
            // fbdExportarCsv
            // 
            this.fbdExportarCsv.Description = "Seleccione el destino del archivo CSV";
            // 
            // FrmClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 371);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.txtNroRegistros);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblNroRegistros);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteList";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteList_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmClienteList_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnExportarCsv;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private System.Windows.Forms.TextBox txtNroRegistros;
        internal MaterialSkin.Controls.MaterialLabel lblNroRegistros;
        private System.Windows.Forms.ComboBox cboFiltro;
        internal MaterialSkin.Controls.MaterialLabel lblFiltro;
        private MaterialSkin.Controls.MaterialRaisedButton btnFiltro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltro;
        private System.Windows.Forms.ToolTip tltExportarCsv;
        private System.Windows.Forms.FolderBrowserDialog fbdExportarCsv;
    }
}