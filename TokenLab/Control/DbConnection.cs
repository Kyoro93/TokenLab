using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenLab.Control
{
    public sealed class DbConnection
    {
        private static readonly DbConnection instance = new DbConnection();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        private DbConnection() { }

        public static DbConnection Instance
        {
            get
            {
                return instance;
            }
        }
        private SqlConnection getConn()
        {
            builder.DataSource = "DESKTOP-88T9E54\\SQLEXPRESS";
            builder.UserID = "tl";
            builder.Password = "tl";
            builder.InitialCatalog = "TokenLab";
            return new SqlConnection(builder.ConnectionString);
        }

        public bool CheckLogin(string strUser, string strPass)
        {
            bool result = false;
            
            using (SqlConnection cn = getConn())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from Client where login = '" +strUser + "' and password = '" +strPass + "';", cn);
                    cn.Open();
                    SqlDataReader data = cmd.ExecuteReader();
                    result = data.HasRows;
                    data.Close();

                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }

        public string GetIdClient(string strUser)
        {
            string result = null;

            using (SqlConnection cn = getConn())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select IdClient from Client where login = '" + strUser + "';", cn);
                    cn.Open();
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        result = data["IdClient"].ToString();
                    }
                    data.Close();

                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }
    }
}
