using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using LogicLayer.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.DTO;
using WebApp.Mappers;

namespace WebApp.Pages
{
    [Authorize(Policy = "MustBeHr")]
    public class StaffSignUpModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private UserAdministrator userAdministrator;

        public StaffSignUpModel(ILogger<IndexModel> logger, UserAdministrator userAdministrator)
        {
            _logger = logger;
            this.userAdministrator = userAdministrator;
        }

        [BindProperty]
        public StaffSignUpDTO NewStaff { get; set; }

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
                Staff staff = DTOMapper.MapStaffSignUpToStaff(NewStaff);

                if (!userAdministrator.CheckUserNameExistence(staff) & !userAdministrator.CheckEmailExistence(staff))
                {
                    userAdministrator.CreateUser(staff);
                    TempData["Success"] = "New staff is successfully created";
                    return RedirectToPage("/Login");
                }
                else if (userAdministrator.CheckUserNameExistence(staff))
                {
                    TempData["Danger"] = "This Username exists";
                }
                else if (userAdministrator.CheckEmailExistence(staff))
                {
                    TempData["Danger"] = "This mail exists";
                }

                return Page();
            }

        }
    }
}
