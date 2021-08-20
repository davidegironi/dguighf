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
    public partial class FormPosts : DGUIGHFForm
    {
        private DGUIGHFSampleModel samplemodel = null;

        private TabElement tabElement_tabPosts = new TabElement();
        private TabElement tabElement_tabPostsextra = new TabElement();
        private TabElement tabElement_tabPostsextra_tabPostsadditionals = new TabElement();
        private TabElement tabElement_tabPostsextra_tabPoststotags = new TabElement();

        private bool _debug = true;

        public class FormPostsLanguage : IDGUIGHFLanguage
        {
            public string text001 = "èTest' text 01.";
        }

        public FormPostsLanguage language = new FormPostsLanguage();

        public FormPosts()
        {
            InitializeComponent();

            Initialize(Program.uighfApplication);

            samplemodel = new DGUIGHFSampleModel();
            samplemodel.LanguageHelper.LoadFromFile(Program.uighfApplication.LanguageFilename);
        }

        public override void AddLanguageComponents()
        {
            LanguageHelper.AddComponent(this);
            LanguageHelper.AddComponent(titleDataGridViewTextBoxColumn, this.GetType().Name, "HeaderText");
            LanguageHelper.AddComponent(button_tabPosts_new);
        }

        /// <summary>
        /// Initialize TabElements
        /// </summary>
        protected override void InitializeTabElements()
        {
            //set sort on View bindingSource
            vPostsBindingSource.Sort = "title";

            //set Readonly OnSetEditingMode for Controls
            DisableReadonlyCheckOnSetEditingModeControlCollection.Add(typeof(DataGridView));

            //set Main BindingSource
            BindingSourceMain = vPostsBindingSource;
            GetDataSourceMain = GetDataSource_main;

            //set Main TabControl
            TabControlMain = tabControl_main;

            //set Main Panels
            PanelFiltersMain = panel_filters;
            PanelListMain = panel_list;
            PanelsExtraMain = new Panel[] { panel_add1 };

            //poststotagsadditionals
            tabElement_tabPostsextra_tabPoststotags = new TabElement()
            {
                TabPageElement = tabPage_tabPostsextra_tabPoststotags,
                ElementListItem = new TabElement.TabElementListItem()
                {
                    PanelData = null,
                    PanelActions = panel_tabPostsextra_tabPoststotags_actions,
                    PanelUpdates = null,

                    BindingSourceList = vPostsToTagsBindingSource,
                    GetDataSourceList = GetDataSourceList_tabPostsextra_tabPoststotags,

                    BindingSourceEdit = poststotagsBindingSource,
                    GetDataSourceEdit = GetDataSourceEdit_tabPostsextra_tabPoststotags,
                    AfterSaveAction = AfterSaveAction_tabPostsextra_tabPoststotags,

                    AddButton = button_tabPostsextra_tabPoststotags_add,
                    IsAddButtonDefaultClickEventAttached = false,
                    RemoveButton = button_tabPostsextra_tabPoststotags_remove,

                    Add = Add_tabPostsextra_tabPoststotags,
                    Remove = Remove_tabPostsextra_tabPoststotags,
                }
            };

            //postsadditionals
            tabElement_tabPostsextra_tabPostsadditionals = new TabElement()
            {
                TabPageElement = tabPage_tabPostsextra_tabPostsadditionals,
                ElementItem = new TabElement.TabElementItem()
                {
                    PanelData = panel_tabPostsextra_tabPostsadditionals_data,
                    PanelActions = panel_tabPostsextra_tabPostsadditionals_actions,
                    PanelUpdates = panel_tabPostsextra_tabPostsadditionals_updates,

                    ParentBindingSourceList = vPostsBindingSource,
                    GetParentDataSourceList = GetDataSource_main,

                    BindingSourceEdit = postsadditionalsBindingSource,
                    GetDataSourceEdit = GetDataSourceEdit_tabPostsextra_tabPostsadditionals,
                    AfterSaveAction = AfterSaveAction_tabPostsextra_tabPostsadditionals,

                    UpdateButton = button_tabPostsextra_tabPostsadditionals_edit,
                    SaveButton = button_tabPostsextra_tabPostsadditionals_save,
                    CancelButton = button_tabPostsextra_tabPostsadditionals_cancel,

                    Update = Update_tabPostsextra_tabPostsadditionals,
                }
            };

            //posts Element
            tabElement_tabPosts = new TabElement()
            {
                TabPageElement = tabPage_tabPosts,
                ElementItem = new TabElement.TabElementItem()
                {
                    PanelData = panel_tabPosts_data,
                    PanelActions = panel_tabPosts_actions,
                    PanelUpdates = panel_tabPosts_updates,

                    ParentBindingSourceList = vPostsBindingSource,
                    GetParentDataSourceList = GetDataSource_main,

                    BindingSourceEdit = postsBindingSource,
                    GetDataSourceEdit = GetDataSourceEdit_tabPosts,
                    AfterSaveAction = AfterSaveAction_tabPosts,

                    AddButton = button_tabPosts_new,
                    UpdateButton = button_tabPosts_edit,
                    RemoveButton = button_tabPosts_delete,
                    SaveButton = button_tabPosts_save,
                    IsSaveButtonDefaultClickEventAttached = false,
                    CancelButton = button_tabPosts_cancel,

                    Add = Add_tabPosts,
                    Update = Update_tabPosts,
                    Remove = Remove_tabPosts
                }
            };

            //postsextra Element
            tabElement_tabPostsextra.TabPageElement = tabPage_tabPostsextra;
            tabElement_tabPostsextra.ElementTabs = new TabElement.TabElementTabs()
            {
                PanelData = panel_tabPostsextra_data,

                TabControlElement = tabControl_tabPostsextra,
                TabElements = new List<TabElement>()
                {
                    tabElement_tabPostsextra_tabPostsadditionals,
                    tabElement_tabPostsextra_tabPoststotags
                }
            };

            //add TabElements
            TabElements.Add(tabElement_tabPosts);
            TabElements.Add(tabElement_tabPostsextra);
        }

        private void FormPosts_Load(object sender, EventArgs e)
        {
            //load blogs combobox
            IEnumerable<VCBlogs> vCBlogs = samplemodel.Blogs.List().OrderBy(r => r.blogs_title).Select(
                r => new VCBlogs
                {
                    blogs_id = r.blogs_id,
                    title = r.blogs_title
                }).ToList();
            vCBlogsBindingSource.DataSource = DGDataTableUtils.ToDataTable<VCBlogs>(vCBlogs);
            blogs_idComboBox.SelectedIndex = -1;

            //load tags combobox
            comboBox_tabPostsextra_tabPoststotags_tags.DataSource = samplemodel.Tags.List().OrderBy(q => q.tags_name).Select(a => new { _id = a.tags_id, _value = a.tags_name + " (" + a.tags_id.ToString() + ")" }).ToArray();
            comboBox_tabPostsextra_tabPoststotags_tags.ValueMember = "_id";
            comboBox_tabPostsextra_tabPoststotags_tags.DisplayMember = "_value";
            comboBox_tabPostsextra_tabPoststotags_tags.SelectedIndex = -1;

            ReloadView();
        }

        private object GetDataSource_main()
        {
            if (_debug)
                Console.WriteLine("GetDataSource_main");

            IEnumerable<VPosts> vPosts =
                samplemodel.Posts.List().Select(
                r => new VPosts
                {
                    posts_id = r.posts_id,
                    title = r.posts_title
                }).ToList();

            return DGDataTableUtils.ToDataTable<VPosts>(vPosts);
        }

        private void vPostsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            textBox_totals.Text = "0";
            try
            {
                textBox_totals.Text = vPostsBindingSource.Count.ToString();
            }
            catch { }
        }

        private void button_messageboxsample_Click(object sender, EventArgs e)
        {
            MessageBoxSample messageboxsample = new MessageBoxSample();
            messageboxsample.Show();
        }


        #region filters

        private void UnsetFilter()
        {
            IsBindingSourceLoading = true;
            textBox_filter_title.Text = "";
            IsBindingSourceLoading = false;
            SetFilter();
        }

        private void SetFilter()
        {
            string filter_s = "";
            if (!String.IsNullOrEmpty(textBox_filter_title.Text))
            {
                if (!String.IsNullOrEmpty(filter_s))
                    filter_s += " AND ";
                filter_s += "title LIKE '%" + textBox_filter_title.Text + "%'";
            }
            vPostsBindingSource.Filter = filter_s;
        }

        private void textBox_filter_title_TextChanged(object sender, EventArgs e)
        {
            SetFilter();
        }

        #endregion


        #region tabPosts

        private object GetDataSourceEdit_tabPosts()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPosts");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<posts, DGUIGHFSampleModel>(samplemodel.Posts, vPostsBindingSource, new string[] { "posts_id" });
        }

        private void AfterSaveAction_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPosts");

            DGUIGHFData.SetBindingSourcePosition<posts, DGUIGHFSampleModel>(samplemodel.Posts, item, vPostsBindingSource);
        }

        private void Add_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabPosts");

            DGUIGHFData.Add<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void Update_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabPosts");

            DGUIGHFData.Update<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void Remove_tabPosts(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabPosts");

            DGUIGHFData.Remove<posts, DGUIGHFSampleModel>(samplemodel.Posts, item);
        }

        private void button_tabPosts_save_Click(object sender, EventArgs e)
        {
            EditingMode lasteditingmode = tabElement_tabPosts.CurrentEditingMode;

            SaveClick(tabElement_tabPosts);
        }

        #endregion


        #region tabPostextra tabPostadditionals

        private object GetDataSourceEdit_tabPostsextra_tabPostsadditionals()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPostsextra_tabPostsadditionals");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<postsadditionals, DGUIGHFSampleModel>(samplemodel.PostsAdditionals, vPostsBindingSource, new string[] { "posts_id" });
        }

        private void AfterSaveAction_tabPostsextra_tabPostsadditionals(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPostsextra_tabPostsadditionals");

            DGUIGHFData.SetBindingSourcePosition<postsadditionals, DGUIGHFSampleModel>(samplemodel.PostsAdditionals, item, vPostsBindingSource);
        }

        private void Update_tabPostsextra_tabPostsadditionals(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabPostsextra_tabPostsadditionals");

            DGUIGHFData.Update<postsadditionals, DGUIGHFSampleModel>(samplemodel.PostsAdditionals, item);
        }

        #endregion


        #region tabPostsextra tabPoststottags

        private object GetDataSourceList_tabPostsextra_tabPoststotags()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceList_tabPostsextra_tabPoststotags");

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

            IEnumerable<VPostsToTags> vPostsToTags =
            samplemodel.PostsToTags.List(r => r.posts_id == posts_id).Select(
            r => new VPostsToTags
            {
                posts_id = r.posts_id,
                tags_id = r.tags_id,
                post = samplemodel.Posts.Find(r.posts_id).posts_title,
                tag = samplemodel.Tags.Find(r.tags_id).tags_name
            }).ToList();

            ret = DGDataTableUtils.ToDataTable<VPostsToTags>(vPostsToTags);

            return ret;
        }

        private object GetDataSourceEdit_tabPostsextra_tabPoststotags()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabPostsextra_tabPoststotags");

            object ret = DGUIGHFData.LoadEntityFromCurrentBindingSource<poststotags, DGUIGHFSampleModel>(samplemodel.PostsToTags, vPostsToTagsBindingSource, new string[] { "posts_id", "tags_id" });
            if (ret != null)
                comboBox_tabPostsextra_tabPoststotags_tags.SelectedValue = ((poststotags)ret).tags_id;
            return ret;
        }

        private void AfterSaveAction_tabPostsextra_tabPoststotags(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabPostsextra_tabPoststotags");

            if (!DGUIGHFData.SetBindingSourcePosition<poststotags, DGUIGHFSampleModel>(samplemodel.PostsToTags, item, vPostsBindingSource))
            {
                BindingSourceList_CurrentChanged(null, null, tabElement_tabPostsextra_tabPoststotags);
            }
        }

        private void Add_tabPostsextra_tabPoststotags(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabPostsextra_tabPoststotags");

            DGUIGHFData.Add<poststotags, DGUIGHFSampleModel>(samplemodel.PostsToTags, item);
        }

        private void Remove_tabPostsextra_tabPoststotags(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabPostsextra_tabPoststotags");

            DGUIGHFData.Remove<poststotags, DGUIGHFSampleModel>(samplemodel.PostsToTags, item);
        }

        private object[] GetSelectedItems_tabPostsextra_tabPoststotags()
        {
            if (_debug)
                Console.WriteLine("GetSelectedItems_tabPostsextra_tabPoststotags");

            return DGUIGHFData.LoadEntitiesFromSelectedKeys<poststotags, DGUIGHFSampleModel>(samplemodel.PostsToTags, DGUIGHFDataGridViewHelper.GetSelectedKeys(dataGridView_tabPostsextra_tabPoststotags_list, new string[] { "postsidDataGridViewTextBoxColumn1", "tagsidDataGridViewTextBoxColumn" }).ToList());
        }

        private void button_tabPostsextra_tabPoststotags_add_Click(object sender, EventArgs e)
        {
            if (vPostsBindingSource.Current != null)
            {
                if (AddClick(tabElement_tabPostsextra_tabPoststotags))
                {

#if NETFRAMEWORK
                    ((poststotags)poststotagsBindingSource.Current).posts_id = Int32.Parse((((DataRowView)vPostsBindingSource.Current).Row)["posts_id"].ToString());
#else
                    ((poststotags)poststotagsBindingSource.Current).posts_id = (((DataRowView)vPostsBindingSource.Current).Row).Field<int>("posts_id");
#endif
                    ((poststotags)poststotagsBindingSource.Current).tags_id = Convert.ToInt32(comboBox_tabPostsextra_tabPoststotags_tags.SelectedValue);

                    SaveClick(tabElement_tabPostsextra_tabPoststotags);
                    ReloadAfterSave(tabElement_tabPostsextra_tabPoststotags, (poststotags)poststotagsBindingSource.Current);
                }
            }
        }

        #endregion

    }
}
