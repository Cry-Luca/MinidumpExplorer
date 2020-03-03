using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbgHelp.MinidumpFiles;

namespace MinidumpExplorer.Views
{
    public partial class ProcessVmCountersView : BaseViewControl
    {
        private MiniDumpProcessVmCountersStream _vmCounters;

        public ProcessVmCountersView()
        {
            InitializeComponent();
        }

        public ProcessVmCountersView(MiniDumpProcessVmCountersStream vmCounters)
            : this()
        {
            _vmCounters = vmCounters;

            AddGroupedNode("Revision", vmCounters.Revision.ToString());
            AddGroupedNode("PageFaultCount", vmCounters.PageFaultCount.ToString("N0"));
            AddGroupedNode("PeakWorkingSetSize", BytesPretty(vmCounters.PeakWorkingSetSize));
            AddGroupedNode("WorkingSetSize", BytesPretty(vmCounters.WorkingSetSize));
            AddGroupedNode("QuotaPeakPagedPoolUsage", BytesPretty(vmCounters.QuotaPeakPagedPoolUsage));
            AddGroupedNode("QuotaPagedPoolUsage", BytesPretty(vmCounters.QuotaPagedPoolUsage));
            AddGroupedNode("QuotaPeakNonPagedPoolUsage", BytesPretty(vmCounters.QuotaPeakNonPagedPoolUsage));
            AddGroupedNode("QuotaNonPagedPoolUsage", BytesPretty(vmCounters.QuotaNonPagedPoolUsage));
            AddGroupedNode("PagefileUsage", BytesPretty(vmCounters.PagefileUsage));
            AddGroupedNode("PeakPagefileUsage", BytesPretty(vmCounters.PeakPagefileUsage));
            AddGroupedNode("PrivateUsage", BytesPretty(vmCounters.PrivateUsage));

            if (vmCounters.Revision > 1)
            {
                AddGroupedNode("Flags", vmCounters.Flags.ToString());
                AddGroupedNode("VirtualSize", vmCounters.VirtualSize.ToString());
                AddGroupedNode("PrivateWorkingSetSize", vmCounters.PrivateWorkingSetSize.ToString());
                AddGroupedNode("SharedCommitUsage", vmCounters.SharedCommitUsage.ToString());
                AddGroupedNode("JobSharedCommitUsage", vmCounters.JobSharedCommitUsage.ToString());
                AddGroupedNode("JobPrivateCommitUsage", vmCounters.JobPrivateCommitUsage.ToString());
                AddGroupedNode("JobPeakPrivateCommitUsage", vmCounters.JobPeakPrivateCommitUsage.ToString());
                AddGroupedNode("JobPrivateCommitLimit", vmCounters.JobPrivateCommitLimit.ToString());
                AddGroupedNode("JobTotalCommitLimit", vmCounters.JobTotalCommitLimit.ToString());
            }
        }

        private string BytesPretty(UInt64 bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            return String.Format("{0:0.#} {1}", len, sizes[order]);
        }

        private void AddGroupedNode(string description, string value)
        {
            ListViewItem newItem;
            newItem = new ListViewItem(description);
            newItem.SubItems.Add(value);
            this.listView1.Items.Add(newItem);
        }
    }
}
