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
    /// Represents the generated structure_sound_cluster_interior_cluster_indices tag block.
    /// </summary>
    public sealed class StructureSoundClusterInteriorClusterIndices : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureSoundClusterInteriorClusterIndices"/> class.
        /// </summary>
        public StructureSoundClusterInteriorClusterIndices()
        {
            this.Fields.Add(new ShortIntegerField("interior cluster index*"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_sound_cluster_interior_cluster_indices tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "structure_sound_cluster_interior_cluster_indices";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_sound_cluster_interior_cluster_indices tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_sound_cluster_interior_cluster_indices";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_sound_cluster_interior_cluster_indices tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_sound_cluster_interior_cluster_indices tag block.
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
