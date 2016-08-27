using DG.Data.Model;
using DG.UIGHFSample.Model.Entity;
using System;

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
            Type contextType = typeof(dguighftestEntities);
            object[] contextParameters = null;

            Initialize(contextType, contextParameters);
        }
    }
}
