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
    /// Represents the generated magazine_objects tag block.
    /// </summary>
    public sealed class MagazineObjects : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagazineObjects"/> class.
        /// </summary>
        public MagazineObjects()
        {
            this.Fields.Add(new ShortIntegerField("rounds"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("equipment^", 1701931376));
        }
        /// <summary>
        /// Gets and returns the name of the magazine_objects tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "magazine_objects";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the magazine_objects tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "magazine_objects";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the magazine_objects tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the magazine_objects tag block.
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
