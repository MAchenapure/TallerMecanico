using Framework;

namespace BEL
{
    public class Automovil : Vehiculo
    {
        public Automovil(int id, string pMarca, string pModelo, string pPatente, Constantes.TipoVehiculo pTipoV, Constantes.TipoAutomovil pTipoA)
        {
            Id = id;
            Marca = pMarca;
            Modelo = pModelo;
            Patente = pPatente;
            TipoVehiculo = pTipoV;
            TipoAutomovil = pTipoA;
        }

        public Automovil(string pMarca, string pModelo, string pPatente, Constantes.TipoVehiculo pTipoV, Constantes.TipoAutomovil pTipoA)
        {
            UltimoId++;
            Id = UltimoId;
            Marca = pMarca;
            Modelo = pModelo;
            Patente = pPatente;
            TipoVehiculo = pTipoV;
            TipoAutomovil = pTipoA;
        }
        public Constantes.TipoAutomovil TipoAutomovil { get; set; }
    }
}