using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public interface IRepuesto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public void Agregar(IRepuesto pRepuesto);
        public void Eliminar(IRepuesto pRepuesto);
        public int PrecioTotal();
        public List<IRepuesto> ListarRepuestos();
    }
}
