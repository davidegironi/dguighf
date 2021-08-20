using System;
using System.Collections.Generic;

#nullable disable

namespace DG.UIGHFSample.Model.Entity
{
    public partial class postsadditionals
    {
        public int posts_id { get; set; }
        public string postsadditionals_note { get; set; }

        public virtual posts posts { get; set; }
    }
}
