using BEL;

namespace BL
{
    public class DesperfectoBL
    {
        public void Persistir(Desperfecto pDesperfecto) { }
        public void AgregarRepuesto(Desperfecto pDesperfecto, Repuesto pRepuesto)
        {
            pDesperfecto.ListaRepuestos.Add(pRepuesto);
        }
        public void CrearPresupuesto(Desperfecto pDesperfecto) {
            Presupuesto mPresupuesto = new Presupuesto();
        }





    }
}