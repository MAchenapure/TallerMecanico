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

        // Agregar repuesto debería estar en RepuestoBL
        public void AgregarRepuesto(Desperfecto pDesperfecto, RepuestoCompuesto pRepuesto)
        {
            pDesperfecto.ListaRepuestos.Add(pRepuesto);
        }
        
        // Crear Presupuesto debería estar en PresupuestoBL
        public void CrearPresupuesto(Desperfecto pDesperfecto)
        {
            Presupuesto mPresupuesto = new Presupuesto();
        }

        public void EliminarDesperfecto(Desperfecto pDesperfecto)
        {
            mDesperfectoDAL.EliminarDesperfecto(pDesperfecto);
        }
    }
}