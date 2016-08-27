#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DG.UI.GHF
{
    public static class DGUIGHFDataGridViewHelper
    {
        /// <summary>
        /// Get DataGridView selected keys by key column names
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        public static IList<object[]> GetSelectedKeys(DataGridView dataGridView, string[] columnNames)
        {
            IList<object[]> selectedKeys = new List<object[]> { };
            if (dataGridView.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    object[] selectedKey = new object[] { };
                    foreach (string columnName in columnNames)
                    {
                        selectedKey = selectedKey.Concat(new object[] { row.Cells[columnName].Value }).ToArray();
                    }
                    selectedKeys.Add(selectedKey);
                }
            }
            return selectedKeys;
        }

        /// <summary>
        /// Count DataGridView selected rows
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static int CountSelectedRows(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count;
        }
    }
}
