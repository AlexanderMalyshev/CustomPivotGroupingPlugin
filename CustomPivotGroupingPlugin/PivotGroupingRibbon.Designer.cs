namespace CustomPivotGroupingPlugin
{
    partial class PivotGroupingRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PivotGroupingRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PivotTab = this.Factory.CreateRibbonTab();
            this.PivotGroup = this.Factory.CreateRibbonGroup();
            this.btnPivotGrouping = this.Factory.CreateRibbonButton();
            this.PivotTab.SuspendLayout();
            this.PivotGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PivotTab
            // 
            this.PivotTab.Groups.Add(this.PivotGroup);
            this.PivotTab.Label = "PivotTab";
            this.PivotTab.Name = "PivotTab";
            // 
            // PivotGroup
            // 
            this.PivotGroup.Items.Add(this.btnPivotGrouping);
            this.PivotGroup.Label = "Pivot Group";
            this.PivotGroup.Name = "PivotGroup";
            // 
            // btnPivotGrouping
            // 
            this.btnPivotGrouping.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnPivotGrouping.Image = global::CustomPivotGroupingPlugin.Properties.Resources.PivotGroupingIcon;
            this.btnPivotGrouping.Label = "Group Active Pivot";
            this.btnPivotGrouping.Name = "btnPivotGrouping";
            this.btnPivotGrouping.ShowImage = true;
            this.btnPivotGrouping.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPivotGrouping_Click);
            // 
            // PivotGroupingRibbon
            // 
            this.Name = "PivotGroupingRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.PivotTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.PivotTab.ResumeLayout(false);
            this.PivotTab.PerformLayout();
            this.PivotGroup.ResumeLayout(false);
            this.PivotGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab PivotTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup PivotGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPivotGrouping;
    }

    partial class ThisRibbonCollection
    {
        internal PivotGroupingRibbon Ribbon1
        {
            get { return this.GetRibbon<PivotGroupingRibbon>(); }
        }
    }
}
