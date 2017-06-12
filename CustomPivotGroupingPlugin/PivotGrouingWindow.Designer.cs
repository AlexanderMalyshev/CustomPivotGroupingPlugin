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
            this.PivotGroupingWindowOkButton = new System.Windows.Forms.Button();
            this.PivotGroupingWindowCancelButton = new System.Windows.Forms.Button();
            this.GroupsGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowRegexEditFieldButton = new System.Windows.Forms.Button();
            this.GroupItemsListView = new System.Windows.Forms.ListView();
            this.GroupNamesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupNamesDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupNamesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PivotGroupingWindowOkButton
            // 
            this.PivotGroupingWindowOkButton.Location = new System.Drawing.Point(171, 302);
            this.PivotGroupingWindowOkButton.Name = "PivotGroupingWindowOkButton";
            this.PivotGroupingWindowOkButton.Size = new System.Drawing.Size(75, 23);
            this.PivotGroupingWindowOkButton.TabIndex = 1;
            this.PivotGroupingWindowOkButton.Text = "Ok";
            this.PivotGroupingWindowOkButton.UseVisualStyleBackColor = true;
            this.PivotGroupingWindowOkButton.Click += new System.EventHandler(this.PivotGroupingWindowOkButton_Click);
            // 
            // PivotGroupingWindowCancelButton
            // 
            this.PivotGroupingWindowCancelButton.Location = new System.Drawing.Point(252, 302);
            this.PivotGroupingWindowCancelButton.Name = "PivotGroupingWindowCancelButton";
            this.PivotGroupingWindowCancelButton.Size = new System.Drawing.Size(75, 23);
            this.PivotGroupingWindowCancelButton.TabIndex = 2;
            this.PivotGroupingWindowCancelButton.Text = "Cancel";
            this.PivotGroupingWindowCancelButton.UseVisualStyleBackColor = true;
            this.PivotGroupingWindowCancelButton.Click += new System.EventHandler(this.PivotGroupingWindowCancelButton_Click);
            // 
            // GroupsGroupBox
            // 
            this.GroupsGroupBox.Controls.Add(this.ShowRegexEditFieldButton);
            this.GroupsGroupBox.Controls.Add(this.GroupItemsCheckBox);
            this.GroupsGroupBox.Controls.Add(this.GroupItemsListView);
            this.GroupsGroupBox.Controls.Add(this.GroupNamesDataGridView);
            this.GroupsGroupBox.Location = new System.Drawing.Point(-2, 3);
            this.GroupsGroupBox.Name = "GroupsGroupBox";
            this.GroupsGroupBox.Size = new System.Drawing.Size(340, 293);
            this.GroupsGroupBox.TabIndex = 7;
            this.GroupsGroupBox.TabStop = false;
            this.GroupsGroupBox.Text = "Select grouping type:";
            // 
            // ShowRegexEditFieldButton
            // 
            this.ShowRegexEditFieldButton.Location = new System.Drawing.Point(306, 20);
            this.ShowRegexEditFieldButton.Name = "ShowRegexEditFieldButton";
            this.ShowRegexEditFieldButton.Size = new System.Drawing.Size(27, 23);
            this.ShowRegexEditFieldButton.TabIndex = 10;
            this.ShowRegexEditFieldButton.Text = "R";
            this.ShowRegexEditFieldButton.UseVisualStyleBackColor = true;
            this.ShowRegexEditFieldButton.Click += new System.EventHandler(this.ShowRegexEditFieldButton_Click);
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
            this.GroupItemsListView.Location = new System.Drawing.Point(154, 19);
            this.GroupItemsListView.MultiSelect = false;
            this.GroupItemsListView.Name = "GroupItemsListView";
            this.GroupItemsListView.Size = new System.Drawing.Size(180, 268);
            this.GroupItemsListView.TabIndex = 9;
            this.GroupItemsListView.UseCompatibleStateImageBehavior = false;
            this.GroupItemsListView.View = System.Windows.Forms.View.Details;
            this.GroupItemsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.GroupItemsListView_ItemChecked);
            // 
            // GroupNamesColumnHeader
            // 
            this.GroupNamesColumnHeader.Text = "       Group Names";
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
            this.GroupNamesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.GroupNamesDataGridView.MultiSelect = false;
            this.GroupNamesDataGridView.Name = "GroupNamesDataGridView";
            this.GroupNamesDataGridView.ShowCellErrors = false;
            this.GroupNamesDataGridView.ShowCellToolTips = false;
            this.GroupNamesDataGridView.ShowRowErrors = false;
            this.GroupNamesDataGridView.Size = new System.Drawing.Size(150, 268);
            this.GroupNamesDataGridView.TabIndex = 8;
            this.GroupNamesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GroupNamesDataGridView_CellMouseClick);
            this.GroupNamesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupNamesDataGridView_CellValueChanged);
            this.GroupNamesDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GroupNamesDataGridView_RowsRemoved);
            // 
            // GroupNamesColumn
            // 
            this.GroupNamesColumn.HeaderText = "Group Names";
            this.GroupNamesColumn.Name = "GroupNamesColumn";
            this.GroupNamesColumn.Width = 105;
            // 
            // GroupItemsCheckBox
            // 
            this.GroupItemsCheckBox.AutoSize = true;
            this.GroupItemsCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.GroupItemsCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupItemsCheckBox.Location = new System.Drawing.Point(159, 25);
            this.GroupItemsCheckBox.Name = "GroupItemsCheckBox";
            this.GroupItemsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.GroupItemsCheckBox.TabIndex = 11;
            this.GroupItemsCheckBox.UseVisualStyleBackColor = false;
            this.GroupItemsCheckBox.Click += new System.EventHandler(this.GroupItemsCheckBox_Click);
            // 
            // PivotGrouingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 331);
            this.Controls.Add(this.GroupsGroupBox);
            this.Controls.Add(this.PivotGroupingWindowCancelButton);
            this.Controls.Add(this.PivotGroupingWindowOkButton);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PivotGrouingWindow";
            this.Text = "PivotGrouingWindow";
            this.GroupsGroupBox.ResumeLayout(false);
            this.GroupsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PivotGroupingWindowOkButton;
        private System.Windows.Forms.Button PivotGroupingWindowCancelButton;
        private System.Windows.Forms.GroupBox GroupsGroupBox;
        private System.Windows.Forms.DataGridView GroupNamesDataGridView;
        private System.Windows.Forms.ListView GroupItemsListView;
        private System.Windows.Forms.ColumnHeader GroupNamesColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNamesColumn;
        private System.Windows.Forms.Button ShowRegexEditFieldButton;
        private System.Windows.Forms.CheckBox GroupItemsCheckBox;
    }
}