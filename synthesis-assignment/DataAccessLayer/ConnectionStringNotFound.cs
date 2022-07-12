using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionStringNotFound : Exception
    {
        public ConnectionStringNotFound(string key)
            : base($"Connection string with key {key} does not exist!")
        { }
    }
}
