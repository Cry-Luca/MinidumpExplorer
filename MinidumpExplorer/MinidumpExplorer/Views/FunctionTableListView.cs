using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbgHelp.MinidumpFiles;
using MinidumpExplorer.Controls;

namespace MinidumpExplorer.Views
{
    public partial class FunctionTableListView : BaseViewControl
    {
        public FunctionTableListView()
        {
            InitializeComponent();
        }

        public FunctionTableListView(MiniDumpFunctionTableDescriptor[] descriptors)
            : this()
        {
            foreach (MiniDumpFunctionTableDescriptor descriptor in descriptors)
            {
                ListViewItem newItem = new ListViewItem(descriptor.BaseAddress.ToString());
                newItem.SubItems.Add(descriptor.MinimumAddress.ToString());
                newItem.SubItems.Add(descriptor.MaximumAddress.ToString());
                newItem.SubItems.Add(descriptor.EntryCount.ToString());
                newItem.SubItems.Add(descriptor.SizeOfAlignPad.ToString());

                this.listView1.Items.Add(newItem);
            }
        }
    }
}
