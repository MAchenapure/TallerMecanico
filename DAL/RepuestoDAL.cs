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

        public void EliminarRepuesto(Repuesto pRepuesto)
        {
            string commandString = "DELETE FROM [Repuesto] WHERE Id_Repuesto = @p1";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pRepuesto.Id) };
            mDAO.ExecuteNonQuery(commandString, paramArray);

            commandString = "DELETE FROM [Desperfecto_Repuesto] WHERE Id_Repuesto = @p1";
            SqlParameter[] paramArray2 = { new SqlParameter("@p1", pRepuesto.Id) };
            mDAO.ExecuteNonQuery(commandString, paramArray2);
        }

        public void GuardarRepuesto(Repuesto pRepuesto)
        {
            string commandString = "INSERT INTO [Repuesto] (Id_Repuesto, Descripcion_Repuesto, Precio_Repuesto) VALUES (@p1, @p2, @p3)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pRepuesto.Id), new SqlParameter("@p2", pRepuesto.Descripcion), new SqlParameter("@p3", pRepuesto.Precio) };
            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public List<Repuesto> ListarRepuestos()
        {
            List<Repuesto> mLista = new List<Repuesto>();
            DataSet mDs = new DataSet();
            string commandString = "SELECT * FROM [Repuesto] ORDER BY Repuesto.Id_Repuesto;";

            mDs = mDAO.ExecuteDataSet(commandString);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in mDs.Tables[0].Rows)
                {
                    int mId = (int)dr["Id_Repuesto"];
                    string mDescripcion = dr["Descripcion_Repuesto"].ToString();
                    int mPrecio= (int)dr["Precio_Repuesto"];

                    Repuesto mRepuesto = new Repuesto(mId, mDescripcion, mPrecio);
                    mLista.Add(mRepuesto);
                }
            }

            return mLista;
        }
        public int ObtenerUltimoId(string pTabla)
        {
            return mDAO.ObtenerUltimoId(pTabla);
        }
    }
}
