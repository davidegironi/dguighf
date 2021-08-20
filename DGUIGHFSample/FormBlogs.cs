#define MULTISELECT

using DG.Data.Model.Helpers;
using DG.UI.GHF;
using DG.UIGHFSample.Model;
using DG.UIGHFSample.Model.Entity;
using DG.UIGHFSample.Objects.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DG.UIGHFSample
{
    public partial class FormBlogs : DGUIGHFForm
    {
        private DGUIGHFSampleModel samplemodel = null;

        private TabElement tabElement_tabBlogs = new TabElement();
        private TabElement tabElement_tabPostslist = new TabElement();
        private TabElement tabElement_tabPostslist_tabPosts = new TabElement();
        private TabElement tabElement_tabPostslist_tabCommentslist = new TabElement();
        private TabElement tabElement_tabPostslist_tabCommentslist_tabComments = new TabElement();
        private TabElement tabElement_tabPostslist_tabCommentslist_tabCommentsuseful = new TabElement();

        private bool _debug = true;

        public FormBlogs()
        {
            InitializeComponent();

            Initialize(Program.uighfApplication);

#if MULTISELECT
            dataGridView_list.MultiSelect = true;
            dataGridView_tabPostslist_list.MultiSelect = true;
            dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.MultiSelect = true;

            dataGridView_list.SelectionChanged += dataGridView_list_SelectionChanged;
            dataGridView_tabPostslist_list.SelectionChanged += dataGridView_tabPostslist_list_SelectionChanged;
            dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list.SelectionChanged += dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list_SelectionChanged;
#endif

            samplemodel = new DGUIGHFSampleModel();
            samplemodel.LanguageHelper.LoadFromFile(Program.uighfApplication.LanguageFilename);
        }

        /// <summary>
        /// Initialize TabElements
        /// </summary>
        protected override void InitializeTabElements()
        {
            //set sort on View bindingSource
            vBlogsBindingSource.Sort = "title";
            vPostsBindingSource.Sort = "title";
            vCommentsBindingSource.Sort = "text";
            vCommentsUsefulBindingSource.Sort = "points";

            //set Readonly OnSetEditingMode for Controls
            DisableReadonlyCheckOnSetEditingModeControlCollection.Add(typeof(DataGridView));

            //set Main BindingSource
            BindingSourceMain = vBlogsBindingSource;
            GetDataSourceMain = GetDataSource_main;

#if MULTISELECT
            //set Main list multiselect
            IsBindingSourceMainMultiselect = true;
#endif

            //set Main TabControl
            TabControlMain = tabControl_main;

            //set Main Panels
            PanelFiltersMain = panel_filters;
            PanelListMain = panel_list;
            PanelsExtraMain = null;

            //commentsuseful Element
            tabElement_tabPostslist_tabCommentslist_tabCommentsuseful.TabPageElement = tabPage_tabPostslist_tabCommentslist_tabCommentsuseful;
            tabElement_tabPostslist_tabCommentslist_tabCommentsuseful.ElementListItem = new TabElement.TabElementListItem()
            {
                PanelFilters = null,
                PanelList = panel_tabPostslist_tabCommentslist_tabCommentsuseful_list,

                PanelData = panel_tabPostslist_tabCommentslist_tabCommentsuseful_data,
                PanelActions = panel_tabPostslist_tabCommentslist_tabCommentsuseful_actions,
                PanelUpdates = panel_tabPostslist_tabCommentslist_tabCommentsuseful_updates,

                BindingSourceList = vCommentsUsefulBindingSource,
                GetDataSourceList = GetDataSourceList_tabPostslist_tabCommentsuseful,
                GetDataSourceEmptyList = GetDataSourceEmptyList_tabPostslist_tabCommentsuseful,

#if MULTISELECT
                CountSelectedItems = CountSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful,
                GetSelectedItems = GetSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful,
                IsBindingSourceListMultiselect = true,
#endif

                BindingSourceEdit = commentsusefulBindingSource,
                GetDataSourceEdit = GetDataSourceEdit_tabPostslist_tabCommentslist_tabCommentsuseful,
                AfterSaveAction = AfterSaveAction_tabPostslist_tabCommentslist_tabCommentsuseful,

                AddButton = button_tabPostslist_tabCommentslist_tabCommentsuseful_new,
                IsAddButtonDefaultClickEventAttached = false,
                UpdateButton = button_tabPostslist_tabCommentslist_tabCommentsuseful_edit,
                RemoveButton = button_tabPostslist_tabCommentslist_tabCommentsuseful_delete,
                SaveButton = button_tabPostslist_tabCommentslist_tabCommentsuseful_save,
                CancelButton = button_tabPostslist_tabCommentslist_tabCommentsuseful_cancel,

                Add = Add_tabPostslist_tabCommentslist_tabCommentsuseful,
                Update = Update_tabPostslist_tabCommentslist_tabCommentsuseful,
                Remove = Remove_tabPostslist_tabCommentslist_tabCommentsuseful
            };
            tabElement_tabPostslist_tabCommentslist_tabCommentsuseful.ElementListItem.BindingSourceListChanged += tabPostslist_tabCommentslist_BindingSourceListChanged;
            tabElement_tabPostslist_tabCommentslist_tabCommentsuseful.ElementListItem.BindingSourceEditChanged += tabPostslist_tabCommentslist_BindingSourceEditChanged;

            //comments Element
            tabElement_tabPostslist_tabCommentslist_tabComments.TabPageElement = tabPage_tabPostslist_tabCommentslist_tabComments;
            tabElement_tabPostslist_tabCommentslist_tabComments.ElementItem = new TabElement.TabElementItem()
            {
                PanelData = panel_tabPostslist_tabCommentslist_tabComments_data,
                PanelActions = panel_tabPostslist_tabCommentslist_tabComments_actions,
                PanelUpdates = panel_tabPostslist_tabCommentslist_tabComments_updates,

                ParentBindingSourceList = vCommentsBindingSource,
                GetParentDataSourceList = GetDataSourceList_tabPostslist_tabComments,

                BindingSourceEdit = commentsBindingSource,
                GetDataSourceEdit = GetDataSourceEdit_tabPostslist_tabCommentslist_tabComments,
                AfterSaveAction = AfterSaveAction_tabPostslist_tabCommentslist_tabComments,

                AddButton = button_tabPostslist_tabCommentslist_tabComments_new,
                IsAddButtonDefaultClickEventAttached = false,
                UpdateButton = button_tabPostslist_tabCommentslist_tabComments_edit,
                RemoveButton = button_tabPostslist_tabCommentslist_tabComments_delete,
                SaveButton = button_tabPostslist_tabCommentslist_tabComments_save,
                CancelButton = button_tabPostslist_tabCommentslist_tabComments_cancel,

                Add = Add_tabPostslist_tabCommentslist_tabComments,
                Update = Update_tabPostslist_tabCommentslist_tabComments,
                Remove = Remove_tabPostslist_tabCommentslist_tabComments
            };

            //commentslist Element
            tabElement_tabPostslist_tabCommentslist.TabPageElement = tabPage_tabPostslist_tabCommentslist;
            tabElement_tabPostslist_tabCommentslist.ElementListTabs = new TabElement.TabElementListTabs()
            {
                PanelFilters = null,
                PanelList = panel_tabPostslist_tabCommentslist_list,
                PanelData = panel_tabPostslist_tabCommentslist_data,

                BindingSourceList = vCommentsBindingSource,
                GetDataSourceList = GetDataSourceList_tabPostslist_tabComments,
                GetDataSourceEmptyList = GetDataSourceEmptyList_tabPostslist_tabComments,

#if MULTISELECT
                CountParentSelectedItems = CountParentSelectedItems_tabPostslist_tabComments,
#endif

                TabControlElement = tabControl_tabPostslist_tabCommentslist,
                TabElements = new List<TabElement>()
                {
                    tabElement_tabPostslist_tabCommentslist_tabComments,
                    tabElement_tabPostslist_tabCommentslist_tabCommentsuseful
                }
            };

            //posts Element
            tabElement_tabPostslist_tabPosts.TabPageElement = tabPage_tabPostslist_tabPosts;
            tabElement_tabPostslist_tabPosts.ElementItem = new TabElement.TabElementItem()
            {
                PanelData = panel_tabPostslist_tabPosts_data,
                PanelActions = panel_tabPostslist_tabPosts_actions,
                PanelUpdates = panel_tabPostslist_tabPosts_updates,

                ParentBindingSourceList = vPostsBindingSource,
                GetParentDataSourceList = GetParentDataSourceList_tabPosts,

#if MULTISELECT
                CountParentSelectedItems = CountParentSelectedItems_tabPostslist_tabPosts,
                GetParentSelectedItems = GetSelectedItems_tabPostslist_tabPosts,
#endif

                BindingSourceEdit = postsBindingSource,
                GetDataSourceEdit = GetDataSourceEdit_tabPostslist_tabPosts,
                AfterSaveAction = AfterSaveAction_tabPostslist_tabPosts,

                AddButton = button_tabPostslist_tabPosts_new,
                IsAddButtonDefaultClickEventAttached = false,
                UpdateButton = button_tabPostslist_tabPosts_edit,
                RemoveButton = button_tabPostslist_tabPosts_delete,
                SaveButton = button_tabPostslist_tabPosts_save,
                CancelButton = button_tabPostslist_tabPosts_cancel,

                Add = Add_tabPostslist_tabPosts,
                Update = Update_tabPostslist_tabPosts,
                Remove = Remove_tabPostslist_tabPosts
            };

            //blogs Element
            tabElement_tabBlogs.TabPageElement = tabPage_tabBlogs;
            tabElement_tabBlogs.ElementItem = new TabElement.TabElementItem()
            {
                PanelData = panel_tabBlogs_data,
                PanelActions = panel_tabBlogs_actions,
                PanelUpdates = panel_tabBlogs_updates,

                ParentBindingSourceList = vBlogsBindingSource,
                GetParentDataSourceList = GetDataSource_main,

#if MULTISELECT
                CountParentSelectedItems = CountParentSelectedItems_tabBlogs,
                GetParentSelectedItems = GetSelectedItems_tabBlogs,
#endif

                BindingSourceEdit = blogsBindingSource,
                GetDataSourceEdit = GetDataSourceEdit_tabBlogs,
                AfterSaveAction = AfterSaveAction_tabBlogs,

                AddButton = button_tabBlogs_new,
                IsAddButtonDefaultClickEventAttached = false,
                UpdateButton = button_tabBlogs_edit,
                RemoveButton = button_tabBlogs_delete,
                SaveButton = button_tabBlogs_save,
                CancelButton = button_tabBlogs_cancel,

                Add = Add_tabBlogs,
                Update = Update_tabBlogs,
                Remove = Remove_tabBlogs
            };

            //postslist Element
            tabElement_tabPostslist.TabPageElement = tabPage_tabPostslist;
            tabElement_tabPostslist.ElementListTabs = new TabElement.TabElementListTabs()
            {
                PanelFilters = null,
                PanelList = panel_tabPostslist_list,
                PanelData = panel_tabPostslist_data,

                BindingSourceList = vPostsBindingSource,
                GetDataSourceList = GetParentDataSourceList_tabPosts,
                GetDataSourceEmptyList = GetParentDataSourceEmptyList_tabPosts,

#if MULTISELECT
                CountParentSelectedItems = CountParentSelectedItems_tabPostslist,
                IsBindingSourceListMultiselect = true,
#endif

                TabControlElement = tabControl_tabPostslist,
                TabElements = new List<TabElement>()
                {
                    tabElement_tabPostslist_tabPosts,
                    tabElement_tabPostslist_tabCommentslist
                }
            };

            TabElements.Add(tabElement_tabBlogs);
            TabElements.Add(tabElement_tabPostslist);
        }

        private void FormBlogs_Load(object sender, EventArgs e)
        {
            ReloadView();
        }

        private void button_reloadview_Click(object sender, EventArgs e)
        {
            ReloadView();
        }

        private object GetDataSource_main()
        {
            if (_debug)
                Console.WriteLine("GetDataSource_main");

            IEnumerable<VBlogs> vBlogs =
                samplemodel.Blogs.List().Select(
                r => new VBlogs
                {
                    blogs_id = r.blogs_id,
                    title = r.blogs_title,
                    date = r.blogs_date
                }).ToList();

            return DGDataTableUtils.ToDataTable<VBlogs>(vBlogs);
        }


        #region tabBlogs

        private object GetDataSourceEdit_tabBlogs()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabBlogs");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, vBlogsBindingSource, new string[] { "blogs_id" });
        }

        private void AfterSaveAction_tabBlogs(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabBlogs");

            DGUIGHFData.SetBindingSourcePosition<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, item, vBlogsBindingSource);
        }

        private void Add_tabBlogs(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabBlogs");

            DGUIGHFData.Add<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, item);
        }

        private void Update_tabBlogs(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabBlogs");

            DGUIGHFData.Update<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, item);
        }

        private void Remove_tabBlogs(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabBlogs");

            DGUIGHFData.Remove<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, item);
        }

        private void button_tabBlogs_new_Click(object sender, EventArgs e)
        {
            if (AddClick(tabElement_tabBlogs))
            {
                blogs_dateDateTimePicker.Value = DateTime.Now;
            }
        }

        #endregion


        #region tabPosts

        private object GetParentDataSourceList_tabPosts()
        {
            if (_debug)
                Console.WriteLine("GetParentDataSourceList_tabPosts");

            object ret = null;

            int blogs_id = -1;

            if (vBlogsBindingSource.Current != null)
            {
#if NETFRAMEWORK
                blogs_id = Int32.Parse((((DataRowView)vBlogsBindingSource.Current).Row)["blogs_id"].ToString());
#else
                blogs_id = (((DataRowView)vBlogsBindingSource.Current).Row).Field<int>("blogs_id");
#endif
            }

            IEnumerable<VPosts> vPosts =
            samplemodel.Posts.List(r => r.blogs_id == blogs_id).Select(
            r => new VPosts
            {
                posts_id = r.posts_id,
                title = r.posts_title
            }).ToList();

            ret = DGDataTableUtils.ToDataTable<VPosts>(vPosts);

            return ret;
        }

        private object GetParentDataSourceEmptyList_tabPosts()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEmptyList_tabPosts");

            return DGDataTableUtils.ToDataTable<VPosts>(Enumerable.Empty<VPosts>());
        }

        private object GetDataSourceEdit_tabPostslist_tabPosts()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPostslist_tabPosts");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<posts, DGUIGHFSampleModel>(samplemodel.Posts, vPostsBindingSource, new string[] { "posts_id" });
        }

        private void AfterSaveAction_tabPostslist_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPostslist_tabPosts");

            DGUIGHFData.SetBindingSourcePosition<posts, DGUIGHFSampleModel>(samplemodel.Posts, item, vPostsBindingSource);
        }

        private void Add_tabPostslist_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabPostslist_tabPosts");

            DGUIGHFData.Add<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void Update_tabPostslist_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabPostslist_tabPosts");

            DGUIGHFData.Update<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void Remove_tabPostslist_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabPostslist_tabPosts");

            DGUIGHFData.Remove<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void button_tabPostslist_tabPosts_new_Click(object sender, EventArgs e)
        {
            if (AddClick(tabElement_tabPostslist_tabPosts))
            {
#if NETFRAMEWORK
                int blogs_id = Int32.Parse((((DataRowView)vBlogsBindingSource.Current).Row)["blogs_id"].ToString());
#else
                int blogs_id = (((DataRowView)vBlogsBindingSource.Current).Row).Field<int>("blogs_id");
#endif
                ((posts)postsBindingSource.Current).blogs_id = blogs_id;
            }
        }

        #endregion


        #region tabPosts tabComments

        private object GetDataSourceList_tabPostslist_tabComments()
        {
            if (_debug)
                Console.WriteLine("GetParentDataSourceList_tabPostslist_tabComments");

            object ret = null;

            int posts_id = -1;

            if (vPostsBindingSource.Current != null)
            {
#if NETFRAMEWORK
                posts_id = Int32.Parse((((DataRowView)vPostsBindingSource.Current).Row)["posts_id"].ToString());
#else
                posts_id = (((DataRowView)vPostsBindingSource.Current).Row).Field<int>("posts_id");
#endif
            }

            IEnumerable<VComments> vComments =
            samplemodel.Comments.List(r => r.posts_id == posts_id).Select(
            r => new VComments
            {
                comments_id = r.comments_id,
                text = r.comments_text
            }).ToList();

            ret = DGDataTableUtils.ToDataTable<VComments>(vComments);

            return ret;
        }

        private object GetDataSourceEmptyList_tabPostslist_tabComments()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEmptyList_tabPostslist_tabComments");

            return DGDataTableUtils.ToDataTable<VComments>(Enumerable.Empty<VComments>());
        }

        private object GetDataSourceEdit_tabPostslist_tabCommentslist_tabComments()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPostslist_tabCommentslist_tabComments");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<comments, DGUIGHFSampleModel>(samplemodel.Comments, vCommentsBindingSource, new string[] { "comments_id" });
        }

        private void AfterSaveAction_tabPostslist_tabCommentslist_tabComments(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPostslist_tabCommentslist_tabComments");

            DGUIGHFData.SetBindingSourcePosition<comments, DGUIGHFSampleModel>(samplemodel.Comments, item, vCommentsBindingSource);
        }

        private void Add_tabPostslist_tabCommentslist_tabComments(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabPostslist_tabCommentslist_tabComments");

            DGUIGHFData.Add<comments, DGUIGHFSampleModel>(samplemodel.Comments, item);
        }

        private void Update_tabPostslist_tabCommentslist_tabComments(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabPostslist_tabCommentslist_tabComments");

            DGUIGHFData.Update<comments, DGUIGHFSampleModel>(samplemodel.Comments, item);
        }

        private void Remove_tabPostslist_tabCommentslist_tabComments(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabPostslist_tabCommentslist_tabComments");

            DGUIGHFData.Remove<comments, DGUIGHFSampleModel>(samplemodel.Comments, item);
        }

        private void button_tabPostslist_tabCommentslist_tabComments_new_Click(object sender, EventArgs e)
        {
            if (vPostsBindingSource.Current != null)
            {
                if (AddClick(tabElement_tabPostslist_tabCommentslist_tabComments))
                {
#if NETFRAMEWORK
                    int posts_id = Int32.Parse((((DataRowView)vPostsBindingSource.Current).Row)["posts_id"].ToString());
#else
                    int posts_id = (((DataRowView)vPostsBindingSource.Current).Row).Field<int>("posts_id");
#endif
                    ((comments)commentsBindingSource.Current).posts_id = posts_id;
                }
            }
        }

        #endregion


        #region tabPosts tabComments tabCommentsuseful

        private object GetDataSourceList_tabPostslist_tabCommentsuseful()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceList_tabPostslist_tabCommentsuseful");

            object ret = null;

            int comments_id = -1;
            if (vCommentsBindingSource.Current != null)
            {
#if NETFRAMEWORK
                comments_id = Int32.Parse((((DataRowView)vCommentsBindingSource.Current).Row)["comments_id"].ToString());
#else
                comments_id = (((DataRowView)vCommentsBindingSource.Current).Row).Field<int>("comments_id");
#endif
            }

            IEnumerable<VCommentsUseful> vCommentsUseful =
            samplemodel.CommentsUseful.List(r => r.comments_id == comments_id).Select(
            r => new VCommentsUseful
            {
                commentsuseful_id = r.commentsuseful_id,
                comments_id = r.comments_id,
                points = r.commentsuseful_points
            }).ToList();

            ret = DGDataTableUtils.ToDataTable<VCommentsUseful>(vCommentsUseful);

            return ret;
        }

        private object GetDataSourceEmptyList_tabPostslist_tabCommentsuseful()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEmptyList_tabPostslist_tabCommentsuseful");

            return DGDataTableUtils.ToDataTable<VCommentsUseful>(Enumerable.Empty<VCommentsUseful>());
        }

        private object GetDataSourceEdit_tabPostslist_tabCommentslist_tabCommentsuseful()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPostslist_tabCommentslist_tabCommentsuseful");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, vCommentsUsefulBindingSource, new string[] { "commentsuseful_id" });
        }

        private void AfterSaveAction_tabPostslist_tabCommentslist_tabCommentsuseful(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPostslist_tabCommentslist_tabCommentsuseful");

            DGUIGHFData.SetBindingSourcePosition<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, item, vCommentsUsefulBindingSource);
        }

        private void Add_tabPostslist_tabCommentslist_tabCommentsuseful(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabPostslist_tabCommentslist_tabCommentsuseful");

            DGUIGHFData.Add<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, item);
        }

        private void Update_tabPostslist_tabCommentslist_tabCommentsuseful(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabPostslist_tabCommentslist_tabCommentsuseful");

            DGUIGHFData.Update<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, item);
        }

        private void Remove_tabPostslist_tabCommentslist_tabCommentsuseful(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabPostslist_tabCommentslist_tabCommentsuseful");

            DGUIGHFData.Remove<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, item);
        }

        private void button_tabPostslist_tabCommentslist_tabCommentsuseful_new_Click(object sender, EventArgs e)
        {
            if (vCommentsBindingSource.Current != null)
            {
                if (AddClick(tabElement_tabPostslist_tabCommentslist_tabCommentsuseful))
                {
#if NETFRAMEWORK
                    int comments_id = Int32.Parse((((DataRowView)vCommentsBindingSource.Current).Row)["comments_id"].ToString());
#else
                    int comments_id = (((DataRowView)vCommentsBindingSource.Current).Row).Field<int>("comments_id");
#endif
                    ((commentsuseful)commentsusefulBindingSource.Current).comments_id = comments_id;
                }
            }
        }

        void tabPostslist_tabCommentslist_BindingSourceListChanged(object sender, EventArgs e)
        {
            vCommentsUsefulBindingSource_CurrentChanged(sender, e);
        }

        void tabPostslist_tabCommentslist_BindingSourceEditChanged(object sender, EventArgs e)
        {
            commentsusefulBindingSource_CurrentChanged(sender, e);
        }

        private void vCommentsUsefulBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            Console.WriteLine("vCommentsUsefulBindingSource changed");
        }

        private void commentsusefulBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            Console.WriteLine("commentsusefulBindingSource changed");
        }

        #endregion


