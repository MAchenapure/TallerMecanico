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
    public class DesperfectoDAL
    {
        DAO mDAO = new DAO();

        public void EliminarDesperfecto(Desperfecto pDesperfecto)
        {
            string commandString = "";
            commandString = "DELETE FROM Desperfecto WHERE Id_Desperfecto = @p1";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pDesperfecto.Id) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public void GuardarDesperfecto(Desperfecto pDesperfecto)
        {
            string commandString = "INSERT INTO [Desperfecto] (Id_Desperfecto, Id_Vehiculo, Descripcion_Desperfecto, Tiempo_Desperfecto, ManoDeObra_Desperfecto) VALUES (@p1, @p2, @p3, @p4, @p5)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pDesperfecto.Id), new SqlParameter("@p2", pDesperfecto.IdVehiculo), new SqlParameter("@p3", pDesperfecto.Descripcion), new SqlParameter("@p4", pDesperfecto.Tiempo), new SqlParameter("@p5", pDesperfecto.ManoDeObra) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public int ObtenerUltimoId(string pTabla)
        {
            return mDAO.ObtenerUltimoId(pTabla);
        }
        public List<Desperfecto> ListarDesperfectos(int pIdVehiculo)
        {
            List<Desperfecto> mLista = new List<Desperfecto>();
            DataSet mDs = new DataSet();
            string commandString = "SELECT * FROM [Desperfecto] WHERE Id_Vehiculo = @p1 ORDER BY Id_Desperfecto";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pIdVehiculo) };

            mDs = mDAO.ExecuteDataSet(commandString, paramArray);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in mDs.Tables[0].Rows)
                {
                    int mId = (int)dr["Id_Desperfecto"];
                    int mIdVehiculo = (int)dr["Id_Vehiculo"];
                    string mDescripcion = dr["Descripcion_Desperfecto"].ToString();
                    int mTiempo = (int)dr["Tiempo_Desperfecto"];
                    int mManoDeObra = (int)dr["ManoDeObra_Desperfecto"];

                    Desperfecto mDesperfecto = new Desperfecto(mId, mIdVehiculo, mDescripcion, mManoDeObra, mTiempo);

                    mLista.Add(mDesperfecto);
                }
            }
            return mLista;
        }
    }
}
