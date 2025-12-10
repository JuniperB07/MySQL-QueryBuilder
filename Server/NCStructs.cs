using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_QueryBuilder.Server
{
    internal struct ConnectionStringMetadata
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public string ConnSTR
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Password))
                    return $"server={Server}; user={User}; password={Password}; database={Database};";
                else
                    return $"server={Server}; user={User}; database={Database};";

            }
        }

        public ConnectionStringMetadata(
            string SetServer = "",
            string SetUser = "",
            string SetPassword="",
            string SetDatabase = "")
        {
            Server = SetServer;
            User = SetUser;
            Password = SetPassword;
            Database = SetDatabase;
        }
    }
}
