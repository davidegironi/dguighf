using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity.Models
{
    public partial class commentsuseful
    {
        public int commentsuseful_id { get; set; }
        public int comments_id { get; set; }
        public byte commentsuseful_points { get; set; }

        public virtual comments comments { get; set; }
    }
}
