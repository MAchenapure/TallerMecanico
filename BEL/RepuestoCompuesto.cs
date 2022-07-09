using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class RepuestoCompuesto : IRepuesto, IEnumerable<IRepuesto>
    {
        private List<IRepuesto> mRepuestos = new List<IRepuesto>();
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        #region Implementación IRepuesto
        public void Agregar(IRepuesto pRepuesto)
        {
            mRepuestos.Add(pRepuesto);
        }
        public void Eliminar(IRepuesto pRepuesto)
        {
            mRepuestos.Remove(pRepuesto);
        }
        public List<IRepuesto> ListarRepuestos()
        {
            return this.mRepuestos;
        }
        public int PrecioTotal()
        {
            int mPrecioTotal = 0;
            foreach (RepuestoSimple repuesto in this)
                mPrecioTotal += repuesto.PrecioTotal();
            return mPrecioTotal;

        }
        #endregion

        #region Implementación IEnumerable
        public IEnumerator<IRepuesto> GetEnumerator()
        {
            return mRepuestos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mRepuestos.GetEnumerator();
        }

        #endregion
    }
}
