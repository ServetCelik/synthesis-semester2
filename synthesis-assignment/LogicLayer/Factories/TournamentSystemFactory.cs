using LogicLayer.Exceptions;
using LogicLayer.Interfaces;
using LogicLayer.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Factories
{
    public static class TournamentSystemFactory
    {
        public static ITournamentSystem SystemFactory(string name)
        {
            foreach (var item in SystemDictionary())
            {
                if (item.Key == name)
                {
                    return item.Value;
                }
            }
            throw new TournamentSystemNotFound(name);
        }

        private static Dictionary<string, ITournamentSystem> SystemDictionary()
        {
            Dictionary<string, ITournamentSystem> dict = new Dictionary<string, ITournamentSystem>();

            RoundRobin roundRobin = new RoundRobin();
            DoubleRoundRobin doubleRoundRobin = new DoubleRoundRobin();
            dict.Add("RoundRobin", roundRobin);
            dict.Add("DoubleRoundRobin", doubleRoundRobin);
            return dict;
        }
    }
}
