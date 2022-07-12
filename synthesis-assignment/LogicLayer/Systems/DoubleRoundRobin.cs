using LogicLayer.Entities;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Systems
{
    public class DoubleRoundRobin : ITournamentSystem
    {
        public List<Match> GenerateMatches(Tournament tournament)
        {
            List<Match> matches = new List<Match>();
            DateTime firstDay = tournament.StartDate;
            string tournamentId = tournament.Id;
            List<Player> players = tournament.Players;

            if (players.Count % 2 == 1)
            {
                players.Add(new Player("asdasd", "fake", "123", "abc", "def", "ServetA", "Celik", 0, 0));
            }

            int totalDays = players.Count - 1;
            int halfsize = players.Count / 2;

            List<Player> team1 = new List<Player>();
            List<Player> team2 = new List<Player>();
            team1.AddRange(players.GetRange(0, halfsize));
            team2.AddRange(players.GetRange(halfsize, halfsize));


            var firstUser = players[0];

            team1.RemoveAt(0);
            team2.Reverse();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < totalDays; j++)
                {
                    string matchId = Guid.NewGuid().ToString();
                    matches.Add(new Match(matchId, tournamentId, firstDay, tournament.SportType, firstUser, team2[0]));

                    for (int k = 0; k < team1.Count; k++)
                    {
                        string matchId2 = Guid.NewGuid().ToString();
                        matches.Add(new Match(matchId2, tournamentId, firstDay, tournament.SportType, team1[k], team2[k + 1]));
                    }
                    var firstPlayerOfTeam2 = team2[0];
                    var lastPlayerOfTeam1 = team1[team1.Count - 1];

                    team1.RemoveAt(team1.Count - 1);
                    team2.RemoveAt(0);
                    team1.Insert(0, firstPlayerOfTeam2);
                    team2.Add(lastPlayerOfTeam1);
                    firstDay = firstDay.AddDays(1);
                }
            }

            while (matches.Exists(x => x.Player1.Id == "asdasd"))
            {                
                matches.Remove(matches.Find(x => x.Player1.Id == "asdasd"));
            }
            while (matches.Exists(x => x.Player2.Id == "asdasd"))
            {
                matches.Remove(matches.Find(x => x.Player2.Id == "asdasd"));
            }

            //matches.AddRange(matches.GetRange(0,matches.Count));

            //for (int i = matches.Count/2; i < matches.Count; i++)
            //{
            //    matches[i].Date = matches[i].Date.AddDays(totalDays);
            //}

            return matches;
        }

    }
}
