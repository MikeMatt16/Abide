﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Abide.Updater.Compression
{
    /// <summary>
    /// Represents an Abide Update Package file header.
    /// </summary>
    internal struct HEADER
    {
        /// <summary>
        /// Gets the runtime size of the <see cref="HEADER"/> structure in bytes.
        /// </summary>
        public static readonly int RuntimeSize = Marshal.SizeOf(typeof(HEADER));

        /// <summary>
        /// Gets or sets the four-character code string for the package.
        /// </summary>
        public string AupTag
        {
            get { return aupTag; }
            set { aupTag = value; }
        }
        /// <summary>
        /// Gets or sets the version of the package.
        /// </summary>
        public AupVersion Version
        {
            get { return (AupVersion)version; }
            set { version = (uint)value; }
        }
        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        public uint Length
        {
            get { return length; }
            set { length = value; }
        }
        /// <summary>
        /// Gets or sets the offset of the start of the data.
        /// </summary>
        public uint DataOffset
        {
            get { return dataOffset; }
            set { dataOffset = value; }
        }
        /// <summary>
        /// Gets or sets the offset of the file names index.
        /// </summary>
        public uint FileIndexOffset
        {
            get { return fileIndexOffset; }
            set { fileIndexOffset = value; }
        }
        /// <summary>
        /// Gets or sets the offset of the file names.
        /// </summary>
        public uint FileNamesOffset
        {
            get { return fileNamesOffset; }
            set { fileNamesOffset = value; }
        }
        /// <summary>
        /// Gets or sets the number of file entries within the file.
        /// </summary>
        public uint EntryCount
        {
            get { return entryCount; }
            set { entryCount = value; }
        }

        private FOURCC aupTag;
        private uint version;
        private uint length;
        private uint dataOffset;
        private uint fileIndexOffset;
        private uint fileNamesOffset;
        private uint entryCount;
        private uint reserved0;
    }

    /// <summary>
    /// Represents an Abide Update Package File Entry object.
    /// </summary>
    internal struct ENTRY
    {
        /// <summary>
        /// Gets the runtime size of the <see cref="ENTRY"/> structure in bytes.
        /// </summary>
        public static readonly int RuntimeSize = Marshal.SizeOf(typeof(ENTRY));

        /// <summary>
        /// Gets or sets the length of the data.
        /// </summary>
        public uint Length
        {
            get { return length; }
            set { length = value; }
        }
        /// <summary>
        /// Gets or sets the offset of the data.
        /// </summary>
        public uint Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        /// <summary>
        /// Gets or sets the date and time the file entry was created.
        /// </summary>
        public DateTime Created
        {
            get { return new DateTime(created); }
            set { created = value.Ticks; }
        }
        /// <summary>
        /// Gets or sets the date and time the file entry was last modified.
        /// </summary>
        public DateTime Modified
        {
            get { return new DateTime(modified); }
            set { modified = value.Ticks; }
        }
        /// <summary>
        /// Gets or sets the date and time the file entry was last accessed.
        /// </summary>
        public DateTime Accessed
        {
            get { return new DateTime(accessed); }
            set { accessed = value.Ticks; }
        }

        private uint length;
        private uint offset;
        private long created;
        private long modified;
        private long accessed;
    }

    /// <summary>
    /// Represents a four-character code.
    /// </summary>
    internal struct FOURCC : IComparable<string>, IEquatable<string>, IEquatable<FOURCC>, IComparable<FOURCC>
    {
        /// <summary>
        /// Represents the runtime size of the <see cref="FOURCC"/> structure in bytes.
        /// </summary>
        public static readonly int RuntimeSize = Marshal.SizeOf(typeof(FOURCC));
        /// <summary>
        /// Represents a zero-value <see cref="FOURCC"/> structure.
        /// </summary>
        public static readonly FOURCC Zero = 0;

        /// <summary>
        /// Gets or sets the four-character code string.
        /// </summary>
        public string String
        {
            get { return new string(new char[] { (char)c0, (char)c1, (char)c2, (char)c3 }); }
            set
            {
                //Get FourCC
                char[] fourCc = new char[4];
                for (int i = 0; i < Math.Min(4, value.Length); i++)
                    fourCc[i] = value[i];

                //Set
                c0 = (byte)fourCc[0];
                c1 = (byte)fourCc[1];
                c2 = (byte)fourCc[2];
                c3 = (byte)fourCc[3];
            }
        }
        /// <summary>
        /// Gets or sets the four-character code as an unsigned 32-bit integer.
        /// </summary>
        public uint Dword
        {
            get
            {
                byte[] buffer = new byte[] { c0, c1, c2, c3 };
                return BitConverter.ToUInt32(buffer, 0);
            }
            set
            {
                //Get Buffer
                byte[] buffer = BitConverter.GetBytes(value);

                //Set
                c0 = buffer[0];
                c1 = buffer[1];
                c2 = buffer[2];
                c3 = buffer[3];
            }
        }

        private byte c0, c1, c2, c3;

        /// <summary>
        /// Initializes a new <see cref="FOURCC"/> structure using the supplied unsigned integer.
        /// </summary>
        /// <param name="dword">The unsigned 32-bit integer to set the four-cc as.</param>
        public FOURCC(uint dword)
        {
            //Get Buffer
            byte[] buffer = BitConverter.GetBytes(dword);

            //Set
            c0 = buffer[0];
            c1 = buffer[1];
            c2 = buffer[2];
            c3 = buffer[3];
        }
        /// <summary>
        /// Initializes a new <see cref="FOURCC"/> structure using the supplied four-character code string.
        /// </summary>
        /// <param name="fourcc">The four-cc string to set as.</param>
        public FOURCC(string fourcc)
        {
            //Get FourCC
            char[] fourCc = new char[4];
            for (int i = 0; i < Math.Min(4, fourcc.Length); i++)
                fourCc[i] = fourcc[i];

            //Set
            c0 = (byte)fourCc[0];
            c1 = (byte)fourCc[1];
            c2 = (byte)fourCc[2];
            c3 = (byte)fourCc[3];
        }
        /// <summary>
        /// Converts the <see cref="FOURCC"/> structure to its string representation.
        /// </summary>
        /// <returns>A string containing the four-character code string.</returns>
        public override string ToString()
        {
            return String;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(string other)
        {
            return String.CompareTo(other);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(string other)
        {
            return String.Equals(other);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(FOURCC other)
        {
            return Dword.Equals(other.Dword);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(FOURCC other)
        {
            return Dword.CompareTo(other.Dword);
        }

        public static implicit operator FOURCC(string fourcc)
        {
            return new FOURCC(fourcc);
        }
        public static implicit operator string(FOURCC fourcc)
        {
            return fourcc.String;
        }
        public static implicit operator FOURCC(uint dword)
        {
            return new FOURCC(dword);
        }
        public static implicit operator uint(FOURCC fourcc)
        {
            return fourcc.Dword;
        }
    }

    /// <summary>
    /// Represents an enumeration containing valid Abide Update Package versions.
    /// </summary>
    public enum AupVersion : uint
    {
        /// <summary>
        /// Represents Abide AddOn Package Version 1.0.
        /// </summary>
        Version10 = 0,
    }
}
