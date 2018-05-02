using System;
using System.Windows.Forms;
using Demo.Utiles;
using Demo.Dal;
using Demo.Model;
using UI = Demo.Entities;
using BE = Demo.Model;
using System.Collections.Generic;
using System.Linq;
using LINQtoCSV;
using System.Text;
using System.IO;

namespace Demo.Mantenimientos
{
    public partial class FrmClienteList : Form
    {

        #region "Patron Singleton"

        private static FrmClienteList frmInstance = null;

        public static FrmClienteList Instance()
        {

            if (frmInstance == null || frmInstance.IsDisposed == true)
            {
                frmInstance = new FrmClienteList();
            }

            frmInstance.BringToFront();

            return frmInstance;
        }

        #endregion

        private int lastRowIndex = 0;
        private List<UI.Cliente> lstClienteUi = null;

        public FrmClienteList()
        {
            InitializeComponent();
        }

        #region Formulario

        private void FrmClienteList_Load(object sender, EventArgs e)
        {
            try
            {
                this.lstClienteUi = new List<UI.Cliente>();

                this.CargarListadoClientes();
                this.FormatoListadoClientes();

                this.CargarComboFiltros();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void FrmClienteList_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                General.AutoWidthColumn(ref this.dgvClientes, "Nombres");
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

                lastRowIndex = this.dgvClientes.Rows.Count;

                var frmClienteMant = FrmClienteMant.Instance();
                frmClienteMant.MdiParent = this.MdiParent;
                frmClienteMant.Show();

                frmClienteMant.frmList = this;

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
                if (this.dgvClientes.CurrentRow != null)
                {
                    lastRowIndex = this.dgvClientes.CurrentRow.Index;

                    var uiCliente = (UI.Cliente)this.dgvClientes.CurrentRow.DataBoundItem;
                    this.Editar(uiCliente);
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
                if (this.dgvClientes.CurrentRow != null)
                {

                    if (General.ConfirmationMessage("¿Desea eliminar la Cliente seleccionada?") == false)
                        return;

                    var uiCliente = (UI.Cliente)this.dgvClientes.CurrentRow.DataBoundItem;

                    bool rpta = Eliminar(uiCliente.ID);

                    if (rpta == true)
                    {
                        lastRowIndex = this.dgvClientes.Rows.Count - 2;
                        if (lastRowIndex < 0)
                            lastRowIndex = 0;
                        this.CargarListadoClientes();

                        General.InformationMessage("Se eliminó la Cliente seleccionada");
                    }
                }
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            try
            {

                string archivoCsv = $"Clientes_{ DateTime.Now.ToString("yyyyMMdd")}.csv";
                string rutaCsv = Directory.GetCurrentDirectory();

                fbdExportarCsv.Description = $"Seleccione el destino del archivo {archivoCsv}";
                fbdExportarCsv.SelectedPath = rutaCsv;

                DialogResult result = fbdExportarCsv.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdExportarCsv.SelectedPath))
                {
                    rutaCsv = fbdExportarCsv.SelectedPath;

                    string archivo = Path.Combine(rutaCsv, archivoCsv);

                    this.ExportarCsv(archivo);

                    General.InformationMessage("Se exporto los datos de Clientes");
                }
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                    return;

                lastRowIndex = e.RowIndex;

                var uiCliente = (UI.Cliente)this.dgvClientes.CurrentRow.DataBoundItem;
                this.Editar(uiCliente);

            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void cboFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (this.cboFiltro.SelectedIndex == 0)
                    this.txtFiltro.Clear();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarListadoClientes();
            }
            catch (Exception ex)
            {
                General.ErrorMessage(ex.Message);
            }
        }

        #endregion

        #region Metodos

