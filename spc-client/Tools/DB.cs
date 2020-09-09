using spc_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.Tools
{
    public class DB
    {
        public static SpcModel Instance()
        {
            return new SpcModel();
        }
    }
}
