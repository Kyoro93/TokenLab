using System;

namespace TokenLab.Control
{
    public class clsEvent
    {
        private Int32 intIdEvent;
        private string strDescription;
        private string strStartDatetime;
        private string strFinalDatetime;
        private string strOwnerLogin;

        public clsEvent(int intIdEvent, string strDescription, string strStartDatetime, string strFinalDatetime, string strOwnerLogin)
        {
            IntIdEvent = intIdEvent;
            StrStartDatetime = strStartDatetime;
            StrFinalDatetime = strFinalDatetime;
            StrDescription = strDescription;
            StrOwnerLogin = strOwnerLogin;
        }

        public int IntIdEvent { get => intIdEvent; set => intIdEvent = value; }
        public string StrStartDatetime { get => strStartDatetime; set => strStartDatetime = value; }
        public string StrFinalDatetime { get => strFinalDatetime; set => strFinalDatetime = value; }
        public string StrDescription { get => strDescription; set => strDescription = value; }
        public string StrOwnerLogin { get => strOwnerLogin; set => strOwnerLogin = value; }

        public void CreateOrUpdateEventOnDb()
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                _db.InsertOrUpdateEvent(intIdEvent, strDescription, strStartDatetime.Replace("-",""), strFinalDatetime.Replace("-", ""));
            }catch(Exception ex)
            {
                throw (ex);
            }
        }

        public void DeleteEventFromDb()
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                _db.DeleteEvent(intIdEvent);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void InviteToEvent(string strAccessTo)
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                _db.InsertInvitation(intIdEvent, strAccessTo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void AcceptInvite(string strAccessTo)
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                _db.AcceptInvitation(intIdEvent, strAccessTo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void DeleteInvitation(string strAccessTo)
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                _db.DeleteInvitation(intIdEvent, strAccessTo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public bool CheckInvite(string strAccessTo)
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                return _db.CheckInvitation(intIdEvent, strAccessTo);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
