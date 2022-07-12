using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using LogicLayer.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.Mappers;

namespace WebApp.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        private UserAdministrator userAdministrator;        

        public SignUpModel(ILogger<IndexModel> logger, UserAdministrator userAdministrator)
        {
            _logger = logger;
            this.userAdministrator = userAdministrator;            
        }

        [BindProperty]
        public PlayerSignUpDTO Player { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostAsync()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            else
            {
                Player newPlayer = DTOMapper.MapPlayerSignUpDTOToPlayer(Player);

                if (!userAdministrator.CheckUserNameExistence(newPlayer) & !userAdministrator.CheckEmailExistence(newPlayer))
                {
                    userAdministrator.CreateUser(newPlayer);
                    TempData["Success"] = "Your account is succesfully created";
                    return RedirectToPage("/Login");
                }
                else if (userAdministrator.CheckUserNameExistence(newPlayer))
                {
                    TempData["Danger"] = "This username exists";
                    return new PageResult();
                }
                else if (userAdministrator.CheckEmailExistence(newPlayer))
                {
                    TempData["Danger"] = "This email exists";
                    return new PageResult();
                }
                
                return Page();
            }

        }
    }
}
