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
    /// Represents the generated falling_damage_block tag block.
    /// </summary>
    public sealed class FallingDamageBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FallingDamageBlock"/> class.
        /// </summary>
        public FallingDamageBlock()
        {
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new RealBoundsField("harmful falling distance:world units"));
            this.Fields.Add(new TagReferenceField("falling damage", 1785754657));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new RealField("maximum falling distance:world units"));
            this.Fields.Add(new TagReferenceField("distance damage", 1785754657));
            this.Fields.Add(new TagReferenceField("vehicle environemtn collision damage effect", 1785754657));
            this.Fields.Add(new TagReferenceField("vehicle killed unit damage effect", 1785754657));
            this.Fields.Add(new TagReferenceField("vehicle collision damage", 1785754657));
            this.Fields.Add(new TagReferenceField("flaming death damage", 1785754657));
            this.Fields.Add(new PadField("", 28));
        }
        /// <summary>
        /// Gets and returns the name of the falling_damage_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "falling_damage_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the falling_damage_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "falling_damage_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the falling_damage_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the falling_damage_block tag block.
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
