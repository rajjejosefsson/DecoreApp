using System.ComponentModel.DataAnnotations;

namespace Decore.ClientApp.ViewModels

{
    public class LoginViewModel
    {

       [Required(ErrorMessage = "Anget rätt användarnamn?")]
        public string Username { get; set; }

       [Required(ErrorMessage = "Anget rätt lösenord?")]
        public string Password { get; set; }
    }
}