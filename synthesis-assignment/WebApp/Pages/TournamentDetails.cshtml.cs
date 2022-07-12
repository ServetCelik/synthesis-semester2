using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.Mappers;

namespace WebApp.Pages
{
    public class TournamentDetailsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        TournamentAdministrator tournamentAdministrator;
        UserAdministrator userAdministrator;
        public TournamentDetailsModel(ILogger<IndexModel> logger, TournamentAdministrator tournamentAdministrator, UserAdministrator userAdministrator)
        {
            _logger = logger;
            this.tournamentAdministrator = tournamentAdministrator;
            this.userAdministrator = userAdministrator;
        }
        private Player loggedUser;


        [BindProperty]
        public TournamentDTO TournamentDTO { get; set; }
        [BindProperty]
        public Dictionary<string, int> LeaderBoard { get; set; }
        private List<Tournament> tournaments;

        private Tournament TheTournament;       

        [BindProperty]
        public string id { get; set; }
        //[BindProperty]
        //public string name { get; set; }

        public void OnGet(string id)
        {
            this.id = id;
            tournaments = tournamentAdministrator.GetTournamentList();
            TheTournament = tournaments.Find(x => x.Id == id);
            TournamentDTO = DTOMapper.MapTournamentToDTO(TheTournament);
            LeaderBoard = tournamentAdministrator.TournamentLeaderBoard(TheTournament);
           
            //Tournament = DTOMapper.MapTournamentToDTO(normalTournament);
        }

        public IActionResult OnPost()
        {
            tournaments = tournamentAdministrator.GetTournamentList();
            TheTournament = tournaments.Find(x => x.Id == id);
            TournamentDTO = DTOMapper.MapTournamentToDTO(TheTournament);

            try
            {
                loggedUser = (Player)userAdministrator.FindUserByUserName(User.Identity.Name);

                if (tournamentAdministrator.AddPlayerToTournament(TheTournament, loggedUser))
                {
                    TempData["Success"] = $"You joined the {TheTournament.TournamentName.ToUpper()} tournament";
                    return RedirectToPage("/Index");
                }
                TempData["Danger"] = "It is not possible to Join to this tournament";
                return new PageResult();
            }
            catch (UserDoesntExistException ex)
            {
                TempData["Danger"] = ex.Message;
                return new PageResult();
            }
            
        }

    }
}
