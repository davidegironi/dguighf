using DG.Data.Model;
#if NETFRAMEWORK
using DG.UIGHFSample.Model.Entity;
#else
using DG.UIGHFSample.Model.Entity.Models;
#endif
using System;
using System.Linq;

namespace DG.UIGHFSample.Model
{
    public class PostsRepository : GenericDataRepository<posts, DGUIGHFSampleModel>
    {
        public PostsRepository() : base() { }

        public class PostsRepositoryLanguage : IGenericDataRepositoryLanguage
        {
            public string postRepositoryE001 = "A Blog must be selected.";
            public string postRepositoryE002 = "Post title could not be empty.";
            public string postRepositoryE003 = "Post already inserted.";
        }

        public PostsRepositoryLanguage language = new PostsRepositoryLanguage();

        public override void Add(params posts[] items)
        {
            base.Add(items);

            foreach (posts item in items)
            {
                postsadditionals postsadditionals = new postsadditionals();
                postsadditionals.posts_id = item.posts_id;
                postsadditionals.postsadditionals_note = null;
                BaseModel.PostsAdditionals.Add(postsadditionals);
            }
        }

        public override void Remove(params posts[] items)
        {
            foreach (posts item in items)
            {
                BaseModel.PostsAdditionals.Remove(BaseModel.PostsAdditionals.Find(item.posts_id));
            }

            base.Remove(items);
        }

        public override bool CanAdd(ref string[] errors, params posts[] items)
        {
            errors = new string[] { };

            bool ret = base.CanAdd(ref errors, items);
            if (!ret)
                return ret;

            foreach (posts item in items)
            {
                //do not check this external key, to check exception handler
                //if (!BaseModel.Blogs.Any(r => r.blogs_id == item.blogs_id))
                //{
                //    ret = false;
                //    errors = errors.Concat(new string[] { language.postRepositoryE001 }).ToArray();
                //}

                if (String.IsNullOrEmpty(item.posts_title))
                {
                    ret = false;
                    errors = errors.Concat(new string[] { language.postRepositoryE002 }).ToArray();
                }

                if (ret)
                {
                    if (Any(r => r.blogs_id == item.blogs_id && r.posts_title == item.posts_title))
                    {
                        ret = false;
                        errors = errors.Concat(new string[] { language.postRepositoryE003 }).ToArray();
                    }
                }

                if (!ret)
                    break;
            }

            return ret;
        }

        public override bool CanUpdate(ref string[] errors, params posts[] items)
        {
            errors = new string[] { };

            bool ret = base.CanUpdate(ref errors, items);
            if (!ret)
                return ret;

            foreach (posts item in items)
            {
                if (!BaseModel.Blogs.Any(r => r.blogs_id == item.blogs_id))
                {
                    ret = false;
                    errors = errors.Concat(new string[] { language.postRepositoryE001 }).ToArray();
                }

                if (String.IsNullOrEmpty(item.posts_title))
                {
                    ret = false;
                    errors = errors.Concat(new string[] { language.postRepositoryE002 }).ToArray();
                }

                if (ret)
                {
                    if (Any(r => r.blogs_id == item.blogs_id && r.posts_id != item.posts_id && r.posts_title == item.posts_title))
                    {
                        ret = false;
                        errors = errors.Concat(new string[] { language.postRepositoryE003 }).ToArray();
                    }
                }

                if (!ret)
                    break;
            }

            return ret;
        }

        public override bool CanRemove(bool checkForeingKeys, string[] excludedForeingKeys, ref string[] errors, params posts[] items)
        {
            errors = new string[] { };

            if (excludedForeingKeys != null && !excludedForeingKeys.Contains("FK_postsadditionals_posts"))
                excludedForeingKeys = excludedForeingKeys.Concat(new string[] { "FK_postsadditionals_posts" }).ToArray();
            else
                excludedForeingKeys = new string[] { "FK_postsadditionals_posts" };

            return base.CanRemove(checkForeingKeys, excludedForeingKeys, ref errors, items);
        }


    }

}
