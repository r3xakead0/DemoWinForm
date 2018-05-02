using System;
using System.Windows.Forms;
using System.ComponentModel;
using Demo.Utiles;
using Demo.Dal;
using Demo.Model;
using UI = Demo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Seguridad
{
    public partial class FrmUsuarioList : Form
    {

        #region "Patron Singleton"

        private static FrmUsuarioList frmInstance = null;

        public static FrmUsuarioList Instance()
        {

            if (frmInstance == null || frmInstance.IsDisposed == true)
            {
                frmInstance = new FrmUsuarioList();
            }

            frmInstance.BringToFront();

            return frmInstance;
        }

        #endregion

        private int lastRowIndex = 0;

        public FrmUsuarioList()
        {
            InitializeComponent();
        }

        #region formulario

        private void FrmUsuarioList_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarListadoUsuarios();
                this.FormatoListadoUsuarios();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void FrmUsuarioList_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                General.AutoWidthColumn(ref this.dgvUsuarios, "Nombres");
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                lastRowIndex = this.dgvUsuarios.Rows.Count;

                var frmUsuarioNew = FrmUsuarioMant.Instance();
                frmUsuarioNew.MdiParent = this.MdiParent;
                frmUsuarioNew.Show();

                frmUsuarioNew.frmList = this;
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgvUsuarios.CurrentRow != null)
                {
                    var uiUsuario = (UI.Usuario)this.dgvUsuarios.CurrentRow.DataBoundItem;

                    if (uiUsuario.ID == 1)
                        throw new Exception("No se puede editar el usuario ADMIN");

                    lastRowIndex = this.dgvUsuarios.CurrentRow.Index;

                    var frmUsuarioEdit = FrmUsuarioMant.Instance() ;
                    frmUsuarioEdit.MdiParent = this.MdiParent;
                    frmUsuarioEdit.Show();

                    frmUsuarioEdit.Cargar(uiUsuario);
                    frmUsuarioEdit.frmList = this;
                }
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsuarios.CurrentRow != null)
                {


                    var uiUsuario = (UI.Usuario)this.dgvUsuarios.CurrentRow.DataBoundItem;

                    if (uiUsuario.ID == 1)
                        throw new Exception("No se puede eliminar el usuario ADMIN");

                    if (General.ConfirmationMessage("¿Desea eliminar el usuario seleccionado?") == false)
                        return;

                    int idUsuarioSesion = ((MdiMain)this.MdiParent).uiUsuario.ID;
                    bool rpta = Eliminar(uiUsuario.ID);
             
                    if (rpta == true)
                    {
                        lastRowIndex = this.dgvUsuarios.Rows.Count - 2;
                        if (lastRowIndex < 0)
                            lastRowIndex = 0;
                        this.CargarListadoUsuarios();

                        General.InformationMessage("Se eliminó el usuario seleccionado");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                    return;

                var uiUsuario = (UI.Usuario)this.dgvUsuarios.CurrentRow.DataBoundItem;

                if (uiUsuario.ID == 1)
                    throw new Exception("No se puede editar el usuario ADMIN");

                lastRowIndex = e.RowIndex;

                var frmUsuarioEdit = FrmUsuarioMant.Instance();
                frmUsuarioEdit.MdiParent = this.MdiParent;
                frmUsuarioEdit.Show();

                frmUsuarioEdit.Cargar(uiUsuario);
                frmUsuarioEdit.frmList = this;
                
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void dgvUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var col = dgvUsuarios.Columns[e.ColumnIndex];
                ListSortDirection dir;

                switch (col.HeaderCell.SortGlyphDirection)
                {
                    case SortOrder.Ascending:
                        dir = ListSortDirection.Ascending;
                        break;
                    default:
                        dir = ListSortDirection.Descending;
                        break;
                }

                dgvUsuarios.Sort(col, dir);
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Metodo

        private List<UI.Usuario> Listar()
        {
            var lstUsuarioUi = new List<UI.Usuario>();
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    List<Usuario> lstUsuarioBe = db.Usuarios.ToList();

                    foreach (Usuario usuarioBE in lstUsuarioBe)
                    {
                        var usuarioUI = new UI.Usuario();

                        usuarioUI.ID = usuarioBE.Id;
                        usuarioUI.Username = usuarioBE.Name;
                        usuarioUI.Password = usuarioBE.Password;
                        usuarioUI.Nombres = usuarioBE.Nombre;
                        usuarioUI.Email = usuarioBE.Email;
                        usuarioUI.Bloqueado = usuarioBE.Bloqueado == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;

                        lstUsuarioUi.Add(usuarioUI);
                    }
                }

                return lstUsuarioUi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Eliminar(int id)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    Usuario usuarioBe = db.Usuarios.First(b => b.Id == id);
                    db.Usuarios.Remove(usuarioBe);
                    db.SaveChanges();

                    rpta = true;
                }

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarListadoUsuarios()
        {
            try
            {
                int idUsuarioSesion = ((MdiMain)this.MdiParent).uiUsuario.ID;

                var lstUiUsuarios = Listar();

                var sorted = new SortableBindingList<UI.Usuario>(lstUiUsuarios);
                this.dgvUsuarios.DataSource = sorted;

                if (lstUiUsuarios.Count > 0)
                {
                    this.dgvUsuarios.CurrentCell = this.dgvUsuarios.Rows[lastRowIndex].Cells["Nombres"];
                    this.dgvUsuarios.Rows[lastRowIndex].Selected = true;
                    this.dgvUsuarios.FirstDisplayedScrollingRowIndex = lastRowIndex;
                    this.dgvUsuarios.Update();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FormatoListadoUsuarios()
        {
            try
            {

                General.FormatDatagridview(ref this.dgvUsuarios);

                this.dgvUsuarios.Columns["ID"].Visible = false;

                this.dgvUsuarios.Columns["Username"].Visible = true;
                this.dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
                this.dgvUsuarios.Columns["Username"].Width = 100;
                this.dgvUsuarios.Columns["Username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvUsuarios.Columns["Password"].Visible = false;

                this.dgvUsuarios.Columns["Nombres"].Visible = true;
                this.dgvUsuarios.Columns["Nombres"].HeaderText = "Nombres";
                this.dgvUsuarios.Columns["Nombres"].Width = 100;
                this.dgvUsuarios.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvUsuarios.Columns["Email"].Visible = true;
                this.dgvUsuarios.Columns["Email"].HeaderText = "Email";
                this.dgvUsuarios.Columns["Email"].Width = 200;
                this.dgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvUsuarios.Columns["Bloqueado"].Visible = true;
                this.dgvUsuarios.Columns["Bloqueado"].HeaderText = "Bloqueado";
                this.dgvUsuarios.Columns["Bloqueado"].Width = 70;
                this.dgvUsuarios.Columns["Bloqueado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                General.AutoWidthColumn(ref this.dgvUsuarios, "Nombres");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        
    }
}
