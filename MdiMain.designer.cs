namespace Demo
{
    partial class MdiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMain));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMantenimientoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCambioClave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMantenimientoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanasCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanasMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanasMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanasCerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentanasOrganizarIconos = new System.Windows.Forms.ToolStripMenuItem();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.tslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslUsuarioValor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslVersionValor = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.stsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModulos,
            this.windowsMenu});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(862, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // tsmModulos
            // 
            this.tsmModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSeguridad,
            this.tsmMantenimientos});
            this.tsmModulos.Name = "tsmModulos";
            this.tsmModulos.Size = new System.Drawing.Size(66, 20);
            this.tsmModulos.Text = "Modulos";
            // 
            // tsmSeguridad
            // 
            this.tsmSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimientoUsuarios,
            this.toolStripSeparator1,
            this.tsmCambioClave});
            this.tsmSeguridad.Name = "tsmSeguridad";
            this.tsmSeguridad.Size = new System.Drawing.Size(180, 22);
            this.tsmSeguridad.Text = "Seguridad";
            // 
            // tsmMantenimientoUsuarios
            // 
            this.tsmMantenimientoUsuarios.Name = "tsmMantenimientoUsuarios";
            this.tsmMantenimientoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmMantenimientoUsuarios.Text = "Usuarios";
            this.tsmMantenimientoUsuarios.Click += new System.EventHandler(this.tsmMantenimientoUsuarios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmCambioClave
            // 
            this.tsmCambioClave.Name = "tsmCambioClave";
            this.tsmCambioClave.Size = new System.Drawing.Size(180, 22);
            this.tsmCambioClave.Text = "Cambiar Clave";
            this.tsmCambioClave.Click += new System.EventHandler(this.tsmCambioClave_Click);
            // 
            // tsmMantenimientos
            // 
            this.tsmMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimientoClientes});
            this.tsmMantenimientos.Name = "tsmMantenimientos";
            this.tsmMantenimientos.Size = new System.Drawing.Size(180, 22);
            this.tsmMantenimientos.Text = "Mantenimientos";
            // 
            // tsmMantenimientoClientes
            // 
            this.tsmMantenimientoClientes.Name = "tsmMantenimientoClientes";
            this.tsmMantenimientoClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmMantenimientoClientes.Text = "Clientes";
            this.tsmMantenimientoClientes.Click += new System.EventHandler(this.tsmMantenimientoClientes_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVentanasCascada,
            this.tsmVentanasMosaicoVertical,
            this.tsmVentanasMosaicoHorizontal,
            this.tsmVentanasCerrarTodo,
            this.tsmVentanasOrganizarIconos});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(67, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // tsmVentanasCascada
            // 
            this.tsmVentanasCascada.Name = "tsmVentanasCascada";
            this.tsmVentanasCascada.Size = new System.Drawing.Size(180, 22);
            this.tsmVentanasCascada.Text = "&Cascada";
            this.tsmVentanasCascada.Click += new System.EventHandler(this.tsmVentanasCascada_Click);
            // 
            // tsmVentanasMosaicoVertical
            // 
            this.tsmVentanasMosaicoVertical.Name = "tsmVentanasMosaicoVertical";
            this.tsmVentanasMosaicoVertical.Size = new System.Drawing.Size(180, 22);
            this.tsmVentanasMosaicoVertical.Text = "Mosaico &vertical";
            this.tsmVentanasMosaicoVertical.Click += new System.EventHandler(this.tsmVentanasMosaicoVertical_Click);
            // 
            // tsmVentanasMosaicoHorizontal
            // 
            this.tsmVentanasMosaicoHorizontal.Name = "tsmVentanasMosaicoHorizontal";
            this.tsmVentanasMosaicoHorizontal.Size = new System.Drawing.Size(180, 22);
            this.tsmVentanasMosaicoHorizontal.Text = "Mosaico &horizontal";
            this.tsmVentanasMosaicoHorizontal.Click += new System.EventHandler(this.tsmVentanasMosaicoHorizontal_Click);
            // 
            // tsmVentanasCerrarTodo
            // 
            this.tsmVentanasCerrarTodo.Name = "tsmVentanasCerrarTodo";
            this.tsmVentanasCerrarTodo.Size = new System.Drawing.Size(180, 22);
            this.tsmVentanasCerrarTodo.Text = "C&errar todo";
            this.tsmVentanasCerrarTodo.Click += new System.EventHandler(this.tsmVentanasCerrarTodo_Click);
            // 
            // tsmVentanasOrganizarIconos
            // 
            this.tsmVentanasOrganizarIconos.Name = "tsmVentanasOrganizarIconos";
            this.tsmVentanasOrganizarIconos.Size = new System.Drawing.Size(180, 22);
            this.tsmVentanasOrganizarIconos.Text = "&Organizar iconos";
            this.tsmVentanasOrganizarIconos.Click += new System.EventHandler(this.tsmVentanasOrganizarIconos_Click);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUsuario,
            this.stlUsuario,
            this.tslUsuarioValor,
            this.tslVersion,
            this.tslVersionValor});
            this.stsPrincipal.Location = new System.Drawing.Point(0, 416);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(862, 22);
            this.stsPrincipal.TabIndex = 3;
            this.stsPrincipal.Text = "statusStrip1";
            // 
            // tslUsuario
            // 
            this.tslUsuario.AutoSize = false;
            this.tslUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(60, 17);
            this.tslUsuario.Text = "Usuario :";
            this.tslUsuario.ToolTipText = "Sesión del Usuario";
            // 
            // stlUsuario
            // 
            this.stlUsuario.Name = "stlUsuario";
            this.stlUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tslUsuarioValor
            // 
            this.tslUsuarioValor.AutoSize = false;
            this.tslUsuarioValor.Name = "tslUsuarioValor";
            this.tslUsuarioValor.Size = new System.Drawing.Size(500, 17);
            this.tslUsuarioValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslVersion
            // 
            this.tslVersion.AutoSize = false;
            this.tslVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslVersion.Name = "tslVersion";
            this.tslVersion.Size = new System.Drawing.Size(60, 17);
            this.tslVersion.Text = "Versión :";
            this.tslVersion.ToolTipText = "Versión del Sistema";
            // 
            // tslVersionValor
            // 
            this.tslVersionValor.AutoSize = false;
            this.tslVersionValor.Name = "tslVersionValor";
            this.tslVersionValor.Size = new System.Drawing.Size(40, 17);
            this.tslVersionValor.Text = "1.00";
            this.tslVersionValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 438);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "MdiMain";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.MdiMain_Load);
            this.Resize += new System.EventHandler(this.MdiMain_Resize);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.stsPrincipal.ResumeLayout(false);
            this.stsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmModulos;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimientos;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel stlUsuario;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanasCascada;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanasMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanasMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanasCerrarTodo;
        private System.Windows.Forms.ToolStripMenuItem tsmVentanasOrganizarIconos;
        private System.Windows.Forms.ToolStripMenuItem tsmSeguridad;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimientoUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCambioClave;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimientoClientes;
        private System.Windows.Forms.ToolStripStatusLabel tslUsuarioValor;
        private System.Windows.Forms.ToolStripStatusLabel tslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tslVersionValor;
    }
}