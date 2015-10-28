using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPlab8.DataController
{
    using System.Configuration;

    public abstract class ConnectionAccess
    {
        protected string ConnectionString
        {
            get
            {
                return ConfigurationManager.
                    ConnectionStrings["VP_DBConnectionString"].ToString();
            }
        }
    }
}
