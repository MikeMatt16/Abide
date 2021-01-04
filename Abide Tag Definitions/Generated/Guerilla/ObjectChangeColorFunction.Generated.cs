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
    /// Represents the generated object_change_color_function tag block.
    /// </summary>
    public sealed class ObjectChangeColorFunction : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectChangeColorFunction"/> class.
        /// </summary>
        public ObjectChangeColorFunction()
        {
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new LongFlagsField("scale flags", "blend in hsv#blends colors in hsv rather than rgb space", "...more colors#blends colors through more hues (goes the long way around the colo" +
                        "r wheel)"));
            this.Fields.Add(new RealRgbColorField("color lower bound"));
            this.Fields.Add(new RealRgbColorField("color upper bound"));
            this.Fields.Add(new StringIdField("darken by"));
            this.Fields.Add(new StringIdField("scale by"));
        }
        /// <summary>
        /// Gets and returns the name of the object_change_color_function tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "object_change_color_function";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the object_change_color_function tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "object_change_color_function";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the object_change_color_function tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the object_change_color_function tag block.
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
