using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenLab.Control;

namespace TokenLab.Model
{
    public sealed class Client
    {
        private static readonly Client instance = new Client();

        private Client() { }

        public static Client Instance
        {
            get
            {
                return instance;
            }
        }

        private Int32 IntIdClient;
        private string StrUser;

        public void SetLoggedUser(string StrUser)
        {
            DbConnection _conn = DbConnection.Instance;

            this.StrUser = StrUser;
            this.IntIdClient = Convert.ToInt32(_conn.GetIdClient(StrUser));
        }

        public Int32 GetIdClient()
        {
            return IntIdClient;
        }

        public string GetUser()
        {
            return StrUser;
        }
    }
}
