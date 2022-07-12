using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface IResultValidation
    {
        public bool isValidResult(int scoreFistPlayer, int scoreSecondPlayer);
    }
}
