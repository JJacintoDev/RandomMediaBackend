using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RandomMediaBackend.Models
{
    public class Posts
    {
       

        [Key]
        public int PostID { get; set; }

        [Required]
        public string PostCategory { get; set; }

        [Required]
        public string PostTitle { get; set; }

        public string PostContent { get; set; }

        public string PostImage { get; set; }
        [Required]
        public string PostLikeness { get; set; }
        [Required]
        public int PostType { get; set; }
        [Required]
        public int PostViews { get; set; }
        [Required]
        public bool PinnedPost { get; set; }

        [Required]
        public DateTime PostDate { get; set; }


        [ForeignKey(nameof(User))]
        public string Username { get; set; }
        public Users User { get; set; }

        public ICollection<Comments> ListComments { get; set; }
    }
}
