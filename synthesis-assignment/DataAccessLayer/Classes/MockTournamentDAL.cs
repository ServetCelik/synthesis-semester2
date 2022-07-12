using LogicLayer.Entities;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Classes
{
    public class MockTournamentDAL : ITournamentDAL
    {
        


        public void NewTournamentDAL(Tournament tournament)
        {

        }
        public void DeleteTournamentDAL(Tournament tournament)
        {

        }
        public void AddPlayerToTournamentDAL(Tournament tournament, Player player)
        {

        }
        public void DeletePlayerFromTournamnetDAL(Tournament tournament, Player player)
        {

        }
        public void AddGeneratedMatchesToDBDAL(Match match)
        {

        }
        public void AddMatchScoreDAL(Match match)
        {

        }
        public List<Tournament> GetTournamentsFromDBDAL()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            List<Tournament> tournaments = new List<Tournament>();
            
            tournaments.Add(new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable));
            tournaments.Add(new Tournament("2", "b", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(5), DateTime.Now.AddDays(30), 3, 6, staff, LogicLayer.Enums.Status.applicable));
            tournaments.Add(new Tournament("3", "c", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(-50), DateTime.Now.AddDays(-1), 2, 6, staff, LogicLayer.Enums.Status.applicable));

            return tournaments;
        }
        public List<Match> FindMatchesByTournamentIdDAL(Tournament tournament)
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            List<Match> matches = new List<Match>();
            matches.Add(new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2));
            matches.Add(new Match("2", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2));
            matches.Add(new Match("3", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2));
            matches.Add(new Match("4", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2));
            return matches;
        }
        
        public List<Player> GetPlayersJoinedATournamentDAL(Tournament tournament)
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            List<Player> playerList = new List<Player>();
            playerList.Add(player1);
            playerList.Add(player2);
            return playerList;

        }


        public void UpdateTournamentStatusDAL(Tournament tournament)
        {

        }

        public Tournament FindTournamentById(string id)
        {
            return null;
        }
        public User FindUserByIdDAL(string id)
        {
            return null;
        }
    }
}
