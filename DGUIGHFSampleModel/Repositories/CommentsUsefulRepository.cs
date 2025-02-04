using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample.Model
{
    public class CommentsUsefulRepository : GenericDataRepository<commentsuseful, DGUIGHFSampleModel>
    {
        public CommentsUsefulRepository() : base() { }
    }
}
