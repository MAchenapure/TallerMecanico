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

        public void AgregarRepuesto(int pIdDesperfecto, int pIdRepuesto)
        {
            string commandString = "INSERT INTO [Desperfecto_Repuesto] (Id_Desperfecto, Id_Repuesto) VALUES (@p1, @p2)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pIdDesperfecto), new SqlParameter("@p2", pIdRepuesto) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public void EliminarDesperfecto(Desperfecto pDesperfecto)
        {
            EliminarRepuesto(pDesperfecto);

            string commandString = "DELETE FROM [Desperfecto] WHERE Id_Desperfecto = @p1";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pDesperfecto.Id) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public void EliminarDesperfecto(int pIdVehiculo)
        {
            EliminarRepuesto(pIdVehiculo);

            string commandString = "DELETE FROM [Desperfecto] WHERE Id_Vehiculo = @p1";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pIdVehiculo) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }


        public void EliminarRepuesto(Desperfecto pDesperfecto)
        {
            string commandString = "DELETE FROM [Desperfecto_Repuesto] WHERE Id_Desperfecto = @p1";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pDesperfecto.Id) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public void EliminarRepuesto(int pIdVehiculo)
        {
            string commandString = "DELETE T1 FROM [Desperfecto_Repuesto] As T1 INNER JOIN Desperfecto As T2 ON T2.Id_Vehiculo = @p1 AND T2.Id_Desperfecto = T1.Id_Desperfecto;";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pIdVehiculo) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public void GuardarDesperfecto(Desperfecto pDesperfecto)
        {
            string commandString = "INSERT INTO [Desperfecto] (Id_Desperfecto, Id_Vehiculo, Descripcion_Desperfecto, Tiempo_Desperfecto, ManoDeObra_Desperfecto) VALUES (@p1, @p2, @p3, @p4, @p5)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pDesperfecto.Id), new SqlParameter("@p2", pDesperfecto.IdVehiculo), new SqlParameter("@p3", pDesperfecto.Descripcion), new SqlParameter("@p4", pDesperfecto.Tiempo), new SqlParameter("@p5", pDesperfecto.ManoDeObra) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
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
                    List<Repuesto> mListaRepuestos = this.ListarRepuestos(mId);
                    Desperfecto mDesperfecto = new Desperfecto(mId, mIdVehiculo, mDescripcion, mManoDeObra, mTiempo, mListaRepuestos);

                    mLista.Add(mDesperfecto);
                }
            }
            return mLista;
        }
        public List<Repuesto> ListarRepuestos(int pIdDesperfecto)
        {
            List<Repuesto> mLista = new List<Repuesto>();
            DataSet mDs = new DataSet();
            string commandString = "SELECT [Repuesto].Id_Repuesto, [Repuesto].Descripcion_Repuesto, [Repuesto].Precio_Repuesto FROM Repuesto, Desperfecto_Repuesto WHERE [Desperfecto_Repuesto].Id_Desperfecto = @p1 AND [Repuesto].Id_Repuesto = [Desperfecto_Repuesto].Id_Repuesto ORDER BY [Repuesto].Id_Repuesto;";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pIdDesperfecto) };

            mDs = mDAO.ExecuteDataSet(commandString, paramArray);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in mDs.Tables[0].Rows)
                {
                    int mId = (int)dr["Id_Repuesto"];
                    string mDescripcion = dr["Descripcion_Repuesto"].ToString();
                    int mPrecio = (int)dr["Precio_Repuesto"];

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
