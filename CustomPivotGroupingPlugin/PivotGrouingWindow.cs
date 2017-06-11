using System;
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
            foreach (Excel.PivotItem rowItem in pt.PivotFields("Product").PivotItems)
            {
                items.Add(rowItem.Name);
            }

            return items;
        }

        private void btnPivotGroupingWindowCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupNamesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGroupsView(e.RowIndex);
        }

        private void RefreshGroupsView(int selectedItem)
        {
            if (selectedItem >= groups.Count)
                return;

            GroupItemsListView.Items.Clear();
            GroupItemsListView.CheckBoxes = selectedItem == 0 ? false : true;

            groups[selectedItem].Item2.ForEach(groupItem => GroupItemsListView.Items.Add(groupItem));

            if (selectedItem != 0)
                groups[0].Item2.ForEach(groupItem => GroupItemsListView.Items.Add(groupItem));
        }

        private void GroupNamesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GroupNamesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            String newValue = GroupNamesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.RowIndex == groups.Count)
                groups.Add(new Tuple<string, List<string>>(newValue, new List<string>()));
            else
                groups[e.RowIndex] = new Tuple<string, List<string>>(newValue, groups[e.RowIndex].Item2);

            RefreshGroupsView(e.RowIndex);
        }

        private void GroupNamesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowCount != 1 || GroupNamesDataGridView.Rows.Count == 1)
                return;

            //rgroups.Add(new Tuple<string, List<string>>(GroupNamesDataGridView[e.RowIndex, 0].Value.ToString(), new List<string>()));
        }
    }
}
