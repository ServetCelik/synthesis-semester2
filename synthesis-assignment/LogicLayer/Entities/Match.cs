using LogicLayer.Factories;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entities
{
    public class Match
    {
        string matchId;
        string tournamentId;
        DateTime date;
        string sportType;
        Player player1;
        Player player2;
        int? player1Score;
        int? player2Score;

        public Match(string matchId, string tournamentId, DateTime date, string sportType, Player player1, Player player2)
        {
            this.matchId = matchId;
            this.tournamentId = tournamentId;
            this.date = date;
            this.sportType = sportType;
            this.player1 = player1;
            this.player2 = player2;
            player1Score = null;
            player1Score = null;
        }

        public string MatchId { get => matchId;}
        public string TournamentId { get => tournamentId;}
        public DateTime Date { get => date; set => date = value; }
        public Player Player1 { get => player1;}
        public Player Player2 { get => player2;}
        public int? Player1Score { get => player1Score; set => player1Score = value; }
        public int? Player2Score { get => player2Score; set => player2Score = value; }
        public string SportType { get => sportType;}

        public string ShowScores()
        {
            if (player1Score==null)
            {
                return "-/-";
            }
            else
            {
                return $"{player1Score} / {player2Score}";
            }
        }
        public bool AddScore(int firstPlayerScore, int secondPlayerScore)
        {
            IResultValidation resultValidation = ResultValidationFactory.ResultFactory(this.sportType);

            bool CheckResult = resultValidation.isValidResult(firstPlayerScore, secondPlayerScore);
            if (CheckResult)
            {
                this.Player1Score = firstPlayerScore;
                this.Player2Score = secondPlayerScore;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
