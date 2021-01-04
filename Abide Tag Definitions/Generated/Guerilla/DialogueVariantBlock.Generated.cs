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
    /// Represents the generated dialogue_variant_block tag block.
    /// </summary>
    public sealed class DialogueVariantBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueVariantBlock"/> class.
        /// </summary>
        public DialogueVariantBlock()
        {
            this.Fields.Add(new ShortIntegerField("variant number#variant number to use this dialogue with (must match the suffix in" +
                        " the permutations on the unit\'s model)"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new TagReferenceField("dialogue", 1969515623));
        }
        /// <summary>
        /// Gets and returns the name of the dialogue_variant_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "dialogue_variant_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the dialogue_variant_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "dialogue_variant_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the dialogue_variant_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the dialogue_variant_block tag block.
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
