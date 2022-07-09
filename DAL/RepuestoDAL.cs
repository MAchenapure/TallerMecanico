using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class RepuestoDAL
    {
        DAO mDAO = new DAO();

        public void GuardarRepuesto(IRepuesto pRepuesto, int pIdDesperfecto)
        {
            if(pRepuesto == typeof(RepuestoCompuesto))
            {
                string commandString = "INSERT INTO [Repuesto] (Id_Repuesto, Descripcion_Repuesto, Precio_Repuesto) VALUES (@p1, @p2, @p3)";
                SqlParameter[] paramArray = { new SqlParameter("@p1", pRepuesto.Id), new SqlParameter("@p2", pRepuesto.Descripcion), new SqlParameter("@p3", pRepuesto.Precio) };
                mDAO.ExecuteNonQuery(commandString, paramArray);
            }
        }
    }
}
