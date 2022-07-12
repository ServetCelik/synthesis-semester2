using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.ResultValidation
{
    public class TableTennisValidation : IResultValidation
    {
        //Each player gets 2 serves, and it alternates until one of the players scores 11 points,
        //unless there is a deuce(10:10). In that case, each player gets only one serve and it 
        //alternates until one of the players gets a two point lead.
        public bool isValidResult(int scoreFistPlayer, int scoreSecondPlayer)
        {
            if ((scoreFistPlayer==11 & scoreSecondPlayer<10)||(scoreSecondPlayer==11&scoreFistPlayer<10))
            {
                return true;
            }
            else if (scoreFistPlayer >= 10 & scoreSecondPlayer >= 10)
            {
                if ((scoreFistPlayer==scoreSecondPlayer+2)||(scoreSecondPlayer==scoreFistPlayer+2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
