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
    /// Represents the generated pixel32_block tag block.
    /// </summary>
    public sealed class Pixel32Block : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pixel32Block"/> class.
        /// </summary>
        public Pixel32Block()
        {
            this.Fields.Add(new ArgbColorField("color"));
        }
        /// <summary>
        /// Gets and returns the name of the pixel32_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "pixel32_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the pixel32_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "pixel32_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the pixel32_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the pixel32_block tag block.
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
