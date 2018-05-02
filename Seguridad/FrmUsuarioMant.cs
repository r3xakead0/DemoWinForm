using System;
using System.Windows.Forms;
using Demo.Utiles;
using Demo.Dal;
using Demo.Model;
using UI = Demo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Seguridad
{
    public partial class FrmUsuarioMant : Form
    {

        #region "Patron Singleton"

        private static FrmUsuarioMant frmInstance = null;

        public static FrmUsuarioMant Instance()
        {

            if (frmInstance == null || frmInstance.IsDisposed == true)
            {
                frmInstance = new FrmUsuarioMant();
            }

            frmInstance.BringToFront();

            return frmInstance;
        }

        #endregion

        private UI.Usuario uiUsuario = null;
        public FrmUsuarioList frmList = null;

        #region Formulario

        public FrmUsuarioMant()
        {
            try
            {
                InitializeComponent();

                this.uiUsuario = new UI.Usuario();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones de Formulario

                if (this.txtUsuario.Text.Trim().Length == 0)
                {
                    this.txtUsuario.Focus();
                    throw new Exception("Ingrese el usuario");
                }

                if (this.txtNombre.Text.Trim().Length == 0)
                {
                    this.txtNombre.Focus();
                    throw new Exception("Ingrese el nombre del usuario");
                }

                if (this.txtEmail.Text.Trim().Length == 0)
                {
                    this.txtEmail.Focus();
                    throw new Exception("Ingrese el email del usuario");
                }
                else if (General.IsValidEmail(this.txtEmail.Text) == false)
                {
                    this.txtEmail.Focus();
                    throw new Exception("Ingrese un email valido");
                }

                if (this.txtContrasenha.Text.Trim().Length == 0)
                {
                    this.txtContrasenha.Focus();
                    throw new Exception("Ingrese la contraseña del usuario");
                }

                if (this.txtContrasenha2.Text.Trim().Length == 0)
                {
                    this.txtContrasenha2.Focus();
                    throw new Exception("Ingrese la contraseña repetida del usuario");
                }

                if (this.txtContrasenha.Text.Trim() != this.txtContrasenha2.Text.Trim())
                {
                    this.txtContrasenha.Focus();
                    throw new Exception("La contraseñas ingresadas no coinciden");
                }

                #endregion

                uiUsuario.Username = this.txtUsuario.Text.Trim();
                uiUsuario.Password = this.txtContrasenha.Text.Trim();
                uiUsuario.Nombres = this.txtNombre.Text.Trim();
                uiUsuario.Email = this.txtEmail.Text.Trim();
                uiUsuario.Bloqueado = this.cbxBloqueado.Checked ? UI.ActivoEnum.Si : UI.ActivoEnum.No;

                int idUsuarioSesion = ((MdiMain)this.MdiParent).uiUsuario.ID;
                bool rpta = false;
                string msg = "";
                if (uiUsuario.ID == 0)
                {
                    rpta = Insertar(ref uiUsuario);
                    if (rpta)
                        msg = "Se registro un nuevo Usuario";
                }
                else
                {
                    rpta = Actualizar(uiUsuario);
                    if (rpta)
                        msg = "Se actualizo el Usuario";
                }

                if (rpta == true)
                {
                    General.InformationMessage(msg);
                    this.frmList.CargarListadoUsuarios();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                var rpta = General.ConfirmationMessage($"¿Desea salir del formulario { this.Text }?");

                if (rpta == false)
                    return;

                this.Close();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Metodo

        public void Cargar(UI.Usuario uiUsuario)
        {
            try
            {
                this.uiUsuario = uiUsuario;

                this.txtUsuario.Text = this.uiUsuario.Username;
                this.txtNombre.Text = this.uiUsuario.Nombres;
                this.txtEmail.Text = this.uiUsuario.Email;

                this.txtContrasenha.Text = this.uiUsuario.Password;
                this.txtContrasenha2.Text = this.uiUsuario.Password;

                bool bloqueado = this.uiUsuario.Bloqueado ==  Entities.ActivoEnum.Si ? true : false;
                this.cbxBloqueado.Checked = bloqueado;

            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
            
        }

        private bool Insertar(ref UI.Usuario usuarioUi)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {

                    var usuarioBe = new Usuario();
                    usuarioBe.Name = usuarioUi.Username;
                    usuarioBe.Password = usuarioUi.Password;
                    usuarioBe.Nombre = usuarioUi.Nombres;
                    usuarioBe.Email = usuarioUi.Email;
                    usuarioBe.Bloqueado = usuarioUi.Bloqueado == UI.ActivoEnum.Si ? true : false;

                    db.Usuarios.Add(usuarioBe);

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

        private bool Actualizar(UI.Usuario usuarioUi)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    var usuarioBe = db.Usuarios.SingleOrDefault(b => b.Id == usuarioUi.ID);
                    if (usuarioBe != null)
                    {
                        usuarioBe.Name = usuarioUi.Username;
                        usuarioBe.Password = usuarioUi.Password;
                        usuarioBe.Nombre = usuarioUi.Nombres;
                        usuarioBe.Email = usuarioUi.Email;
                        usuarioBe.Bloqueado = usuarioUi.Bloqueado == UI.ActivoEnum.Si ? true : false ;

                        db.SaveChanges();

                        rpta = true;
                    }
                }

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
