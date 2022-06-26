using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Desperfecto
    {
        public string Descripcion { get; set; }
        public int ManoDeObra { get; set; }
        public int Tiempo { get; set; }
        public Presupuesto mPresupuesto { get; set; }

        public List<Repuesto> ListaRepuestos = new List<Repuesto>();
    }
}
