using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RandomMediaBackend.Models
{
    public class Comments
    {
       

        [Key]
        public int CommentsID { get; set; }

        [Required]
        public string CommentsText { get; set; }
        [Required]
        public DateTime CommentDate { get; set; }
        [Required]
        public int CommentLikeness { get; set; }


        [ForeignKey(nameof(User))]
        [Required]
        public string Username { get; set; }
        public Users User { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostFK { get; set; }
        public Posts Post { get; set; }


    }
}
