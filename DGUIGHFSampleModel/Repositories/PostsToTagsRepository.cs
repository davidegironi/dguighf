using System.Linq;
using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample.Model
{
    public class PostsToTagsRepository : GenericDataRepository<poststotags, DGUIGHFSampleModel>
    {
        public PostsToTagsRepository() : base() { }

        public override bool CanAdd(ref string[] errors, params poststotags[] items)
        {
            errors = new string[] { };

            bool ret = base.CanAdd(ref errors, items);
            if (!ret)
                return ret;

            foreach (poststotags item in items)
            {
                if (ret)
                {
                    if (Any(r => r.posts_id == item.posts_id && r.tags_id == item.tags_id))
                    {
                        ret = false;
                        errors = errors.Concat(new string[] { "Tag already inserted." }).ToArray();
                    }
                }

                if (!ret)
                    break;
            }

            return ret;
        }
    }
}
