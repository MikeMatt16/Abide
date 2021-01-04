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
    /// Represents the generated user_interface_list_skin_definition_block tag block.
    /// </summary>
    public sealed class UserInterfaceListSkinDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceListSkinDefinitionBlock"/> class.
        /// </summary>
        public UserInterfaceListSkinDefinitionBlock()
        {
            this.Fields.Add(new LongFlagsField("list flags", "unused"));
            this.Fields.Add(new TagReferenceField("arrows bitmap", 1651078253));
            this.Fields.Add(new Point2dField("up-arrows offset:from bot-left of 1st item"));
            this.Fields.Add(new Point2dField("down-arrows offset:from bot-left of 1st item"));
            this.Fields.Add(new ExplanationField("Item Animations", "Animations ordered as follows:\n0) list item focused\n1) list item unfocused\n2) lis" +
                        "t item ambient\n3) list item hovered\n4) list item unhovered\n5) list item clicked " +
                        "(hovered->focused)\n6) list item unfocused back to hovered state (focused->hovere" +
                        "d)\n"));
            this.Fields.Add(new BlockField<SingleAnimationReferenceBlock>("item animations", 7));
            this.Fields.Add(new BlockField<TextBlockReferenceBlock>("text blocks", 64));
            this.Fields.Add(new ExplanationField("NOTE:", "the bitmap block top-left is actually bottom-left here in list skin land!"));
            this.Fields.Add(new BlockField<BitmapBlockReferenceBlock>("bitmap blocks", 64));
            this.Fields.Add(new BlockField<HudBlockReferenceBlock>("hud blocks", 64));
            this.Fields.Add(new BlockField<PlayerBlockReferenceBlock>("player blocks", 64));
        }
        /// <summary>
        /// Gets and returns the name of the user_interface_list_skin_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "user_interface_list_skin_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_interface_list_skin_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_interface_list_skin_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_interface_list_skin_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_interface_list_skin_definition_block tag block.
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
