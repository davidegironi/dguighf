using DG.Data.Model;
using DG.UIGHFSample.Model.Entity;

namespace DG.UIGHFSample.Model
{
    public class CommentsRepository : GenericDataRepository<comments, DGUIGHFSampleModel>
    {
        public CommentsRepository() : base() { }
    }
}
