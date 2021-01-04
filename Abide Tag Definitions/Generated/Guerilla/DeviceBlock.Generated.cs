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
    /// Represents the generated device_block tag block.
    /// </summary>
    public sealed class DeviceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceBlock"/> class.
        /// </summary>
        public DeviceBlock()
        {
            this.Fields.Add(new ExplanationField("$$$ DEVICE $$$", ""));
            this.Fields.Add(new LongFlagsField("flags", "position loops", "(unused)", "allow interpolation"));
            this.Fields.Add(new RealField("power transition time:seconds"));
            this.Fields.Add(new RealField("power acceleration time:seconds"));
            this.Fields.Add(new RealField("position transition time:seconds"));
            this.Fields.Add(new RealField("position acceleration time:seconds"));
            this.Fields.Add(new RealField("depowered position transition time:seconds"));
            this.Fields.Add(new RealField("depowered position acceleration time:seconds"));
            this.Fields.Add(new WordFlagsField("lightmap flags", "don\'t use in lightmap", "don\'t use in lightprobe"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("open (up)", -3));
            this.Fields.Add(new TagReferenceField("close (down)", -3));
            this.Fields.Add(new TagReferenceField("opened", -3));
            this.Fields.Add(new TagReferenceField("closed", -3));
            this.Fields.Add(new TagReferenceField("depowered", -3));
            this.Fields.Add(new TagReferenceField("repowered", -3));
            this.Fields.Add(new RealField("delay time:seconds"));
            this.Fields.Add(new TagReferenceField("delay effect", -3));
            this.Fields.Add(new RealField("automatic activation radius:world units"));
        }
        /// <summary>
        /// Gets and returns the name of the device_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "device_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the device_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "device";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the device_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the device_block tag block.
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
