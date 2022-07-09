using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Desperfecto
    {
        public static int UltimoId = 0;

        public Desperfecto(int pId, int pIdVehiculo, string pDescripcion, int pManoDeObra, int pTiempo)
        {
            Id = pId;
            IdVehiculo = pIdVehiculo;
            Descripcion = pDescripcion;
            ManoDeObra = pManoDeObra;
            Tiempo = pTiempo;
        }

        public Desperfecto(int pIdVehiculo, string pDescripcion, int pManoDeObra, int pTiempo)
        {
            UltimoId++;
            Id = UltimoId;
            IdVehiculo = pIdVehiculo;
            Descripcion = pDescripcion;
            ManoDeObra = pManoDeObra;
            Tiempo = pTiempo;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int ManoDeObra { get; set; }
        public int Tiempo { get; set; }
        public int IdVehiculo { get; set; }

        public List<IRepuesto> ListaRepuestos = new List<IRepuesto>();
    }
}
