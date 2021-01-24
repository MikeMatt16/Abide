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
    /// Represents the generated structure_bsp_sound_cluster_block tag block.
    /// </summary>
    public sealed class StructureBspSoundClusterBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspSoundClusterBlock"/> class.
        /// </summary>
        public StructureBspSoundClusterBlock()
        {
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<StructureSoundClusterPortalDesignators>("enclosing portal designators", 512));
            this.Fields.Add(new BlockField<StructureSoundClusterInteriorClusterIndices>("interior cluster indices", 512));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_sound_cluster_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_sound_cluster_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_sound_cluster_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_sound_cluster_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_sound_cluster_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_sound_cluster_block tag block.
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
