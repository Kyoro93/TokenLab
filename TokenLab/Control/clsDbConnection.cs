using System;
using System.Data;
using System.Data.SqlClient;
using TokenLab.Model;

namespace TokenLab.Control
{
    public sealed class clsDbConnection
    {
        private static readonly clsDbConnection instance = new clsDbConnection();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        private clsDbConnection() { }

        public static clsDbConnection Instance
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


        public DataTable GetEventsByOwner(string strOwner) {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    DataTable dt = new DataTable();
                    {
                        cn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Event where OwnerLogin = '" + strOwner + "' UNION ALL SELECT * FROM Event WHERE IdEvent IN (SELECT IdEvent FROM Invitation WHERE AccessTo = '" + @strOwner + "' AND AcceptedAt IS NOT NULL ) ORDER BY Event.StartDatetime ASC;", cn);
                        sqlDa.Fill(dt);
                        cn.Close();
                        return dt;
                    }
                } catch(Exception e)
                {
                    throw (e);
                }
            }
        }

        public DataTable GetEventsByInvitationReceived(string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    DataTable dt = new DataTable();
                    {
                        cn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Event.*, (SELECT CASE WHEN Inv.AcceptedAt IS NULL THEN 'pendente' ELSE 'aceito' END FROM Invitation Inv where Inv.IdEvent = Event.IdEvent AND Inv.AccessTo = '" + strAccessTo + "') AS InvitationStatus FROM Event where IdEvent IN (SELECT IdEvent FROM Invitation WHERE AccessTo = '" + strAccessTo + "') ORDER BY Event.StartDateTime;", cn);
                        sqlDa.Fill(dt);
                        cn.Close();
                        return dt;
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        internal object GetEventsByInvitationSent(string strOwnerLogin)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    DataTable dt = new DataTable();
                    {
                        cn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Event.*, Invitation.AccessTo, (SELECT CASE WHEN Inv.AcceptedAt IS NULL THEN 'pendente' ELSE 'aceito' END FROM Invitation Inv where Inv.IdEvent = Event.IdEvent AND Inv.AccessTo = Invitation.AccessTo) AS InvitationStatus FROM Event INNER JOIN Invitation ON Event.IdEvent = Invitation.IdEvent WHERE Event.OwnerLogin = '" + strOwnerLogin + "' ORDER BY Invitation.InvitedAt;", cn);
                        sqlDa.Fill(dt);
                        cn.Close();
                        return dt;
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool CheckInvitation(int intIdEvent, string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT 1 FROM Invitation WHERE IdEvent = " + intIdEvent + " AND AccessTo = '" + strAccessTo + "';", cn);
                        sqlDa.Fill(dt);
                        cn.Close();
                        if (Convert.ToInt32(dt.Rows.Count) == 1)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool UserExist(string strUserLogin)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT 1 FROM Client WHERE login = '" + strUserLogin + "';", cn);
                        sqlDa.Fill(dt);
                        cn.Close();
                        if (Convert.ToInt32(dt.Rows.Count) == 1)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool InsertOrUpdateEvent(Int32 intIdEvent, string strDescription, string strStartDatetime,string strFinalDatetime)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("EventAddOrEdit", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.Parameters.AddWithValue("@Description", strDescription);
                    sqlCmd.Parameters.AddWithValue("@StartDatetime", strStartDatetime);
                    sqlCmd.Parameters.AddWithValue("@FinalDatetime", strFinalDatetime);
                    sqlCmd.Parameters.AddWithValue("@OwnerLogin", clsClient.Instance.GetUser());
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }catch(Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool DeleteEvent(Int32 intIdEvent)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("EventDeleteById", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool InsertInvitation(Int32 intIdEvent, string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("InvitationAdd", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.Parameters.AddWithValue("@AccessTo", strAccessTo);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool DeleteInvitation(Int32 intIdEvent, string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("InvitationDeleteByIdEventAndAccessTo", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.Parameters.AddWithValue("@AccessTo", strAccessTo);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool AcceptInvitation(Int32 intIdEvent, string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("InvitationAccept", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.Parameters.AddWithValue("@AccessTo", strAccessTo);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool DeleteSingleInvitation(Int32 intIdEvent, string strAccessTo)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("InvitationDeleteByIdEvent", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.Parameters.AddWithValue("@strAccessTo", strAccessTo);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool DeleteAllInvitation(Int32 intIdEvent)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("InvitationDeleteByIdEvent", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IdEvent", intIdEvent);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public bool InsertOrUpdateClient(string strLogin, string strPassword)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    cn.Open();
                    SqlCommand sqlCmd = new SqlCommand("ClientAddOrUpdate", cn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Login", strLogin);
                    sqlCmd.Parameters.AddWithValue("@Password", strPassword);
                    sqlCmd.ExecuteNonQuery();
                    cn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

        public Int32 GetEventNumberByPeriodAndOwner(Int32 intIdEvent, string strStartDatetime, string strFinalDatetime, string strOwnerLogin)
        {
            using (SqlConnection cn = getConn())
            {
                try
                {
                    DataTable dt = new DataTable();
                    string stringSelect = "SELECT dbo.FCTEventsByPeriodAndOwner('" + intIdEvent + "', '" + strStartDatetime.Replace("-", "") + "', '" + strFinalDatetime.Replace("-", "") + "', '" + strOwnerLogin + "')";

                    cn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(stringSelect, cn);
                    sqlDa.Fill(dt);
                    cn.Close();
                    return Convert.ToInt32(dt.Rows[0][0]);
                }
                catch (Exception e)
                {
                    throw (e);
                }
            }
        }

    }
}
