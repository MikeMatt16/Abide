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
    /// Represents the generated hud_message_elements_block tag block.
    /// </summary>
    public sealed class HudMessageElementsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudMessageElementsBlock"/> class.
        /// </summary>
        public HudMessageElementsBlock()
        {
            this.Fields.Add(new CharIntegerField("type*"));
            this.Fields.Add(new CharIntegerField("data*"));
        }
        /// <summary>
        /// Gets and returns the name of the hud_message_elements_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "hud_message_elements_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_message_elements_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_message_elements_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_message_elements_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 8192;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_message_elements_block tag block.
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
