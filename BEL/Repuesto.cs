using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Repuesto
    {
        public static List<Repuesto> ListaRepuestos = new List<Repuesto>();
        public static int UltimoId = 0;

        public Repuesto(int pId, string pDescripcion, int pPrecio)
        {
            Id = pId;
            Descripcion = pDescripcion;
            Precio = pPrecio;
        }
        public Repuesto(string pDescripcion, int pPrecio)
        {
            UltimoId++;
            Id = UltimoId;
            Descripcion = pDescripcion;
            Precio = pPrecio;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}
