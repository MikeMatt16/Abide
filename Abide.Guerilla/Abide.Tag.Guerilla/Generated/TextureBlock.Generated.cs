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
    /// Represents the generated texture_block tag block.
    /// </summary>
    public sealed class TextureBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextureBlock"/> class.
        /// </summary>
        public TextureBlock()
        {
            this.Fields.Add(new CharIntegerField("stage index"));
            this.Fields.Add(new CharIntegerField("parameter index"));
            this.Fields.Add(new CharIntegerField("global texture index"));
            this.Fields.Add(new CharIntegerField("flags"));
        }
        /// <summary>
        /// Gets and returns the name of the texture_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "texture_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the texture_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "texture_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the texture_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the texture_block tag block.
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
