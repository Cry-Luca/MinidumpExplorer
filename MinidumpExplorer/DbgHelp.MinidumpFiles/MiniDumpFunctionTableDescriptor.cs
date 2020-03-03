using DbgHelp.MinidumpFiles.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbgHelp.MinidumpFiles
{
    /// <summary>
    /// Describes function table information.
    /// </summary>
    public class MiniDumpFunctionTableDescriptor
    {
        private MINIDUMP_FUNCTION_TABLE_DESCRIPTOR _functionTableDescriptor;

        internal MiniDumpFunctionTableDescriptor(MINIDUMP_FUNCTION_TABLE_DESCRIPTOR descriptor)
        {
            _functionTableDescriptor = descriptor;
        }

        /// <summary>
        /// The minimum address of functions described by the table.
        /// </summary>
        public UInt64 MinimumAddress
        {
            get { return _functionTableDescriptor.MinimumAddress; }
        }

        /// <summary>
        /// The maximum address of functions described by the table.
        /// </summary>
        public UInt64 MaximumAddress
        {
            get { return _functionTableDescriptor.MaximumAddress; }
        }

        /// <summary>
        /// The base address to use when computing full virtual addresses from relative virtual addresses in function entries.
        /// </summary>
        public UInt64 BaseAddress
        {
            get { return _functionTableDescriptor.BaseAddress; }
        }

        /// <summary>
        /// The number of entries in the function table.
        /// </summary>
        public UInt32 EntryCount
        {
            get { return _functionTableDescriptor.EntryCount; }
        }

        /// <summary>
        /// The size of alignment padding that follows the function entry data, in bytes. 
        /// The function entry data in the stream is guaranteed to be aligned appropriately for access to the data members. 
        /// If a minidump is directly mapped in memory, it is always possible to directly reference structure members in the stream.
        /// </summary>
        public UInt32 SizeOfAlignPad
        {
            get { return _functionTableDescriptor.SizeOfAlignPad; }
        }
    }
}
