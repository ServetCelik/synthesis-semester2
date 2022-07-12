using LogicLayer.Entities;
using LogicLayer.LogicClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class TournamentsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        TournamentAdministrator tournamentAdministrator;
        public TournamentsModel(ILogger<IndexModel> logger, TournamentAdministrator tournamentAdministrator)
        {
            _logger = logger;
            this.tournamentAdministrator = tournamentAdministrator;
        }

        [BindProperty]
        public List<Tournament> Tournaments { get; set; }
        public void OnGet()
        {
            Tournaments = tournamentAdministrator.GetTournamentList();
        }
    }
}
