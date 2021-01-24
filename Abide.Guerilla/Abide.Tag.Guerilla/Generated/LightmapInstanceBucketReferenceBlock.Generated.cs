//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Guerilla.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated lightmap_instance_bucket_reference_block tag block.
    /// </summary>
    public sealed class LightmapInstanceBucketReferenceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightmapInstanceBucketReferenceBlock"/> class.
        /// </summary>
        public LightmapInstanceBucketReferenceBlock()
        {
            this.Fields.Add(new ShortIntegerField("flags"));
            this.Fields.Add(new ShortIntegerField("bucket index"));
            this.Fields.Add(new BlockField<LightmapInstanceBucketSectionOffsetBlock>("section offsets", 255));
        }
        /// <summary>
        /// Gets and returns the name of the lightmap_instance_bucket_reference_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "lightmap_instance_bucket_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the lightmap_instance_bucket_reference_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "lightmap_instance_bucket_reference_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the lightmap_instance_bucket_reference_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2000;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the lightmap_instance_bucket_reference_block tag block.
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
