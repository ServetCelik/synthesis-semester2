using System.ComponentModel.DataAnnotations;

namespace WebApp.DTO
{
    public class StaffSignUpDTO
    {
        string userName;
        string password;
        string email;
        string role;

        public StaffSignUpDTO()
        {
        }


        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length is 4 characters.", MinimumLength = 4)]
        public string UserName { get => userName; set => userName = value; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        [Required]
        [EmailAddress(ErrorMessage = " Invalid e-mail adress.")]
        public string Email { get => email; set => email = value; }
        [Required]
        public string Role { get => role; set => role = value; }
    }
}
