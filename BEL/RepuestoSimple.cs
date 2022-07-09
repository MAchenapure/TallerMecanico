using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RepuestoSimple : IRepuesto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        #region Implementación IRepuesto
        public void Agregar(IRepuesto pRepuesto)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(IRepuesto pRepuesto)
        {
            throw new NotImplementedException();
        }

        public List<IRepuesto> ListarRepuestos()
        {
            return null;
        }

        public int PrecioTotal()
        {
            return Precio;
        }
        #endregion
    }
}
