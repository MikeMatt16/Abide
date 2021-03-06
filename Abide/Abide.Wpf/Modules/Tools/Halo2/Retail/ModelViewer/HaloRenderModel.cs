﻿using Abide.HaloLibrary;
using Abide.HaloLibrary.Halo2;
using Abide.HaloLibrary.Halo2.Retail;
using Abide.HaloLibrary.Halo2.Retail.Tag;
using Abide.HaloLibrary.Halo2.Retail.Tag.Generated;
using Abide.Tag;
using Abide.Tag.Cache.Generated;
using Abide.Wpf.Modules.ViewModel;
using Abide.Wpf.Modules.Win32;
using Abide.Wpf.Modules.Halo2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Media3D;

namespace Abide.Wpf.Modules.Tools.Halo2.Retail.ModelViewer
{
    public sealed class HaloRenderModel : BaseViewModel
    {
        private EntityModel[] entityModels = null;
        private ParsedModel[] models = null;
        private RegionInformation[] regions = null;
        private CompressionInfo compressionInfo = new CompressionInfo();
        private Dictionary<long, byte[]> resources = new Dictionary<long, byte[]>();
        private RenderModel renderModelTagGroup;
        private HaloTag tag;

        public ObservableCollection<RenderModelContainer> ModelContainers { get; } = new ObservableCollection<RenderModelContainer>();
        public HaloTag Tag
        {
            get => tag;
            private set
            {
                if (tag != value)
                {
                    tag = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public HaloRenderModel(HaloTag tag)
        {
            Tag = tag ?? throw new ArgumentNullException(nameof(tag));

            if (tag.Tag != HaloTags.mode)
            {
                throw new ArgumentException("Specified tag is not a render model.", nameof(tag));
            }
        }
        public void Load()
        {
            resources = Tag.Map.GetResourcesForTag(Tag);
            using (TagData data = Tag.Map.ReadTagData(Tag))
            using (BinaryReader reader = data.Stream.CreateReader())
            {
                _ = data.Stream.Seek(tag.MemoryAddress, SeekOrigin.Begin);
                renderModelTagGroup = new RenderModel();
                renderModelTagGroup.Read(reader);

                BlockField compressionInfoBlock = (BlockField)renderModelTagGroup.TagBlocks[0].Fields[5];
                if (compressionInfoBlock.BlockList.Count > 0)
                {
                    TagBlock compressionInfoTagBlock = (TagBlock)compressionInfoBlock.Value;
                    _ = data.Stream.Seek(compressionInfoTagBlock.Offset, SeekOrigin.Begin);
                    compressionInfo = reader.Read<CompressionInfo>();
                }

                List<PermutationInformation> permutationsList = new List<PermutationInformation>();
                BlockField regionsBlock = (BlockField)renderModelTagGroup.TagBlocks[0].Fields[6];
                regions = new RegionInformation[((TagBlock)regionsBlock.Value).Count];
                for (int i = 0; i < regionsBlock.BlockList.Count; i++)
                {
                    Block region = regionsBlock.BlockList[i];
                    string regionName = Tag.Map.GetStringById((StringId)region.Fields[0].Value);

                    regions[i] = new RegionInformation() { Name = regionName };

                    BlockField permutations = (BlockField)region.Fields[3];
                    for (int j = 0; j < permutations.BlockList.Count; j++)
                    {
                        Block permutation = permutations.BlockList[j];
                        string name = Tag.Map.GetStringById((StringId)permutation.Fields[0].Value);
                        short indexLod1 = (short)permutation.Fields[1].Value;
                        short indexLod2 = (short)permutation.Fields[2].Value;
                        short indexLod3 = (short)permutation.Fields[3].Value;
                        short indexLod4 = (short)permutation.Fields[4].Value;
                        short indexLod5 = (short)permutation.Fields[5].Value;
                        short indexLod6 = (short)permutation.Fields[6].Value;

                        regions[i].Permutations.Add(new PermutationInformation()
                        {
                            Name = name,
                            Lod1SectionIndex = (short)permutation.Fields[1].Value,
                            Lod2SectionIndex = (short)permutation.Fields[2].Value,
                            Lod3SectionIndex = (short)permutation.Fields[3].Value,
                            Lod4SectionIndex = (short)permutation.Fields[4].Value,
                            Lod5SectionIndex = (short)permutation.Fields[5].Value,
                            Lod6SectionIndex = (short)permutation.Fields[6].Value,
                        });
                    }
                }

                BlockField sections = (BlockField)renderModelTagGroup.TagBlocks[0].Fields[7];
                entityModels = new EntityModel[sections.BlockList.Count];
                models = new ParsedModel[sections.BlockList.Count];
                for (int i = 0; i < sections.BlockList.Count; i++)
                {
                    Block sectionBlock = sections.BlockList[i];
                    Block geometryBlockInfo = (Block)sectionBlock.Fields[6].Value;
                    TagBlock sectionsTagBlock = sections.Handle;

                    int offset = (int)geometryBlockInfo.Fields[1].Value;
                    int size = (int)geometryBlockInfo.Fields[2].Value;

                    if (!resources.ContainsKey(offset) && offset != -1)
                    {
                        resources.Add(offset, Helper.ReadExternalData(offset, size));
                    }

                    entityModels[i] = new EntityModel(data, sectionsTagBlock.Offset + (i * sectionBlock.Size), compressionInfo, resources[offset]);
                    models[i] = new ParsedModel(sectionBlock, compressionInfo, resources[offset]);
                }
            }
        }
        public void Process()
        {
            foreach (RegionInformation region in regions)
            {
                foreach (PermutationInformation permutation in region.Permutations)
                {
                    RenderModelContainer container1 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 0
                    };
                    RenderModelContainer container2 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 1
                    };
                    RenderModelContainer container3 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 2
                    };
                    RenderModelContainer container4 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 3
                    };
                    RenderModelContainer container5 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 4
                    };
                    RenderModelContainer container6 = new RenderModelContainer()
                    {
                        RegionName = region.Name,
                        PermutationName = permutation.Name,
                        LodIndex = 5
                    };


                    if (permutation.Lod1SectionIndex >= 0)
                    {
                        container1.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod1SectionIndex]);
                    }

