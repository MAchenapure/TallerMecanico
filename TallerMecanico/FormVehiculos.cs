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
            ActualizarGrid();
            cbVehiculos.DataSource = Enum.GetValues(typeof(Constantes.TipoVehiculo));
        }

        VehiculoBL mVehiculoBL = new VehiculoBL();

        public void ActualizarGrid()
        {
            grdVehiculos.DataSource = null;
            grdVehiculos.DataSource = mVehiculoBL.ListarVehiculos();
        }

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
    }
}