        private void ExportarCsv(string archivo)
        {
            try
            {

                CsvFileDescription outputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = true,
                    TextEncoding = Encoding.ASCII,
                    EnforceCsvColumnAttribute = true
                };
                CsvContext cc = new CsvContext();
                cc.Write(this.lstClienteUi, archivo, outputFileDescription);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<UI.Cliente> ListarClientes()
        {
            var lstClienteUi = new List<UI.Cliente>();
            try
            {
                using (DemoContext db = new DemoContext())
                {
                    List<BE.Cliente> lstClienteBe = db.Clientes.ToList();

                    foreach (BE.Cliente clienteBe in lstClienteBe)
                    {
                        var clienteUi = new UI.Cliente();

                        clienteUi.ID = clienteBe.Id;
                        clienteUi.Codigo = clienteBe.Codigo;
                        clienteUi.Nombres = clienteBe.Nombres;
                        clienteUi.Apellidos = clienteBe.Apellidos;
                        clienteUi.FechaNacimiento = clienteBe.FechaNacimiento;
                        clienteUi.Sexo = clienteBe.Sexo == "M" ? UI.SexoEnum.Masculino : UI.SexoEnum.Femenino;
                        clienteUi.Activo = clienteBe.Activo == true ? UI.ActivoEnum.Si : UI.ActivoEnum.No;

                        var documentoBe = db.Documentos.Find(clienteBe.DocumentoId);
                        if (documentoBe != null)
                        {
                            clienteUi.DocumentoId = documentoBe.Id;
                            clienteUi.DocumentoNombre = documentoBe.Nombre;
                        }
                        clienteUi.NroDocumento = clienteBe.NroDocumento;

                        lstClienteUi.Add(clienteUi);
                    }
                }

                return lstClienteUi;
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
                    Cliente ClienteBE = db.Clientes.First(b => b.Id == id);
                    db.Clientes.Remove(ClienteBE);
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

        private void Editar(UI.Cliente uiCliente)
        {
            try
            {
                var frmClienteMant = FrmClienteMant.Instance();
                frmClienteMant.MdiParent = this.MdiParent;
                frmClienteMant.Show();

                frmClienteMant.frmList = this;
                frmClienteMant.Cargar(uiCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarListadoClientes()
        {
            try
            {
                General.PointerLoad(this);

                this.lstClienteUi = this.ListarClientes();

                if (this.cboFiltro.SelectedIndex > 0)
                {
                    string filtro = this.cboFiltro.SelectedValue.ToString();
                    string buscar = this.txtFiltro.Text;

                    if (buscar.Length > 0)
                    {
                        this.lastRowIndex = 0;
                        lstClienteUi = lstClienteUi.Where(x => x.GetType().GetProperty(filtro).GetValue(x).ToString().ToUpper().StartsWith(buscar.ToUpper())).ToList();
                    }
                }

                this.txtNroRegistros.Text = lstClienteUi.Count.ToString();

                var sorted = new SortableBindingList<UI.Cliente>(lstClienteUi);
                this.dgvClientes.DataSource = sorted;

                if (lstClienteUi.Count > 0)
                {
                    this.dgvClientes.CurrentCell = this.dgvClientes.Rows[lastRowIndex].Cells["Nombres"];
                    this.dgvClientes.Rows[lastRowIndex].Selected = true;
                    this.dgvClientes.FirstDisplayedScrollingRowIndex = lastRowIndex;
                    this.dgvClientes.Update();
                }
 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                General.PointerReady(this);
            }
        }

        public void FormatoListadoClientes()
        {
            try
            {
                General.FormatDatagridview(ref this.dgvClientes);

                for (int i = 0; i < this.dgvClientes.Columns.Count; i++)
                    this.dgvClientes.Columns[i].Visible = false;

                this.dgvClientes.Columns["Codigo"].Visible = true;
                this.dgvClientes.Columns["Codigo"].HeaderText = "Codigo";
                this.dgvClientes.Columns["Codigo"].Width = 100;
                this.dgvClientes.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvClientes.Columns["Nombres"].Visible = true;
                this.dgvClientes.Columns["Nombres"].HeaderText = "Nombres";
                this.dgvClientes.Columns["Nombres"].Width = 150;
                this.dgvClientes.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvClientes.Columns["Apellidos"].Visible = true;
                this.dgvClientes.Columns["Apellidos"].HeaderText = "Apellidos";
                this.dgvClientes.Columns["Apellidos"].Width = 150;
                this.dgvClientes.Columns["Apellidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvClientes.Columns["NroDocumento"].Visible = true;
                this.dgvClientes.Columns["NroDocumento"].HeaderText = "Nro Documento";
                this.dgvClientes.Columns["NroDocumento"].Width = 100;
                this.dgvClientes.Columns["NroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                this.dgvClientes.Columns["Activo"].Visible = true;
                this.dgvClientes.Columns["Activo"].HeaderText = "Activo";
                this.dgvClientes.Columns["Activo"].Width = 70;
                this.dgvClientes.Columns["Activo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                General.AutoWidthColumn(ref this.dgvClientes, "Nombres");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboFiltros()
        {
            try
            {
                var lstGenericoUi = new List<UI.Generico>();
                lstGenericoUi.Add(new UI.Generico() { Codigo = "", Nombre = "Todos" });

                for (int i = 0; i < this.dgvClientes.Columns.Count; i++)
                {
                    if (this.dgvClientes.Columns[i].Visible == true)
                    {
                        string nombre = this.dgvClientes.Columns[i].Name;
                        string texto = this.dgvClientes.Columns[i].HeaderText;

                        lstGenericoUi.Add(new UI.Generico() { Codigo = nombre, Nombre = texto });
                    }
                }

                this.cboFiltro.DataSource = lstGenericoUi;
                this.cboFiltro.DisplayMember = "Nombre";
                this.cboFiltro.ValueMember = "Codigo";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}
