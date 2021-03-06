﻿using Abide.HaloLibrary.Halo2Map;
using Abide.HaloLibrary.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Abide.HaloLibrary.Halo2.Retail
{
    public sealed class HaloMapFile
    {
        private Dictionary<TagId, HaloTag> tagList = new Dictionary<TagId, HaloTag>();
        private Header header = new Header();
        private Index index = new Index();
        private string[] strings = null;
        private uint tagDataAddressTranslator;
        private uint[] bspTagDataAddressTranslators;

        public string FileName { get; set; } = string.Empty;
        public string Name
        {
            get => header.Name;
            set => header.Name = value;
        }
        public string ScenarioTagName
        {
            get => header.ScenarioPath;
            set => header.ScenarioPath = value;
        }
        public TagId ScenarioTagId
        {
            get => index.ScenarioId;
            set => index.ScenarioId = value;
        }
        public TagId GlobalsTagId
        {
            get => index.GlobalsId;
            set => index.GlobalsId = value;
        }
        public uint Checksum
        {
            get => header.Checksum;
            set => header.Checksum = value;
        }
        public int IndexOffset
        {
            get => (int)header.IndexOffset;
        }
        public int IndexLength
        {
            get => (int)header.IndexLength;
        }
        public int TagDataLength
        {
            get => (int)header.TagDataLength;
        }
        public int TotalDataLength
        {
            get => (int)header.MapDataLength;
        }
        public int TagCount
        {
            get => tagList.Count;
        }

        public HaloMapFile() { }
        public BinaryReader OpenRead()
        {
            if (File.Exists(FileName))
                return new BinaryReader(File.OpenRead(FileName), Encoding.UTF8, false);
            else throw new FileNotFoundException("Unable to open specified map file for reading.", FileName ?? "null");
        }
        public BinaryWriter OpenWrite()
        {
            if (File.Exists(FileName))
                return new BinaryWriter(File.OpenWrite(FileName), Encoding.UTF8, false);
            else throw new FileNotFoundException("Unable to open specified map file for writing.", FileName ?? "null");
        }
        public TagData ReadTagData(HaloTag tag)
        {
            if (tag == null) return null;
            TagData tagData = new TagData(tag);

            if (tag.BaseAddress == tagDataAddressTranslator)
            {
                long bspLength = header.MapDataLength - (header.TagDataLength + header.IndexLength + Index.Length);
                tagData.MemoryAddress = index.TagsAddress + header.IndexLength + bspLength;

                using (var reader = OpenRead())
                {
                    reader.BaseStream.Seek(header.IndexOffset + header.IndexLength, SeekOrigin.Begin);
                    tagData.Stream = new VirtualStream(tagData.MemoryAddress, reader.ReadBytes((int)header.TagDataLength));
                    return tagData;
                }
            }
            else if (bspTagDataAddressTranslators.Any(t => tag.BaseAddress == t))
            {
                var scenario = GetTagById(ScenarioTagId);
                using (var data = ReadTagData(scenario))
                using (BinaryReader tagReader = data.Stream.CreateReader())
                {
                    tagReader.BaseStream.Seek(scenario.MemoryAddress + 528, SeekOrigin.Begin);
                    TagBlock structureBsps = tagReader.ReadTagBlock();

                    for (int i = 0; i < structureBsps.Count; i++)
                    {
                        tagReader.BaseStream.Seek(structureBsps.Offset, SeekOrigin.Begin);
                        uint structureBspOffset = tagReader.ReadUInt32();
                        uint structureBspLength = tagReader.ReadUInt32();
                        uint structureBspMemoryAddress = tagReader.ReadUInt32();
                        tagReader.ReadInt32();
                        TagFourCc sbspTag = tagReader.Read<TagFourCc>();
                        TagId sbspId = tagReader.ReadTagId();
                        TagFourCc ltmpTag = tagReader.Read<TagFourCc>();
                        TagId ltmpId = tagReader.ReadTagId();

                        if (sbspId == tag.Id || ltmpId == tag.Id)
                        {
                            tagData.MemoryAddress = structureBspMemoryAddress;

                            using (var reader = OpenRead())
                            {
                                reader.BaseStream.Seek(structureBspOffset, SeekOrigin.Begin);
                                tagData.Stream = new VirtualStream(structureBspMemoryAddress, reader.ReadBytes((int)structureBspLength));
                                return tagData;
                            }
                        }
                    }
                }
            }

            return null;
        }
        public void OverwriteTagData(TagData data)
        {
            if (data == null || data.Stream == null || data.Tag == null || data.MemoryAddress < Index.IndexVirtualAddress) return;

            if (data.Tag.BaseAddress == tagDataAddressTranslator)
            {
                using (var writer = OpenWrite())
                {
                    writer.BaseStream.Seek(header.IndexOffset + header.IndexLength, SeekOrigin.Begin);
                    writer.Write(data.Stream.ToArray());
                }
            }
            else if (bspTagDataAddressTranslators.Any(t => data.Tag.BaseAddress == t))
            {
                var scenario = GetTagById(ScenarioTagId);
                using (var scenarioData = ReadTagData(scenario))
                using (BinaryReader reader = scenarioData.Stream.CreateReader())
                {
                    reader.BaseStream.Seek(scenario.MemoryAddress + 528, SeekOrigin.Begin);
                    TagBlock structureBsps = reader.ReadTagBlock();

                    for (int i = 0; i < structureBsps.Count; i++)
                    {
                        reader.BaseStream.Seek(structureBsps.Offset, SeekOrigin.Begin);
                        uint structureBspOffset = reader.ReadUInt32();
                        uint structureBspLength = reader.ReadUInt32();
                        uint structureBspMemoryAddress = reader.ReadUInt32();
                        reader.ReadInt32();
                        TagFourCc sbspTag = reader.Read<TagFourCc>();
                        TagId sbspId = reader.ReadTagId();
                        TagFourCc ltmpTag = reader.Read<TagFourCc>();
                        TagId ltmpId = reader.ReadTagId();

                        if (sbspId == data.Tag.Id || ltmpId == data.Tag.Id)
                        {
                            using (var writer = OpenWrite())
                            {
                                writer.BaseStream.Seek(structureBspOffset, SeekOrigin.Begin);
                                writer.Write(data.Stream.ToArray());
                            }
                        }
                    }
                }
            }
        }
        public void Load()
        {
            using (BinaryReader reader = OpenRead())
            {
                header = reader.Read<Header>();

                string[] tagNames = new string[header.FileNameCount];
                for (int i = 0; i < header.FileNameCount; i++)
                {
                    reader.BaseStream.Seek(header.FileNamesIndexOffset + (i * 4), SeekOrigin.Begin);
                    uint offset = reader.ReadUInt32();

                    reader.BaseStream.Seek(header.FileNamesOffset + offset, SeekOrigin.Begin);
                    tagNames[i] = reader.ReadUTF8NullTerminated();
                }

                strings = new string[header.StringCount];
                for (int i = 0; i < header.StringCount; i++)
                {
                    reader.BaseStream.Seek(header.StringsIndexOffset + (i * 4), SeekOrigin.Begin);
                    uint offset = reader.ReadUInt32();

                    reader.BaseStream.Seek(header.StringsOffset + offset, SeekOrigin.Begin);
                    strings[i] = reader.ReadUTF8NullTerminated();
                }

                reader.BaseStream.Seek(header.IndexOffset, SeekOrigin.Begin);
                index = reader.Read<Index>();

                uint baseAddress = index.TagsAddress + header.IndexLength;
                uint bspDataLength = header.MapDataLength - (header.TagDataLength + header.IndexLength + Index.Length);
                tagDataAddressTranslator = baseAddress + bspDataLength - (header.IndexOffset + header.IndexLength);
                HaloTag[] tags = new HaloTag[index.ObjectCount];

                tagList.Clear();
                reader.BaseStream.Seek(index.ObjectsOffset - index.TagsAddress, SeekOrigin.Current);
                for (int i = 0; i < index.ObjectCount; i++)
                {
                    tags[i] = new HaloTag(this, reader);

                    if (i < tagNames.Length)
                        tags[i].TagName = tagNames[i];
                    else tags[i].TagName = tags[i].ToString();

                    if (tags[i].MemoryAddress > 0)
                        tags[i].BaseAddress = tagDataAddressTranslator;

                    tagList.Add(tags[i].Id, tags[i]);
                }

                var scenarioTag = GetTagById(ScenarioTagId);
                reader.BaseStream.Seek(scenarioTag.FileAddress + 528, SeekOrigin.Begin);
                var structureBsps = reader.ReadTagBlock();
                bspTagDataAddressTranslators = new uint[structureBsps.Count];
                for (int i = 0; i < structureBsps.Count; i++)
                {
                    reader.BaseStream.Seek(structureBsps.Offset + (i * 68), scenarioTag.BaseAddress, SeekOrigin.Begin);
                    uint structureBspOffset = reader.ReadUInt32();
                    uint size = reader.ReadUInt32();
                    long address = reader.ReadInt64();
                    _ = reader.ReadTag();
                    TagId sbspId = reader.ReadTagId();
                    _ = reader.ReadTag();
                    TagId ltmpId = reader.ReadTagId();

                    if (!sbspId.IsNull)
                    {
                        reader.BaseStream.Seek(structureBspOffset, SeekOrigin.Begin);
                        var sbspHeader = reader.Read<StructureBspBlockHeader>();

                        var structureBspTag = GetTagById(sbspId);
                        structureBspTag.MemoryAddress = sbspHeader.StructureBspOffset;
                        bspTagDataAddressTranslators[i] = sbspHeader.StructureBspOffset - (structureBspOffset + StructureBspBlockHeader.Length);
                        structureBspTag.BaseAddress = bspTagDataAddressTranslators[i];

                        if (!ltmpId.IsNull)
                        {
                            var lightmapTag = GetTagById(ltmpId);
                            lightmapTag.MemoryAddress = sbspHeader.StructureLightmapOffset;
                            lightmapTag.BaseAddress = sbspHeader.StructureBspOffset - (structureBspOffset + StructureBspBlockHeader.Length);
                        }
                    }
                }
            }
        }
        public void RecalculateChecksum()
        {
            using (var reader = OpenRead())
            {
                header = reader.Read<Header>();
                header.Checksum = 0;
                for (int i = 0; i < (header.FileLength - Header.Length) / 4; i++)
                {
                    header.Checksum ^= reader.ReadUInt32();
                }
            }

            using (var writer = OpenWrite())
            {
                writer.Write(header);
            }
        }
        public HaloTag GetTagById(TagId id)
        {
            if (tagList.ContainsKey(id.Dword))
                return tagList[id.Dword];
            return null;
        }
        public string GetStringById(StringId id)
        {
            if (id.Index < strings.Length)
                return strings[id.Index];
            return null;
        }
        public bool HasString(string str)
        {
            if (str != null)
            {
                return strings.Contains(str);
            }

            return false;
        }
        public IEnumerable<HaloTag> GetTagsEnumerator()
        {
            return tagList.Values;
        }
        public Dictionary<long, byte[]> GetResourcesForTag(TagId id)
        {
            return GetResourcesForTag(GetTagById(id));
        }
        public Dictionary<long, byte[]> GetResourcesForTag(HaloTag tag)
        {
            Dictionary<long, byte[]> resources = new Dictionary<long, byte[]>();
            uint rawOffset; int rawSize;
            long translator;

            if (tag == null) return resources;

            using (BinaryReader reader = OpenRead())
            {
                switch (tag.Tag)
                {
                    case "ugh!":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 64, SeekOrigin.Begin);
                        TagBlock sounds = reader.ReadTagBlock();
                        for (int i = 0; i < sounds.Count; i++)
                        {
                            reader.BaseStream.Seek(sounds.Offset + (i * 12), translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32() & 0x7FFFFFFF;

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 80, SeekOrigin.Begin);
                        TagBlock extraInfos = reader.ReadTagBlock();
                        for (int i = 0; i < extraInfos.Count; i++)
                        {
                            reader.BaseStream.Seek(extraInfos.Offset + (i * 44) + 8, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "mode":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 36, SeekOrigin.Begin);
                        TagBlock sections = reader.ReadTagBlock();
                        for (int i = 0; i < sections.Count; i++)
                        {
                            reader.BaseStream.Seek(sections.Offset + (i * 92) + 56, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 116, SeekOrigin.Begin);
                        TagBlock prtInfos = reader.ReadTagBlock();
                        for (int i = 0; i < prtInfos.Count; i++)
                        {
                            reader.BaseStream.Seek(prtInfos.Offset + (i * 88) + 52, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "sbsp":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 156, SeekOrigin.Begin);
                        TagBlock clusters = reader.ReadTagBlock();
                        for (int i = 0; i < clusters.Count; i++)
                        {
                            reader.BaseStream.Seek(clusters.Offset + (i * 176) + 40, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 312, SeekOrigin.Begin);
                        TagBlock geometryDefinitions = reader.ReadTagBlock();
                        for (int i = 0; i < geometryDefinitions.Count; i++)
                        {
                            reader.BaseStream.Seek(geometryDefinitions.Offset + (i * 200) + 40, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 532, SeekOrigin.Begin);
                        TagBlock waterDefinitions = reader.ReadTagBlock();
                        for (int i = 0; i < waterDefinitions.Count; i++)
                        {
                            reader.BaseStream.Seek(waterDefinitions.Offset + (i * 172) + 16, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }

                        reader.BaseStream.Seek(tag.FileAddress + 564, SeekOrigin.Begin);
                        TagBlock decorators = reader.ReadTagBlock();
                        for (int i = 0; i < decorators.Count; i++)
                        {
                            reader.BaseStream.Seek(decorators.Offset + (i * 48) + 16, translator, SeekOrigin.Begin);
                            TagBlock caches = reader.ReadTagBlock();
                            for (int j = 0; j < caches.Offset; j++)
                            {
                                reader.BaseStream.Seek(caches.Offset + (j * 44), translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }
                        }
                        break;

                    case "ltmp":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 128, SeekOrigin.Begin);
                        TagBlock groups = reader.ReadTagBlock();
                        for (int i = 0; i < groups.Count; i++)
                        {
                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 32, translator, SeekOrigin.Begin);
                            clusters = reader.ReadTagBlock();
                            for (int j = 0; j < clusters.Count; j++)
                            {
                                reader.BaseStream.Seek(clusters.Offset + (j * 84) + 40, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }

                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 48, translator, SeekOrigin.Begin);
                            TagBlock poops = reader.ReadTagBlock();
                            for (int j = 0; j < poops.Count; j++)
                            {
                                reader.BaseStream.Seek(poops.Offset + (j * 84) + 40, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }

                            reader.BaseStream.Seek(groups.Offset + (i * 104) + 64, translator, SeekOrigin.Begin);
                            TagBlock buckets = reader.ReadTagBlock();
                            for (int j = 0; j < buckets.Count; j++)
                            {
                                reader.BaseStream.Seek(buckets.Offset + (j * 56) + 12, translator, SeekOrigin.Begin);
                                rawOffset = reader.ReadUInt32();
                                rawSize = reader.ReadInt32();

                                if (CheckRawOffset(rawOffset))
                                {
                                    reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                    if (!resources.ContainsKey(rawOffset))
                                        resources.Add(rawOffset, reader.ReadBytes(rawSize));
                                }
                            }
                        }
                        break;

                    case "weat":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress, SeekOrigin.Begin);
                        TagBlock particleSystems = reader.ReadTagBlock();
                        for (int i = 0; i < particleSystems.Count; i++)
                        {
                            reader.BaseStream.Seek(particleSystems.Offset + (i * 140) + 64, translator, SeekOrigin.Begin);
                            rawOffset = reader.ReadUInt32();
                            rawSize = reader.ReadInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "DECR":
                        reader.BaseStream.Seek(tag.FileAddress + 56, SeekOrigin.Begin);
                        rawOffset = reader.ReadUInt32();
                        rawSize = reader.ReadInt32();

                        if (CheckRawOffset(rawOffset))
                        {
                            reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                            if (!resources.ContainsKey(rawOffset))
                                resources.Add(rawOffset, reader.ReadBytes(rawSize));
                        }
                        break;

                    case "PRTM":
                        reader.BaseStream.Seek(tag.FileAddress + 160, SeekOrigin.Begin);
                        rawOffset = reader.ReadUInt32();
                        rawSize = reader.ReadInt32();

                        if (CheckRawOffset(rawOffset))
                        {
                            reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                            if (!resources.ContainsKey(rawOffset))
                                resources.Add(rawOffset, reader.ReadBytes(rawSize));
                        }
                        break;

                    case "jmad":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress, SeekOrigin.Begin);
                        TagBlock animations = reader.ReadTagBlock();
                        for (int i = 0; i < animations.Count; i++)
                        {
                            reader.BaseStream.Seek(animations.Offset + (i * 20) + 4, translator, SeekOrigin.Begin);
                            rawSize = reader.ReadInt32();
                            rawOffset = reader.ReadUInt32();

                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;

                    case "bitm":
                        translator = tag.BaseAddress;
                        reader.BaseStream.Seek(tag.FileAddress + 68, SeekOrigin.Begin);
                        TagBlock bitmapData = reader.ReadTagBlock();
                        for (int i = 0; i < bitmapData.Count; i++)
                        {
                            reader.BaseStream.Seek(bitmapData.Offset + (i * 116) + 28, translator, SeekOrigin.Begin);
                            uint lod1Offset = reader.ReadUInt32();
                            uint lod2Offset = reader.ReadUInt32();
                            uint lod3Offset = reader.ReadUInt32();
                            uint lod4Offset = reader.ReadUInt32();
                            uint lod5Offset = reader.ReadUInt32();
                            uint lod6Offset = reader.ReadUInt32();
                            int lod1Size = reader.ReadInt32();
                            int lod2Size = reader.ReadInt32();
                            int lod3Size = reader.ReadInt32();
                            int lod4Size = reader.ReadInt32();
                            int lod5Size = reader.ReadInt32();
                            int lod6Size = reader.ReadInt32();

                            rawOffset = lod1Offset; rawSize = lod1Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod2Offset; rawSize = lod2Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod3Offset; rawSize = lod3Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod4Offset; rawSize = lod4Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod5Offset; rawSize = lod5Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }

                            rawOffset = lod6Offset; rawSize = lod6Size;
                            if (CheckRawOffset(rawOffset))
                            {
                                reader.BaseStream.Seek(rawOffset, SeekOrigin.Begin);
                                if (!resources.ContainsKey(rawOffset))
                                    resources.Add(rawOffset, reader.ReadBytes(rawSize));
                            }
                        }
                        break;
                }
            }

            return resources;
        }
        public StringContainer GetStringsForTag(TagId id)
        {
            return GetStringsForTag(GetTagById(id));
        }
        public StringContainer GetStringsForTag(HaloTag tag)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(Name))
                return base.ToString();

            return Name;
        }
        private bool CheckRawOffset(long offset)
        {
            return (offset & 0xC0000000) == 0 && offset >= 0 && offset < header.FileLength;
        }

        public static HaloMapFile Load(string fileName)
        {
            HaloMapFile map = new HaloMapFile() { FileName = fileName };
            map.Load();

            return map;
        }
    }

    public sealed class TagData : IDisposable
    {
        public HaloTag Tag { get; }
        public long MemoryAddress { get; internal set; }
        public VirtualStream Stream { get; internal set; }

        public TagData(HaloTag tag)
        {
            Tag = tag;
        }
        public void Dispose()
        {
            Stream.Dispose();
        }
    }

    public sealed class HaloTag
    {
        private ObjectEntry objectEntry = new ObjectEntry();

        public HaloMapFile Map { get; }
        public string TagName { get; internal set; } = string.Empty;
        public uint BaseAddress { get; internal set; }
        public TagId Id => objectEntry.Id;
        public TagFourCc Tag => objectEntry.Tag;
        public long LongLength => objectEntry.Size;
        public long FileAddress => objectEntry.Offset - BaseAddress;
        public int Length
        {
            get => (int)objectEntry.Size;
            internal set => objectEntry.Size = (uint)value;
        }
        public long MemoryAddress
        {
            get => objectEntry.Offset;
            internal set => objectEntry.Offset = (uint)value;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(TagName))
                return $"{TagName}.{Tag} {Id} Offset: {FileAddress} Size: {Length}";
            else return $"{Id} Offset: {FileAddress} Size: {Length}";
        }
        internal HaloTag(HaloMapFile owner, BinaryReader reader)
        {
            Map = owner;
            objectEntry = reader.Read<ObjectEntry>();
        }
    }
}
