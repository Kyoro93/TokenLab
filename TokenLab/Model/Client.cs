using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenLab.Model
{
    class Client
    {
        public string StrUser { get => StrUser; set => StrUser = value; }

        public Client(string StrUser)
        {
            this.StrUser = StrUser;
        }

    }
}
