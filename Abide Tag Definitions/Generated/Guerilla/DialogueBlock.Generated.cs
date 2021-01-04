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
    /// Represents the generated dialogue_block tag block.
    /// </summary>
    public sealed class DialogueBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueBlock"/> class.
        /// </summary>
        public DialogueBlock()
        {
            this.Fields.Add(new TagReferenceField("global dialogue info", 1633971303));
            this.Fields.Add(new LongFlagsField("flags", "female"));
            this.Fields.Add(new BlockField<SoundReferencesBlock>("vocalizations", 500));
            this.Fields.Add(new StringIdField("mission dialogue designator#3-letter mission dialogue designator name"));
        }
        /// <summary>
        /// Gets and returns the name of the dialogue_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "dialogue_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the dialogue_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "dialogue";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the dialogue_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the dialogue_block tag block.
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
