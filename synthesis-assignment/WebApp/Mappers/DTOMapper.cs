using LogicLayer.Entities;
using LogicLayer.Utility;
using WebApp.DTO;

namespace WebApp.Mappers
{
    public static class DTOMapper
    {
        public static Staff MapStaffSignUpToStaff (StaffSignUpDTO DTO)
        {
            string id = Guid.NewGuid().ToString();
            string salt = Guid.NewGuid().ToString();
            string hashedPassword = PasswordHasher.sha256_hash(DTO.Password + salt);
            return new Staff(id, DTO.UserName, hashedPassword, salt, DTO.Email, DTO.Role);
        }

        public static Player MapPlayerSignUpDTOToPlayer(PlayerSignUpDTO DTO)
        {
            string id = Guid.NewGuid().ToString();
            string salt = Guid.NewGuid().ToString();
            string hashedPassword = PasswordHasher.sha256_hash(DTO.Password + salt);
            return new Player(id, DTO.UserName, hashedPassword, salt, DTO.Email, DTO.FirstName, DTO.LastName, 0, 0);
        }

        public static TournamentDTO MapTournamentToDTO(Tournament tournament)
        {
            TournamentDTO tournamentDTO = new TournamentDTO();
            tournamentDTO.Id = tournament.Id;
            tournamentDTO.TournamentName = tournament.TournamentName;
            tournamentDTO.SportType = tournament.SportType;
            tournamentDTO.TournamentType = tournament.TournamentType;
            tournamentDTO.Description = tournament.Description;
            tournamentDTO.Location = tournament.Location;
            tournamentDTO.StartDate = tournament.StartDate;
            tournamentDTO.EndDate = tournament.EndDate;
            tournamentDTO.MinPlayers = tournament.MinPlayers;
            tournamentDTO.MaxPlayers = tournament.MaxPlayers;
            tournamentDTO.Players = tournament.Players;
            tournamentDTO.WhoCreated = tournament.WhoCreated;
            tournamentDTO.Matches = tournament.Matches;
            tournamentDTO.Status = tournament.Status;

            return tournamentDTO;

        }
 
    }
}
