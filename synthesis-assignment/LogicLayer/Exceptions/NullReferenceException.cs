using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class NullReferenceException : Exception
    {
        public NullReferenceException() : base("User cannot be founded")
        {
        }
    }
}
