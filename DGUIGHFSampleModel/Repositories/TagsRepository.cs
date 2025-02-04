using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif

namespace DG.UIGHFSample.Model
{
    public class TagsRepository : GenericDataRepository<tags, DGUIGHFSampleModel>
    {
        public TagsRepository() : base() { }
    }
}
