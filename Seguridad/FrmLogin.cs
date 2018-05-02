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
    public partial class FrmLogin : Form
    {
        private bool accedio = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private UI.Usuario Validar(string usuario, string clave)
        {
            UI.Usuario usuarioUi = null;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    var usuarioBe = db.Usuarios.SingleOrDefault(x => x.Name == usuario
                                                 && x.Password == clave);

                    if (usuarioBe != null)
                    {
                        usuarioUi = new UI.Usuario();
                        usuarioUi.ID = usuarioBe.Id;
                        usuarioUi.Username = usuarioBe.Name;
                        usuarioUi.Password = usuarioBe.Password;
                        usuarioUi.Nombres = usuarioBe.Nombre;
                        usuarioUi.Email = usuarioBe.Email;
                        usuarioUi.Bloqueado = usuarioBe.Bloqueado == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;
                    }
                }

                return usuarioUi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.txtUsuario.Text.Trim();
                string password = this.txtContrasena.Text.Trim();

                var uiUsuario = Validar(username, password);

                if (uiUsuario == null)
                {
                    General.InformationMessage("Usuario y/o contraseña incorrectas");
                }
                else
                {
                    var mdi = ((MdiMain)this.MdiParent);
                    mdi.Acceso(uiUsuario);
                    accedio = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (accedio == false)
                {
                    Application.Exit();
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
                this.Close();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }
    }
}
