using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenLab.Control;

namespace TokenLab.Model
{
    public sealed class clsClient
    {
        private static readonly clsClient instance = new clsClient();

        private clsClient() { }

        public static clsClient Instance
        {
            get
            {
                return instance;
            }
        }

        private string StrUser;

        public void SetLoggedUser(string StrUser)
        {
            clsDbConnection _conn = clsDbConnection.Instance;

            this.StrUser = StrUser;
        }

        public string GetUser()
        {
            return StrUser;
        }

        public bool UserExist(string strUserLogin)
        {
            try
            {
                clsDbConnection _db = clsDbConnection.Instance;
                return _db.UserExist(strUserLogin);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
