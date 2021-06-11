using System;
using System.Collections.Generic;

#nullable disable

namespace BlogPosts.Models
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string PostContent { get; set; }
        public DateTime? PostDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
