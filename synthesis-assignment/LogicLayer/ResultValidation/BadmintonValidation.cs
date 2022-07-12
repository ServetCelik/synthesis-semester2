using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.ResultValidation
{
    public class BadmintonValidation : IResultValidation
    {       

        public bool isValidResult(int scoreFistPlayer, int scoreSecondPlayer)
        {
            
            if ((scoreFistPlayer==21 & scoreSecondPlayer < 20)|| (scoreSecondPlayer == 21 & scoreFistPlayer < 20))
            {
                return true;
            }
            
            else if (scoreFistPlayer>=20 & scoreSecondPlayer>=20)
            {
                if ((scoreSecondPlayer==30&scoreFistPlayer==29)||(scoreFistPlayer==30&scoreSecondPlayer==29)|| (scoreSecondPlayer == 30 & scoreFistPlayer == 28) || (scoreFistPlayer == 30 & scoreSecondPlayer == 28))
                {
                    return true;
                }
                
                if (scoreFistPlayer<30 & scoreSecondPlayer<30)
                {
                    if ((scoreFistPlayer == scoreSecondPlayer + 2) || (scoreSecondPlayer == scoreFistPlayer + 2))
                    {
                        return true;
                    }
                }              
                
            }
            return false;
        }
    }
}
