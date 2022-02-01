using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class User{
        public User(){

        }
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        [Required]
        [MinLength(3)]
        [Display(Name = "Your Username: ")]
        public string Username {get; set;} = string.Empty;

        [Required]
        [EmailAddress]
        public string Email {get; set;} = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;} = string.Empty;
    }



}