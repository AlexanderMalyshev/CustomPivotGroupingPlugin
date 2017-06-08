using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

using Excel = Microsoft.Office.Interop.Excel;

namespace CustomPivotGroupingPlugin
{
    public partial class PivotGroupingRibbon
    {
        private void PivotGroupingRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnPivotGrouping_Click(object sender, RibbonControlEventArgs e)
        {
            PivotGrouingWindow pgw = new PivotGrouingWindow(groups);
            pgw.Show();
        }

        private Dictionary<String, List<String>> groups = new Dictionary<string, List<string>>();
    }
}
