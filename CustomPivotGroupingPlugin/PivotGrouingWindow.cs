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
        public PivotGrouingWindow(Dictionary<String, List<String>> _groups)
        {
            InitializeComponent();

            groups = _groups;
            groups.Add("Other", new List<string>());

            Excel.PivotTable pt = Globals.PivotGroupingAddIn.Application.ActiveCell.PivotTable;
            foreach (Excel.PivotItem rowItem in pt.PivotFields("Product").PivotItems) // no pt.DataFields pt.RowFields pt.ColumnFields pt.DataFields
            {
                groups["Other"].Add(rowItem.Name);
            }
        }

        private void btnPivotGroupingWindowCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<String, List<String>> groups;
    }
}
