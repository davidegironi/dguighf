using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity
{
    public partial class posts
    {
        public posts()
        {
            comments = new HashSet<comments>();
            poststotags = new HashSet<poststotags>();
        }

        public int posts_id { get; set; }
        public int blogs_id { get; set; }
        public string posts_title { get; set; }
        public string posts_text { get; set; }
        public string posts_username { get; set; }
        public string posts_email { get; set; }

        public virtual blogs blogs { get; set; }
        public virtual postsadditionals postsadditionals { get; set; }
        public virtual ICollection<comments> comments { get; set; }
        public virtual ICollection<poststotags> poststotags { get; set; }
    }
}
