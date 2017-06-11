﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace CustomPivotGroupingPlugin
{
    public partial class PivotGrouingWindow : Form
    {
        private const int OTHER = 0;
        private bool IsGroupItemsListViewInEdit = false;
        private int SelectedNameIndex = int.MaxValue;
        private List<Tuple<String, List<String>>> groups;

        public PivotGrouingWindow(List<Tuple<String, List<String>>> _groups)
        {
            InitializeComponent();

            groups = _groups;
            groups.Clear();

            GroupNamesDataGridView.Rows.Clear();
            GroupNamesDataGridView.Rows.Add("Other");
            
            groups.Add(new Tuple<string, List<string>>("Other", ExtractItemsFromPivotRows()));
            RefreshGroupsView(0);
        }

        private static List<string> ExtractItemsFromPivotRows()
        {
            List<string> items = new List<string>();

            Excel.PivotTable pt = Globals.PivotGroupingAddIn.Application.ActiveCell.PivotTable;
            string selectedFields = pt.RowFields.Item(0).Name;
            foreach (Excel.PivotItem rowItem in pt.PivotFields(selectedFields).PivotItems)
            {
                items.Add(rowItem.Name);
            }

            return items;
        }

        private void GroupNamesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedNameIndex = e.RowIndex;
            RefreshGroupsView(e.RowIndex);
        }

        private void RefreshGroupsView(int selectedItem)
        {
            IsGroupItemsListViewInEdit = true;
            GroupItemsListView.Items.Clear();

            if (selectedItem >= groups.Count)
                return;

            GroupItemsListView.CheckBoxes = selectedItem == 0 ? false : true;

            groups[selectedItem].Item2.ForEach(groupItem => {
                var listItem = new ListViewItem(groupItem);
                listItem.Checked = true;
                GroupItemsListView.Items.Add(listItem);
            });

            if (selectedItem != OTHER)
                groups[OTHER].Item2.ForEach(groupItem => GroupItemsListView.Items.Add(groupItem));

            IsGroupItemsListViewInEdit = false;
        }
        
        private void GroupNamesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || GroupNamesDataGridView.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            String newValue = GroupNamesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.RowIndex == groups.Count)
                groups.Add(new Tuple<string, List<string>>(newValue, new List<string>()));
            else
                groups[e.RowIndex] = new Tuple<string, List<string>>(newValue, groups[e.RowIndex].Item2);

            RefreshGroupsView(GroupNamesDataGridView.SelectedRows.Count > 0 ? GroupNamesDataGridView.SelectedRows[0].Index : int.MaxValue);
        }

        private void GroupNamesDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex >= groups.Count)
                return;

            groups[OTHER].Item2.AddRange(groups[e.RowIndex].Item2);
            groups.RemoveAt(e.RowIndex);
        }

        private void GroupItemsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (SelectedNameIndex >= groups.Count || IsGroupItemsListViewInEdit)
                return;

            if (e.Item.Checked)
            {
                groups[OTHER].Item2.Remove(e.Item.Text);
                groups[SelectedNameIndex].Item2.Add(e.Item.Text);
            }
            else
            {
                groups[OTHER].Item2.Add(e.Item.Text);
                groups[SelectedNameIndex].Item2.Remove(e.Item.Text);
            }
        }

        private void PivotGroupingWindowOkButton_Click(object sender, EventArgs e)
        {
            //if (groups.Count <= 1) // something was configured
            //    return;

            Excel.PivotTable pt = Globals.PivotGroupingAddIn.Application.ActiveCell.PivotTable;

            groups.ForEach(groupItem => 
            {
                if (groupItem.Item2.Count == 0)
                    return;

                Excel.PivotFields pfs = pt.RowFields;
                string selectedFields = pfs.Item(0).Name + "[";
                groupItem.Item2.ForEach(item => selectedFields += item + ",");
                selectedFields = selectedFields.Substring(0, selectedFields.Length - 1);
                selectedFields += "]";
                pt.PivotSelect(selectedFields, Excel.XlPTSelectionMode.xlLabelOnly);

                var selection = Globals.PivotGroupingAddIn.Application.Selection;
                selection.Group();

                foreach (Excel.PivotField pf in pt.PivotFields())
                {
                    foreach (Excel.PivotItem rowItem in pf.PivotItems())
                    {
                        if (rowItem.Name.StartsWith("Group"))
                            rowItem.Name = groupItem.Item1;
                    }
                }
            });

            this.Close();
        }
        private void PivotGroupingWindowCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
