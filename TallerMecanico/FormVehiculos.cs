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

        // AGREGAR TEXTBOX AL FORM DE DONDE SE TOMARAN LOS DATOS A MODIFICAR

        VehiculoBL mVehiculoBL = new VehiculoBL();

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

            grdVehiculos.Columns.Add("Patente", "Patente");
            grdVehiculos.Columns[0].DataPropertyName = "Patente";
            grdVehiculos.Columns.Add("Tipo", "Tipo");
            grdVehiculos.Columns[1].DataPropertyName = "TipoVehiculo";
            grdVehiculos.Columns.Add("Marca", "Marca");
            grdVehiculos.Columns[2].DataPropertyName = "Marca";
            grdVehiculos.Columns.Add("Modelo", "Modelo");
            grdVehiculos.Columns[3].DataPropertyName = "Modelo";
            grdVehiculos.Columns.Add("Id", "Id");
            grdVehiculos.Columns[4].DataPropertyName = "Id";
            #endregion

            cbVehiculos.DataSource = Enum.GetValues(typeof(Constantes.TipoVehiculo));
        }

        private void ActualizarGrid()
        {
            grdVehiculos.DataSource = null;
            grdVehiculos.DataSource = mVehiculoBL.ListarVehiculos();
            grdVehiculos.ClearSelection();
        }

        #region Métodos ABM Vehículo
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Constantes.TipoVehiculo TipoVehiculo = (Constantes.TipoVehiculo)cbVehiculos.SelectedItem;

            switch (TipoVehiculo)
            {
                case Constantes.TipoVehiculo.Automovil:
                    {
                        Automovil mAuto = new Automovil("Volkswagen", "Gol Trend", "MXQ368", TipoVehiculo, Constantes.TipoAutomovil.Compacto);
                        mVehiculoBL.AgregarVehiculo(mAuto);
                        break;
                    }
                case Constantes.TipoVehiculo.Moto:
                    {
                        Moto mMoto = new Moto("Bajaj", "Rouser 200", "AAA243", TipoVehiculo, 200);
                        mVehiculoBL.AgregarVehiculo(mMoto);
                        break;
                    }
            }

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
                Vehiculo mVehiculoSeleccionado = grdVehiculos.SelectedRows[0].DataBoundItem as Vehiculo;
                Vehiculo mVehiculoModificado = new Automovil(mVehiculoSeleccionado.Id, "Peugeot", "207", "KJS223", Constantes.TipoVehiculo.Automovil, Constantes.TipoAutomovil.Compacto);

                mVehiculoBL.ModificarVehiculo(mVehiculoSeleccionado, mVehiculoModificado);
                ActualizarGrid();
            }
        }
        #endregion
    }
}