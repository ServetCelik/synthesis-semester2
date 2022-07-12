using LogicLayer.Entities;
using LogicLayer.LogicClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Pages
{
    public class TheBestModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserAdministrator userAdministrator;


        public TheBestModel(ILogger<IndexModel> logger, UserAdministrator userAdministrator)
        {
            _logger = logger;
            this.userAdministrator = userAdministrator;
        }
        [BindProperty]
        public List<Player> players { get; set; }

        [BindProperty]
        public string Type { get; set; }
        public string[] Types = new[] { "By Rate", "By Total Win"};
    
    public void OnGet()
        {
            players = userAdministrator.CreateHonorListByRate();            
        }
        public void OnPost()
        {
            if (Type == "By Rate")
            {
                players = userAdministrator.CreateHonorListByRate();
            }
            else if (Type == "By Total Win")
            {
                players = userAdministrator.CreateHonorListByTotalWin();
            }
        }
    }
}
