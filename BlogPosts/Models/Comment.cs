using System;
using System.Collections.Generic;

#nullable disable

namespace BlogPosts.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
