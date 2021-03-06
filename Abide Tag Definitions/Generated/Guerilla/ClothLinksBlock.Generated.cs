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
    /// Represents the generated cloth_links_block tag block.
    /// </summary>
    public sealed class ClothLinksBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClothLinksBlock"/> class.
        /// </summary>
        public ClothLinksBlock()
        {
            this.Fields.Add(new LongIntegerField("attachment bits*"));
            this.Fields.Add(new ShortIntegerField("index1*"));
            this.Fields.Add(new ShortIntegerField("index2*"));
            this.Fields.Add(new RealField("default_distance*"));
            this.Fields.Add(new RealField("damping_multiplier*"));
        }
        /// <summary>
        /// Gets and returns the name of the cloth_links_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "cloth_links_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the cloth_links_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "cloth_links_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the cloth_links_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 640;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the cloth_links_block tag block.
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
