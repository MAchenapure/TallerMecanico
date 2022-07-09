using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DAO
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TallerMecanico;Integrated Security=True";
        SqlConnection mCon = new SqlConnection(connectionString);

        internal void ExecuteNonQuery(string commandString, SqlParameter[] parameterCollection)
        {
            try
            {
                SqlCommand mCom = new SqlCommand(commandString, mCon);
                mCom.Parameters.AddRange(parameterCollection);
                mCon.Open();
                mCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed) mCon.Close();
            }
        }
        internal DataSet ExecuteDataSet(string commandString, SqlParameter[] parameterCollection = null)
        {
            if(parameterCollection != null)
            {
                try
                {
                    SqlCommand mCom = new SqlCommand(commandString, mCon);
                    mCom.Parameters.AddRange(parameterCollection);
                    SqlDataAdapter mDa = new SqlDataAdapter(mCom);
                    DataSet mDs = new DataSet();

                    mDa.Fill(mDs);
                    return mDs;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    if (mCon.State != ConnectionState.Closed) mCon.Close();
                }
            } else
            {
                try
                {
                    SqlCommand mCom = new SqlCommand(commandString, mCon);
                    SqlDataAdapter mDa = new SqlDataAdapter(mCom);
                    DataSet mDs = new DataSet();

                    mDa.Fill(mDs);
                    return mDs;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    if (mCon.State != ConnectionState.Closed) mCon.Close();
                }
            }
        }
        public int ObtenerUltimoId(string pTabla)
        {
            try
            {
                SqlCommand mCom = new SqlCommand("SELECT ISNULL(MAX(Id_" + pTabla + "),0) FROM " + pTabla, mCon);
                mCon.Open();
                return int.Parse(mCom.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (mCon.State != ConnectionState.Closed)
                    mCon.Close();
            }
        }

    }
}