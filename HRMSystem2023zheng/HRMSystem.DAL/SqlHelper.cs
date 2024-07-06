using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.DAL
{
  public  class SqlHelper
    {
        public static SqlDataReader GetDataReader(string sql, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            return comm.ExecuteReader(CommandBehavior.CloseConnection);
        }


        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public static object ExecuteScalar(string sql,params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                conn.Open();
                return comm.ExecuteScalar();
            }
        }
        public static int ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(parameters);
                conn.Open();
                return comm.ExecuteNonQuery();
            }
        }
        public static DataTable  GetTable(string sql,params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.SelectCommand.Parameters.AddRange(parameters);
                sda.Fill(dt);
                return dt;

            }
        }
        public static bool Execute(string sql1, string sql2, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction st = null;
                SqlCommand comm = null;
                try
                {
                    st = conn.BeginTransaction();
                    comm = new SqlCommand(sql1, conn, st);
                    comm.CommandText += sql2;
                    comm.Parameters.AddRange(parameters);
                    comm.ExecuteNonQuery();
                    st.Commit();
                }
                catch (Exception ex)
                {
                    st.Rollback();
                    return false;
                    throw ex;
                }
                return true;
            }
        }

    }
}
