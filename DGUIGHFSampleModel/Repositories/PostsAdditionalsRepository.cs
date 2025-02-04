using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample.Model
{
    public class PostsAdditionalsRepository : GenericDataRepository<postsadditionals, DGUIGHFSampleModel>
    {
        public PostsAdditionalsRepository() : base() { }
    }

}
