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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.btnPivotGroupingWindowOk = new System.Windows.Forms.Button();
            this.btnPivotGroupingWindowCancel = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGroupFilter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Automatically group items";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Manualy group items";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select grouping type:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGroupName,
            this.chGroupFilter});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(14, 65);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 222);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 100;
            // 
            // chGroupName
            // 
            this.chGroupName.Text = "Group Name";
            this.chGroupName.Width = 148;
            // 
            // chGroupFilter
            // 
            this.chGroupFilter.Text = "Group Filter";
            this.chGroupFilter.Width = 164;
            // 
            // PivotGrouingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPivotGroupingWindowCancel);
            this.Controls.Add(this.btnPivotGroupingWindowOk);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PivotGrouingWindow";
            this.Text = "PivotGrouingWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPivotGroupingWindowOk;
        private System.Windows.Forms.Button btnPivotGroupingWindowCancel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chGroupName;
        private System.Windows.Forms.ColumnHeader chGroupFilter;
    }
}