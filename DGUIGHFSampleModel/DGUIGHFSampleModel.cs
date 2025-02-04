using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Context;
#endif
using System;
#if !NETFRAMEWORK
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
#endif

namespace DG.UIGHFSample.Model
{
    public class DGUIGHFSampleModel : GenericDataModel
    {
        // Logged Repositories
        public BlogsRepository Blogs { get; private set; }

        // Repositories
        public CommentsRepository Comments { get; private set; }
        public CommentsUsefulRepository CommentsUseful { get; private set; }
        public PostsRepository Posts { get; private set; }
        public PostsAdditionalsRepository PostsAdditionals { get; private set; }
        public PostsToTagsRepository PostsToTags { get; private set; }
        public TagsRepository Tags { get; private set; }

        /// <summary>
        /// Initialize the model
        /// </summary>
        public DGUIGHFSampleModel()
            : base()
        {
            Type contextType = typeof(dguighfsamplemodelContext);
            object[] contextParameters = null;

            Initialize(contextType, contextParameters);
        }
    }
}
