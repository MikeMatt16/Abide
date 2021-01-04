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
    /// Represents the generated multiplayer_ui_block tag block.
    /// </summary>
    public sealed class MultiplayerUiBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplayerUiBlock"/> class.
        /// </summary>
        public MultiplayerUiBlock()
        {
            this.Fields.Add(new TagReferenceField("random player names", 1970170211));
            this.Fields.Add(new BlockField<MultiplayerColorBlock>("obsolete profile colors", 32));
            this.Fields.Add(new BlockField<MultiplayerColorBlock>("team colors", 32));
            this.Fields.Add(new TagReferenceField("team names", 1970170211));
        }
        /// <summary>
        /// Gets and returns the name of the multiplayer_ui_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "multiplayer_ui_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the multiplayer_ui_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "multiplayer_ui_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the multiplayer_ui_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the multiplayer_ui_block tag block.
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
