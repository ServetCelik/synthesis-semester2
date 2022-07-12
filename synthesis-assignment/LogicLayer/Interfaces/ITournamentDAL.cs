using LogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface ITournamentDAL
    {
        public void NewTournamentDAL(Tournament tournament);
        public void DeleteTournamentDAL(Tournament tournament);
        public void AddPlayerToTournamentDAL(Tournament tournament, Player player);
        public void DeletePlayerFromTournamnetDAL(Tournament tournament, Player player);
        public void AddGeneratedMatchesToDBDAL(Match match);
        public void AddMatchScoreDAL(Match match);
        public List<Tournament> GetTournamentsFromDBDAL();
        public List<Match> FindMatchesByTournamentIdDAL(Tournament tournament);        
        public List<Player> GetPlayersJoinedATournamentDAL(Tournament tournament);
        public void UpdateTournamentStatusDAL(Tournament tournament);       
        public User FindUserByIdDAL(string id);
    }
}
