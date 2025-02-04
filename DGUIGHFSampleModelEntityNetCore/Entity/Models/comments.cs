using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity.Models
{
    public partial class comments
    {
        public comments()
        {
            commentsuseful = new HashSet<commentsuseful>();
        }

        public int comments_id { get; set; }
        public int posts_id { get; set; }
        public string comments_text { get; set; }
        public string comments_username { get; set; }
        public string comments_email { get; set; }

        public virtual posts posts { get; set; }
        public virtual ICollection<commentsuseful> commentsuseful { get; set; }
    }
}
