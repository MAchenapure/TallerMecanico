using BEL;
using DAL;

namespace BL
{
    public class DesperfectoBL
    {
        DesperfectoDAL mDesperfectoDAL = new DesperfectoDAL();

        public DesperfectoBL()
        {
            Desperfecto.UltimoId = mDesperfectoDAL.ObtenerUltimoId("Desperfecto");
        }
        
        public void AgregarDesperfecto(Desperfecto pDesperfecto) 
        {
            mDesperfectoDAL.GuardarDesperfecto(pDesperfecto);
        }

        public void AgregarRepuesto(Repuesto pRepuesto, Desperfecto pDesperfecto)
        {
            mDesperfectoDAL.AgregarRepuesto(pDesperfecto.Id, pRepuesto.Id);
        }

        public void EliminarDesperfecto(Desperfecto pDesperfecto)
        {
            mDesperfectoDAL.EliminarDesperfecto(pDesperfecto);
        }
    }
}