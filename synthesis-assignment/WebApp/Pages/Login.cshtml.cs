using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using LogicLayer.Utility;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Authentication;
using System.Security.Claims;
using WebApp.DTO;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserAdministrator userAdministrator;
        

        public LoginModel(ILogger<IndexModel> logger, UserAdministrator userAdministrator)
        {
            _logger = logger;
            this.userAdministrator = userAdministrator;           
        }

        [BindProperty]
        public UserLoginDTO LoggedUser { get; set; }
        private User user;

        public void OnGet()
        {
            

        }

        public IActionResult OnPostAsync()
        {
            if (ModelState.IsValid)
            {                
                return HandleLogin();
            }

            return new PageResult();
        }

        private IActionResult HandleLogin()
        {
            try
            {
                if (userAdministrator.CheckLogin(LoggedUser.UserName , LoggedUser.Password))
                {
                    user = userAdministrator.FindUserByUserName(LoggedUser.UserName);
                    SetupSessionCookie();
                    TempData["Success"] = "You are loggedin";
                    return new RedirectToPageResult("index");
                }
                return new PageResult();
            }
            catch(UserDoesntExistException ex)
            {
                TempData["White"] = ex.Message;
                return new PageResult();
            }
            catch (LogicLayer.Exceptions.AuthenticationException ex)
            {
                TempData["White"] = ex.Message;
                return new PageResult();            
            }
            catch (EntityNotFoundException ex)
            {
                TempData["White"] = ex.Message;
                return new PageResult();               
            }
            catch (System.NullReferenceException)
            {
                TempData["White"] = new LogicLayer.Exceptions.NullReferenceException().Message;
                return new PageResult();
                
            }

        }

        private void SetupSessionCookie()
        {            
            var claims = new List<Claim> {
                new Claim( ClaimTypes.Name, user.UserName),
                new Claim("Status", "LoggedIn")
            };
            if (user is Staff)
            {
                Staff player = (Staff)user;
                claims.Add(new Claim(ClaimTypes.Role, player.Role));
            }
            //var myAuthType = "cookieAuth";
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(/*myAuthType, */claimsPrincipal); // this line create the cookie 
        }

        


    }
}
