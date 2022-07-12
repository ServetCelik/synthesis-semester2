using LogicLayer.Entities;
using LogicLayer.Enums;

namespace WebApp.DTO
{
    public class TournamentDTO
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
        public TournamentDTO()
        {
        }

        public string Id { get => id; set => id = value; }
        public string TournamentName { get => tournamentName; set => tournamentName = value; }
        public string SportType { get => sportType; set => sportType = value; }
        public string TournamentType { get => tournamentType; set => tournamentType = value; }
        public string Description { get => description; set => description = value; }
        public string Location { get => location; set => location = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int MinPlayers { get => minPlayers; set => minPlayers = value; }
        public int MaxPlayers { get => maxPlayers; set => maxPlayers = value; }
        public List<Player> Players { get => players; set => players = value; }
        public Staff WhoCreated { get => whoCreated; set => whoCreated = value; }
        public List<Match> Matches { get => matches; set => matches = value; }
        public Status Status { get => status; set => status = value; }
       


        //public string Id { get => Id; set => Id = value; }
        //public string TournamentName { get => TournamentName; set => TournamentName = value; }
        //public string SportType { get => SportType; set => SportType = value; }
        //public string TournamentType { get => TournamentType; set => TournamentType = value; }
        //public string Description { get => Description; set => Description = value; }
        //public string Location { get => Location; set => Location = value; }
        //public DateTime StartDate { get => StartDate; set => StartDate = value; }
        //public DateTime EndDate { get => EndDate; set => EndDate = value; }
        //public int MinPlayers { get => MinPlayers; set => MinPlayers = value; }
        //public int MaxPlayers { get => MaxPlayers; set => MaxPlayers = value; }
        //public List<Player> Players { get => Players; set => Players = value; }
        //public Staff WhoCreated { get => WhoCreated; set => WhoCreated = value; }
        //public List<Match> Matches { get => Matches; set => Matches = value; }
        //public Status Status { get => Status; set => Status = value; }
    }
}
