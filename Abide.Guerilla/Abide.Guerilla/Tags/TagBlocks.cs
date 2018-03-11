﻿using Abide.HaloLibrary;
using Abide.HaloLibrary.Halo2Map;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using static Abide.HaloLibrary.Halo2Map.MapFile;

namespace Abide.Guerilla.Tags
{
    /// <summary>
    /// Represents an Abide tag block.
    /// </summary>
    public abstract class AbideTagBlock : IDataStructure, IWritable, IReadable
    {
        /// <summary>
        /// Gets or sets the string list.
        /// </summary>
        public StringList StringList { get => stringList; set => stringList = value; }
        /// <summary>
        /// Gets or sets the tag list.
        /// </summary>
        public IndexEntryList TagList { get => indexEntryList; set => indexEntryList = value; }

        private StringList stringList = new StringList();
        private IndexEntryList indexEntryList = new IndexEntryList();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbideTagBlock"/> class.
        /// </summary>
        public AbideTagBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbideTagBlock"/> class using the supplied string list and index entry list.
        /// </summary>
        /// <param name="stringList">The list of strings.</param>
        /// <param name="indexEntryList">The list of index entries.</param>
        public AbideTagBlock(StringList stringList, IndexEntryList indexEntryList)
        {
            this.stringList = stringList;
            this.indexEntryList = indexEntryList;
        }

        /// <summary>
        /// Gets the size of the tag block in bytes.
        /// </summary>
        public abstract int Size { get; }
        /// <summary>
        /// Initializes the tag block.
        /// </summary>
        public abstract void Initialize();
        /// <summary>
        /// Reads the tag block from the base stream of the supplied <see cref="BinaryReader"/>.
        /// </summary>
        /// <param name="reader">The binary reader whose underlying stream is to have the data structure read from.</param>
        public abstract void Read(BinaryReader reader);
        /// <summary>
        /// Writes the tag block to the base stream of the supplied <see cref="BinaryWriter"/>.
        /// </summary>
        /// <param name="writer">The binary writer whose underlying stream is to have the data structure written to.</param>
        public abstract void Write(BinaryWriter writer);
        /// <summary>
        /// Retrieves a string representation of this tag block.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            //Prepare
            string name = base.ToString();
            FieldAttribute fieldAttribute = null;

            //Loop
            foreach (var fieldInfo in GetType().GetFields())
            {
                //Get field attribute
                fieldAttribute = fieldInfo.GetCustomAttribute<FieldAttribute>();

                //Check
                if (fieldAttribute != null)
                {
                    //Check if is block name
                    if (fieldAttribute.Name.Contains("^"))
                    {
                        //Get value string
                        object value = fieldInfo.GetValue(this);
                        name = value.ToString();

                        //Check
                        if (fieldAttribute.Type == typeof(Types.TagReference) && indexEntryList.ContainsID(((Types.TagReference)value).Id))
                            name = $"{indexEntryList[((Types.TagReference)value).Id].Filename}.{((Types.TagReference)value).Tag}";
                        else if (fieldAttribute.Type == typeof(StringId) && stringList.Count > ((StringId)value).Index)
                            name = stringList[((StringId)value).Index];
                        else if (fieldAttribute.Type.IsEnum) name = Enum.GetName(fieldAttribute.Type, value);
                        break;
                    }
                }
            }

            //Return
            return name;
        }

