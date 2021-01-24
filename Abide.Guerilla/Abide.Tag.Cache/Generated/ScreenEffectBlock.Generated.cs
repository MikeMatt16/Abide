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
    /// Represents the generated screen_effect_block tag block.
    /// </summary>
    public sealed class ScreenEffectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenEffectBlock"/> class.
        /// </summary>
        public ScreenEffectBlock()
        {
            this.Fields.Add(new ExplanationField("SCREEN EFFECT", "A screen effect is essentially a collection of pass references, each one correspo" +
                        "nding to a shader pass reference from the template. Note that only shader passes" +
                        " in the TRANSPARENT layer are considered during screen effect rendering."));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new TagReferenceField("shader", 1936220516));
            this.Fields.Add(new PadField("", 64));
            this.Fields.Add(new BlockField<RasterizerScreenEffectPassReferenceBlock>("pass references", 8));
        }
        /// <summary>
        /// Gets and returns the name of the screen_effect_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "screen_effect_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the screen_effect_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "screen_effect";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the screen_effect_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the screen_effect_block tag block.
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
