#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DG.UI.GHF
{

    public class DGUIGHFForm : Form
    {
        /// <summary>
        /// Forces the reload for this form
        /// </summary>
        private bool m_forceFormReload = false;

        /// <summary>
        /// Forces the reload for this form is disabled
        /// </summary>
        private bool m_forceFormReloadArmingDisabled = false;

        /// <summary>
        /// Reload this form when it becames active
        /// </summary>
        protected bool ReloadFormOnActive = true;

        /// <summary>
        /// Check if the form is loaded for the first time
        /// </summary>
        protected bool IsFirstLoad = false;

        /// <summary>
        /// Check if the form ReloadView is called for the first time
        /// </summary>
        protected bool IsFirstReloadView = true;

        /// <summary>
        /// EditingMode enumerator, C is for create, R for read, U for update, D for Delete
        /// </summary>
        protected enum EditingMode { R, C, U, D, parentC, parentR, parentU, parentD, childC, childR, childU, childD };

        /// <summary>
        /// Check and the BindingSource is loading status
        /// </summary>
        protected bool IsBindingSourceLoading { get; set; }

        /// <summary>
        /// UIGHFApplication reference
        /// </summary>
        protected DGUIGHFApplication UIGHFApplication { get; set; }

        /// <summary>
        /// Form language
        /// </summary>
        public DGUIGHFLanguageBase languageBase = new DGUIGHFLanguageBase();

        /// <summary>
        /// Langauge Helper
        /// </summary>
        public DGUIGHFLanguageHelper LanguageHelper { get; private set; }

        /// <summary>
        /// Set the Type of Control for which the Readonly method is disabled when SetEditingMode is called
        /// </summary>
        protected List<Type> DisableReadonlyCheckOnSetEditingModeControlCollection = new List<Type>();

        /// <summary>
        /// Set controls type with recursion enabled on SetEditing
        /// </summary>
        protected List<Type> RecursionSetEditingModeControlTypeCollection = new List<Type>();

        /// <summary>
        /// Concurrency Helper Record used to define current record editing
        /// </summary>
        public struct ConcurrencyHelperRecord
        {
            /// <summary>
            /// Concurrency helper database for the current record
            /// </summary>
            public string database;

            /// <summary>
            /// Concurrency helper table for the current record
            /// </summary>
            public string table;

            /// <summary>
            /// Concurrency helper record Id for the current record
            /// </summary>
            public string recordId;

            /// <summary>
            /// Concurrency Helper record initializer
            /// </summary>
            /// <param name="database"></param>
            /// <param name="table"></param>
            /// <param name="recordId"></param>
            public ConcurrencyHelperRecord(string database, string table, string recordId)
            {
                this.database = database;
                this.table = table;
                this.recordId = recordId;
            }
        }


        #region Main view Controls

        /// <summary>
        /// Panel that contains filter or search controls for the Main view BindingSource
        /// </summary>
        protected Panel PanelFiltersMain { get; set; }

        /// <summary>
        /// Panel that contains other controls for the Main view BindingSource
        /// </summary>
        protected Panel[] PanelsExtraMain { get; set; }

        /// <summary>
        /// Panel that contains items listed in the Main view BindingSource
        /// </summary>
        protected Panel PanelListMain { get; set; }

        /// <summary>
        /// Check if the BindingSourceMain is binded to a multiselect grid, if set to true the BindingSourceMain CurrentChanged is not attached
        /// </summary>
        protected bool IsBindingSourceMainMultiselect { get; set; }

        /// <summary>
        /// Main view BindingSource
        /// </summary>
        protected BindingSource BindingSourceMain { get; set; }

        /// <summary>
        /// Fuction that return elements listed in the Main view BindingSource
        /// </summary>
        protected Func<object> GetDataSourceMain { get; set; }

        /// <summary>
        /// TabControl that contains child TabPages
        /// </summary>
        protected TabControl TabControlMain { get; set; }

        /// <summary>
        /// Child TabElements for the this Form
        /// </summary>
        protected List<TabElement> TabElements = new List<TabElement>();

        #endregion


        #region TabElements definitions

        /// <summary>
        /// TabElement structure
        /// </summary>
        protected class TabElement
        {
            /// <summary>
            /// TabPage related to this TabElement
            /// </summary>
            public TabPage TabPageElement { get; set; }

            /// <summary>
            /// Get or Set the LazyLoad property of this TabElement
            /// </summary>
            public bool IsLazyLoaded { get; set; }

            /// <summary>
            /// The item that can be edited
            /// </summary>
            public TabElementItem ElementItem { get; set; }

            /// <summary>
            /// A list with items that can be edited
            /// </summary>
            public TabElementListItem ElementListItem { get; set; }

            /// <summary>
            /// Child TabElements
            /// </summary>
            public TabElementTabs ElementTabs { get; set; }

            /// <summary>
            /// A list with child TabElements
            /// </summary>
            public TabElementListTabs ElementListTabs { get; set; }

            /// <summary>
            /// EditingMode for the current TabElement
            /// </summary>
            public EditingMode CurrentEditingMode { get; set; }

            /// <summary>
            /// Default constructor
            /// </summary>
            public TabElement()
            {
                TabPageElement = null;
                IsLazyLoaded = false;
                ElementItem = null;
                ElementListItem = null;
                ElementTabs = null;
                ElementListTabs = null;
                CurrentEditingMode = EditingMode.R;
            }

            /// <summary>
            /// Item that can be edited
            /// </summary>
            public class TabElementItemBase
            {
                /// <summary>
                /// Panel that contains data or other elements
                /// </summary>
                public Panel PanelData { get; set; }

                /// <summary>
                /// Panel that contains Action buttons or controls
                /// </summary>
                public Panel PanelActions { get; set; }

                /// <summary>
                /// /// <summary>
                /// Panel that contains Update buttons or controls
                /// </summary>
                public Panel PanelUpdates { get; set; }

                /// <summary>
                /// Function that counts the selected items of the parent, used on multiselect mode
                /// </summary>
                public Func<int> CountParentSelectedItems { get; set; }

                /// <summary>
                /// BindingSource for item to be edited
                /// </summary>
                public BindingSource BindingSourceEdit { get; set; }

                /// <summary>
                /// BindingSourceEdit changed delegate
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                public delegate void BindingSourceEditChangedEventHandler(object sender, EventArgs e);

                /// <summary>
                /// BindingSourceEdit changed event
                /// </summary>
                public event BindingSourceEditChangedEventHandler BindingSourceEditChanged;

                /// <summary>
                /// Function that returns the DataSource for the item to be edited, it just return one element DataSource
                /// </summary>
                public Func<object> GetDataSourceEdit { get; set; }

                /// <summary>
                /// Button used to raise the AddClick event
                /// </summary>
                public Control AddButton { get; set; }

                /// <summary>
                /// Attach an AddClick event to the Add button on Initialize
                /// </summary>
                public bool IsAddButtonDefaultClickEventAttached { get; set; }

                /// <summary>
                /// Button used to raise the UpdateClick event
                /// </summary>
                public Control UpdateButton { get; set; }

                /// <summary>
                /// Attach an UpdateClick event to the Update button on Initialize
                /// </summary>
                public bool IsUpdateButtonDefaultClickEventAttached { get; set; }

                /// <summary>
                /// Button used to raise the RemoveClick event
                /// </summary>
                public Control RemoveButton { get; set; }

                /// <summary>
                /// Attach an RemoveClick event to the Remove button on Initialize
                /// </summary>
                public bool IsRemoveButtonDefaultClickEventAttached { get; set; }

                /// <summary>
                /// Button used to raise the SaveClick event
                /// </summary>
                public Control SaveButton { get; set; }

                /// <summary>
                /// Attach an SaveClick event to the Save button on Initialize
                /// </summary>
                public bool IsSaveButtonDefaultClickEventAttached { get; set; }

                /// <summary>
                /// Button used to raise the CancelClick event
                /// </summary>
                public Control CancelButton { get; set; }

                /// <summary>
                /// Attach an CancelClick event to the Cancel button on Initialize
                /// </summary>
                public bool IsCancelButtonDefaultClickEventAttached { get; set; }

                /// <summary>
                /// Action used to Add an item
                /// </summary>
                public Action<object> Add { get; set; }

                /// <summary>
                /// Action used to Update the selected item
                /// </summary>
                public Action<object> Update { get; set; }

                /// <summary>
                /// Action used to Remove the selected item
                /// </summary>
                public Action<object> Remove { get; set; }

                /// <summary>
                /// Action called after the Add event is called, usefull to set the parent List BindingSource
                /// </summary>
                public Action<object> AfterSaveAction { get; set; }

                /// <summary>
                /// Reload the main view after Save
                /// </summary>
                public bool ReloadViewAfterSave { get; set; }

                /// <summary>
                /// Default constructor
                /// </summary>
                public TabElementItemBase()
                {
                    PanelData = null;
                    PanelActions = null;
                    PanelUpdates = null;
                    CountParentSelectedItems = null;
                    BindingSourceEdit = null;
                    GetDataSourceEdit = null;
                    AddButton = null;
                    IsAddButtonDefaultClickEventAttached = true;
                    UpdateButton = null;
                    IsUpdateButtonDefaultClickEventAttached = true;
                    RemoveButton = null;
                    IsRemoveButtonDefaultClickEventAttached = true;
                    SaveButton = null;
                    IsSaveButtonDefaultClickEventAttached = true;
                    CancelButton = null;
                    IsCancelButtonDefaultClickEventAttached = true;
                    Add = null;
                    Update = null;
                    Remove = null;
                    AfterSaveAction = null;
                    ReloadViewAfterSave = false;
                }

                /// <summary>
                /// Raise the BindingSourceEditChanged evend
                /// </summary>
                /// <param name="e"></param>
                public virtual void OnBindingSourceEditChanged(EventArgs e)
                {
                    if (BindingSourceEditChanged != null)
                        BindingSourceEditChanged(this, e);
                }
            }

            /// <summary>
            /// Item that can be edited
            /// </summary>
            public class TabElementItem : TabElementItemBase
            {
                /// <summary>
                /// Function that returns all the items of the parent selected, used on multiselect mode
                /// </summary>
                public Func<object[]> GetParentSelectedItems { get; set; }

                /// <summary>
                /// BindingSource of the parent that lists elements that could be edited
                /// </summary>
                public BindingSource ParentBindingSourceList { get; set; }

                /// <summary>
                /// BindingSourceList of the parent changed delegate
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                public delegate void ParentBindingSourceListChangedEventHandler(object sender, EventArgs e);

                /// <summary>
                /// BindingSourceList of the parent changed event
                /// </summary>
                public event ParentBindingSourceListChangedEventHandler ParentBindingSourceListChanged;

                /// <summary>
                /// Function that returns the DataSource of the parent for the item to be listed, loaded in the List BindingSource
                /// </summary>
                public Func<object> GetParentDataSourceList { get; set; }

                /// <summary>
                /// Default constructor
                /// </summary>
                public TabElementItem()
                {
                    GetParentSelectedItems = null;
                    ParentBindingSourceList = null;
                    GetParentDataSourceList = null;
                }

                /// <summary>
                /// Raise the ParentBindingSourceListChanged evend
                /// </summary>
                /// <param name="e"></param>
                public virtual void OnParentBindingSourceListChanged(EventArgs e)
                {
                    if (ParentBindingSourceListChanged != null)
                        ParentBindingSourceListChanged(this, e);
                }
            }

            /// <summary>
            /// List with items that can be edited
            /// </summary>
            public class TabElementListItem : TabElementItemBase
            {
                /// <summary>
                /// Panel that contains filter or search controls for the List BindingSource
                /// </summary>
                public Panel PanelFilters { get; set; }

                /// <summary>
                /// Panel that contains items listed in the List BindingSource
                /// </summary>
                public Panel PanelList { get; set; }

                /// <summary>
                /// Check if the BindingSourceList is binded to a multiselect grid, if set to true the BindingSourceList CurrentChanged is not attached
                /// </summary>
                public bool IsBindingSourceListMultiselect { get; set; }

                /// <summary>
                /// BindingSource that lists elements that could be edited
                /// </summary>
                public BindingSource BindingSourceList { get; set; }

                /// <summary>
                /// BindingSourceList changed delegate
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                public delegate void BindingSourceListChangedEventHandler(object sender, EventArgs e);

                /// <summary>
                /// BindingSourceList changed event
                /// </summary>
                public event BindingSourceListChangedEventHandler BindingSourceListChanged;

                /// <summary>
                /// Function that returns the DataSource for the item to be listed, loaded in the List BindingSource
                /// </summary>
                public Func<object> GetDataSourceList { get; set; }

                /// <summary>
                /// Function that returns the empty DataSource for the item to be listed, loaded in the List BindingSource
                /// </summary>
                public Func<object> GetDataSourceEmptyList { get; set; }

                /// <summary>
                /// Function that counts all the items, used on multiselect mode
                /// </summary>
                public Func<int> CountSelectedItems { get; set; }

                /// <summary>
                /// Function that returns all the items, used on multiselect mode
                /// </summary>
                public Func<object[]> GetSelectedItems { get; set; }

                /// <summary>
                /// Default constructor
                /// </summary>
                public TabElementListItem()
                {
                    PanelFilters = null;
                    PanelList = null;
                    IsBindingSourceListMultiselect = false;
                    BindingSourceList = null;
                    GetDataSourceList = null;
                    GetDataSourceEmptyList = null;
                    CountSelectedItems = null;
                    GetSelectedItems = null;
                }

                /// <summary>
                /// Raise the BindingSourceListChanged evend
                /// </summary>
                /// <param name="e"></param>
                public virtual void OnBindingSourceListChanged(EventArgs e)
                {
                    if (BindingSourceListChanged != null)
                        BindingSourceListChanged(this, e);
                }
            }

            /// <summary>
            /// Child TabElements
            /// </summary>
            public class TabElementTabs
            {
                /// <summary>
                /// Panel that contains data or other elements
                /// </summary>
                public Panel PanelData { get; set; }

                /// <summary>
                /// Function that counts the selected items, used on multiselect mode
                /// </summary>
                public Func<int> CountParentSelectedItems { get; set; }

                /// <summary>
                /// TabControl that contains child TabPages
                /// </summary>
                public TabControl TabControlElement { get; set; }

                /// <summary>
                /// Child TabElements for the current TabElement
                /// </summary>
                public List<TabElement> TabElements { get; set; }

                /// <summary>
                /// Default constructor
                /// </summary>
                public TabElementTabs()
                {
                    PanelData = null;
                    CountParentSelectedItems = null;
                    TabControlElement = null;
                    TabElements = null;
                }
            }

            /// <summary>
            /// A list with child TabElements
            /// </summary>
            public class TabElementListTabs
            {
                /// <summary>
                /// Panel that contains data or other elements
                /// </summary>
                public Panel PanelData { get; set; }

                /// <summary>
                /// Panel that contains filter or search controls for the List BindingSource
                /// </summary>
                public Panel PanelFilters { get; set; }

                /// <summary>
                /// Panel that contains items listed in the List BindingSource
                /// </summary>
                public Panel PanelList { get; set; }

                /// <summary>
                /// Check if the BindingSourceList is binded to a multiselect grid, if set to true the BindingSourceList CurrentChanged is not attached
                /// </summary>
                public bool IsBindingSourceListMultiselect { get; set; }

                /// <summary>
                /// Function that counts the selected items of the parent, used on multiselect mode
                /// </summary>
                public Func<int> CountParentSelectedItems { get; set; }

                /// <summary>
                /// BindingSource that lists elements that could be edited
                /// </summary>
                public BindingSource BindingSourceList { get; set; }

                /// <summary>
                /// BindingSourceList changed delegate
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                public delegate void BindingSourceListChangedEventHandler(object sender, EventArgs e);

                /// <summary>
                /// BindingSourceList changed event
                /// </summary>
                public event BindingSourceListChangedEventHandler BindingSourceListChanged;

                /// <summary>
                /// Function that returns the DataSource for the item to be listed, loaded in the List BindingSource
                /// </summary>
                public Func<object> GetDataSourceList { get; set; }

                /// <summary>
                /// Function that returns the empty DataSource for the item to be listed, loaded in the List BindingSource
                /// </summary>
                public Func<object> GetDataSourceEmptyList { get; set; }

                /// <summary>
                /// TabControl that contains child TabPages
                /// </summary>
                public TabControl TabControlElement { get; set; }

                /// <summary>
                /// Child TabElements for the current TabElement
                /// </summary>
                public List<TabElement> TabElements { get; set; }

                /// <summary>
                /// Default constructor
                /// </summary>
                public TabElementListTabs()
                {
                    PanelData = null;
                    PanelFilters = null;
                    PanelList = null;
                    IsBindingSourceListMultiselect = false;
                    CountParentSelectedItems = null;
                    BindingSourceList = null;
                    GetDataSourceList = null;
                    GetDataSourceEmptyList = null;
                    TabControlElement = null;
                    TabElements = null;
                }

                /// <summary>
                /// Raise the BindingSourceListChanged evend
                /// </summary>
                /// <param name="e"></param>
                public virtual void OnBindingSourceListChanged(EventArgs e)
                {
                    if (BindingSourceListChanged != null)
                        BindingSourceListChanged(this, e);
                }
            }

        }

        #endregion


        #region Initializer

        /// <summary>
        /// UIGHFForm constructor
        /// </summary>
        public DGUIGHFForm()
        {
            IsBindingSourceMainMultiselect = false;
            RecursionSetEditingModeControlTypeCollection = new List<Type>()
            {
                typeof(Panel),
                typeof(TabControl),
                typeof(TabPage),
                typeof(GroupBox)
            };
        }

        /// <summary>
        /// Override this function and Instantiate the TabElements of the form
        /// </summary>
        protected virtual void InitializeTabElements()
        { }

        /// <summary>
        /// Initialize the UIGHFForm
        /// </summary>
        /// <param name="uighfApplication"></param>
        protected void Initialize(DGUIGHFApplication uighfApplication)
        {
            UIGHFApplication = uighfApplication;

            //used id a form is called by external assembly
            if (Assembly.GetEntryAssembly().GetName().Name.ToString() != uighfApplication.AppName)
            {
                //get DGUIGHFApplication of the caller
                DGUIGHFApplication uighfApplicationEntry = null;
                foreach (Type t in Assembly.GetEntryAssembly().GetTypes())
                {
                    FieldInfo[] fields = t.GetFields().Where(r => r.FieldType == typeof(DGUIGHFApplication)).ToArray();
                    if (fields.Count() > 0)
                    {
                        uighfApplicationEntry = fields.First().GetValue(null) as DGUIGHFApplication;
                        break;
                    }
                }
            }

            //initialize tabElements
            InitializeTabElements();

            //attach default event handlers
            this.Load += new System.EventHandler(Form_Load);
            this.Activated += new System.EventHandler(Form_Activated);
            this.Deactivate += new System.EventHandler(Form_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form_FormClosing);
            if (this.TabControlMain != null)
                this.TabControlMain.SelectedIndexChanged += new System.EventHandler((sender, e) => TabControl_SelectedIndexChanged(sender, e, TabElements, TabControlMain));
            if (this.TabControlMain != null)
                this.TabControlMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler((sender, e) => TabControl_Selecting(sender, e, TabControlMain));
            if (this.BindingSourceMain != null && !this.IsBindingSourceMainMultiselect)
                this.BindingSourceMain.CurrentChanged += new System.EventHandler(BindingSourceMain_CurrentChanged);
            Add_BindingSourceList_EventHandlers(TabElements);
            Add_TabControl_EventHandlers(TabElements);
            Add_Buttons_ClickEventHandlers(TabElements);

            //set language
            LanguageHelper = new DGUIGHFLanguageHelper(this);
            AddLanguageComponents();
            LanguageHelper.LoadFromFile(uighfApplication.LanguageFilename);
            SetAdditionalLanguage();
        }

        /// <summary>
        /// Add language components to this form
        /// </summary>
        public virtual void AddLanguageComponents()
        { }

        /// <summary>
        /// Set additional language for this form
        /// </summary>
        public virtual void SetAdditionalLanguage()
        { }

        /// <summary>
        /// Add custom CurrentChange event handlers on List BindingSource
        /// </summary>
        /// <param name="tabElements"></param>
        private void Add_BindingSourceList_EventHandlers(List<TabElement> tabElements)
        {
            if (tabElements != null)
            {
                foreach (TabElement tabElement in tabElements)
                {
                    if (tabElement.ElementItem != null)
                    { }
                    else if (tabElement.ElementListItem != null)
                    {
                        if (!tabElement.ElementListItem.IsBindingSourceListMultiselect)
                            tabElement.ElementListItem.BindingSourceList.CurrentChanged += new System.EventHandler((sender, e) => BindingSourceList_CurrentChanged(sender, e, tabElement));
                    }
                    else if (tabElement.ElementListTabs != null)
                    {
                        if (!tabElement.ElementListTabs.IsBindingSourceListMultiselect)
                            tabElement.ElementListTabs.BindingSourceList.CurrentChanged += new System.EventHandler((sender, e) => BindingSourceList_CurrentChanged(sender, e, tabElement));

                        //recursive call
                        Add_BindingSourceList_EventHandlers(tabElement.ElementListTabs.TabElements);
                    }
                    else if (tabElement.ElementTabs != null)
                    {
                        //recursive call
                        Add_BindingSourceList_EventHandlers(tabElement.ElementTabs.TabElements);
                    }
                }
            }
        }

        /// <summary>
        /// Add custom SelectedIndexChanged and Selecting event handlers on TabControl
        /// </summary>
        /// <param name="tabElements"></param>
        private void Add_TabControl_EventHandlers(List<TabElement> tabElements)
        {
            if (tabElements != null)
            {
                foreach (TabElement tabElement in tabElements)
                {
                    if (tabElement.ElementItem != null)
                    { }
                    else if (tabElement.ElementListItem != null)
                    { }
                    else if (tabElement.ElementListTabs != null)
                    {
                        tabElement.ElementListTabs.TabControlElement.SelectedIndexChanged += new System.EventHandler((sender, e) => TabControl_SelectedIndexChanged(sender, e, tabElement.ElementListTabs.TabElements, tabElement.ElementListTabs.TabControlElement));
                        tabElement.ElementListTabs.TabControlElement.Selecting += new System.Windows.Forms.TabControlCancelEventHandler((sender, e) => TabControl_Selecting(sender, e, tabElement.ElementListTabs.TabControlElement));

                        //recursive call
                        Add_TabControl_EventHandlers(tabElement.ElementListTabs.TabElements);
                    }
                    else if (tabElement.ElementTabs != null)
                    {
                        tabElement.ElementTabs.TabControlElement.SelectedIndexChanged += new System.EventHandler((sender, e) => TabControl_SelectedIndexChanged(sender, e, tabElement.ElementTabs.TabElements, tabElement.ElementTabs.TabControlElement));
                        tabElement.ElementTabs.TabControlElement.Selecting += new System.Windows.Forms.TabControlCancelEventHandler((sender, e) => TabControl_Selecting(sender, e, tabElement.ElementTabs.TabControlElement));

                        //recursive call
                        Add_TabControl_EventHandlers(tabElement.ElementTabs.TabElements);
                    }
                }
            }
        }

        /// <summary>
        /// Add Click events on buttons
        /// </summary>
        /// <param name="tabElements"></param>
        private void Add_Buttons_ClickEventHandlers(List<TabElement> tabElements)
        {
            if (tabElements != null)
            {
                foreach (TabElement tabElement in tabElements)
                {
                    if (tabElement.ElementItem != null)
                    {
                        if (tabElement.ElementItem.AddButton != null && tabElement.ElementItem.IsAddButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementItem.AddButton.Click += new System.EventHandler((sender, e) => Button_Add_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementItem.UpdateButton != null && tabElement.ElementItem.IsUpdateButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementItem.UpdateButton.Click += new System.EventHandler((sender, e) => Button_Update_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementItem.RemoveButton != null && tabElement.ElementItem.IsRemoveButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementItem.RemoveButton.Click += new System.EventHandler((sender, e) => Button_Remove_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementItem.SaveButton != null && tabElement.ElementItem.IsSaveButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementItem.SaveButton.Click += new System.EventHandler((sender, e) => Button_Save_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementItem.CancelButton != null && tabElement.ElementItem.IsCancelButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementItem.CancelButton.Click += new System.EventHandler((sender, e) => Button_Cancel_Click(sender, e, tabElement));
                        }
                    }
                    else if (tabElement.ElementListItem != null)
                    {
                        if (tabElement.ElementListItem.AddButton != null && tabElement.ElementListItem.IsAddButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementListItem.AddButton.Click += new System.EventHandler((sender, e) => Button_Add_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementListItem.UpdateButton != null && tabElement.ElementListItem.IsUpdateButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementListItem.UpdateButton.Click += new System.EventHandler((sender, e) => Button_Update_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementListItem.RemoveButton != null && tabElement.ElementListItem.IsRemoveButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementListItem.RemoveButton.Click += new System.EventHandler((sender, e) => Button_Remove_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementListItem.SaveButton != null && tabElement.ElementListItem.IsSaveButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementListItem.SaveButton.Click += new System.EventHandler((sender, e) => Button_Save_Click(sender, e, tabElement));
                        }
                        if (tabElement.ElementListItem.CancelButton != null && tabElement.ElementListItem.IsCancelButtonDefaultClickEventAttached)
                        {
                            tabElement.ElementListItem.CancelButton.Click += new System.EventHandler((sender, e) => Button_Cancel_Click(sender, e, tabElement));
                        }
                    }
                    else if (tabElement.ElementListTabs != null)
                    {
                        //recursive call
                        Add_Buttons_ClickEventHandlers(tabElement.ElementListTabs.TabElements);
                    }
                    else if (tabElement.ElementTabs != null)
                    {
                        //recursive call
                        Add_Buttons_ClickEventHandlers(tabElement.ElementTabs.TabElements);
                    }
                }
            }
        }

        #endregion


        #region Main Form Actions

        /// <summary>
        /// Main FormClosing handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //inhibit close if we are editing
            if (UIGHFApplication.IsEditing)
                e.Cancel = true;
        }

        /// <summary>
        /// Main form Activated handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Activated(object sender, EventArgs e)
        {
            //reload on form activation
            if (m_forceFormReload)
            {
                if (ReloadFormOnActive && !UIGHFApplication.IsEditing)
                    this.OnLoad(e);
                m_forceFormReload = false;
            }
        }

        /// <summary>
        /// Main form Deactivate handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Deactivate(object sender, EventArgs e)
        {
            //arm reload on form activation
            if (!m_forceFormReloadArmingDisabled)
                m_forceFormReload = true;
            m_forceFormReloadArmingDisabled = false;
        }

        /// <summary>
        /// Main form Load handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            //check and set the first time loader
            if (!IsFirstLoad)
            {
                IsFirstLoad = true;
            }
        }

        #endregion


        #region Various methods

        /// <summary>
        /// Set a BindingSource for a DataSource
        /// </summary>
        /// <param name="bindingSource"></param>
        /// <param name="dataSource"></param>
        private void SetBindingSourceDataSource(BindingSource bindingSource, object dataSource)
        {
            if (dataSource != null)
            {
                IsBindingSourceLoading = true;
                bindingSource.DataSource = dataSource;
                IsBindingSourceLoading = false;
                if (bindingSource.IsBindingSuspended)
                {
                    bindingSource.ResumeBinding();
                }
            }
            else
            {
                bindingSource.SuspendBinding();
            }
        }

        #endregion


        #region Main list

        /// <summary>
        /// Reload the main view
        /// </summary>
        protected void ReloadView()
        {
            //set main binding source
            object datasource = GetDataSourceMain();
            SetBindingSourceDataSource(BindingSourceMain, datasource);

            SetEditingMode(EditingMode.R);

            //reset lazyload for every tab
            ResetLazyLoad(TabElements);

            if (!IsBindingSourceMainMultiselect || (IsBindingSourceMainMultiselect && !IsFirstReloadView))
            {
                //reload the selected tab
                TabControl_SelectedIndexChanged(null, null, TabElements, TabControlMain);
            }
            if (IsFirstReloadView)
                IsFirstReloadView = false;
        }

        #endregion


        #region BindingSource event handlers

        /// <summary>
        /// Default BindingSourceMain CurrentChanged handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BindingSourceMain_CurrentChanged(object sender, EventArgs e)
        {
            if (IsBindingSourceLoading)
                return;

            //reset lazyload for every tab
            ResetLazyLoad(TabElements);

            //reload the selected tab
            TabControl_SelectedIndexChanged(sender, e, TabElements, TabControlMain);
        }

        /// <summary>
        /// Default BindingSourceList CurrentChanged handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BindingSourceList_CurrentChanged(object sender, EventArgs e, TabElement tabElement)
        {
            if (IsBindingSourceLoading)
                return;

            //count selected items in case of multiselect
            bool loaddatasource = true;
            if (tabElement.ElementItem != null)
            { }
            else if (tabElement.ElementListItem != null)
            {
                if (tabElement.ElementListItem.CountSelectedItems != null)
                {
                    if (tabElement.ElementListItem.CountSelectedItems() != 1)
                        loaddatasource = false;
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (tabElement.ElementItem != null)
            { }
            else if (tabElement.ElementListItem != null)
            {
                //load the new datasource for the CurrentElement
                object datasource = null;
                if (loaddatasource)
                {
                    datasource = tabElement.ElementListItem.GetDataSourceEdit();
                }
                SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceEdit, datasource);
                //raise the CurrentElement changed event
                tabElement.ElementListItem.OnBindingSourceEditChanged(new EventArgs());
            }
            else if (tabElement.ElementListTabs != null)
            {
                //reset lazyload for sub tabs
                ResetLazyLoad(tabElement.ElementListTabs.TabElements);

                //reload the selected tab
                TabControl_SelectedIndexChanged(sender, e, tabElement.ElementListTabs.TabElements, tabElement.ElementListTabs.TabControlElement);
            }
            else if (tabElement.ElementTabs != null)
            {
                //reset lazyload for sub tabs
                ResetLazyLoad(tabElement.ElementTabs.TabElements);

                //reload the selected tab
                TabControl_SelectedIndexChanged(sender, e, tabElement.ElementTabs.TabElements, tabElement.ElementTabs.TabControlElement);
            }
        }

        #endregion


        #region TabControl event hanlders

        /// <summary>
        /// Default TabControl SelectedIndexChanged handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElements"></param>
        /// <param name="tabControl"></param>
        protected void TabControl_SelectedIndexChanged(object sender, EventArgs e, List<TabElement> tabElements, TabControl tabControl)
        {
            //if no element is selected, skip to first tab
            if (BindingSourceMain.Current == null)
            {
                tabControl.SelectedIndex = 0;
            }

            //load current tab
            TabElement tabElement = tabElements.Find(r => r.TabPageElement == tabControl.SelectedTab);
            if (tabElement != null)
            {
                bool loaddatasource = true;

                //count selected items in case of multiselect
                if (tabElement.ElementItem != null)
                {
                    if (tabElement.ElementItem.CountParentSelectedItems != null)
                    {
                        if (tabElement.ElementItem.CountParentSelectedItems() != 1)
                        {
                            loaddatasource = false;
                            (tabElement.TabPageElement.Parent as TabControl).SelectedIndex = 0;
                        }
                    }
                }
                else if (tabElement.ElementListItem != null)
                {
                    if (tabElement.ElementListItem.CountParentSelectedItems != null)
                    {
                        if (tabElement.ElementListItem.CountParentSelectedItems() != 1)
                        {
                            loaddatasource = false;
                            (tabElement.TabPageElement.Parent as TabControl).SelectedIndex = 0;
                        }
                    }
                }
                else if (tabElement.ElementListTabs != null)
                {
                    if (tabElement.ElementListTabs.CountParentSelectedItems != null)
                    {
                        if (tabElement.ElementListTabs.CountParentSelectedItems() != 1)
                        {
                            loaddatasource = false;
                            (tabElement.TabPageElement.Parent as TabControl).SelectedIndex = 0;
                        }
                    }
                }
                else if (tabElement.ElementTabs != null)
                { }

                //if it not load, load it
                if (!tabElement.IsLazyLoaded)
                {
                    tabElement.IsLazyLoaded = true;

                    if (tabElement.ElementItem != null)
                    {
                        //set the CurrentElement datasource
                        object datasource = null;
                        if (loaddatasource)
                        {
                            datasource = tabElement.ElementItem.GetDataSourceEdit();
                        }
                        SetBindingSourceDataSource(tabElement.ElementItem.BindingSourceEdit, datasource);
                        //raise the CurrentElement changed event
                        tabElement.ElementItem.OnBindingSourceEditChanged(new EventArgs());
                    }
                    else if (tabElement.ElementListItem != null)
                    {
                        //set the List datasource
                        object datasource = null;
                        if (loaddatasource)
                        {
                            datasource = tabElement.ElementListItem.GetDataSourceList();
                        }
                        else
                        {
                            if (tabElement.ElementListItem.GetDataSourceEmptyList != null)
                            {
                                datasource = tabElement.ElementListItem.GetDataSourceEmptyList();
                            }
                        }
                        SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceList, datasource);
                        //raise the List changed event
                        tabElement.ElementListItem.OnBindingSourceListChanged(new EventArgs());

                        //raise the currentchange event
                        BindingSourceList_CurrentChanged(null, null, tabElement);
                    }
                    else if (tabElement.ElementListTabs != null)
                    {
                        //set the List datasource
                        object datasource = null;
                        if (loaddatasource)
                        {
                            datasource = tabElement.ElementListTabs.GetDataSourceList();
                        }
                        else
                        {
                            datasource = tabElement.ElementListTabs.GetDataSourceEmptyList();
                        }
                        SetBindingSourceDataSource(tabElement.ElementListTabs.BindingSourceList, datasource);
                        //raise the List changed event
                        tabElement.ElementListTabs.OnBindingSourceListChanged(new EventArgs());

                        //raise the currentchange event
                        BindingSourceList_CurrentChanged(null, null, tabElement);
                    }
                    else if (tabElement.ElementTabs != null)
                    {
                        //raise the currentchange event
                        BindingSourceList_CurrentChanged(null, null, tabElement);
                    }
                }
            }
        }

        /// <summary>
        /// Default TabControl Selectiong handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabControl"></param>
        protected void TabControl_Selecting(object sender, TabControlCancelEventArgs e, TabControl tabControl)
        {
            //cancel load if tab is not enabled
            if (!e.TabPage.Enabled)
                e.Cancel = true;
        }

        #endregion


        #region Tab Loader/Unloader

        /// <summary>
        /// Reset LazyLoading status for every TabElements and childs
        /// </summary>
        /// <param name="tabElements"></param>
        private void ResetLazyLoad(List<TabElement> tabElements)
        {
            //reset lazyloading
            foreach (TabElement tabElement in tabElements)
            {
                if (tabElement.ElementItem != null)
                { }
                else if (tabElement.ElementListItem != null)
                { }
                else if (tabElement.ElementListTabs != null)
                {
                    ResetLazyLoad(tabElement.ElementListTabs.TabElements);
                }
                else if (tabElement.ElementTabs != null)
                {
                    ResetLazyLoad(tabElement.ElementTabs.TabElements);
                }

                tabElement.IsLazyLoaded = false;
            }
        }

        /// <summary>
        /// Reset LazyLoad on all form TabElements
        /// </summary>
        private void ResetLazyLoadAllTabs()
        {
            ResetLazyLoad(TabElements);
        }

        /// <summary>
        /// Unload a TabElement
        /// </summary>
        /// <param name="tabElement"></param>
        private void UnloadTab(TabElement tabElement)
        {
            if (tabElement.ElementItem != null)
            {
                //unload the datasource for the current Element
                SetBindingSourceDataSource(tabElement.ElementItem.BindingSourceEdit, null);
                //raise the CurrentElement changed event
                tabElement.ElementItem.OnBindingSourceEditChanged(new EventArgs());
            }
            else if (tabElement.ElementListItem != null)
            {
                //unload the datasource for the List
                object datasource = null;
                if (tabElement.ElementListItem.GetDataSourceEmptyList != null)
                {
                    tabElement.ElementListItem.GetDataSourceEmptyList();
                }
                SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceList, datasource);
                //raise the List changed event
                tabElement.ElementListItem.OnBindingSourceListChanged(new EventArgs());

                //unload the datasource for the current Element
                SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceEdit, null);
                //raise the CurrentElement changed event
                tabElement.ElementListItem.OnBindingSourceEditChanged(new EventArgs());
            }
            else if (tabElement.ElementListTabs != null)
            {
                //unload the datasource for the List
                object datasource = null;
                if (tabElement.ElementListTabs.GetDataSourceEmptyList != null)
                {
                    tabElement.ElementListTabs.GetDataSourceEmptyList();
                }
                SetBindingSourceDataSource(tabElement.ElementListTabs.BindingSourceList, datasource);
                //raise the List changed event
                tabElement.ElementListTabs.OnBindingSourceListChanged(new EventArgs());

                //unload sub
                UnloadTabs(tabElement.ElementListTabs.TabElements);
            }
            else if (tabElement.ElementTabs != null)
            {
                //unload sub
                UnloadTabs(tabElement.ElementTabs.TabElements);
            }
        }

        /// <summary>
        /// Unload every TabElements and childs
        /// </summary>
        /// <param name="tabElements"></param>
        private void UnloadTabs(List<TabElement> tabElements)
        {
            foreach (TabElement tabElement in tabElements)
            {
                UnloadTab(tabElement);
            }
        }

        /// <summary>
        /// Unload all form TabElements and childs
        /// </summary>
        private void UnloadAllTabs()
        {
            UnloadTabs(TabElements);
        }

        /// <summary>
        /// Load a TabElement
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="loadList"></param>
        /// <param name="loadEdit"></param>
        private void LoadTab(TabElement tabElement, bool loadList, bool loadEdit)
        {
            if (tabElement.ElementItem != null)
            {
                if (loadList)
                {
                    //reload the BindingSourceList
                    object datasource = tabElement.ElementItem.GetParentDataSourceList();
                    SetBindingSourceDataSource(tabElement.ElementItem.ParentBindingSourceList, datasource);
                    //raise the List changed event
                    tabElement.ElementItem.OnParentBindingSourceListChanged(new EventArgs());
                }
                if (loadEdit)
                {
                    //load the new datasource for the CurrentElement
                    object datasource = tabElement.ElementItem.GetDataSourceEdit();
                    SetBindingSourceDataSource(tabElement.ElementItem.BindingSourceEdit, datasource);
                    //raise the CurrentElement changed event
                    tabElement.ElementItem.OnBindingSourceEditChanged(new EventArgs());
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (loadList)
                {
                    //load the new datasource for the List
                    object datasource = tabElement.ElementListItem.GetDataSourceList();
                    SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceList, datasource);
                    //raise the List changed event
                    tabElement.ElementListItem.OnBindingSourceListChanged(new EventArgs());
                }
                if (loadEdit)
                {
                    //load the new datasource for the CurrentElement
                    object datasource = tabElement.ElementListItem.GetDataSourceEdit();
                    SetBindingSourceDataSource(tabElement.ElementListItem.BindingSourceEdit, datasource);
                    //raise the CurrentElement changed event
                    tabElement.ElementListItem.OnBindingSourceEditChanged(new EventArgs());
                }
            }
            else if (tabElement.ElementListTabs != null)
            {
                if (loadList)
                {
                    //load the new datasource for the List
                    object datasource = tabElement.ElementListTabs.GetDataSourceList();
                    SetBindingSourceDataSource(tabElement.ElementListTabs.BindingSourceList, datasource);
                    //raise the List changed event
                    tabElement.ElementListTabs.OnBindingSourceListChanged(new EventArgs());
                }

                //load sub
                LoadTabs(tabElement.ElementListTabs.TabElements, loadList, loadEdit);
            }
            else if (tabElement.ElementTabs != null)
            {
                //load sub
                LoadTabs(tabElement.ElementListTabs.TabElements, loadList, loadEdit);
            }
        }

        /// <summary>
        /// Load every TabElements and childs
        /// </summary>
        /// <param name="tabElements"></param>
        /// <param name="loadList"></param>
        /// <param name="loadEdit"></param>
        private void LoadTabs(List<TabElement> tabElements, bool loadList, bool loadEdit)
        {
            foreach (TabElement tabElement in tabElements)
            {
                LoadTab(tabElement, loadList, loadEdit);
            }
        }

        /// <summary>
        /// Load all form TabElements and childs
        /// </summary>
        private void LoadAllTabs()
        {
            LoadTabs(TabElements, true, true);
        }

        /// <summary>
        /// Reload a tab
        /// </summary>
        /// <param name="tabElement"></param>
        protected void ReloadTab(TabElement tabElement)
        {
            LoadTab(tabElement, true, true);
        }

        #endregion


        #region Button click events

        /// <summary>
        /// Default Add button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElement"></param>
        private void Button_Add_Click(object sender, EventArgs e, TabElement tabElement)
        {
            AddClick(tabElement);
        }

        /// <summary>
        /// Default Update button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElement"></param>
        private void Button_Update_Click(object sender, EventArgs e, TabElement tabElement)
        {
            UpdateClick(tabElement);
        }

        /// <summary>
        /// Default Remove button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElement"></param>
        private void Button_Remove_Click(object sender, EventArgs e, TabElement tabElement)
        {
            RemoveClick(tabElement);
        }

        /// <summary>
        /// Default Save button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElement"></param>
        private void Button_Save_Click(object sender, EventArgs e, TabElement tabElement)
        {
            SaveClick(tabElement);
        }

        /// <summary>
        /// Default Cancel button Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tabElement"></param>
        private void Button_Cancel_Click(object sender, EventArgs e, TabElement tabElement)
        {
            CancelClick(tabElement);
        }

        #endregion


        #region Buttons helpers

        /// <summary>
        /// Add button Click event helper
        /// </summary>
        /// <param name="tabElement"></param>
        /// <returns></returns>
        protected bool AddClick(TabElement tabElement)
        {
            if (tabElement.ElementItem != null)
            {
                tabElement.ElementItem.BindingSourceEdit.ResumeBinding();
                tabElement.ElementItem.BindingSourceEdit.AddNew();

                SetEditingModeTab(tabElement, EditingMode.C);

                return true;
            }
            else if (tabElement.ElementListItem != null)
            {
                tabElement.ElementListItem.BindingSourceEdit.ResumeBinding();
                tabElement.ElementListItem.BindingSourceEdit.AddNew();

                SetEditingModeTab(tabElement, EditingMode.C);

                return true;
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            return true;
        }

        /// <summary>
        /// Update button Click event helper
        /// </summary>
        /// <param name="tabElement"></param>
        /// <returns></returns>
        protected bool UpdateClick(TabElement tabElement)
        {
            //count selected items in case of multiselect
            bool loaddatasource = true;
            if (tabElement.ElementItem != null)
            {
                if (tabElement.ElementItem.CountParentSelectedItems != null)
                {
                    if (tabElement.ElementItem.CountParentSelectedItems() != 1)
                        loaddatasource = false;
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (tabElement.ElementListItem.CountSelectedItems != null)
                {
                    if (tabElement.ElementListItem.CountSelectedItems() != 1)
                        loaddatasource = false;
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (!loaddatasource)
                return false;

            bool elselected = false;

            if (tabElement.ElementItem != null)
            {
                if (!tabElement.ElementItem.BindingSourceEdit.IsBindingSuspended && tabElement.ElementItem.BindingSourceEdit.Current != null)
                {
                    elselected = true;
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (!tabElement.ElementListItem.BindingSourceList.IsBindingSuspended && tabElement.ElementListItem.BindingSourceList.Current != null)
                {
                    elselected = true;
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (elselected)
            {
                SetEditingModeTab(tabElement, EditingMode.U);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Remove button Click event helper
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="displayAlertOnError"></param>
        /// <returns></returns>
        protected bool RemoveClick(TabElement tabElement, bool displayAlertOnError)
        {
            bool elselected = false;
            object[] elselecteditems = null;

            if (tabElement.ElementItem != null)
            {
                if (tabElement.ElementItem.GetParentSelectedItems != null)
                {
                    elselecteditems = tabElement.ElementItem.GetParentSelectedItems();
                    if (elselecteditems != null && elselecteditems.Count() > 0)
                    {
                        elselected = true;
                    }
                }
                else
                {
                    if (!tabElement.ElementItem.BindingSourceEdit.IsBindingSuspended && tabElement.ElementItem.BindingSourceEdit.Current != null)
                    {
                        elselected = true;
                    }
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (tabElement.ElementListItem.GetSelectedItems != null)
                {
                    elselecteditems = tabElement.ElementListItem.GetSelectedItems();
                    if (elselecteditems != null && elselecteditems.Count() > 0)
                    {
                        elselected = true;
                    }
                }
                else
                {
                    if (!tabElement.ElementListItem.BindingSourceList.IsBindingSuspended && tabElement.ElementListItem.BindingSourceList.Current != null)
                    {
                        elselected = true;
                    }
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (elselected)
            {
                m_forceFormReloadArmingDisabled = true;
                if (MessageBox.Show((elselecteditems != null && elselecteditems.Count() > 1 ? languageBase.formDeleteManyMessageBoxText : languageBase.formDeleteMessageBoxText), languageBase.formDeleteMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (elselecteditems != null && elselecteditems.Count() > 1)
                    {
                        bool deleteerrors = false;
                        bool almostoneisdeleted = false;
                        foreach (object item in elselecteditems)
                        {
                            try
                            {
                                if (tabElement.ElementItem != null)
                                {
                                    tabElement.ElementItem.Remove(item);
                                }
                                else if (tabElement.ElementListItem != null)
                                {
                                    tabElement.ElementListItem.Remove(item);
                                }
                                else if (tabElement.ElementListTabs != null)
                                { }
                                else if (tabElement.ElementTabs != null)
                                { }
                                almostoneisdeleted = true;
                            }
                            catch (ArgumentException ex)
                            {
                                if (displayAlertOnError)
                                {
                                    new DGUIGHFFormErrors(ex.Message, true, languageBase).ShowDialog();
                                }
                                deleteerrors = true;
                            }
                            catch (DataException ex)
                            {
                                if (displayAlertOnError)
                                {
                                    new DGUIGHFFormErrors(ex.Message, false, languageBase).ShowDialog();
                                }
                                deleteerrors = true;
                            }
                            if (deleteerrors)
                                break;
                        }

                        if (!deleteerrors || almostoneisdeleted)
                        {
                            ResetLazyLoad(TabElements);

                            ReloadAfterSave(tabElement, null);
                        }
                    }
                    else
                    {
                        SetEditingModeTab(tabElement, EditingMode.D);

                        SaveClick(tabElement, displayAlertOnError);

                        SetEditingModeTab(tabElement, EditingMode.R);
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Remove button Click event helper, display alert on error
        /// </summary>
        /// <param name="tabElement"></param>
        /// <returns></returns>
        protected bool RemoveClick(TabElement tabElement)
        {
            return RemoveClick(tabElement, true);
        }

        /// <summary>
        /// Save button Click event helper
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="displayAlertOnError"></param>
        /// <param name="reloadAfterSave"></param>
        /// <returns></returns>
        protected bool SaveClick(TabElement tabElement, bool displayAlertOnError, bool reloadAfterSave)
        {
            object item = null;

            if (tabElement.ElementItem != null)
            {
                tabElement.ElementItem.BindingSourceEdit.EndEdit();
                item = tabElement.ElementItem.BindingSourceEdit.Current;
            }
            else if (tabElement.ElementListItem != null)
            {
                tabElement.ElementListItem.BindingSourceEdit.EndEdit();
                item = tabElement.ElementListItem.BindingSourceEdit.Current;
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (tabElement.CurrentEditingMode == EditingMode.C)
            {
                try
                {
                    if (tabElement.ElementItem != null)
                    {
                        tabElement.ElementItem.Add(item);
                    }
                    else if (tabElement.ElementListItem != null)
                    {
                        tabElement.ElementListItem.Add(item);
                    }
                    else if (tabElement.ElementListTabs != null)
                    { }
                    else if (tabElement.ElementTabs != null)
                    { }
                }
                catch (ArgumentException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, true, languageBase).ShowDialog();
                    }
                    return false;
                }
                catch (DataException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, false, languageBase).ShowDialog();
                    }
                    return false;
                }
            }
            else if (tabElement.CurrentEditingMode == EditingMode.U)
            {
                try
                {
                    if (tabElement.ElementItem != null)
                    {
                        tabElement.ElementItem.Update(item);
                    }
                    else if (tabElement.ElementListItem != null)
                    {
                        tabElement.ElementListItem.Update(item);
                    }
                    else if (tabElement.ElementListTabs != null)
                    { }
                    else if (tabElement.ElementTabs != null)
                    { }
                }
                catch (ArgumentException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, true, languageBase).ShowDialog();
                    }
                    return false;
                }
                catch (DataException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, false, languageBase).ShowDialog();
                    }
                    return false;
                }
            }
            else if (tabElement.CurrentEditingMode == EditingMode.D)
            {
                try
                {
                    if (tabElement.ElementItem != null)
                    {
                        tabElement.ElementItem.Remove(item);
                    }
                    else if (tabElement.ElementListItem != null)
                    {
                        tabElement.ElementListItem.Remove(item);
                    }
                    else if (tabElement.ElementListTabs != null)
                    { }
                    else if (tabElement.ElementTabs != null)
                    { }
                }
                catch (ArgumentException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, true, languageBase).ShowDialog();
                    }
                    return false;
                }
                catch (DataException ex)
                {
                    if (displayAlertOnError)
                    {
                        new DGUIGHFFormErrors(ex.Message, false, languageBase).ShowDialog();
                    }
                    return false;
                }
                item = null;
            }

            //reload controls after save
            if (reloadAfterSave)
            {
                ResetLazyLoad(TabElements);

                ReloadAfterSave(tabElement, item);
            }

            return true;
        }

        /// <summary>
        /// Save button Click event helper, reload list after save
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="displayAlertOnError"></param>
        /// <returns></returns>
        protected bool SaveClick(TabElement tabElement, bool displayAlertOnError)
        {
            return SaveClick(tabElement, displayAlertOnError, true);
        }

        /// <summary>
        /// Save button Click event helper, display alert on error, and reload list after save
        /// </summary>
        /// <param name="tabElement"></param>
        /// <returns></returns>
        protected bool SaveClick(TabElement tabElement)
        {
            return SaveClick(tabElement, true, true);
        }

        /// <summary>
        /// Cancel button Click event helper
        /// </summary>
        /// <param name="tabElement"></param>
        protected bool CancelClick(TabElement tabElement)
        {
            if (tabElement.ElementItem != null)
            {
                tabElement.ElementItem.BindingSourceEdit.CancelEdit();
            }
            else if (tabElement.ElementListItem != null)
            {
                tabElement.ElementListItem.BindingSourceEdit.CancelEdit();
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            LoadTab(tabElement, false, true);

            SetEditingModeTab(tabElement, EditingMode.R);

            return true;
        }

        /// <summary>
        /// Reload TabElement after save
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="item"></param>
        protected void ReloadAfterSave(TabElement tabElement, object item)
        {
            SetEditingModeTab(tabElement, EditingMode.R);

            LoadTab(tabElement, true, false);

            if (tabElement.ElementItem != null)
            {
                if (tabElement.ElementItem.ReloadViewAfterSave)
                {
                    ReloadView();
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (tabElement.ElementListItem.ReloadViewAfterSave)
                {
                    ReloadView();
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            if (tabElement.ElementItem != null)
            {
                if (tabElement.ElementItem.AfterSaveAction != null)
                {
                    IsBindingSourceLoading = true;
                    tabElement.ElementItem.AfterSaveAction(item);
                    IsBindingSourceLoading = false;
                }
            }
            else if (tabElement.ElementListItem != null)
            {
                if (tabElement.ElementListItem.AfterSaveAction != null)
                {
                    IsBindingSourceLoading = true;
                    tabElement.ElementListItem.AfterSaveAction(item);
                    IsBindingSourceLoading = false;
                }
            }
            else if (tabElement.ElementListTabs != null)
            { }
            else if (tabElement.ElementTabs != null)
            { }

            LoadTab(tabElement, false, true);
        }

        #endregion


        #region Set EditingMode

        /// <summary>
        /// Set EditingMode for the Main view
        /// </summary>
        /// <param name="action"></param>
        protected void SetEditingMode(EditingMode action)
        {
            if (action == EditingMode.C || action == EditingMode.U || action == EditingMode.childC || action == EditingMode.childU)
            {
                UIGHFApplication.IsEditing = true;

                foreach (TabPage tabPage in TabControlMain.TabPages)
                {
                    if (TabControlMain.SelectedTab != tabPage)
                    {
                        tabPage.Enabled = false;
                    }
                }

                ChangeChildControlsStatus(PanelFiltersMain, false);

                ChangeChildControlsStatus(PanelListMain, false);

                if (PanelsExtraMain != null)
                {
                    foreach (Panel panel in PanelsExtraMain)
                    {
                        ChangeChildControlsStatus(panel, false);
                    }
                }

                foreach (TabElement tabElement in TabElements)
                {
                    SetEditingModeTab(tabElement, EditingMode.parentU);
                }
            }
            else if (action == EditingMode.D || action == EditingMode.R || action == EditingMode.childD || action == EditingMode.childR)
            {
                if (action == EditingMode.D || action == EditingMode.childD)
                    UIGHFApplication.IsEditing = true;
                else
                    UIGHFApplication.IsEditing = false;

                foreach (TabPage tabPage in TabControlMain.TabPages)
                {
                    tabPage.Enabled = true;
                }

                ChangeChildControlsStatus(PanelFiltersMain, true);

                ChangeChildControlsStatus(PanelListMain, true);

                if (PanelsExtraMain != null)
                {
                    foreach (Panel panel in PanelsExtraMain)
                    {
                        ChangeChildControlsStatus(panel, true);
                    }
                }

                foreach (TabElement tabElement in TabElements)
                {
                    SetEditingModeTab(tabElement, EditingMode.parentR);
                }
            }
        }

        /// <summary>
        /// Set EditingMode for the selected TabElement
        /// </summary>
        /// <param name="tabElement"></param>
        /// <param name="action"></param>
        protected void SetEditingModeTab(TabElement tabElement, EditingMode action)
        {
            if (action == EditingMode.C || action == EditingMode.R || action == EditingMode.U || action == EditingMode.D)
            {
                tabElement.CurrentEditingMode = action;
            }

            if (action == EditingMode.U || action == EditingMode.C)
            {
                if (action == EditingMode.U)
                {
                    SetEditingMode(EditingMode.childU);
                }
                else if (action == EditingMode.C)
                {
                    SetEditingMode(EditingMode.childC);
                }

                if (tabElement.ElementItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelData, true, true);

                    ChangeChildControlsStatus(tabElement.ElementItem.PanelActions, false);
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelUpdates, true);
                }
                else if (tabElement.ElementListItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelData, true, true);

                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelFilters, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelList, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelActions, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelUpdates, true);
                }
                else if (tabElement.ElementListTabs != null)
                { }
                else if (tabElement.ElementTabs != null)
                { }
            }
            else if (action == EditingMode.D || action == EditingMode.R || action == EditingMode.parentR)
            {
                if (action == EditingMode.R)
                {
                    SetEditingMode(EditingMode.childR);
                }
                else if (action == EditingMode.D)
                {
                    SetEditingMode(EditingMode.childD);
                }

                if (tabElement.ElementItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelData, false, true);

                    ChangeChildControlsStatus(tabElement.ElementItem.PanelActions, true);
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelUpdates, false);
                }
                else if (tabElement.ElementListItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelData, false, true);

                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelFilters, true);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelList, true);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelActions, true);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelUpdates, false);
                }
                else if (tabElement.ElementListTabs != null)
                {
                    foreach (TabElement tabElement2 in tabElement.ElementListTabs.TabElements)
                    {
                        SetEditingModeTab(tabElement2, action);
                    }

                    foreach (TabPage tabPage in tabElement.ElementListTabs.TabControlElement.TabPages)
                    {
                        tabPage.Enabled = true;
                    }

                    ChangeChildControlsStatus(tabElement.ElementListTabs.PanelData, true, false);

                    ChangeChildControlsStatus(tabElement.ElementListTabs.PanelFilters, true);
                    ChangeChildControlsStatus(tabElement.ElementListTabs.PanelList, true);
                }
                else if (tabElement.ElementTabs != null)
                {
                    foreach (TabElement tabElement2 in tabElement.ElementTabs.TabElements)
                    {
                        SetEditingModeTab(tabElement2, action);
                    }

                    foreach (TabPage tabPage in tabElement.ElementTabs.TabControlElement.TabPages)
                    {
                        tabPage.Enabled = true;
                    }

                    ChangeChildControlsStatus(tabElement.ElementTabs.PanelData, true, false);
                }
            }
            else if (action == EditingMode.parentU)
            {
                if (tabElement.ElementItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelData, false, true);

                    ChangeChildControlsStatus(tabElement.ElementItem.PanelActions, false);
                    ChangeChildControlsStatus(tabElement.ElementItem.PanelUpdates, false);
                }
                else if (tabElement.ElementListItem != null)
                {
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelData, false, true);

                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelFilters, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelList, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelActions, false);
                    ChangeChildControlsStatus(tabElement.ElementListItem.PanelUpdates, false);
                }
                else if (tabElement.ElementListTabs != null)
                {
                    foreach (TabElement tabElement2 in tabElement.ElementListTabs.TabElements)
                    {
                        SetEditingModeTab(tabElement2, action);
                    }

                    bool tabenabled = false;
                    tabenabled = HasTabPageEnabled(tabElement.ElementListTabs.TabElements, tabElement.ElementListTabs.TabControlElement);

                    ChangeChildControlsStatus(tabElement.ElementListTabs.PanelFilters, false);
                    ChangeChildControlsStatus(tabElement.ElementListTabs.PanelList, false);

                    foreach (TabPage tabPage in tabElement.ElementListTabs.TabControlElement.TabPages)
                    {
                        if (tabElement.ElementListTabs.TabControlElement.SelectedTab != tabPage)
                        {
                            tabPage.Enabled = false;
                        }
                    }

                    if (!tabenabled)
                    {
                        ChangeChildControlsStatus(tabElement.ElementListTabs.PanelData, false, true);
                    }
                }
                else if (tabElement.ElementTabs != null)
                {
                    foreach (TabElement tabElement2 in tabElement.ElementTabs.TabElements)
                    {
                        SetEditingModeTab(tabElement2, action);
                    }

                    bool tabenabled = false;
                    tabenabled = HasTabPageEnabled(tabElement.ElementTabs.TabElements, tabElement.ElementTabs.TabControlElement);

                    foreach (TabPage tabPage in tabElement.ElementTabs.TabControlElement.TabPages)
                    {
                        if (tabElement.ElementTabs.TabControlElement.SelectedTab != tabPage)
                        {
                            tabPage.Enabled = false;
                        }
                    }

                    if (!tabenabled)
                    {
                        ChangeChildControlsStatus(tabElement.ElementTabs.PanelData, false, true);
                    }
                }
            }
        }

        /// <summary>
        /// Change the status of every child Control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        /// <param name="checkReadonly"></param>
        /// <param name="recursionEnabled"></param>
        private void ChangeChildControlsStatus(Control control, bool enable, bool checkReadonly, bool recursionEnabled)
        {
            if (control != null)
            {
                foreach (Control c in control.Controls)
                {
                    if (RecursionSetEditingModeControlTypeCollection.Contains(c.GetType()) && recursionEnabled)
                    {
                        ChangeChildControlsStatus(c, enable, checkReadonly, recursionEnabled);
                    }
                    else
                    {
                        if (checkReadonly)
                        {
                            var property = c.GetType().GetProperty("ReadOnly");
                            if (!DisableReadonlyCheckOnSetEditingModeControlCollection.Contains(c.GetType()) && property != null)
                            {
                                property.SetValue(c, !enable, null);
                            }
                            else
                            {
                                c.Enabled = enable;
                            }
                        }
                        else
                        {
                            c.Enabled = enable;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Change the status of every child Control, check Readonly by default
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        /// <param name="recursionEnabled"></param>
        private void ChangeChildControlsStatus(Control control, bool enable, bool recursionEnabled)
        {
            ChangeChildControlsStatus(control, enable, true, recursionEnabled);
        }

        /// <summary>
        /// Change the status of every child Control, check Readonly by default, recursion not enabled
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        private void ChangeChildControlsStatus(Control control, bool enable)
        {
            ChangeChildControlsStatus(control, enable, true, false);
        }

        /// <summary>
        /// Check if a TabPage is selected/active in the current TabElements and childs
        /// </summary>
        /// <param name="tabElements"></param>
        /// <param name="tabControl"></param>
        /// <returns></returns>
        private bool HasTabPageEnabled(List<TabElement> tabElements, TabControl tabControl)
        {
            bool ret = false;

            //check current tab pages
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabControl.SelectedTab == tabPage)
                {
                    ret = true;
                    return ret;
                }
            }

            //recursive check
            foreach (TabElement tabElement in tabElements)
            {
                if (tabElement.ElementItem != null)
                { }
                else if (tabElement.ElementListItem != null)
                { }
                else if (tabElement.ElementListTabs != null)
                {
                    ret = HasTabPageEnabled(tabElement.ElementListTabs.TabElements, tabElement.ElementListTabs.TabControlElement);
                    if (ret)
                    {
                        break;
                    }
                }
                else if (tabElement.ElementTabs != null)
                {
                    ret = HasTabPageEnabled(tabElement.ElementTabs.TabElements, tabElement.ElementTabs.TabControlElement);
                    if (ret)
                    {
                        break;
                    }
                }
            }

            return ret;
        }

        #endregion

    }

}
