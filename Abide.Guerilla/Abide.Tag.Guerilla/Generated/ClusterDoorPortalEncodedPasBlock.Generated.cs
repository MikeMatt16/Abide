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
    /// Represents the generated cluster_door_portal_encoded_pas_block tag block.
    /// </summary>
    public sealed class ClusterDoorPortalEncodedPasBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDoorPortalEncodedPasBlock"/> class.
        /// </summary>
        public ClusterDoorPortalEncodedPasBlock()
        {
            this.Fields.Add(new LongIntegerField(""));
        }
        /// <summary>
        /// Gets and returns the name of the cluster_door_portal_encoded_pas_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "cluster_door_portal_encoded_pas_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cluster_door_portal_encoded_pas_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cluster_door_portal_encoded_pas_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cluster_door_portal_encoded_pas_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2048;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cluster_door_portal_encoded_pas_block tag block.
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
