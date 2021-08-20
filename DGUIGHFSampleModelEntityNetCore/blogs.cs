using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity
{
    public partial class blogs
    {
        public blogs()
        {
            posts = new HashSet<posts>();
        }

        public int blogs_id { get; set; }
        public string blogs_title { get; set; }
        public string blogs_description { get; set; }
        public DateTime blogs_date { get; set; }

        public virtual ICollection<posts> posts { get; set; }
    }
}
