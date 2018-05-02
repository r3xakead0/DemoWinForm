using System;
using System.Windows.Forms;
using Demo.Utiles;
using Demo.Seguridad;
using Demo.Mantenimientos;
using UI = Demo.Entities;

namespace Demo
{
    public partial class MdiMain : Form
    {

        public UI.Usuario uiUsuario = null;

        public MdiMain()
        {
            InitializeComponent();
        }

        public void Acceso(UI.Usuario uiUsuario)
        {
            try
            {
                this.uiUsuario = uiUsuario;

                this.mnuPrincipal.Visible = true;
                this.stsPrincipal.Visible = true;

                this.stlUsuario.Text = uiUsuario.Nombres;
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void MdiMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                this.mnuPrincipal.Visible = false;
                this.stsPrincipal.Visible = false;

                var frmLogin = new FrmLogin();
                frmLogin.MdiParent = this;
                frmLogin.StartPosition = FormStartPosition.CenterScreen;
                frmLogin.Show();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
            
        }

        private void MdiMain_Resize(object sender, EventArgs e)
        {
            try
            {
                int otrosLbl = 0;
                otrosLbl += this.tslUsuario.Width;
                otrosLbl += this.tslVersion.Width;
                otrosLbl += this.tslVersionValor.Width;

                this.tslUsuarioValor.Width = this.stsPrincipal.Width - otrosLbl - 100;
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #region Seguridad

        private void tsmMantenimientoUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                var frmUsuarioList = FrmUsuarioList.Instance();
                frmUsuarioList.MdiParent = this;
                frmUsuarioList.StartPosition = FormStartPosition.CenterScreen;
                frmUsuarioList.Show();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void tsmCambioClave_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCambioClave = FrmCambioClave.Instance();
                frmCambioClave.MdiParent = this;
                frmCambioClave.StartPosition = FormStartPosition.CenterScreen;
                frmCambioClave.Show();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Mantenimientos

        private void tsmMantenimientoClientes_Click(object sender, EventArgs e)
        {
            try
            {
                var frmClienteList = FrmClienteList.Instance();
                frmClienteList.MdiParent = this;
                frmClienteList.StartPosition = FormStartPosition.CenterScreen;
                frmClienteList.Show();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Ventanas

        private void tsmVentanasCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmVentanasMosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmVentanasMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmVentanasCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmVentanasOrganizarIconos_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

    }
}
