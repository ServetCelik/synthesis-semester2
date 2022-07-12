using LogicLayer.Exceptions;
using LogicLayer.Interfaces;
using LogicLayer.ResultValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Factories
{
    public static class ResultValidationFactory
    {
        public static IResultValidation ResultFactory(string name)
        {
            foreach (var item in ResultValidationDictionary())
            {
                if (item.Key == name)
                {
                    return item.Value;
                }
            }
            throw new SportTypeNotFound(name);
        }

        private static Dictionary<string, IResultValidation> ResultValidationDictionary()
        {
            Dictionary<string, IResultValidation> dict = new Dictionary<string, IResultValidation>();

            TableTennisValidation tournamentValidation = new TableTennisValidation();
            BadmintonValidation badmintonValidation = new BadmintonValidation();
            dict.Add("Table Tennis", tournamentValidation);
            dict.Add("Badminton", badmintonValidation);
            return dict;
        }
    }
}
