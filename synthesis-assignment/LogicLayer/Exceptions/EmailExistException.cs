using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class EmailExistException : Exception
    {
        public EmailExistException() : base("This email is exist.")
        {
        }
    }
}