                    if (permutation.Lod2SectionIndex >= 0)
                    {
                        container2.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod2SectionIndex]);
                    }

                    if (permutation.Lod3SectionIndex >= 0)
                    {
                        container3.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod3SectionIndex]);
                    }

                    if (permutation.Lod4SectionIndex >= 0)
                    {
                        container4.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod4SectionIndex]);
                    }

                    if (permutation.Lod5SectionIndex >= 0)
                    {
                        container5.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod5SectionIndex]);
                    }

                    if (permutation.Lod6SectionIndex >= 0)
                    {
                        container6.Mesh = ConvertFromEntityModel(entityModels[permutation.Lod6SectionIndex]);
                    }

                    ModelContainers.Add(container1);
                    ModelContainers.Add(container2);
                    ModelContainers.Add(container3);
                    ModelContainers.Add(container4);
                    ModelContainers.Add(container5);
                    ModelContainers.Add(container6);
                }
            }
        }
        
        private static short[] DecompressIndices(short[] indices, int start, int count)
        {
            bool dir = false;
            short tempx;
            short tempy;
            short tempz;
            short[] shite = new short[50000];
            int m = start;
            int s = 0;
            do
            {
                tempx = indices[m];
                tempy = indices[m + 1];
                tempz = indices[m + 2];

                if (tempx != tempy && tempx != tempz && tempy != tempz)
                {
                    if (dir == false)
                    {
                        shite[s] = tempx;
                        shite[s + 1] = tempy;
                        shite[s + 2] = tempz;
                        s += 3;

                        dir = true;
                    }
                    else
                    {
                        shite[s] = tempx;
                        shite[s + 1] = tempz;
                        shite[s + 2] = tempy;
                        s += 3;
                        dir = false;
                    }

                    m += 1;
                }
                else
                {
                    if (dir)
                    {
                        dir = false;
                    }
                    else
                    {
                        dir = true;
                    }

                    m += 1;
                }
            }
            while (m < start + count - 2);
            short[] uncompressedindices = new short[s];
            Array.Copy(shite, uncompressedindices, s);
            return uncompressedindices;
        }
        private static MeshGeometry3D ConvertFromEntityModel(EntityModel entityModel)
        {
            MeshGeometry3D meshGeometry = new MeshGeometry3D();
            List<short> indices = new List<short>(entityModel.Indices);

            // start of shitty entity code

            int subMeshCount = entityModel.SubMeshInfo.Length;
            int[] faceCount = new int[subMeshCount];
            int[] faceStart = new int[subMeshCount];
            if (entityModel.FaceCount * 3 != entityModel.IndiceCount)
            {
                short[] meshIndices = new short[entityModel.FaceCount * 3];
                int indexOffset = 0;

                for (int x = 0; x < entityModel.SubMeshInfo.Length; x++)
                {
                    EntityModel.ModelSubMeshInfo subMeshInfo = entityModel.SubMeshInfo[x];
                    short[] subMeshIndices = DecompressIndices(indices.ToArray(),
                        subMeshInfo.IndiceStart, subMeshInfo.IndiceCount);
                    Array.ConstrainedCopy(subMeshIndices, 0, meshIndices, indexOffset, subMeshIndices.Length);

                    faceCount[x] = subMeshIndices.Length / 3;
                    faceStart[x] = indexOffset;
                    indexOffset += subMeshIndices.Length;
                }

                indices = new List<short>(meshIndices);
            }
            else
            {
                for (int x = 0; x < subMeshCount; x++)
                {
                    faceCount[x] = entityModel.SubMeshInfo[x].IndiceCount / 3;
                    faceStart[x] = entityModel.SubMeshInfo[x].IndiceStart / 3;
                }
            }

            //end of shitty entity code

            foreach (Vector3 vertex in entityModel.Vertices)
            {
                meshGeometry.Positions.Add(new Point3D(vertex.I, vertex.J, vertex.K));
            }

            foreach (Vector3 normal in entityModel.Normals)
            {
                meshGeometry.Normals.Add(new Vector3D(normal.I, normal.J, normal.K));
            }

            foreach (Vector2 texcoord in entityModel.UVs)
            {
                meshGeometry.TextureCoordinates.Add(new Point(texcoord.I, texcoord.J));
            }

            foreach (short index in indices)
            {
                meshGeometry.TriangleIndices.Add(index);
            }

            return meshGeometry;
        }
    }

    public class ParsedModel
    {
        private readonly int vertexCount, triangleCount, classification, compressionFlags;
        private readonly List<byte[]> vertexBuffers = new List<byte[]>();
        private readonly Block sectionDataBlock = null;
        private readonly BlockField partsBlock = null;
        private readonly BlockField subpartsBlock = null;
        private readonly BlockField visibilityBoundsBlock = null;
        private readonly BlockField rawVerticesBlock = null;
        private readonly BlockField stripIndiciesBlock = null;
        private readonly DataField visiblityMoppCodeBlock = null;
        private readonly BlockField moppReorderTableBlock = null;
        private readonly BlockField vertexBuffersBlock = null;
        private readonly BlockField rawPointsBlock = null;
        private readonly DataField runtimePointData = null;
        private readonly BlockField rigidPointGroupsBlock = null;
        private readonly BlockField vertexPointIndicesBlock = null;
        private readonly BlockField nodeMapBlock = null;

        public ParsedModel(Block sectionBlock, CompressionInfo compressionInfo, byte[] raw)
        {
            if (sectionBlock.Name == "render_model_section_block")  // sanity check
            {
                var sectionInfo = (Block)sectionBlock.Fields[2].Value;
                vertexCount = (short)sectionInfo.Fields[1].Value;
                triangleCount = (short)sectionInfo.Fields[2].Value;
                classification = (short)sectionInfo.Fields[12].Value;
                compressionFlags = (short)sectionInfo.Fields[13].Value;

                var blockInfo = (Block)sectionBlock.Fields[6].Value;
                var resources = (BlockField)blockInfo.Fields[5];

                using (var rawStream = new MemoryStream(raw, false))
                using (var reader = new BinaryReader(rawStream))
                {
                    var headerFourCc = new string(reader.ReadChars(4));
                    if (headerFourCc != "hklb") System.Diagnostics.Debugger.Break();

                    var resourcesSize = reader.ReadInt32();
                    var headerSize = (int)blockInfo.Fields[3].Value;
                    var resourcesStart = rawStream.Seek(headerSize, SeekOrigin.Current);

                    sectionDataBlock = ((BlockField)sectionBlock.Fields[5]).Create();    // create a section data block
                    var geometrySectionBlock = (Block)sectionDataBlock.Fields[0].Value;
                    var pointDataBlock = (Block)sectionDataBlock.Fields[1].Value;

                    partsBlock = (BlockField)geometrySectionBlock.Fields[0];            // offset 0
                    subpartsBlock = (BlockField)geometrySectionBlock.Fields[1];         // offset 8
                    visibilityBoundsBlock = (BlockField)geometrySectionBlock.Fields[2]; // offset 16
                    rawVerticesBlock = (BlockField)geometrySectionBlock.Fields[3];      // offset 24
                    stripIndiciesBlock = (BlockField)geometrySectionBlock.Fields[4];    // offset 32
                    visiblityMoppCodeBlock = (DataField)geometrySectionBlock.Fields[5]; // offset 40
                    moppReorderTableBlock = (BlockField)geometrySectionBlock.Fields[6]; // offset 48
                    vertexBuffersBlock = (BlockField)geometrySectionBlock.Fields[7];    // offset 56
                    rawPointsBlock = (BlockField)pointDataBlock.Fields[0];              // offset 68
                    runtimePointData = (DataField)pointDataBlock.Fields[1];             // offset 76
                    rigidPointGroupsBlock = (BlockField)pointDataBlock.Fields[2];       // offset 84
                    vertexPointIndicesBlock = (BlockField)pointDataBlock.Fields[3];     // offset 92
                    nodeMapBlock = (BlockField)sectionDataBlock.Fields[2];              // offset 100

                    for (int i = 0; i < resources.BlockList.Count; i++)
                    {
                        var resource = resources.BlockList[i];
                        int type = (byte)resource.Fields[0].Value;
                        int primaryLocator = (short)resource.Fields[2].Value;
                        int secondaryLocator = (short)resource.Fields[3].Value;
                        int size = (int)resource.Fields[4].Value;
                        int offset = (int)resource.Fields[5].Value;

                        var resourceOffset = rawStream.Position;
                        var resourceFourCc = new string(reader.ReadChars(4));
                        if (resourceFourCc != "crsr") System.Diagnostics.Debugger.Break();

                        switch (type)
                        {
                            case 0: // Tag block
                            case 1: // Tag data
                                int count = size / secondaryLocator;

                                if (type == 0)
                                {
                                    for (int j = 0; j < count; j++)
                                    {
                                        Block tagBlock = null;
                                        switch (primaryLocator)
                                        {
                                            case 0: // parts offset
                                                partsBlock.AddNew(out tagBlock);
                                                break;

                                            case 8: // subparts offset
                                                subpartsBlock.AddNew(out tagBlock);
                                                break;

                                            case 16:    // visibility bounds offset
                                                visibilityBoundsBlock.AddNew(out tagBlock);
                                                break;

                                            case 24:    // raw vertices offset
                                                rawVerticesBlock.AddNew(out tagBlock);
                                                break;

                                            case 32:    // strip indicies offset
                                                stripIndiciesBlock.AddNew(out tagBlock);
                                                break;

                                            case 48:    // mopp reorder table
                                                moppReorderTableBlock.AddNew(out tagBlock);
                                                break;

                                            case 56:    // vertex buffers offset
                                                vertexBuffersBlock.AddNew(out tagBlock);
                                                vertexBuffers.Add(null);
                                                break;

                                            case 68:    // raw points offset
                                                rawPointsBlock.AddNew(out tagBlock);
                                                break;

                                            case 84:    // rigid point groups offset
                                                rigidPointGroupsBlock.AddNew(out tagBlock);
                                                break;

                                            case 92:    // vertex-point indices offset
                                                vertexPointIndicesBlock.AddNew(out tagBlock);
                                                break;

                                            case 100:   // node map offset
                                                nodeMapBlock.AddNew(out tagBlock);
                                                break;

                                            default:
                                                System.Diagnostics.Debugger.Break();
                                                continue;
                                        }

                                        if (tagBlock != null)
                                        {
                                            tagBlock.Read(reader);
                                        }
                                    }
                                }
                                else
                                {
                                    System.Diagnostics.Debugger.Break();

                                    switch (primaryLocator)
                                    {
                                        case 40:    // visibility mopp code offset
                                            visiblityMoppCodeBlock.SetBuffer(reader.ReadBytes(size));
                                            break;

                                        case 76:    // runtime point data offset
                                            runtimePointData.SetBuffer(reader.ReadBytes(size));
                                            break;

                                        default:
                                            System.Diagnostics.Debugger.Break();
                                            break;
                                    }
                                }
                                break;

                            case 2: // Vertex buffer
                                var vertexBuffer = (VertexBuffer)vertexBuffersBlock.BlockList[secondaryLocator].Fields[0].Value;
                                vertexBuffers[secondaryLocator] = reader.ReadBytes(vertexCount * vertexBuffer.Stride);
                                break;

                            default:
                                System.Diagnostics.Debugger.Break();
                                break;
                        }

                        rawStream.Align(4);     // apparently the stream must be aligned to 4 bytes
                    }

                    var footerFourCc = new string(reader.ReadChars(4));
                    if (footerFourCc != "fklb") System.Diagnostics.Debugger.Break();
                }

                var vertices = new List<Vector3>();
                var texCoords = new List<Vector2>();
                var triangles = new List<ushort>();

                var vertexBufferValues = vertexBuffersBlock.BlockList.Select(b => (VertexBuffer)b.Fields[0].Value).ToArray();
                for (int i = 0; i < vertexBufferValues.Length; i++)
                {
                    var vertexBuffer = vertexBuffers[i];
                    var vb = vertexBufferValues[i];

                    using (var stream = new MemoryStream(vertexBuffer, false))
                    using (var reader = new BinaryReader(stream))
                    {
                        var type = (XboxVertexBufferType)vb.Type;

                        for (int j = 0; j < vertexCount; j++)
                        {
                            switch (type)
                            {
                                case XboxVertexBufferType.PositionBoned1_Compressed:
                                    PackedVector3 vertexPosition = reader.Read<PackedVector3>();
                                    byte weight = reader.ReadByte();

                                    vertices.Add(new Vector3(
                                        compressionInfo.Inflate(Component.PositionX, vertexPosition.X),
                                        compressionInfo.Inflate(Component.PositionY, vertexPosition.Y),
                                        compressionInfo.Inflate(Component.PositionZ, vertexPosition.Z)));
                                    break;

                                case XboxVertexBufferType.Texcoord_Compressed:
                                    PackedVector2 texcoordPosition = reader.Read<PackedVector2>();
                                    texCoords.Add(new Vector2(
                                        compressionInfo.Inflate(Component.TexcoordX, texcoordPosition.X),
                                        compressionInfo.Inflate(Component.TexcoordY, texcoordPosition.Y)));
                                    break;

                                case XboxVertexBufferType.NormalBinormalTangent_Compressed:
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// ew.
    /// </summary>
    public class EntityModel
    {
        private readonly byte[] data;

        public List<Vector3> Binormals { get; set; } = new List<Vector3>();
        public List<int> BoneMap { get; set; } = new List<int>();
        public int FaceCount { get; set; }
        public int HeaderSize { get; set; }
        public int IndiceCount { get; set; }
        public short[] Indices { get; set; }
        public List<Vector3> Normals { get; set; } = new List<Vector3>();
        public RawDataOffsetChunk[] RawDataChunkInfo { get; set; }
        public ModelSubMeshInfo[] SubMeshInfo { get; set; }
        public List<Vector3> Tangents { get; set; } = new List<Vector3>();
        public List<Vector2> UVs { get; set; } = new List<Vector2>();
        public List<BoneInfo> VerticeBones { get; set; } = new List<BoneInfo>();
        public int VerticeCount { get; set; }
        public List<Vector3> Vertices { get; set; } = new List<Vector3>();
        public int lod { get; set; }
        public string permutation { get; set; }
        public string piecename { get; set; }
        public byte type { get; set; }

        public EntityModel(TagData tag, long offset, CompressionInfo boundingBox, byte[] data)
        {
            this.data = data;

            using (BinaryReader BR = tag.Stream.CreateReader())
            {
                BR.BaseStream.Position = offset + 4;
                VerticeCount = BR.ReadUInt16();
                FaceCount = BR.ReadUInt16();
                BR.BaseStream.Position = offset + 20;
                type = BR.ReadByte();
                BR.BaseStream.Position = offset + 68;
                HeaderSize = data.Length - BR.ReadInt32() - 4;
                int tempc = BR.ReadInt32();
                long tempr = BR.ReadUInt32();
                RawDataChunkInfo = new RawDataOffsetChunk[tempc];
                for (int x = 0; x < tempc; x++)
                {
                    RawDataChunkInfo[x] = new RawDataOffsetChunk();
                    BR.BaseStream.Position = tempr + (x * 16) + 6;
                    RawDataChunkInfo[x].ChunkSize = BR.ReadUInt16();
                    RawDataChunkInfo[x].Size = BR.ReadInt32();
                    if (RawDataChunkInfo[x].ChunkSize == 0)
                    {
                        RawDataChunkInfo[x].ChunkSize = RawDataChunkInfo[x].Size;
                    }

                    RawDataChunkInfo[x].Offset = BR.ReadInt32();
                    RawDataChunkInfo[x].ChunkCount = RawDataChunkInfo[x].Size / RawDataChunkInfo[x].ChunkSize;
                }
            }

            using (MemoryStream ms = new MemoryStream(data))
            using (BinaryReader BR = new BinaryReader(ms))
            {
                SubMeshInfo = new ModelSubMeshInfo[RawDataChunkInfo[0].ChunkCount];
                for (int x = 0; x < RawDataChunkInfo[0].ChunkCount; x++)
                {
                    SubMeshInfo[x] = new ModelSubMeshInfo();
                    BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[0].Offset + (x * 72) + 4;
                    SubMeshInfo[x].ShaderNumber = BR.ReadUInt16();
                    SubMeshInfo[x].IndiceStart = BR.ReadUInt16();
                    SubMeshInfo[x].IndiceCount = BR.ReadUInt16();
                }

                BR.BaseStream.Position = 40;
                IndiceCount = BR.ReadUInt16();

                int indicechunk = 0;
                int verticechunk = 0;
                int uvchunk = 0;

                for (int x = 0; x < RawDataChunkInfo.Length; x++)
                {
                    if (RawDataChunkInfo[x].ChunkSize == 2)
                    {
                        indicechunk = x;
                        verticechunk = x + 2;
                        uvchunk = x + 3;
                        break;
                    }
                }

                int bonemapchunk = 0;
                BR.BaseStream.Position = 108;
                int tempbonemapcount = BR.ReadUInt16();
                if (tempbonemapcount > 0)
                {
                    for (int x = uvchunk + 1; x < RawDataChunkInfo.Length; x++)
                    {
                        if (RawDataChunkInfo[x].ChunkSize == 1)
                        {
                            bonemapchunk = x;
                            break;
                        }
                    }

                    BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[bonemapchunk].Offset;
                    for (int x = 0; x < tempbonemapcount; x++)
                    {
                        BoneMap.Add(BR.ReadByte());
                    }
                }
                else
                {
                    BoneMap.Add(0);
                }

                RawDataChunkInfo[verticechunk].ChunkSize = RawDataChunkInfo[verticechunk].Size / VerticeCount;
                for (int x = 0; x < VerticeCount; x++)
                {
                    BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[verticechunk].Offset + (RawDataChunkInfo[verticechunk].ChunkSize * x);
                    short i = BR.ReadInt16(), j = BR.ReadInt16(), k = BR.ReadInt16();
                    Vertices.Add(new Vector3(
                        DecompressVertice(i, boundingBox.PositionX.Min, boundingBox.PositionX.Max),
                        DecompressVertice(j, boundingBox.PositionY.Min, boundingBox.PositionY.Max),
                        DecompressVertice(k, boundingBox.PositionZ.Min, boundingBox.PositionZ.Max)));

                    // if (tempbonemapcount == 0) { continue; }

                    switch (RawDataChunkInfo[verticechunk].ChunkSize)
                    {
                        case 6:
                            BoneInfo b = new BoneInfo();
                            b.BoneIndex.Add(0);
                            b.Weight.Add(1.0f);
                            VerticeBones.Add(b);

                            break;
                        case 8:
                            BoneInfo c = new BoneInfo();
                            c.BoneIndex.Add(BR.ReadByte());
                            c.Weight.Add(1.0f);
                            byte tempb = BR.ReadByte();
                            if (tempb == 0)
                            {
                                VerticeBones.Add(c);
                                break;
                            }

                            BoneInfo c2 = new BoneInfo();
                            c2.BoneIndex.Add(tempb);
                            c2.Weight.Add(1.0f);
                            VerticeBones.Add(c2);
                            c.Weight[0] = 1.0f;
                            VerticeBones.Add(c);
                            break;
                        case 12:
                            BoneInfo bbb = new BoneInfo();
                            bbb.BoneIndex.Add(BR.ReadByte());
                            bbb.Weight.Add(0.99f);
                            VerticeBones.Add(bbb);
                            break;
                    }
                }

                RawDataChunkInfo[uvchunk].ChunkSize = 4;
                for (int x = 0; x < VerticeCount; x++)
                {
                    Vector2 tempuv = new Vector2();
                    BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[uvchunk].Offset + (RawDataChunkInfo[uvchunk].ChunkSize * x);
                    PackedVector2 normalVector = BR.Read<PackedVector2>();

                    // if (tempuv.X > 1) { tempuv.X = tempuv.X - 1; }
                    // else
                    if (tempuv.I < 0)
                    {
                        tempuv.I = 1 - tempuv.I;
                    }

                    // if (tempuv.Y > 1) { tempuv.Y = tempuv.Y - 1; }
                    // else
                    if (tempuv.J < 0)
                    {
                        tempuv.J = 1 - tempuv.J;
                    }

                    UVs.Add(tempuv);
                }

                RawDataChunkInfo[uvchunk + 1].ChunkSize = 12;
                for (int x = 0; x < VerticeCount; x++)
                {
                    BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[uvchunk + 1].Offset +
                                             (RawDataChunkInfo[uvchunk + 1].ChunkSize * x);

                    int dword = BR.ReadInt32();

                    Vector3 tempnormal = DecompressNormal(dword);

                    int converto = CompressNormal(tempnormal);
                    Vector3 tempnormal2 = DecompressNormal(converto);
                    Normals.Add(tempnormal);
                }

                BR.BaseStream.Position = HeaderSize + RawDataChunkInfo[indicechunk].Offset;
                this.Indices = new short[IndiceCount];
                for (int x = 0; x < IndiceCount; x++)
                {
                    Indices[x] = (short)BR.ReadUInt16();
                }
            }
        }

        private static int CompressNormal(Vector3 normal)
        {
            bool negx = false;
            if (normal.I < 0)
            {
                negx = true;
                normal.I = -normal.I;
            }

            float bbb = normal.I * Convert.ToSingle(0x3ff);
            int b = Convert.ToInt32(bbb);
            if (negx)
            {
                b = -b + 1 | 0x400;
            }

            bool negy = false;
            if (normal.J < 0)
            {
                negy = true;
                normal.J = -normal.J;
            }

            float bbb2 = normal.J * Convert.ToSingle(0x3ff);
            int b2 = Convert.ToInt32(bbb2);
            if (negy)
            {
                b2 = -b2 + 1 | 0x400;
            }

            b2 <<= 11;

            bool negz = false;
            if (normal.K < 0)
            {
                negz = true;
                normal.K = -normal.K;
            }

            float bbb3 = normal.K * Convert.ToSingle(0x1ff);
            int b3 = Convert.ToInt32(bbb3);
            if (negz)
            {
                b3 = -b3 + 1 | 0x200;
            }

            b3 <<= 22;

            int result = b3 | b2 | b;

            return result;
        }
        private static Vector3 DecompressNormal(int compressednormal)
        {
            int xx = compressednormal & 0x3ff;
            float xxx = Convert.ToSingle(xx) / Convert.ToSingle(0x3ff);
            int bitx = (compressednormal >> 10) & 0x1;
            if (bitx == 1)
            {
                xxx = 1 - xxx;
                xxx = -xxx;
            }

            int yy = (compressednormal >> 11) & 0x3ff;
            float yyy = Convert.ToSingle(yy) / Convert.ToSingle(0x3ff);
            int bity = (compressednormal >> 21) & 0x1;
            if (bity == 1)
            {
                yyy = 1 - yyy;
                yyy = -yyy;
            }

            int zz = (compressednormal >> 22) & 0x1ff;
            float zzz = Convert.ToSingle(zz) / Convert.ToSingle(0x1ff);
            int bitz = (compressednormal >> 31) & 0x1;
            if (bitz == 1)
            {
                zzz = 1 - zzz;
                zzz = -zzz;
            }

            return new Vector3(xxx, yyy, zzz);
        }
        private static float DecompressVertice(float input, float min, float max)
        {
            float percent = (input + 32768) / 65535;
            float result = (percent * (max - min)) + min;
            return result;
        }
        private static float CompressVertice(float input, float min, float max)
        {
            float result = input - min;
            result = result / (max - min);
            result = result * 65535;
            result = result - 32768;
            return result;
        }

        public class RawDataOffsetChunk
        {
            public int ChunkCount { get; set; }
            public int ChunkSize { get; set; }
            public int Offset { get; set; }
            public int Size { get; set; }
        }

        public class ModelSubMeshInfo
        {
            public ushort ShaderNumber { get; internal set; }
            public ushort IndiceStart { get; internal set; }
            public ushort IndiceCount { get; internal set; }
        }

        public class BoneInfo
        {
            public List<int> BoneIndex { get; internal set; } = new List<int>();
            public List<float> Weight { get; internal set; } = new List<float>();
        }
    }

    public struct R11G11B10Float
    {
        private int value;
    }

    public struct CompressionInfo
    {
        private const float shortConst = short.MaxValue;
        private const float ushortInverse = 1f / ushort.MaxValue;

        public FloatBounds PositionX { get; set; }
        public FloatBounds PositionY { get; set; }
        public FloatBounds PositionZ { get; set; }
        public FloatBounds TexcoordX { get; set; }
        public FloatBounds TexcoordY { get; set; }
        public FloatBounds SecondaryTexcoordX { get; set; }
        public FloatBounds SecondaryTexcoordY { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is CompressionInfo other)
            {
                return other.PositionX == PositionX && other.PositionY == PositionY &&
                    other.PositionZ == other.PositionZ && other.TexcoordX == TexcoordX &&
                    other.TexcoordY == other.TexcoordY && other.SecondaryTexcoordX == SecondaryTexcoordX &&
                    other.SecondaryTexcoordY == SecondaryTexcoordY;
            }

            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public float Inflate(Component component, float value)
        {
            FloatBounds bounds;
            switch (component)
            {
                case Component.PositionX:
                    bounds = PositionX;
                    break;
                case Component.PositionY:
                    bounds = PositionY;
                    break;
                case Component.PositionZ:
                    bounds = PositionZ;
                    break;
                case Component.TexcoordX:
                    bounds = TexcoordX;
                    break;
                case Component.TexcoordY:
                    bounds = TexcoordY;
                    break;
                case Component.SecondaryTexcoordX:
                    bounds = SecondaryTexcoordX;
                    break;
                case Component.SecondaryTexcoordY:
                    bounds = SecondaryTexcoordY;
                    break;

                default:
                    return 0;
            }

            return (value + shortConst) * ushortInverse + (bounds.Max - bounds.Min) + bounds.Min;
        }
        public float Normalize(Component component, float value)
        {
            FloatBounds bounds;
            switch (component)
            {
                case Component.PositionX:
                    bounds = PositionX;
                    break;
                case Component.PositionY:
                    bounds = PositionY;
                    break;
                case Component.PositionZ:
                    bounds = PositionZ;
                    break;
                case Component.TexcoordX:
                    bounds = TexcoordX;
                    break;
                case Component.TexcoordY:
                    bounds = TexcoordY;
                    break;
                case Component.SecondaryTexcoordX:
                    bounds = SecondaryTexcoordX;
                    break;
                case Component.SecondaryTexcoordY:
                    bounds = SecondaryTexcoordY;
                    break;

                default:
                    return 0;
            }

            return bounds.Min + (value / (bounds.Max - bounds.Min));
        }

        public static bool operator ==(CompressionInfo left, CompressionInfo right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(CompressionInfo left, CompressionInfo right)
        {
            return !(left == right);
        }
    }

    public struct Packed16 : IComparable<Packed16>, IEquatable<Packed16>
    {
        public const float MinValue = -1f;
        public const float MaxValue = 1f;

        private short value;

        private Packed16(short value)
        {
            this.value = value;
        }
        private Packed16(float value)
        {
            if (value < -1f)
            {
                value = -1f;
            }

            if (value > 1f)
            {
                value = 1f;
            }

            this.value = (short)Math.Floor(value * (short.MaxValue / 2f));
        }

        public int CompareTo(Packed16 value)
        {
            return this.value.CompareTo(value.value);
        }
        public bool Equals(Packed16 value)
        {
            return this.value.Equals(value.value);
        }
        public override string ToString()
        {
            return (Math.Abs(value) / (float)(value < 0 ? short.MinValue : short.MaxValue)).ToString();
        }

        public static implicit operator Packed16(float value)
        {
            return new Packed16(value);
        }
        public static explicit operator Packed16(short value)
        {
            return new Packed16(value);
        }
        public static implicit operator float(Packed16 value)
        {
            double v = value.value;
            return (float)(Math.Abs(v) / (v < 0 ? short.MinValue : short.MaxValue));
        }
        public static explicit operator short(Packed16 value)
        {
            return value.value;
        }
    }

    public struct PackedVector3
    {
        public static readonly PackedVector3 Zero = new PackedVector3(0f, 0f, 0f);
        private Packed16 x, y, z;

        public float X
        {
            get => x;
            set => x = value;
        }
        public float Y
        {
            get => y;
            set => y = value;
        }
        public float Z
        {
            get => z;
            set => z = value;
        }


        public PackedVector3(float x, float y, float z)
        {
            //Check
            if (x < -1f || x > 1)
            {
                throw new ArgumentException("Value is less than negative one or is greater than one.", nameof(x));
            }

            if (y < -1f || y > 1)
            {
                throw new ArgumentException("Value is less than negative one or is greater than one.", nameof(y));
            }

            if (z < -1f || z > 1)
            {
                throw new ArgumentException("Value is less than negative one or is greater than one.", nameof(z));
            }

            //Set
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3 Inflate(CompressionInfo compression)
        {
            return new Vector3(compression.Inflate(Component.PositionX, x), compression.Inflate(Component.PositionY, y), compression.Inflate(Component.PositionZ, z));
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        public static implicit operator Vector3(PackedVector3 vector)
        {
            return new Vector3(vector.x, vector.y, vector.z);
        }
    }

    public struct PackedVector2
    {
        public static readonly PackedVector2 Zero = new PackedVector2(0f, 0f);
        private Packed16 x, y;

        public float X
        {
            get => x;
            set => x = value;
        }
        public float Y
        {
            get => y;
            set => y = value;
        }

        public PackedVector2(float x, float y)
        {
            //Check
            if (x < -1f || x > 1)
            {
                throw new ArgumentException("Value is less than negative one or is greater than one.", nameof(x));
            }

            if (y < -1f || y > 1)
            {
                throw new ArgumentException("Value is less than negative one or is greater than one.", nameof(y));
            }

            //Set
            this.x = x;
            this.y = y;
        }
        public Vector2 InflateXY(CompressionInfo compression)
        {
            return new Vector2(compression.Inflate(Component.PositionX, x), compression.Inflate(Component.PositionY, y));
        }
        public Vector2 InflateUV(CompressionInfo compression)
        {
            return new Vector2(compression.Inflate(Component.TexcoordX, x), compression.Inflate(Component.TexcoordY, y));
        }
        public Vector2 InflateSecondaryUV(CompressionInfo compression)
        {
            return new Vector2(compression.Inflate(Component.SecondaryTexcoordX, x), compression.Inflate(Component.SecondaryTexcoordY, y));
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
        public static implicit operator Vector2(PackedVector2 vector)
        {
            return new Vector2(vector.x, vector.y);
        }
    }

    /// <summary>
    /// Represents an enumeration containing compressable components.
    /// </summary>
    public enum Component : byte
    {
        PositionX,
        PositionY,
        PositionZ,
        TexcoordX,
        TexcoordY,
        SecondaryTexcoordX,
        SecondaryTexcoordY,
    }

    public enum XboxVertexBufferType : byte
    {
        /// <summary>
        /// POSITION - Vector3
        /// </summary>
        Position_Uncompressed = 1,
        /// <summary>
        /// POSITION - Custom packing into 3 shorts
        /// </summary>
        Position_Compressed = 2,

        /// <summary>
        /// POSITION/BLENDINDICES - Custom packing into 3 shorts + 1 bone index
        /// </summary>
        PositionBoned1_Compressed = 4,

        /// <summary>
        /// POSITION/BLENDINDICES/BLENDWEIGHT - Custom packing into 3 shorts + (2 bytes padding?) + 2 bone index (bytes) + 2 weights (ubyte)
        /// </summary>
        PositionSkinned2Wt_Compressed = 6,

        /// <summary>
        /// POSITION/BLENDINDICES/BLENDWEIGHT - Custom packing into 3 shorts + 3 bone index + 3 weights
        /// </summary>
        PositionSkinned3Wt_Compressed = 8,

        /// <summary>
        /// TEXCOORD0 - Vector2
        /// </summary>
        Texcoord_Uncompressed = 0x18,
        /// <summary>
        /// TEXCOORD0 - Custom packing into 2 shorts
        /// </summary>
        Texcoord_Compressed = 0x19,
        /// <summary>
        /// NORMAL/BINORMAL/TANGENT - 3x Vector3
        /// </summary>
        NormalBinormalTangent_Uncompressed = 0x1A,
        /// <summary>
        /// NORMAL/BINORMAL/TANGENT - 3x R11G11B10_Float
        /// </summary>
        NormalBinormalTangent_Compressed = 0x1B,

        /// <summary>
        /// TEXCOORD1 - Vector2
        /// </summary>
        SecondaryTexcoord_Uncompressed = 0x1E,
        /// <summary>
        /// TEXCOORD1 - Custom packing into 2 shorts
        /// </summary>
        SecondaryTexcoord_Compressed = 0x1F,

        /// <summary>
        /// COLOR - R8G8B8
        /// </summary>
        PrimaryLightmapColor_UByte3 = 0x2F,
        /// <summary>
        /// POSITION - R11G11B10_Float
        /// </summary>
        IncidentRadiosity_Compressed = 0x30,
    }

    public enum PcVertexBufferType : byte
    {
        /// <summary>
        /// POSITION - Vector3
        /// </summary>
        Position_Uncompressed = 1,

        /// <summary>
        /// TEXCOORD0 - Vector2
        /// </summary>
        Texcoord_Uncompressed = 0x17,

        /// <summary>
        /// NORMAL/BINORMAL/TANGENT - 3x Vector3
        /// </summary>
        NormalBinormalTangent_Uncompressed = 0x19,

        /// <summary>
        /// TEXCOORD1 - Vector2
        /// </summary>
        SecondaryTexcoord_Uncompressed = 0x1D,

        /// <summary>
        /// COLOR - A8R8G8B8
        /// </summary>
        PrimaryLightmapColor_UByte4 = 0x2E,
        /// <summary>
        /// POSITION - Vector3
        /// </summary>
        IncidentRadiosity_Uncompressed = 0x2F,
    }

    public class SectionInformation
    {
        public int TotalVertexCount { get; set; }
        public int TotalTriangleCount { get; set; }
        public int TotalPartCount { get; set; }
        public int ShadowCastingTriangleCount { get; set; }
        public int ShadowCastingPartCount { get; set; }
        public int OpaquePointCount { get; set; }
        public int OpaquePartCount { get; set; }
        public List<SectionResource> Resources { get; } = new List<SectionResource>();
    }

    public class SectionResource
    {
        public ResourceType Type { get; set; }
        public int PrimaryLocator { get; set; }
        public int SecondaryLocator { get; set; }
        public int ResourceDataSize { get; set; }
        public int ResourceDataOffset { get; set; }
    }

    public class RegionInformation
    {
        public string Name { get; set; }
        public List<PermutationInformation> Permutations { get; } = new List<PermutationInformation>();
    }

    public class PermutationInformation
    {
        public string Name { get; set; }
        public int Lod1SectionIndex { get; set; }
        public int Lod2SectionIndex { get; set; }
        public int Lod3SectionIndex { get; set; }
        public int Lod4SectionIndex { get; set; }
        public int Lod5SectionIndex { get; set; }
        public int Lod6SectionIndex { get; set; }
    }

    public class RenderModelContainer : BaseViewModel
    {
        private string permutationName = string.Empty;
        private string regionName = string.Empty;
        private Geometry3D mesh = null;
        private int lodIndex = 0;

        public Geometry3D Mesh
        {
            get => mesh;
            set
            {
                if (mesh != value)
                {
                    mesh = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string PermutationName
        {
            get => permutationName;
            set
            {
                if (permutationName != value)
                {
                    permutationName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string RegionName
        {
            get => regionName;
            set
            {
                if (regionName != value)
                {
                    regionName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int LodIndex
        {
            get => lodIndex;
            set
            {
                if (lodIndex != value)
                {
                    lodIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public override string ToString()
        {
            return $"{RegionName} {PermutationName} LOD #{LodIndex + 1}";
        }
    }

    public enum ResourceType
    {
        TagBlock,
        TagData,
        VertexBuffer
    }
}
