using System.ComponentModel.DataAnnotations;

namespace PcColletion.Cms.Models
{
    public class NewUserModel
    {
        [Required(ErrorMessage = "Lütfen doldurunuz")]
        [MinLength(3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen doldurunuz")]
        [MinLength(6)]
        public string Password { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
        public string SurName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Lütfen doldurunuz")]
        public string Emails { get; set; }
        public string Phone { get; set; }

    }
}
