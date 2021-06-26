using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RandomMediaBackend.Models
{
    public class Users
    {
        
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Necessita de colocar um username")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Necessita de colocar uma password")]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Necessita de colocar um email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string ProfileImg { get; set; }
        [Required]
        public string BannerImg { get; set; }
        [Required]
        public string Bio { get; set; }

        public ICollection<Posts> ListPosts { get; set; }


    }
}
