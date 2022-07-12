using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class DALNotFound : Exception
    {
        public DALNotFound(string key)
            : base($"DAL object with the key of {key} does not exist!")
        { }
    }
}
