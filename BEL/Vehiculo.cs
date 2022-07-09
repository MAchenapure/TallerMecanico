using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace BEL
{
    public abstract class Vehiculo : IComparable<Vehiculo>
    {
        public static int UltimoId = 0;

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public List<Desperfecto> ListaDesperfectos = new List<Desperfecto>();
        public Constantes.TipoVehiculo TipoVehiculo { get; set; }

        public int CompareTo(Vehiculo? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
