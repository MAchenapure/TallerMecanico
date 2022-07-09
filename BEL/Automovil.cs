using Framework;

namespace BEL
{
    public class Automovil : Vehiculo
    {
        #region Constructores
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
        public Automovil(int id, string pMarca, string pModelo, string pPatente, Constantes.TipoVehiculo pTipoV, Constantes.TipoAutomovil pTipoA, List<Desperfecto> pListaDesperfectos)
        {
            Id = id;
            Marca = pMarca;
            Modelo = pModelo;
            Patente = pPatente;
            TipoVehiculo = pTipoV;
            TipoAutomovil = pTipoA;
            ListaDesperfectos = pListaDesperfectos;
        }
        #endregion

        public Constantes.TipoAutomovil TipoAutomovil { get; set; }
    }
}