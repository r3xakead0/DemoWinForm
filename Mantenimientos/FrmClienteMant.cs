using System;
using System.Windows.Forms;
using Demo.Utiles;
using Demo.Dal;
using Demo.Model;
using UI = Demo.Entities;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;

namespace Demo.Mantenimientos
{
    public partial class FrmClienteMant : Form
    {

        #region "Patron Singleton"

        private static FrmClienteMant frmInstance = null;

        public static FrmClienteMant Instance()
        {

            if (frmInstance == null || frmInstance.IsDisposed == true)
            {
                frmInstance = new FrmClienteMant();
            }

            frmInstance.BringToFront();

            return frmInstance;
        }

        #endregion

        public FrmClienteList frmList = null;
        private UI.Cliente clienteUi = null;

        public FrmClienteMant()
        {
            try
            {
                InitializeComponent();

                this.clienteUi = new UI.Cliente();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }

        }

        #region Formulario

        private void FrmClienteMant_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarListadoDocumentos();
                this.CargarListadoSexos();
                this.Limpiar();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validaciones del formulario

                if (this.txtCodigo.Text.Trim().Length == 0)
                {
                    this.txtCodigo.Focus();
                    throw new Exception("Ingrese el codigo del Cliente");
                }

                if (this.txtNombres.Text.Trim().Length == 0)
                {
                    this.txtNombres.Focus();
                    throw new Exception("Ingrese los nombres del Cliente");
                }

                if (this.txtApellidos.Text.Trim().Length == 0)
                {
                    this.txtApellidos.Focus();
                    throw new Exception("Ingrese los apellidos del Cliente");
                }

                if (this.cboDocumento.SelectedIndex == 0)
                {
                    this.cboDocumento.Focus();
                    throw new Exception("Seleccione el documento del Cliente");
                }

                if (this.txtNroDocumento.Text.Trim().Length == 0)
                {
                    this.txtNroDocumento.Focus();
                    throw new Exception("Ingrese el numero de documento del Cliente");
                }

                if (this.cboSexo.SelectedIndex == 0)
                {
                    this.cboSexo.Focus();
                    throw new Exception("Seleccione el sexo del Cliente");
                }

                #endregion

                #region Guardar

                this.clienteUi.Codigo = this.txtCodigo.Text.Trim();
                this.clienteUi.Nombres = this.txtNombres.Text.Trim();
                this.clienteUi.Apellidos = this.txtApellidos.Text.Trim();

                UI.Documento documentoUi = (UI.Documento)this.cboDocumento.SelectedItem;
                this.clienteUi.DocumentoId = documentoUi.Id;
                this.clienteUi.DocumentoNombre = documentoUi.Nombre;

                this.clienteUi.NroDocumento = this.txtNroDocumento.Text.Trim();
                this.clienteUi.Activo = this.chkActivo.Checked == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;

                this.clienteUi.FechaNacimiento = this.dtpFechaNacimiento.Value;
                UI.SexoEnum sexo;
                if (Enum.TryParse<UI.SexoEnum>(this.cboSexo.SelectedValue.ToString(), out sexo))
                    this.clienteUi.Sexo = sexo;

                bool rpta = false;
                string msg = "";
         
                if (this.clienteUi.ID == 0) //Nuevo
                {
                    rpta = Insertar(ref this.clienteUi);
                    if (rpta)
                        msg = "Se registro una nuevo Cliente";
                }
                else  //Actualizar
                {
                    rpta = Actualizar(this.clienteUi);
                    if (rpta)
                        msg = "Se actualizo la Cliente";
                }

                if (rpta == true)
                {
                    General.InformationMessage(msg);
                    this.frmList.CargarListadoClientes();
                    this.Close();
                }
                    
                #endregion

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

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtEdad.Text = this.ObtenerEdad(this.dtpFechaNacimiento.Value).ToString();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Metodos

