using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entities
{
    public class Player:User
    {
        string firstName;
        string lastName;
        int nrOfMatchesWin;
        int nrOfMatchesLost;

        public Player(string id, string userName, string hashedPassword, string salt, string email, string firstName, string lastName, int nrOfMatchesWin, int nrOfMatchesLost) : base(id, userName, hashedPassword, salt, email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.nrOfMatchesWin = nrOfMatchesWin;
            this.nrOfMatchesLost = nrOfMatchesLost;
        }


        public string FirstName { get => firstName;}
        public string LastName { get => lastName;}
        public int NrOfMatchesWin { get => nrOfMatchesWin; set => nrOfMatchesWin = value; }
        public int NrOfMatchesLost { get => nrOfMatchesLost; set => nrOfMatchesLost = value; }
        public double WinRate()
        {
            return ((double)this.nrOfMatchesWin / (this.nrOfMatchesWin + this.nrOfMatchesLost)) * 100;
        }
    }
}
