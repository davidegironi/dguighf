using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity
{
    public partial class tags
    {
        public tags()
        {
            poststotags = new HashSet<poststotags>();
        }

        public int tags_id { get; set; }
        public string tags_name { get; set; }

        public virtual ICollection<poststotags> poststotags { get; set; }
    }
}