#if MULTISELECT
        private void dataGridView_list_SelectionChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            BindingSourceMain_CurrentChanged(sender, e);
        }
#endif

#if MULTISELECT
        private void dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list_SelectionChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            BindingSourceList_CurrentChanged(sender, e, tabElement_tabPostslist_tabCommentslist_tabCommentsuseful);
        }

        private int CountSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful()
        {
            if (_debug)
                Console.WriteLine("CountSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful");

            return DGUIGHFDataGridViewHelper.CountSelectedRows(dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list);
        }

        private object[] GetSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful()
        {
            if (_debug)
                Console.WriteLine("GetSelectedItems_tabPostslist_tabCommentslist_tabCommentsuseful");

            return DGUIGHFData.LoadEntitiesFromSelectedKeys<commentsuseful, DGUIGHFSampleModel>(samplemodel.CommentsUseful, DGUIGHFDataGridViewHelper.GetSelectedKeys(dataGridView_tabPostslist_tabCommentslist_tabCommentsuseful_list, new string[] { "commentsusefulidDataGridViewTextBoxColumn" }).ToList());
        }
#endif

#if MULTISELECT
        private int CountParentSelectedItems_tabPostslist_tabComments()
        {
            if (_debug)
                Console.WriteLine("CountParentSelectedItems_tabPostslist_tabComments");

            return DGUIGHFDataGridViewHelper.CountSelectedRows(dataGridView_tabPostslist_list);
        }
