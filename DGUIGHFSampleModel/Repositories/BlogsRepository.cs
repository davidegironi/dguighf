using System.Linq;
using DG.Data.Model;
using DG.UIGHFSample.Model.Entity;
using System;

namespace DG.UIGHFSample.Model
{
    public class BlogsRepository : GenericDataRepository<blogs, DGUIGHFSampleModel>
    {
        public BlogsRepository() : base() { }

        public class BlogsRepositoryLanguage : IGenericDataRepositoryLanguage
        {
            public string blogRepositoryE001 = "Blog title can not be null or empty.";
            public string blogRepositoryE002 = "Blog already inserted.";
        }

        public BlogsRepositoryLanguage language = new BlogsRepositoryLanguage();

        public override bool CanAdd(ref string[] errors, params blogs[] items)
        {
            errors = new string[] { };

            bool ret = base.CanAdd(ref errors, items);
            if (!ret)
                return ret;

            foreach (blogs item in items)
            {
                if(String.IsNullOrEmpty(item.blogs_title))
                {
                    ret = false;
                    errors = errors.Concat(new string[] { language.blogRepositoryE001 }).ToArray();
                }

                if (ret)
                {
                    if (Any(r => r.blogs_title == item.blogs_title))
                    {
                        ret = false;
                        errors = errors.Concat(new string[] { language.blogRepositoryE002 }).ToArray();
                    }
                }

                if (!ret)
                    break;
            }

            return ret;
        }

        public override bool CanUpdate(ref string[] errors, params blogs[] items)
        {
            errors = new string[] { };

            bool ret = base.CanUpdate(ref errors, items);
            if (!ret)
                return ret;

            foreach (blogs item in items)
            {
                if (String.IsNullOrEmpty(item.blogs_title))
                {
                    ret = false;
                    errors = errors.Concat(new string[] { language.blogRepositoryE001 }).ToArray();
                }

                ////disable to test stacktracer
                //if (ret)
                //{
                //    if (Any(r => r.blogs_id != item.blogs_id && r.blogs_title == item.blogs_title))
                //    {
                //        ret = false;
                //        errors = errors.Concat(new string[] { language.blogRepositoryE002 }).ToArray();
                //    }
                //}

                if (!ret)
                    break;
            }

            return ret;
        }
    }
}
