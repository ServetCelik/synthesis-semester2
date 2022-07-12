using LogicLayer.Enums;
using LogicLayer.Factories;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entities
{
    public class Tournament
    {
        string id;
        string tournamentName;
        string sportType;
        string tournamentType;
        string description;
        string location;
        DateTime startDate;
        DateTime endDate;
        int minPlayers;
        int maxPlayers;
        List<Player> players;
        Staff whoCreated;        
        List<Match> matches;        
        Status status;

        public string Id { get => id;}
        public string TournamentName { get => tournamentName;}
        public string SportType { get => sportType;}
        public string TournamentType { get => tournamentType;}
        public string Description { get => description;}
        public string Location { get => location;}
        public DateTime StartDate { get => startDate;}
        public DateTime EndDate { get => endDate;}
        public int MinPlayers { get => minPlayers;}
        public int MaxPlayers { get => maxPlayers;}
        public List<Player> Players { get => players; set => players = value; }
        public Staff WhoCreated { get => whoCreated;}
        public List<Match> Matches { get => matches; set => matches = value; }
        public Status Status { get => status;}



        public Tournament(string id, string tournamentName, string sportType, string tournamentType, string description, string location, DateTime startDate, DateTime endDate, int minPlayers, int maxPlayers, Staff whoCreated, Status status)
        {           
            this.id = id;
            this.tournamentName = tournamentName;
            this.sportType = sportType;
            this.tournamentType = tournamentType;
            this.description = description;
            this.location = location;
            this.startDate = startDate;
            this.endDate = endDate;
            this.minPlayers = minPlayers;
            this.maxPlayers = maxPlayers;
            this.players = new List<Player>();
            this.whoCreated = whoCreated;
            this.matches = new List<Match>();
            this.status = status;
        }

        public bool AddPlayer(Player player)
        {
            bool doesAlreadyJoin = this.players.Exists(x=>x.Id==player.Id);
            if (!doesAlreadyJoin & this.status==Status.applicable)
            {
                this.players.Add(player);
                return true;
            }
            return false;
        }
        public bool DeletePlayer(Player player)
        {
            bool didThisPlayerJoin = this.players.Exists(x => x.Id == player.Id);
            if (didThisPlayerJoin & this.matches.Count==0)
            {
                players.Remove(player);
                return true;
            }
            return false;
        }
                
        public bool GenerateMatches()
        {
            if (this.status==Status.inapplicable & this.players.Count>=this.MinPlayers)
            {
                ITournamentSystem tournamentSystem = TournamentSystemFactory.SystemFactory(tournamentType);
                List<Match> generatedMatches = tournamentSystem.GenerateMatches(this);
                this.matches.AddRange(generatedMatches);
                return true;
            }
            return false;                       
        }

        public bool UpdateStatus()
        {
            var firstStatus = this.status;

            if (DateTime.Now.AddDays(7) >= this.startDate & this.players.Count < this.minPlayers)
            {
                this.status = Status.canceled;
            }
            else if (DateTime.Now.AddDays(7) > this.startDate & DateTime.Now < this.startDate & this.players.Count >= this.minPlayers)
            {
                this.status = Status.inapplicable;
            }

            else if (DateTime.Now >= this.startDate & DateTime.Now < this.endDate & this.players.Count >= this.minPlayers)
            {
                this.status = Status.started;
            }
            else if (DateTime.Now > this.endDate & this.players.Count >= this.minPlayers)
            {
                this.status = Status.finished;
            }
            if (this.status!=firstStatus)
            {
               return true;
            }
            return false;
        }


    }
}
