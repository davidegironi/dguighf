#region License
// Copyright (c) 2014 AvioBrain
//                    Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public partial class DGUIGHFFormDataConsistencyViewer : Form
    {
        private bool m_showdetails = false;

        private BindingSource bindingSourceColumns = new BindingSource();
        private DataTable dataTableColumns = new DataTable();

        /// <summary>
        /// Form language
        /// </summary>
        public DGUIGHFLanguageBase languageBase = new DGUIGHFLanguageBase();

        private class VDataConsistencyComparerColumns
        {
            public string fieldName { get; set; }
            public string fieldNameV { get; set; }
            public string originalValue { get; set; }
            public string originalValueV { get; set; }
            public string currentValue { get; set; }
            public string currentValueV { get; set; }
        }

        private Dictionary<string, object> originalValues = new Dictionary<string, object>();
        private Dictionary<string, object> currentValues = new Dictionary<string, object>();
        private Dictionary<string, Func<object, string>> parseFieldValuesFunc = new Dictionary<string, Func<object, string>>();
        private Dictionary<string, string> parseFieldNameDict = new Dictionary<string, string>();

        /// <summary>
        /// Initialize the data consistency viewer
        /// </summary>
        /// <param name="originalValues"></param>
        /// <param name="currentValues"></param>
        /// <param name="parseFieldValuesFunc"></param>
        /// <param name="parseFieldNameDict"></param>
        /// <param name="language"></param>
        public DGUIGHFFormDataConsistencyViewer(IDictionary<string, object> originalValues, IDictionary<string, object> currentValues, IDictionary<string, Func<object, string>> parseFieldValuesFunc, IDictionary<string, string> parseFieldNameDict, DGUIGHFLanguageBase language)
        {
            InitializeComponent();

            //default return value
            this.DialogResult = DialogResult.Cancel;

            //set private variables
            this.originalValues = originalValues.ToDictionary(k => k.Key, k => k.Value);
            this.currentValues = currentValues.ToDictionary(k => k.Key, k => k.Value);
            if (parseFieldValuesFunc != null)
                this.parseFieldValuesFunc = parseFieldValuesFunc.ToDictionary(k => k.Key, k => k.Value);
            if (parseFieldNameDict != null)
                this.parseFieldNameDict = parseFieldNameDict.ToDictionary(k => k.Key, k => k.Value);

            if (language != null)
                languageBase = language;
            else
                languageBase = new DGUIGHFLanguageBase();

            ShowDetails(false);
        }

        /// <summary>
        /// Initialize the data consistency viewer
        /// </summary>
        /// <param name="originalValues"></param>
        /// <param name="currentValues"></param>
        /// <param name="parseFieldValuesFunc"></param>
        /// <param name="parseFieldNameDict"></param>
        public DGUIGHFFormDataConsistencyViewer(IDictionary<string, object> originalValues, IDictionary<string, object> currentValues, IDictionary<string, Func<object, string>> parseFieldValuesFunc, IDictionary<string, string> parseFieldNameDict)
            : this(originalValues, currentValues, parseFieldValuesFunc, parseFieldNameDict, null)
        { }

        /// <summary>
        /// Load the data consistency viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ABUIGHFFormDataConsistencyViewer_Load(object sender, EventArgs e)
        {
            this.Text = languageBase.dataConsistencyViewerTitle;
            label_info.Text = languageBase.dataConsistencyViewerInfoLabel;
            label_text.Text = languageBase.dataConsistencyViewerTextLabel;
            button_ignore.Text = languageBase.dataConsistencyViewerIgnoreButton;
            button_reload.Text = languageBase.dataConsistencyViewerReloadButton;
            button_edit.Text = languageBase.dataConsistencyViewerEditButton;

            this.Icon = SystemIcons.Warning;

            dataGridView_columns.DataSource = bindingSourceColumns;

            LoadValues();
        }

        /// <summary>
        /// Load values to display
        /// </summary>
        private void LoadValues()
        {
            List<VDataConsistencyComparerColumns> itemsColumns = new List<VDataConsistencyComparerColumns>();

            //load rows
            foreach (KeyValuePair<string, object> o in originalValues)
            {
                object originalValue = null;
                object currentValue = null;
                VDataConsistencyComparerColumns itemColumn = new VDataConsistencyComparerColumns();
                itemColumn.fieldName = o.Key;
                itemColumn.fieldNameV = o.Key;
                if (parseFieldNameDict != null)
                {
                    if (parseFieldNameDict.Where(r => r.Key == o.Key).Count() > 0)
                    {
                        itemColumn.fieldNameV = parseFieldNameDict.Where(r => r.Key == o.Key).FirstOrDefault().Value;
                    }
                }
                originalValue = originalValues.Where(r => r.Key == o.Key).FirstOrDefault().Value;
                itemColumn.originalValue = (originalValue != null ? originalValue.ToString() : null);
                itemColumn.originalValueV = (originalValue != null ? (itemColumn.originalValue.ToString().Length > 100 ? itemColumn.originalValue.ToString().Substring(0, 100) + "..." : itemColumn.originalValue.ToString()) : null);
                if (parseFieldValuesFunc != null)
                {
                    Func<object, string> func = parseFieldValuesFunc.FirstOrDefault(r => r.Key == o.Key).Value;
                    if (func != null)
                    {
                        try
                        {
                            originalValue = originalValues.Where(r => r.Key == o.Key).FirstOrDefault().Value;
                            itemColumn.originalValueV = (originalValue != null ? func(originalValue.ToString()) : null);
                        }
                        catch { }
                    }
                }
                currentValue = currentValues.Where(r => r.Key == o.Key).FirstOrDefault().Value;
                itemColumn.currentValue = (currentValue != null ? currentValue.ToString() : null);
                itemColumn.currentValueV = (currentValue != null ? (itemColumn.currentValue.ToString().Length > 100 ? itemColumn.currentValue.ToString().Substring(0, 100) + "..." : itemColumn.currentValue.ToString()) : null);
                if (parseFieldValuesFunc != null)
                {
                    Func<object, string> func = parseFieldValuesFunc.FirstOrDefault(r => r.Key == o.Key).Value;
                    if (func != null)
                    {
                        try
                        {
                            currentValue = currentValues.Where(r => r.Key == o.Key).FirstOrDefault().Value;
                            itemColumn.currentValueV = (currentValue != null ? func(currentValue.ToString()) : null);
                        }
                        catch { }
                    }
                }
                itemsColumns.Add(itemColumn);
            }

            //build the view datatable
            dataTableColumns = new DataTable();

            //add columns
            dataTableColumns.Columns.Add(new DataColumn("FieldName", typeof(string)));
            dataTableColumns.Columns.Add(new DataColumn(languageBase.dataConsistencyFieldNameColumn, typeof(string)));
            dataTableColumns.Columns.Add(new DataColumn("OriginalValue", typeof(string)));
            dataTableColumns.Columns.Add(new DataColumn(languageBase.dataConsistencyOriginalValueColumn, typeof(string)));
            dataTableColumns.Columns.Add(new DataColumn("CurrentValue", typeof(string)));
            dataTableColumns.Columns.Add(new DataColumn(languageBase.dataConsistencyCurrentValueColumn, typeof(string)));

            //add rows
            foreach (VDataConsistencyComparerColumns i in itemsColumns)
            {
                DataRow dr = dataTableColumns.NewRow();

                dr["FieldName"] = i.fieldName;
                dr[languageBase.dataConsistencyFieldNameColumn] = i.fieldNameV;
                dr["OriginalValue"] = i.originalValue;
                dr[languageBase.dataConsistencyOriginalValueColumn] = i.originalValueV;
                dr["CurrentValue"] = i.currentValue;
                dr[languageBase.dataConsistencyCurrentValueColumn] = i.currentValueV;
                dataTableColumns.Rows.Add(dr);
            }

            //attach datasource to the bindingsource
            bindingSourceColumns.DataSource = dataTableColumns;
            bindingSourceColumns.Sort = languageBase.dataConsistencyFieldNameColumn;

            //disable sorting
            foreach (DataGridViewColumn c in dataGridView_columns.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Programmatic;
                if (c.Name == languageBase.dataConsistencyFieldNameColumn)
                {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    c.Width = 100;
                }
                else
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (c.Name == "FieldName" || c.Name == "OriginalValue" || c.Name == "CurrentValue")
                {
                    c.Visible = false;
                }
            }
        }

        /// <summary>
        /// Exit and continue editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_edit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Exit and reload the record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reload_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        /// <summary>
        /// Exit and save using current values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ignore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        /// <summary>
        /// Show all details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_details_Click(object sender, EventArgs e)
        {
            ShowDetails(!m_showdetails);
        }

        /// <summary>
        /// Show or hide details
        /// </summary>
        /// <param name="showdetails"></param>
        private void ShowDetails(bool showdetails)
        {
            if (!showdetails)
            {
                this.m_showdetails = false;
                panel_details.Visible = false;
                button_details.Text = languageBase.dataConsistencyViewerShowDetailsButton;

                int actualwidth = this.Size.Width;
                Size minsize = new Size(480, 305 - 108);
                if (this.Size.Height < minsize.Height)
                {
                    this.Size = minsize;
                }
                this.MinimumSize = minsize;
                this.Size = new Size(actualwidth, minsize.Height);
            }
            else
            {
                this.m_showdetails = true;
                panel_details.Visible = true;
                button_details.Text = languageBase.dataConsistencyViewerHideDetailsButton;

                int actualwidth = this.Size.Width;
                Size minsize = new Size(480, 305);
                if (this.Size.Height < minsize.Height)
                {
                    this.Size = minsize;
                }
                this.MinimumSize = minsize;
                this.Size = new Size(actualwidth, minsize.Height);
            }
        }

        /// <summary>
        /// DataGrid colors formatting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_columns_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_columns.Rows[e.RowIndex].Cells["OriginalValue"].Value.ToString().CompareTo(dataGridView_columns.Rows[e.RowIndex].Cells["CurrentValue"].Value.ToString()) != 0)
            {
                e.CellStyle.BackColor = Color.Salmon;
            }
        }
    }
}
