using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace BEL
{
    public class Moto : Vehiculo
    {
        public Moto(string pMarca, string pModelo, string pPatente, Constantes.TipoVehiculo pTipoV, int pCilindrada)
        {
            UltimoId++;
            Id = UltimoId;
            Marca = pMarca;
            Modelo = pModelo;
            Patente = pPatente;
            TipoVehiculo = pTipoV;
            Cilindrada = pCilindrada;
        }
        public int Cilindrada { get; set; }

    }
}
