using LogicLayer.Entities;
using LogicLayer.Enums;
using LogicLayer.Factories;
using LogicLayer.Interfaces;
using LogicLayer.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.LogicClasses
{
    public class TournamentAdministrator
    {        
        ITournamentDAL iTournamentDAL; 
        List<Tournament> tournaments = new List<Tournament>();        

        public TournamentAdministrator(ITournamentDAL iTournamentDAL)
        {
            try
            {
                this.iTournamentDAL = iTournamentDAL;
                UpdateTournamentList();
            }
            catch (Exception)
            {

                throw;
            }
            
            
            foreach (var tournament in tournaments)
            {
                UpdateTournamentStatus(tournament);
            }
        }

        /// <summary>
        /// This method gets all the tournaments from db and feed our local tournament list
        /// </summary>
        public void UpdateTournamentList()
        {
            tournaments.Clear();
            tournaments.AddRange(iTournamentDAL.GetTournamentsFromDBDAL());

            for (int i = 0; i < tournaments.Count; i++)
            {
                List<Player> players = GetPlayersJoinedATournament(tournaments[i]);
                List<Match> matches = GetMatchesOfATournament(tournaments[i]);

                tournaments[i].Players = players;
                tournaments[i].Matches = matches;
            }
        }

        /// <summary>
        /// This method finds the matches of selected tournament
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public List<Match> GetMatchesOfATournament(Tournament tournament) 
        {
            List<Match> matches = iTournamentDAL.FindMatchesByTournamentIdDAL(tournament);

            return matches;
        }

        /// <summary>
        /// This method finds the Joined players of selected tournament
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public List<Player> GetPlayersJoinedATournament(Tournament tournament)
        {
            List<Player> players = iTournamentDAL.GetPlayersJoinedATournamentDAL(tournament);
            return players;
        }

        /// <summary>
        /// Return local tournament list
        /// </summary>
        /// <returns></returns>
        public List<Tournament> GetTournamentList()
        {
            return tournaments;
        }

        /// <summary>
        /// This method adds the tournament to local list and our database
        /// </summary>
        /// <param name="tournament"></param>
        public void CreateNewTournament(Tournament tournament)
        {
            tournaments.Add(tournament);
            iTournamentDAL.NewTournamentDAL(tournament);
        }

        /// <summary>
        /// This method deletes a tournament from our local list and db
        /// </summary>
        /// <param name="tournament"></param>
        public void DeleteTournament(Tournament tournament)
        {
            tournaments.Remove(tournament);
            iTournamentDAL.DeleteTournamentDAL(tournament);
        }

        /// <summary>
        /// This method updates tournament status using current time and number of players joined the tournament
        /// </summary>
        /// <param name="tournament"></param>
        public void UpdateTournamentStatus(Tournament tournament)
        {        
            if (tournament.UpdateStatus())
            {
                iTournamentDAL.UpdateTournamentStatusDAL(tournament);
            }            
        }

        /// <summary>
        /// This method checks if a player can be added to a tournament. If it can add it to local list and the db
        /// </summary>
        /// <param name="tournament"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool AddPlayerToTournament(Tournament tournament, Player player)
        {
            if (tournament.AddPlayer(player))
            {
                iTournamentDAL.AddPlayerToTournamentDAL(tournament, player);
                return true;
            }
            return false;            
        }

        /// <summary>
        /// This method checks if a player can be deleted from a tournament. If it can, delete it from local list and the db
        /// </summary>
        /// <param name="tournament"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool DeletePlayerFromTournament(Tournament tournament, Player player)
        {
            if (tournament.DeletePlayer(player))
            {
                iTournamentDAL.DeletePlayerFromTournamnetDAL(tournament, player);
                return true;
            }
            return false;          
            
        }

        /// <summary>
        /// This method generates matches matches if the tournament inapplicable and and min player number requirement are met
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public bool GenerateMatches(Tournament tournament)
        {            
            if (tournament.GenerateMatches())
            {
                foreach (var match in tournament.Matches)
                {
                    iTournamentDAL.AddGeneratedMatchesToDBDAL(match);
                }
                return true;
            }
            return false;            
        }
              
        /// <summary>
        /// This method checks if it is a valid score. If it is then updates it locally and on db
        /// </summary>
        /// <param name="match"></param>
        /// <param name="player1Score"></param>
        /// <param name="player2Score"></param>
        /// <returns></returns>
        public bool AddMatchScore(Match match, int player1Score, int player2Score)
        {
            //Match UpdatedMatch = tournaments.Find(y => y.Id == match.TournamentId).Matches.Find(x => x.MatchId == match.MatchId);
            if (match.AddScore(player1Score,player2Score))
            {
                iTournamentDAL.AddMatchScoreDAL(match);
                return true;
            }
            return false;
            
        }
        /// <summary>
        /// Creates an dictionary which orders players depend on their wins in a tournament
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        public Dictionary<string,int> TournamentLeaderBoard(Tournament tournament)
        {
            Dictionary<string,int> leaderBoard = new Dictionary<string, int>();
            foreach (var player in tournament.Players)
            {
                leaderBoard.Add(player.UserName, 0);
            }
            foreach (var match in tournament.Matches)
            {
                if (match.Player1Score>match.Player2Score)
                {
                    leaderBoard[match.Player1.UserName] += 1;
                }
                else if (match.Player1Score < match.Player2Score)
                {
                    leaderBoard[match.Player2.UserName] += 1;
                }
            }
            var dict = leaderBoard.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return dict;
        }  
       

    }
}
