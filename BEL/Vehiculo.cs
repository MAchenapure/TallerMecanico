using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace BEL
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public Constantes.TipoVehiculo TipoVehiculo { get; set; }

        public static int UltimoId = 0;

    }
}