#endif

#if MULTISELECT

        private int CountParentSelectedItems_tabPostslist_tabPosts()
        {
            if (_debug)
                Console.WriteLine("CountParentSelectedItems_tabPostslist_tabPosts");

            return DGUIGHFDataGridViewHelper.CountSelectedRows(dataGridView_tabPostslist_list);
        }

        private object[] GetSelectedItems_tabPostslist_tabPosts()
        {
            if (_debug)
                Console.WriteLine("GetSelectedItems_tabPostslist_tabPosts");

            return DGUIGHFData.LoadEntitiesFromSelectedKeys<posts, DGUIGHFSampleModel>(samplemodel.Posts, DGUIGHFDataGridViewHelper.GetSelectedKeys(dataGridView_tabPostslist_list, new string[] { "postsidDataGridViewTextBoxColumn" }).ToList());
        }
#endif


#if MULTISELECT
        private int CountParentSelectedItems_tabBlogs()
        {
            if (_debug)
                Console.WriteLine("CountParentSelectedItems_tabBlogs");

            return DGUIGHFDataGridViewHelper.CountSelectedRows(dataGridView_list);
        }

        private object[] GetSelectedItems_tabBlogs()
        {
            if (_debug)
                Console.WriteLine("GetSelectedItems_tabBlogs");

            return DGUIGHFData.LoadEntitiesFromSelectedKeys<blogs, DGUIGHFSampleModel>(samplemodel.Blogs, DGUIGHFDataGridViewHelper.GetSelectedKeys(dataGridView_list, new string[] { "blogsidDataGridViewTextBoxColumn" }).ToList());
        }
#endif

#if MULTISELECT
        private void dataGridView_tabPostslist_list_SelectionChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            BindingSourceList_CurrentChanged(sender, e, tabElement_tabPostslist);
        }

        private int CountParentSelectedItems_tabPostslist()
        {
            if (_debug)
                Console.WriteLine("CountParentSelectedItems_tabPosts");

            return DGUIGHFDataGridViewHelper.CountSelectedRows(dataGridView_list);
        }
#endif

    }
}
