namespace MinidumpExplorer.Views
{
    partial class FunctionTableListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new MinidumpExplorer.Controls.MinidumpListView();
            this.BaseAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinimumAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaximumAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeOfAlignPadHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BaseAddressHeader,
            this.MinimumAddressHeader,
            this.MaximumAddressHeader,
            this.EntryCountHeader,
            this.SizeOfAlignPadHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 432);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BaseAddressHeader
            // 
            this.BaseAddressHeader.Text = "Base Address";
            this.BaseAddressHeader.Width = 111;
            // 
            // MinimumAddressHeader
            // 
            this.MinimumAddressHeader.Text = "Min Address";
            this.MinimumAddressHeader.Width = 150;
            // 
            // MaximumAddressHeader
            // 
            this.MaximumAddressHeader.Text = "Max Address";
            this.MaximumAddressHeader.Width = 167;
            // 
            // EntryCountHeader
            // 
            this.EntryCountHeader.Text = "Count";
            this.EntryCountHeader.Width = 137;
            // 
            // SizeOfAlignPadHeader
            // 
            this.SizeOfAlignPadHeader.Text = "SizeOf Align";
            this.SizeOfAlignPadHeader.Width = 138;
            // 
            // FunctionTableListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "FunctionTableListView";
            this.Size = new System.Drawing.Size(805, 432);
            this.ResumeLayout(false);

        }

        #endregion

        private MinidumpExplorer.Controls.MinidumpListView listView1;
        private System.Windows.Forms.ColumnHeader BaseAddressHeader;
        private System.Windows.Forms.ColumnHeader MinimumAddressHeader;
        private System.Windows.Forms.ColumnHeader MaximumAddressHeader;
        private System.Windows.Forms.ColumnHeader EntryCountHeader;
        private System.Windows.Forms.ColumnHeader SizeOfAlignPadHeader;
    }
}