        /// <summary>
        /// Creates a new instance of the specified tag block type.
        /// </summary>
        /// <typeparam name="T">The tag block type.</typeparam>
        /// <param name="stringList">The list of strings in a Halo 2 map.</param>
        /// <param name="indexEntryList">The list of index entries in a Halo 2 map.</param>
        /// <returns>A new instance of <typeparamref name="T"/>.</returns>
        public static T Instantiate<T>(StringList stringList, IndexEntryList indexEntryList) where T : AbideTagBlock, new()
        {
            //Create
            T tagBlock = new T
            {
                stringList = stringList,
                indexEntryList = indexEntryList
            };

            //Initialize
            tagBlock.Initialize();

            //Return
            return tagBlock;
        }
        /// <summary>
        /// Creates a new instance of the specified tag block type.
        /// </summary>
        /// <typeparam name="T">The tag block type.</typeparam>
        /// <param name="mapFile">The Halo 2 map file.</param>
        /// <returns>A new instance of <typeparamref name="T"/>.</returns>
        public static T Instantiate<T>(MapFile mapFile) where T : AbideTagBlock, new()
        {
            //Create
            T tagBlock = new T
            {
                stringList = mapFile.Strings,
                indexEntryList = mapFile.IndexEntries
            };

            //Initialize
            tagBlock.Initialize();

            //Return
            return tagBlock;
        }
    }

    /// <summary>
    /// Represents a base block list.
    /// </summary>
    /// <typeparam name="T">The block type.</typeparam>
    public abstract class BlockList<T> : ICollection<T>, IEnumerable<T>
    {
        /// <summary>
        /// Gets and returns the block at the given index within the list.
        /// </summary>
        /// <param name="index">The zero-based index of the block.</param>
        /// <returns>A block.</returns>
        public T this[int index]
        {
            get { if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index)); return list[index]; }
        }
        /// <summary>
        /// Determines whether the <see cref="BlockList{T}"/> is full.
        /// </summary>
        public bool IsFull
        {
            get { return list.Count == maximumElementCount; }
        }
        /// <summary>
        /// Gets the number of elements within the <see cref="BlockList{T}"/>.
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }
        /// <summary>
        /// Gets the maximum number of elements allowed within the <see cref="BlockList{T}"/>.
        /// </summary>
        public int MaximumElementCount
        {
            get { return maximumElementCount; }
        }

        private readonly List<T> list = new List<T>();
        private readonly int maximumElementCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockList{T}"/> class using the supplied maximum count.
        /// </summary>
        /// <param name="maximumElementCount">The maximum number of elements within the list.</param>
        public BlockList(int maximumElementCount)
        {
            this.maximumElementCount = maximumElementCount;
        }
        /// <summary>
        /// Attemtpts to add a block to the <see cref="BlockList{T}"/>.
        /// </summary>
        /// <param name="block"></param>
        public void Add(T block)
        {
            if (list.Count < maximumElementCount)
                list.Add(block);
        }
        /// <summary>
        /// Attemtpts to add a block to the <see cref="BlockList{T}"/>.
        /// </summary>
        /// <param name="block">The block to add.</param>
        /// <param name="added">true if the block was added; otherwise false.</param>
        public void Add(T block, out bool added)
        {
            if (list.Count < maximumElementCount)
            { list.Add(block); added = true; }
            else added = false;
        }
        /// <summary>
        /// Clears the <see cref="BlockList{T}"/>.
        /// </summary>
        public void Clear()
        {
            list.Clear();
        }
        /// <summary>
        /// Determines whether a block is in the <see cref="BlockList{T}"/>.
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        public bool Contains(T block)
        {
            return list.Contains(block);
        }
        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="BlockList{T}"/>.
        /// </summary>
        /// <returns>An enumerator.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        /// <summary>
        /// Removes the first occurance of the specified block from the <see cref="BlockList{T}"/>.
        /// </summary>
        /// <param name="block">The block to remove.</param>
        /// <returns>true if a block was removed; otherwise false.</returns>
        public bool Remove(T block)
        {
            return list.Remove(block);
        }
        /// <summary>
        /// Returns a string representation of this <see cref="BlockList{T}"/>.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return $"Count: {list.Count}";
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }
        bool ICollection<T>.IsReadOnly => false;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    /// <summary>
    /// Represents a data list.
    /// </summary>
    public sealed class DataList : BlockList<byte>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataList"/> class.
        /// </summary>
        /// <param name="maximumElementCount">The maximum number of bytes within the list.</param>
        public DataList(int maximumElementCount) : base(maximumElementCount) { }
        /// <summary>
        /// Reads the data list from the current stream using the supplied binary reader.
        /// </summary>
        /// <param name="reader">The binary reader.</param>
        /// <param name="tagBlock">The tag block.</param>
        public void Read(BinaryReader reader, TagBlock tagBlock)
        {
            //Store position
            long position = reader.BaseStream.Position;

            //Clear
            Clear();

            //Check
            if(tagBlock.Count > 0 && tagBlock.Offset > 0)
            {
                //Goto
                reader.BaseStream.Seek(tagBlock.Offset, SeekOrigin.Begin);

                //Read
                for (int i = 0; i < tagBlock.Count; i++)
                    Add(reader.ReadByte());
            }

            //Goto
            reader.BaseStream.Seek(position, SeekOrigin.Begin);
        }
    }

    /// <summary>
    /// Represents a tag block list.
    /// </summary>
    /// <typeparam name="T">The <see cref="AbideTagBlock"/> type.</typeparam>
    public sealed class TagBlockList<T> : BlockList<T> where T: AbideTagBlock, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagBlockList{T}"/>.
        /// </summary>
        /// <param name="maximumElementCount">The maximum number of blocks within the list.</param>
        public TagBlockList(int maximumElementCount) : base(maximumElementCount) { }
        /// <summary>
        /// Reads the tag block list from the current stream using the supplied binary reader.
        /// </summary>
        /// <param name="reader">The binary reader.</param>
        /// <param name="tagBlock">The tag block.</param>
        public void Read(BinaryReader reader, TagBlock tagBlock)
        {
            //Store position
            long position = reader.BaseStream.Position;

            //Clear
            Clear();

            //Check
            if (tagBlock.Count > 0 && tagBlock.Offset > 0)
            {
                //Goto
                reader.BaseStream.Seek(tagBlock.Offset, SeekOrigin.Begin);

                //Read
                for (int i = 0; i < tagBlock.Count; i++)
                {
                    //Create
                    T block = new T();
                    block.Initialize();

                    //Read
                    block.Read(reader);

                    //Add
                    Add(block);
                }
            }

            //Goto
            reader.BaseStream.Seek(position, SeekOrigin.Begin);
        }
        /// <summary>
        /// Attempts to create a new block and adds it to the list.
        /// </summary>
        /// <returns>true if the block was added to the list; otherwise false.</returns>
        public bool CreateNew()
        {
            //Create instance
            T block = new T();

            //Initialize
            block.Initialize();

            //Add?
            Add(block, out bool added);

            //Return
            return added;
        }
    }
}