using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BL
{
    public class RepuestoBL
    {
        RepuestoDAL mRepuestoDAL = new RepuestoDAL();
        public RepuestoBL()
        {
            Repuesto.ListaRepuestos = this.ListarRepuestos();
            Repuesto.UltimoId = mRepuestoDAL.ObtenerUltimoId("Repuesto");
        }

        public void AgregarRepuesto(Repuesto pRepuesto)
        {
            mRepuestoDAL.GuardarRepuesto(pRepuesto);
        }

        public void EliminarRepuesto(Repuesto pRepuesto)
        {
            mRepuestoDAL.EliminarRepuesto(pRepuesto);
        }

        private List<Repuesto> ListarRepuestos()
        {
            return mRepuestoDAL.ListarRepuestos();
        }
    }
}
