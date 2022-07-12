using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class UserDoesntExistException : Exception
    {
        public UserDoesntExistException() : base("This user doesn't exist.")
        {
        }
    }
}
