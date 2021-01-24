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
    /// Represents the generated magazines tag block.
    /// </summary>
    public sealed class Magazines : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Magazines"/> class.
        /// </summary>
        public Magazines()
        {
            this.Fields.Add(new LongFlagsField("flags", "wastes rounds when reloaded", "every round must be chambered"));
            this.Fields.Add(new ShortIntegerField("rounds recharged:per second"));
            this.Fields.Add(new ShortIntegerField("rounds total initial"));
            this.Fields.Add(new ShortIntegerField("rounds total maximum"));
            this.Fields.Add(new ShortIntegerField("rounds loaded maximum"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RealField("reload time:seconds#the length of time it takes to load a single magazine into th" +
                        "e weapon"));
            this.Fields.Add(new ShortIntegerField("rounds reloaded"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealField("chamber time:seconds#the length of time it takes to chamber the next round"));
            this.Fields.Add(new PadField("", 8));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new TagReferenceField("reloading effect", -3));
            this.Fields.Add(new TagReferenceField("reloading damage effect", 1785754657));
            this.Fields.Add(new TagReferenceField("chambering effect", -3));
            this.Fields.Add(new TagReferenceField("chambering damage effect", 1785754657));
            this.Fields.Add(new BlockField<MagazineObjects>("magazines", 8));
        }
        /// <summary>
        /// Gets and returns the name of the magazines tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "magazines";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the magazines tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "magazines";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the magazines tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the magazines tag block.
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
