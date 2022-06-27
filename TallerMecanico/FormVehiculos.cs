using BEL;
using BL;
using Framework;

namespace TallerMecanico
{
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        VehiculoBL mVehiculoBL = new VehiculoBL();


        #region Manejo del Form y Controles de usuario
        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            #region Configuración de grilla
            grdVehiculos.RowHeadersVisible = false;
            grdVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically;
            grdVehiculos.AllowUserToAddRows = false;
            grdVehiculos.AllowUserToDeleteRows = false;
            grdVehiculos.AllowUserToResizeColumns = false;
            grdVehiculos.MultiSelect = false;
            grdVehiculos.AutoGenerateColumns = false;
            grdVehiculos.ClearSelection();

            grdVehiculos.Columns.Add("Id", "Id");
            grdVehiculos.Columns[0].DataPropertyName = "Id";
            grdVehiculos.Columns.Add("Patente", "Patente");
            grdVehiculos.Columns[1].DataPropertyName = "Patente";
            grdVehiculos.Columns.Add("Tipo", "Tipo");
            grdVehiculos.Columns[2].DataPropertyName = "TipoVehiculo";
            grdVehiculos.Columns.Add("Marca", "Marca");
            grdVehiculos.Columns[3].DataPropertyName = "Marca";
            grdVehiculos.Columns.Add("Modelo", "Modelo");
            grdVehiculos.Columns[4].DataPropertyName = "Modelo";

            #endregion

            cbVehiculos.DataSource = Enum.GetValues(typeof(Constantes.TipoVehiculo));
            cbAutomovil.DataSource = Enum.GetValues(typeof(Constantes.TipoAutomovil));
        }
        private void ActualizarGrid()
        {
            grdVehiculos.DataSource = null;
            grdVehiculos.DataSource = mVehiculoBL.ListarVehiculos();
            grdVehiculos.ClearSelection();
        }
        private void MostrarControlesVehiculo()
        {
            if((Constantes.TipoVehiculo)cbVehiculos.SelectedIndex == Constantes.TipoVehiculo.Automovil)
            {
                lblCilindrada.Visible = false;
                numCilindrada.Visible=false;
                lblTipoAuto.Visible=true;
                cbAutomovil.Visible=true;
            } else if((Constantes.TipoVehiculo)cbVehiculos.SelectedIndex == Constantes.TipoVehiculo.Moto)
            {
                lblCilindrada.Visible = true;
                numCilindrada.Visible = true;
                lblTipoAuto.Visible = false;
                cbAutomovil.Visible = false;
            }
        }
        private void cbVehiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            MostrarControlesVehiculo();
        }
        #endregion

        #region ABM Vehículo
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Constantes.TipoVehiculo TipoVehiculo = (Constantes.TipoVehiculo)cbVehiculos.SelectedItem;
            string mMarca = tbMarca.Text;
            string mModelo = tbModelo.Text;
            string mPatente = tbPatente.Text;

            if(mMarca != "" && mModelo != "" && mPatente != "")
            {
                switch (TipoVehiculo)
                {
                    case Constantes.TipoVehiculo.Automovil:
                        {
                            Constantes.TipoAutomovil TipoAutomovil = (Constantes.TipoAutomovil)cbAutomovil.SelectedItem;
                            Automovil mAuto = new Automovil(mMarca, mModelo, mPatente, TipoVehiculo, TipoAutomovil);
                            //Automovil mAuto = new Automovil("Volkswagen", "Gol Trend", "MXQ368", TipoVehiculo, Constantes.TipoAutomovil.Compacto);
                            mVehiculoBL.AgregarVehiculo(mAuto);
                            break;
                        }
                    case Constantes.TipoVehiculo.Moto:
                        {
                            int mCilindrada = (int)numCilindrada.Value;
                            Moto mMoto = new Moto(mMarca, mModelo, mPatente, TipoVehiculo, mCilindrada);
                            //Moto mMoto = new Moto("Bajaj", "Rouser 200", "AAA243", TipoVehiculo, 200);
                            mVehiculoBL.AgregarVehiculo(mMoto);
                            break;
                        }
                }
            } else MessageBox.Show("No se ha podido cargar el Vehículo. Verifique si se completaron todos los campos para ingreso de datos.");

            ActualizarGrid();
        }   
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(grdVehiculos.SelectedRows.Count > 0)
            {
                Vehiculo mVehiculo = grdVehiculos.SelectedRows[0].DataBoundItem as Vehiculo;
                mVehiculoBL.EliminarVehiculo(mVehiculo);
                ActualizarGrid();
            } else
            {
                MessageBox.Show("No se seleccionaron filas");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdVehiculos.SelectedRows.Count > 0)
            {
                Constantes.TipoVehiculo TipoVehiculo = (Constantes.TipoVehiculo)cbVehiculos.SelectedItem;
                string mMarca = tbMarca.Text;
                string mModelo = tbModelo.Text;
                string mPatente = tbPatente.Text;

                Vehiculo mVehiculoSeleccionado = grdVehiculos.SelectedRows[0].DataBoundItem as Vehiculo;

                if(mVehiculoSeleccionado.TipoVehiculo == Constantes.TipoVehiculo.Automovil)
                {
                    Constantes.TipoAutomovil TipoAutomovil = (Constantes.TipoAutomovil)cbAutomovil.SelectedItem;
                    Vehiculo mVehiculoModificado = new Automovil(mVehiculoSeleccionado.Id, mMarca, mModelo, mPatente, mVehiculoSeleccionado.TipoVehiculo, TipoAutomovil);
                    mVehiculoBL.ModificarVehiculo(mVehiculoSeleccionado, mVehiculoModificado);

                } else if(mVehiculoSeleccionado.TipoVehiculo == Constantes.TipoVehiculo.Moto)
                {
                    int mCilindrada = (int)numCilindrada.Value;
                    Vehiculo mVehiculoModificado = new Moto(mVehiculoSeleccionado.Id, mMarca, mModelo, mPatente, mVehiculoSeleccionado.TipoVehiculo, mCilindrada);
                    mVehiculoBL.ModificarVehiculo(mVehiculoSeleccionado, mVehiculoModificado);
                }

                ActualizarGrid();
            }
        }
        #endregion

        private void grdVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if(grdVehiculos.SelectedRows.Count > 0)
            {
                Vehiculo mVehiculoSeleccionado = grdVehiculos.SelectedRows[0].DataBoundItem as Vehiculo;

                cbVehiculos.SelectedItem = mVehiculoSeleccionado.TipoVehiculo;
                tbMarca.Text = mVehiculoSeleccionado.Marca;
                tbModelo.Text = mVehiculoSeleccionado.Modelo;
                tbPatente.Text = mVehiculoSeleccionado.Patente;

                if (mVehiculoSeleccionado.TipoVehiculo == Constantes.TipoVehiculo.Automovil)
                {
                    cbAutomovil.SelectedItem = Constantes.TipoVehiculo.Automovil;
                } else if(mVehiculoSeleccionado.TipoVehiculo == Constantes.TipoVehiculo.Moto)
                {
                    cbAutomovil.SelectedItem = Constantes.TipoVehiculo.Moto;
                }
            }
        }
    }
}