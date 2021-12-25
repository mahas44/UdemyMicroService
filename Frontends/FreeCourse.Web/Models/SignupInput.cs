using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models
{
    public class SignupInput
    {
        [Required]
        [Display(Name = "Email adresiniz")]
        public string Email { get; set; }

        [Display(Name = "Şifreniz")]
        [Required]
        public string Password { get; set; }
        
        [Required]
        [Display(Name = "Kullanıcı adınız")]
        public string Username { get; set; }
     
        [Required]
        [Display(Name = "Şehir")]
        public string City { get; set; }
    }
}
