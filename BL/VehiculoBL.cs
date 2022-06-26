using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using Framework;

namespace BL
{
    public class VehiculoBL
    {
        private List<Vehiculo> mLista = new List<Vehiculo>();
        
        public List<Vehiculo> ListarVehiculos()
        {
            return this.mLista;
        }

        public void AgregarVehiculo(Vehiculo pVehiculo)
        {
            this.mLista.Add(pVehiculo);
        }
        
    }
}
