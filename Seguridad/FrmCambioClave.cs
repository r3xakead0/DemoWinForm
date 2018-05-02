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
    public partial class FrmCambioClave : Form
    {

        #region "Patron Singleton"

        private static FrmCambioClave frmInstance = null;

        public static FrmCambioClave Instance()
        {

            if (frmInstance == null || frmInstance.IsDisposed == true)
            {
                frmInstance = new FrmCambioClave();
            }

            frmInstance.BringToFront();

            return frmInstance;
        }

        #endregion

        public FrmCambioClave()
        {
            try
            {
                InitializeComponent();

            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
            
        }

        #region Formulario

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones

                if (this.txtClaveActual.Text.Trim().Length == 0)
                {
                    this.txtClaveActual.Focus();
                    throw new Exception("Ingrese la clave actual");
                }

                if (this.txtClaveNueva.Text.Trim().Length == 0)
                {
                    this.txtClaveNueva.Focus();
                    throw new Exception("Ingrese la nueva clave");
                }

                if (this.txtClaveRepetir.Text.Trim().Length == 0)
                {
                    this.txtClaveRepetir.Focus();
                    throw new Exception("Ingrese repetivamente la nueva clave");
                }

                if (this.txtClaveNueva.Text.Trim() != this.txtClaveRepetir.Text.Trim())
                {
                    this.txtClaveNueva.Focus();
                    throw new Exception("La nueva clave no coincide");
                }

                #endregion

                string claveActual = this.txtClaveActual.Text;
                string claveNueva = this.txtClaveNueva.Text;
                string claveRepetida = this.txtClaveRepetir.Text;

                var uiUsuario = ((MdiMain)this.MdiParent).uiUsuario;
                uiUsuario.Password = claveNueva;

                var beUsuario = Validar(uiUsuario.Username, uiUsuario.Password);
                if (beUsuario == null)
                {
                    this.txtClaveActual.Focus();
                    throw new Exception("La clave actual es incorrecta");
                }

                bool rpta = ActualizarClave(uiUsuario.ID, uiUsuario.Password);
                if (rpta == true)
                {
                    General.InformationMessage("Se cambio la clave del usuario");
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
                this.Close();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Metodos

        private UI.Usuario Validar(string usuario, string clave)
        {
            UI.Usuario usuarioUI = null;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    var usuarioBE = db.Usuarios.Where(x => x.Name == usuario
                                                 && x.Password == clave).FirstOrDefault();

                    if (usuarioBE != null)
                    {
                        usuarioUI = new UI.Usuario();
                        usuarioUI.ID = usuarioBE.Id;
                        usuarioUI.Username = usuarioBE.Name;
                        usuarioUI.Password = usuarioBE.Password;
                        usuarioUI.Nombres = usuarioBE.Nombre;
                        usuarioUI.Email = usuarioBE.Email;
                        usuarioUI.Bloqueado = usuarioBE.Bloqueado == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;
                    }
                }

                return usuarioUI;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ActualizarClave(int id, string clave)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    var result = db.Usuarios.SingleOrDefault(b => b.Id == id);
                    if (result != null)
                    {
                        result.Password = clave;
                        db.SaveChanges();
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
