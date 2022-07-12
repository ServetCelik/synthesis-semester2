using System.ComponentModel.DataAnnotations;

namespace WebApp.DTO
{
    public class PlayerSignUpDTO
    {        
        string userName;
        string password;       
        string email;
        string firstName;
        string lastName;
        

        public PlayerSignUpDTO()
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
        [StringLength(25, ErrorMessage = "The minimum allowed length is 4 characters.", MinimumLength = 3)]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required]
        [StringLength(25, ErrorMessage = "The minimum allowed length is 4 characters.", MinimumLength = 3)]
        public string LastName { get => lastName; set => lastName = value; }
    }
}
