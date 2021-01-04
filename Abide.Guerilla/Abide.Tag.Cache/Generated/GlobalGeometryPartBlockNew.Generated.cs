//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated global_geometry_part_block_new tag block.
    /// </summary>
    public sealed class GlobalGeometryPartBlockNew : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryPartBlockNew"/> class.
        /// </summary>
        public GlobalGeometryPartBlockNew()
        {
            this.Fields.Add(new EnumField("Type*", "Not Drawn", "Opaque Shadow Only", "Opaque Shadow-Casting", "Opaque Nonshadowing", "Transparent", "Lightmap Only"));
            this.Fields.Add(new WordFlagsField("Flags*", "Decalable", "New Part Types", "Dislikes Photons", "Override Triangle List", "ignored by lightmapper"));
            this.Fields.Add(new ShortBlockIndexField("Material*"));
            this.Fields.Add(new ShortIntegerField("Strip Start Index*"));
            this.Fields.Add(new ShortIntegerField("Strip Length*"));
            this.Fields.Add(new ShortIntegerField("First Subpart Index*"));
            this.Fields.Add(new ShortIntegerField("Subpart Count*"));
            this.Fields.Add(new CharIntegerField("Max Nodes/Vertex*"));
            this.Fields.Add(new CharIntegerField("Contributing Compound Node Count*"));
            this.Fields.Add(new ExplanationField("CENTROID", ""));
            this.Fields.Add(new RealPoint3dField("Position*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new CharIntegerField("Node Index*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("Node Weight*"));
            this.Fields.Add(new RealField("lod mipmap magic number*"));
            this.Fields.Add(new SkipField("", 24));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_part_block_new tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_geometry_part_block_new";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_part_block_new tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "part";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_part_block_new tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 255;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_part_block_new tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
