using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity.Models
{
    public partial class poststotags
    {
        public int posts_id { get; set; }
        public int tags_id { get; set; }
        public string poststotags_comments { get; set; }

        public virtual posts posts { get; set; }
        public virtual tags tags { get; set; }
    }
}
