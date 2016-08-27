using DG.Data.Model.Helpers;
using DG.UI.GHF;
using DG.UIGHFSample.Model;
using DG.UIGHFSample.Model.Entity;
using DG.UIGHFSample.Objects.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DG.UIGHFSample
{
    public partial class FormTags : DGUIGHFForm
    {
        private DGUIGHFSampleModel samplemodel = null;

        private TabElement tabElement_tabTags = new TabElement();

        private bool _debug = true;

        public FormTags()
        {
            InitializeComponent();

            Initialize(Program.uighfApplication);

            samplemodel = new DGUIGHFSampleModel();
            samplemodel.LanguageHelper.LoadFromFile(Program.uighfApplication.LanguageFilename);
        }

        /// <summary>
        /// Initialize TabElements
        /// </summary>
        protected override void InitializeTabElements()
        {
            //set sort on View bindingSource
            vTagsBindingSource.Sort = "name";

            //set Readonly OnSetEditingMode for Controls
            DisableReadonlyCheckOnSetEditingModeControlCollection.Add(typeof(DataGridView));

            //set Main BindingSource
            BindingSourceMain = vTagsBindingSource;
            GetDataSourceMain = GetDataSource_main;

            //set Main TabControl
            TabControlMain = tabControl_main;

            //set Main Panels
            PanelFiltersMain = null;
            PanelListMain = panel_list;
            PanelsExtraMain = null;

            //set tabTags
            tabElement_tabTags = new TabElement()
            {
                TabPageElement = tabPage_tabTags,
                ElementItem = new TabElement.TabElementItem()
                {
                    PanelData = panel_tabTags_data,
                    PanelActions = panel_tabTags_actions,
                    PanelUpdates = panel_tabTags_updates,

                    ParentBindingSourceList = vTagsBindingSource,
                    GetParentDataSourceList = GetDataSource_main,

                    BindingSourceEdit = tagsBindingSource,
                    GetDataSourceEdit = GetDataSourceEdit_tabTags,
                    AfterSaveAction = AfterSaveAction_tabTags,

                    AddButton = button_tabTags_new,
                    UpdateButton = button_tabTags_edit,
                    RemoveButton = button_tabTags_delete,
                    SaveButton = button_tabTags_save,
                    CancelButton = button_tabTags_cancel,

                    Add = Add_tabTags,
                    Update = Update_tabTags,
                    Remove = Remove_tabTags
                }
            };

            //set Elements
            TabElements.Add(tabElement_tabTags);
        }

        private void FormTags_Load(object sender, EventArgs e)
        {
            ReloadView();
        }

        private object GetDataSource_main()
        {
            if (_debug)
                Console.WriteLine("GetDataSource_main");

            IEnumerable<VTags> vTags =
                samplemodel.Tags.List().Select(
                r => new VTags
                {
                    tags_id = r.tags_id,
                    name = r.tags_name
                }).ToList();

            return DGDataTableUtils.ToDataTable<VTags>(vTags);
        }

        #region tabTags

        private object GetDataSourceEdit_tabTags()
        {
            if (_debug)
                Console.WriteLine("GetDataSourceEdit_tabTags");

            return DGUIGHFData.LoadEntityFromCurrentBindingSource<tags, DGUIGHFSampleModel>(samplemodel.Tags, vTagsBindingSource, new string[] { "tags_id" });
        }

        private void AfterSaveAction_tabTags(object item)
        {
            if (_debug)
                Console.WriteLine("AfterSaveAction_tabTags");

            DGUIGHFData.SetBindingSourcePosition<tags, DGUIGHFSampleModel>(samplemodel.Tags, item, vTagsBindingSource);
        }

        private void Add_tabTags(object item)
        {
            if (_debug)
                Console.WriteLine("Add_tabTags");

            DGUIGHFData.Add<tags, DGUIGHFSampleModel>(samplemodel.Tags, item);
        }

        private void Update_tabTags(object item)
        {
            if (_debug)
                Console.WriteLine("Update_tabTags");

            DGUIGHFData.Update<tags, DGUIGHFSampleModel>(samplemodel.Tags, item);
        }

        private void Remove_tabTags(object item)
        {
            if (_debug)
                Console.WriteLine("Remove_tabTags");

            DGUIGHFData.Remove<tags, DGUIGHFSampleModel>(samplemodel.Tags, item);
        }

        #endregion


    }
}
