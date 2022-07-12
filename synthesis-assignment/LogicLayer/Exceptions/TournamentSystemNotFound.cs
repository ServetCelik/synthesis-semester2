using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class TournamentSystemNotFound : Exception
    {
        public TournamentSystemNotFound(string key)
            : base($"Tournament system object with the name of {key} does not exist!")
        { }
    }
}
