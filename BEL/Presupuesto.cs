using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Presupuesto
    {
        public Presupuesto(Desperfecto pDesperfecto, Vehiculo pVehiculo)
        {
            FechaEmision = DateTime.Now;
            mVehiculo = pVehiculo;
            PrecioTotal = ObtenerPrecioTotal(pDesperfecto);
        }

        public DateTime FechaEmision { get; set; }
        public double PrecioTotal { get; set; }
        private Vehiculo mVehiculo { get; set; }

        internal double ObtenerPrecioTotal(Desperfecto pDesperfecto)
        {
            double mPrecioTotal = 0;
            double mCostoRepuestos = 0;
            int mCostoManoDeObra = pDesperfecto.ManoDeObra * pDesperfecto.Tiempo;
            int mDiasTrabajo = (pDesperfecto.Tiempo / 8) + 1;
            int mCostoPorDias = mDiasTrabajo * 30;
            double mRecargoTaller = 1.1;

            foreach (Repuesto mRepuesto in pDesperfecto.ListaRepuestos)
            {
                mCostoRepuestos += mRepuesto.Precio;
            }

            // REGLAS DE NEGOCIO
            if (mVehiculo.GetType() == typeof(Automovil))
            {
                Automovil mAuto = (Automovil)mVehiculo;

                if (mAuto.TipoAutomovil == Framework.Constantes.TipoAutomovil.Utilitario)
                {
                    mCostoManoDeObra = Convert.ToInt32(mCostoManoDeObra * 0.85);
                } 
                else if(mAuto.TipoAutomovil == Framework.Constantes.TipoAutomovil.Lujo)
                {
                    mCostoRepuestos = mCostoRepuestos * 1.1;                   
                }
                else if(mAuto.TipoAutomovil == Framework.Constantes.TipoAutomovil.Compacto)
                {
                    mCostoPorDias = mDiasTrabajo * 10;
                }
            }

            if (mVehiculo.GetType() == typeof(Moto)) {
                mCostoPorDias = mDiasTrabajo * 5;
            } 
            
            mPrecioTotal = (mCostoRepuestos + mCostoManoDeObra + mCostoPorDias) * mRecargoTaller;

            return mPrecioTotal;
        }

    }
}
