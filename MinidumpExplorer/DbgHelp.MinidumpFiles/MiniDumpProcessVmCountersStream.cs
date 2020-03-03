using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbgHelp.MinidumpFiles
{
    public class MiniDumpProcessVmCountersStream
    {
        private Native.MINIDUMP_PROCESS_VM_COUNTERS_1 _vmCounters1;
        private Native.MINIDUMP_PROCESS_VM_COUNTERS_2 _vmCounters2;
        private bool _isCounterType2;

        internal MiniDumpProcessVmCountersStream()
        {
            _vmCounters2 = new Native.MINIDUMP_PROCESS_VM_COUNTERS_2();
            _isCounterType2 = true;
        }

        internal MiniDumpProcessVmCountersStream(Native.MINIDUMP_PROCESS_VM_COUNTERS_1 vmCounters1)
        {
            _vmCounters1 = vmCounters1;
            _isCounterType2 = false;
        }

        internal MiniDumpProcessVmCountersStream(Native.MINIDUMP_PROCESS_VM_COUNTERS_2 vmCounters2)
        {
            _vmCounters2 = vmCounters2;
            _isCounterType2 = true;
        }

        public ushort Revision
        {
            get { if (_isCounterType2) return _vmCounters2.Revision; else return _vmCounters1.Revision; }
        }

        public ushort Flags
        {
            get { if (_isCounterType2) return _vmCounters2.Flags; else return 0; }
        }

        public UInt32 PageFaultCount
        {
            get { if (_isCounterType2) return _vmCounters2.PageFaultCount; else return _vmCounters1.PageFaultCount; }
        }
        
        public UInt64 PeakWorkingSetSize
        {
            get { if (_isCounterType2) return _vmCounters2.PeakWorkingSetSize; else return _vmCounters1.PeakWorkingSetSize; }
        }

        public UInt64 WorkingSetSize
        {
            get { if (_isCounterType2) return _vmCounters2.WorkingSetSize; else return _vmCounters1.WorkingSetSize; }
        }

        public UInt64 QuotaPeakPagedPoolUsage
        {
            get { if (_isCounterType2) return _vmCounters2.QuotaPeakPagedPoolUsage; else return _vmCounters1.QuotaPeakPagedPoolUsage; }
        }

        public UInt64 QuotaPagedPoolUsage
        {
            get { if (_isCounterType2) return _vmCounters2.QuotaPagedPoolUsage; else return _vmCounters1.QuotaPagedPoolUsage; }
        }

        public UInt64 QuotaPeakNonPagedPoolUsage
        {
            get { if (_isCounterType2) return _vmCounters2.QuotaPeakNonPagedPoolUsage; else return _vmCounters1.QuotaPeakNonPagedPoolUsage; }
        }

        public UInt64 QuotaNonPagedPoolUsage
        {
            get { if (_isCounterType2) return _vmCounters2.QuotaNonPagedPoolUsage; else return _vmCounters1.QuotaNonPagedPoolUsage; }
        }

        public UInt64 PagefileUsage
        {
            get { if (_isCounterType2) return _vmCounters2.PagefileUsage; else return _vmCounters1.PagefileUsage; }
        }

        public UInt64 PeakPagefileUsage
        {
            get { if (_isCounterType2) return _vmCounters2.PeakPagefileUsage; else return _vmCounters1.PeakPagefileUsage; }
        }

        public UInt64 PrivateUsage
        {
            get { if (_isCounterType2) return _vmCounters2.PrivateUsage; else return _vmCounters1.PrivateUsage; }
        }

        public UInt64 PeakVirtualSize
        {
            get { if (_isCounterType2) return _vmCounters2.PeakVirtualSize; else return 0; }
        }

        public UInt64 VirtualSize
        {
            get { if (_isCounterType2) return _vmCounters2.VirtualSize; else return 0; }
        }

        public UInt64 PrivateWorkingSetSize
        {
            get { if (_isCounterType2) return _vmCounters2.PrivateWorkingSetSize; else return 0; }
        }

        public UInt64 SharedCommitUsage
        {
            get { if (_isCounterType2) return _vmCounters2.SharedCommitUsage; else return 0; }
        }

        public UInt64 JobSharedCommitUsage
        {
            get { if (_isCounterType2) return _vmCounters2.JobSharedCommitUsage; else return 0; }
        }

        public UInt64 JobPrivateCommitUsage
        {
            get { if (_isCounterType2) return _vmCounters2.JobPrivateCommitUsage; else return 0; }
        }

        public UInt64 JobPeakPrivateCommitUsage
        {
            get { if (_isCounterType2) return _vmCounters2.JobPeakPrivateCommitUsage; else return 0; }
        }

        public UInt64 JobPrivateCommitLimit
        {
            get { if (_isCounterType2) return _vmCounters2.JobPrivateCommitLimit; else return 0; }
        }

        public UInt64 JobTotalCommitLimit
        {
            get { if (_isCounterType2) return _vmCounters2.JobTotalCommitLimit; else return 0; }
        }
    }
}
