using System.ComponentModel.DataAnnotations;

namespace Morgoth.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adını girin")]
        public string username { get; set; }



        [Required(ErrorMessage = "Sifre girin")]
        public string password { get; set; }
    }
}