        private int ObtenerEdad(DateTime fechaNacimiento)
        {
            int edad = 0;
            try
            {
                var hoy = DateTime.UtcNow;
                edad = hoy.Year - fechaNacimiento.Year;

                if (fechaNacimiento > hoy.AddYears(-edad)) edad--;

                return edad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<UI.Documento> ListarDocumentos()
        {
            var lstDocumentoUi = new List<UI.Documento>();
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    List<Documento> lstDocumentoBe = db.Documentos.Where(x => x.Activo == true).ToList();

                    foreach (Documento documentoBe in lstDocumentoBe)
                    {
                        var documentoIdentidadUi = new UI.Documento();

                        documentoIdentidadUi.Id = documentoBe.Id;
                        documentoIdentidadUi.Nombre = documentoBe.Nombre;
                        documentoIdentidadUi.Descripcion = documentoBe.Descripcion;
                        documentoIdentidadUi.Activo = documentoBe.Activo == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;

                        lstDocumentoUi.Add(documentoIdentidadUi);
                    }
                }

                return lstDocumentoUi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Insertar(ref UI.Cliente clienteUi)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {

                    var clienteBe = new Cliente();

                    clienteBe.Codigo = clienteUi.Codigo;
                    clienteBe.Nombres = clienteUi.Nombres;
                    clienteBe.Apellidos = clienteUi.Apellidos;

                    var documentoBe = db.Documentos.Find(clienteUi.DocumentoId);
                    if (documentoBe != null)
                    {
                        clienteBe.Documento = documentoBe;
                        clienteBe.DocumentoId = documentoBe.Id;
                    }
                    clienteBe.NroDocumento = clienteUi.NroDocumento;

                    clienteBe.FechaNacimiento = clienteUi.FechaNacimiento;
                    clienteBe.Sexo = clienteUi.Sexo == UI.SexoEnum.Masculino ? "M" : "F";

                    clienteBe.Activo = clienteUi.Activo == UI.ActivoEnum.Si ? true : false;

                    db.Clientes.Add(clienteBe);

                    db.SaveChanges();

                    clienteUi.ID = clienteBe.Id;
                    rpta = true;
                }

                return rpta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Actualizar(UI.Cliente clienteUi)
        {
            bool rpta = false;
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    var clienteBe = db.Clientes.Find(clienteUi.ID);
                    if (clienteBe != null)
                    {

                        clienteBe.Id = clienteUi.ID;
                        clienteBe.Codigo = clienteUi.Codigo;
                        clienteBe.Nombres = clienteUi.Nombres;
                        clienteBe.Apellidos = clienteUi.Apellidos;
                       
                        var documentoBe = db.Documentos.Find(clienteUi.DocumentoId);
                        if (documentoBe != null)
                        {
                            clienteBe.Documento = documentoBe;
                            clienteBe.DocumentoId = documentoBe.Id;
                        }
                        clienteBe.NroDocumento = clienteUi.NroDocumento;

                        clienteBe.FechaNacimiento = clienteUi.FechaNacimiento;
                        clienteBe.Sexo = clienteUi.Sexo == UI.SexoEnum.Masculino ? "M" : "F";

                        clienteBe.Activo = clienteUi.Activo == UI.ActivoEnum.Si ? true : false;

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

        public void Cargar(UI.Cliente clienteUi)
        {
            try
            {

                this.clienteUi = clienteUi;

                this.txtCodigo.Text = this.clienteUi.Codigo;
                this.txtNombres.Text = this.clienteUi.Nombres;
                this.txtApellidos.Text = this.clienteUi.Apellidos;
                this.cboDocumento.SelectedValue = this.clienteUi.DocumentoId;
                this.txtNroDocumento.Text = this.clienteUi.NroDocumento;
                this.dtpFechaNacimiento.Value = this.clienteUi.FechaNacimiento;
                //this.txtEdad.Text = this.ObtenerEdad(this.clienteUi.FechaNacimiento).ToString();

                var sexo = (UI.SexoEnum)Enum.Parse(typeof(UI.SexoEnum), this.clienteUi.Sexo.ToString());
                this.cboSexo.SelectedItem = sexo;

                this.chkActivo.Checked = this.clienteUi.Activo == UI.ActivoEnum.Si ? true : false;

            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }

        }


        private void Limpiar()
        {
            try
            {
                //Limpiar objeto
                this.clienteUi = new UI.Cliente();

                //Limpiar controles de edicion
                this.txtCodigo.Clear();
                this.txtNombres.Clear();
                this.txtApellidos.Clear();

                this.cboDocumento.SelectedIndex = 0;
                this.txtNroDocumento.Clear();

                this.dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
                this.txtEdad.Text = "18";
                this.cboSexo.SelectedIndex = 0;

                this.chkActivo.Checked = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarListadoDocumentos()
        {
            try
            {
                var lstDocumentoUi = this.ListarDocumentos();
                lstDocumentoUi.Insert(0, new UI.Documento() { Id = 0, Nombre = "Seleccione" });

                this.cboDocumento.DataSource = lstDocumentoUi;
                this.cboDocumento.DisplayMember = "Nombre";
                this.cboDocumento.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarListadoSexos()
        {
            try
            {
                this.cboSexo.DataSource = Enum.GetValues(typeof(UI.SexoEnum));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        
    }
}
