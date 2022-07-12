using LogicLayer.LogicClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private TournamentAdministrator tournamentAdministrator;
        //private UserAdministrator userAdministrator;

        public IndexModel(ILogger<IndexModel> logger/*, TournamentAdministrator tournamentAdministrator, UserAdministrator userAdministrator*/)
        {
            _logger = logger;
            //this.tournamentAdministrator = tournamentAdministrator;
            //this.userAdministrator = userAdministrator;
        }

        public void OnGet()
        {
            
        }
    }
}