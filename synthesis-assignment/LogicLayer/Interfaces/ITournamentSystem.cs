using LogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface ITournamentSystem
    {
        public List<Match> GenerateMatches(Tournament tournament);        
    }
}
