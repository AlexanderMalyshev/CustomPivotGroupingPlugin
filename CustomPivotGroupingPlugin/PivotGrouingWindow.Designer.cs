namespace CustomPivotGroupingPlugin
{
    partial class PivotGrouingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPivotGroupingWindowOk = new System.Windows.Forms.Button();
            this.btnPivotGroupingWindowCancel = new System.Windows.Forms.Button();
            this.GroupsGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupItemsListView = new System.Windows.Forms.ListView();
            this.GroupNamesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupNamesDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupNamesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPivotGroupingWindowOk
            // 
            this.btnPivotGroupingWindowOk.Location = new System.Drawing.Point(171, 302);
            this.btnPivotGroupingWindowOk.Name = "btnPivotGroupingWindowOk";
            this.btnPivotGroupingWindowOk.Size = new System.Drawing.Size(75, 23);
            this.btnPivotGroupingWindowOk.TabIndex = 1;
            this.btnPivotGroupingWindowOk.Text = "Ok";
            this.btnPivotGroupingWindowOk.UseVisualStyleBackColor = true;
            // 
            // btnPivotGroupingWindowCancel
            // 
            this.btnPivotGroupingWindowCancel.Location = new System.Drawing.Point(252, 302);
            this.btnPivotGroupingWindowCancel.Name = "btnPivotGroupingWindowCancel";
            this.btnPivotGroupingWindowCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPivotGroupingWindowCancel.TabIndex = 2;
            this.btnPivotGroupingWindowCancel.Text = "Cancel";
            this.btnPivotGroupingWindowCancel.UseVisualStyleBackColor = true;
            this.btnPivotGroupingWindowCancel.Click += new System.EventHandler(this.btnPivotGroupingWindowCancel_Click);
            // 
            // GroupsGroupBox
            // 
            this.GroupsGroupBox.Controls.Add(this.GroupItemsListView);
            this.GroupsGroupBox.Controls.Add(this.GroupNamesDataGridView);
            this.GroupsGroupBox.Location = new System.Drawing.Point(-2, 3);
            this.GroupsGroupBox.Name = "GroupsGroupBox";
            this.GroupsGroupBox.Size = new System.Drawing.Size(340, 293);
            this.GroupsGroupBox.TabIndex = 7;
            this.GroupsGroupBox.TabStop = false;
            this.GroupsGroupBox.Text = "Select grouping type:";
            // 
            // GroupItemsListView
            // 
            this.GroupItemsListView.AutoArrange = false;
            this.GroupItemsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupItemsListView.CheckBoxes = true;
            this.GroupItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GroupNamesColumnHeader});
            this.GroupItemsListView.FullRowSelect = true;
            this.GroupItemsListView.GridLines = true;
            this.GroupItemsListView.LabelWrap = false;
            this.GroupItemsListView.Location = new System.Drawing.Point(154, 65);
            this.GroupItemsListView.MultiSelect = false;
            this.GroupItemsListView.Name = "GroupItemsListView";
            this.GroupItemsListView.Size = new System.Drawing.Size(180, 222);
            this.GroupItemsListView.TabIndex = 9;
            this.GroupItemsListView.UseCompatibleStateImageBehavior = false;
            this.GroupItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // GroupNamesColumnHeader
            // 
            this.GroupNamesColumnHeader.Text = "Group Items";
            this.GroupNamesColumnHeader.Width = 175;
            // 
            // GroupNamesDataGridView
            // 
            this.GroupNamesDataGridView.AllowUserToResizeRows = false;
            this.GroupNamesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GroupNamesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GroupNamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupNamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupNamesColumn});
            this.GroupNamesDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.GroupNamesDataGridView.Location = new System.Drawing.Point(6, 65);
            this.GroupNamesDataGridView.MultiSelect = false;
            this.GroupNamesDataGridView.Name = "GroupNamesDataGridView";
            this.GroupNamesDataGridView.ShowCellErrors = false;
            this.GroupNamesDataGridView.ShowCellToolTips = false;
            this.GroupNamesDataGridView.ShowRowErrors = false;
            this.GroupNamesDataGridView.Size = new System.Drawing.Size(150, 222);
            this.GroupNamesDataGridView.TabIndex = 8;
            this.GroupNamesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupNamesDataGridView_CellEndEdit);
            this.GroupNamesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GroupNamesDataGridView_CellMouseClick);
            this.GroupNamesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupNamesDataGridView_CellValueChanged);
            // 
            // GroupNamesColumn
            // 
            this.GroupNamesColumn.HeaderText = "Group Names";
            this.GroupNamesColumn.Name = "GroupNamesColumn";
            this.GroupNamesColumn.Width = 105;
            // 
            // PivotGrouingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 331);
            this.Controls.Add(this.GroupsGroupBox);
            this.Controls.Add(this.btnPivotGroupingWindowCancel);
            this.Controls.Add(this.btnPivotGroupingWindowOk);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PivotGrouingWindow";
            this.Text = "PivotGrouingWindow";
            this.GroupsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPivotGroupingWindowOk;
        private System.Windows.Forms.Button btnPivotGroupingWindowCancel;
        private System.Windows.Forms.GroupBox GroupsGroupBox;
        private System.Windows.Forms.DataGridView GroupNamesDataGridView;
        private System.Windows.Forms.ListView GroupItemsListView;
        private System.Windows.Forms.ColumnHeader GroupNamesColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNamesColumn;
    }
}