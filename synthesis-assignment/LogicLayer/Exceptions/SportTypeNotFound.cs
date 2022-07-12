using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class SportTypeNotFound : Exception
    {
        public SportTypeNotFound(string key)
            : base($"Sport type object with the key of {key} does not exist!")
        { }
    }
}
