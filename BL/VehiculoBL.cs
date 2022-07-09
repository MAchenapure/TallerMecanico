using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using Framework;

namespace BL
{
    public class VehiculoBL
    {
        public VehiculoBL()
        {
            Vehiculo.UltimoId = mVehiculoDAL.ObtenerUltimoId("Vehiculo");
        }

        VehiculoDAL mVehiculoDAL = new VehiculoDAL();

        public void AgregarAutomovil(Automovil pAutomovil)
        {
            mVehiculoDAL.GuardarAutomovil(pAutomovil);
        }
        public void AgregarMoto(Moto pMoto)
        {
            mVehiculoDAL.GuardarMoto(pMoto);
        }
        public void EliminarVehiculo(Vehiculo pVehiculo)
        {
            mVehiculoDAL.EliminarVehiculo(pVehiculo);
        }
        public void ModificarAutomovil(Automovil pAuto)
        {
            mVehiculoDAL.ModificarVehiculo(pAuto);
            mVehiculoDAL.ModificarAutomovil(pAuto);
        }
        public void ModificarMoto(Moto pMoto)
        {
            mVehiculoDAL.ModificarVehiculo(pMoto);
            mVehiculoDAL.ModificarMoto(pMoto);
        }
        public List<Desperfecto> ListarDesperfectos(Vehiculo pVehiculo)
        {
            // BORRAR ESTA LISTA, TIENE QUE VENIR DESDE DAL.
            List<Desperfecto> mLista = new List<Desperfecto>();
            return mLista;
        }
        public List<Vehiculo> ListarVehiculos()
        {
            return mVehiculoDAL.ListarVehiculos();
        }
    }
}
