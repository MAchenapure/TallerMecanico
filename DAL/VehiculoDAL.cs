using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using Framework;

namespace DAL
{
    public class VehiculoDAL
    {
        DAO mDAO = new DAO();
        DesperfectoDAL mDesperfectoDAL = new DesperfectoDAL();

        public void EliminarVehiculo(Vehiculo pVehiculo)
        {
            Constantes.TipoVehiculo TipoVehiculo = pVehiculo.TipoVehiculo;
            string commandString = "";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pVehiculo.Id) };

            if (TipoVehiculo == Constantes.TipoVehiculo.Automovil)
            {
                commandString = "DELETE FROM Automovil WHERE Id_Vehiculo = @p1";
                mDAO.ExecuteNonQuery(commandString, paramArray);

            } else if (TipoVehiculo == Constantes.TipoVehiculo.Moto)
            {
                commandString = "DELETE FROM Moto WHERE Id_Vehiculo = @p1";
                mDAO.ExecuteNonQuery(commandString, paramArray);
            }

            mDesperfectoDAL.EliminarDesperfecto(pVehiculo.Id);

            commandString = "DELETE FROM Vehiculo WHERE Id_Vehiculo = @p1";
            SqlParameter[] paramArray2 = { new SqlParameter("@p1", pVehiculo.Id) };
            mDAO.ExecuteNonQuery(commandString, paramArray2);
        }

        public void GuardarAutomovil(Automovil pAutomovil)
        {
            GuardarVehiculo(pAutomovil);
            string commandString = "INSERT INTO [Automovil] (Tipo_Automovil, Id_Vehiculo) VALUES (@p1, @p2)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pAutomovil.TipoAutomovil), new SqlParameter("@p2", pAutomovil.Id) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public void GuardarMoto(Moto pMoto)
        {
            GuardarVehiculo(pMoto);
            string commandString = "INSERT INTO [Moto] (Cilindrada_Moto, Id_Vehiculo) VALUES (@p1, @p2)";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pMoto.Cilindrada), new SqlParameter("@p2", pMoto.Id) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public void GuardarVehiculo(Vehiculo pVehiculo)
        {
            string commandString = "INSERT INTO [Vehiculo] (Id_Vehiculo, Marca_Vehiculo, Modelo_Vehiculo, Patente_Vehiculo, Tipo_Vehiculo) VALUES (@p1, @p2, @p3, @p4, @p5)";

            SqlParameter[] paramArray = { new SqlParameter("@p1", pVehiculo.Id), new SqlParameter("@p2", pVehiculo.Marca), new SqlParameter("@p3", pVehiculo.Modelo), new SqlParameter("@p4", pVehiculo.Patente), new SqlParameter("@p5", pVehiculo.TipoVehiculo) };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }

        public List<Vehiculo> ListarVehiculos()
        {
            List<Vehiculo> mLista = new List<Vehiculo>();
            DataSet mDs = new DataSet();
            string commandString = "SELECT Vehiculo.Id_Vehiculo, Vehiculo.Marca_Vehiculo, Vehiculo.Modelo_Vehiculo, Vehiculo.Patente_Vehiculo, Vehiculo.Tipo_Vehiculo, Automovil.Tipo_Automovil, Moto.Cilindrada_Moto FROM Vehiculo LEFT OUTER JOIN Automovil ON [Vehiculo].[Id_Vehiculo] = [Automovil].[Id_Vehiculo] LEFT OUTER JOIN Moto ON [Vehiculo].[Id_Vehiculo] = [Moto].[Id_Vehiculo] ORDER BY Vehiculo.Id_Vehiculo;";

            mDs = mDAO.ExecuteDataSet(commandString);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in mDs.Tables[0].Rows)
                {
                    int Id = (int)dr["Id_Vehiculo"];
                    string Marca = dr["Marca_Vehiculo"].ToString();
                    string Modelo = dr["Modelo_Vehiculo"].ToString();
                    string Patente = dr["Patente_Vehiculo"].ToString();
                    Constantes.TipoVehiculo TipoVehiculo = (Constantes.TipoVehiculo)(int)dr["Tipo_Vehiculo"];
                    List<Desperfecto> ListaDesperfectos = mDesperfectoDAL.ListarDesperfectos(Id);

                    if(TipoVehiculo == Constantes.TipoVehiculo.Automovil)
                    {
                        Constantes.TipoAutomovil TipoAutomovil = (Constantes.TipoAutomovil)(int)dr["Tipo_Automovil"];
                        Automovil mAuto = new Automovil(Id, Marca, Modelo, Patente, TipoVehiculo, TipoAutomovil, ListaDesperfectos);
                        mLista.Add(mAuto);
                    } else if(TipoVehiculo == Constantes.TipoVehiculo.Moto)
                    {
                        int Cilindrada = (int)dr["Cilindrada_Moto"];
                        Moto mMoto = new Moto(Id, Marca, Modelo, Patente, TipoVehiculo, Cilindrada, ListaDesperfectos);
                        mLista.Add(mMoto);
                    }
                }

            }
            return mLista;
        }

        public void ModificarAutomovil(Automovil pAuto)
        {
            int mId = pAuto.Id;
            Constantes.TipoAutomovil mTipoAutomovil = pAuto.TipoAutomovil;

            string commandString = "UPDATE Automovil SET Automovil.Tipo_Automovil = @p2 WHERE Automovil.Id_Vehiculo = @p1;";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pAuto.Id),
                new SqlParameter("@p2", pAuto.TipoAutomovil)
            };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public void ModificarMoto(Moto pMoto)
        {
            int mId = pMoto.Id;
            int mCilindrada = pMoto.Cilindrada;

            string commandString = "UPDATE Moto SET Moto.Cilindrada_Moto = @p2 WHERE Moto.Id_Vehiculo = @p1;";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pMoto.Id),
                new SqlParameter("@p2", pMoto.Cilindrada)
            };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public void ModificarVehiculo(Vehiculo pVehiculo)
        {
            Constantes.TipoVehiculo TipoVehiculo = pVehiculo.TipoVehiculo;
            int mId = pVehiculo.Id;
            string mMarca = pVehiculo.Marca;
            string mModelo = pVehiculo.Modelo;
            string mPatente = pVehiculo.Patente;

            string commandString = "UPDATE Vehiculo SET Vehiculo.Marca_Vehiculo = @p2, Vehiculo.Modelo_Vehiculo = @p3, Vehiculo.Patente_Vehiculo = @p4, Vehiculo.Tipo_Vehiculo = @p5 WHERE Vehiculo.Id_Vehiculo = @p1;";
            SqlParameter[] paramArray = { new SqlParameter("@p1", pVehiculo.Id),
                new SqlParameter("@p2", pVehiculo.Marca),
                new SqlParameter("@p3", pVehiculo.Modelo),
                new SqlParameter("@p4", pVehiculo.Patente),
                new SqlParameter("@p5", pVehiculo.TipoVehiculo)
            };

            mDAO.ExecuteNonQuery(commandString, paramArray);
        }
        public int ObtenerUltimoId(string pTabla)
        {
            return mDAO.ObtenerUltimoId(pTabla);
        }

    }
}
