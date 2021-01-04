//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated sound_globals_block tag block.
    /// </summary>
    public sealed class SoundGlobalsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoundGlobalsBlock"/> class.
        /// </summary>
        public SoundGlobalsBlock()
        {
            this.Fields.Add(new TagReferenceField("sound classes", 1936614252));
            this.Fields.Add(new TagReferenceField("sound effects", 1936095275));
            this.Fields.Add(new TagReferenceField("sound mix", 1936616824));
            this.Fields.Add(new TagReferenceField("sound combat dialogue constants", 1936747297));
            this.Fields.Add(new TagIndexField(""));
        }
        /// <summary>
        /// Gets and returns the name of the sound_globals_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "sound_globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the sound_globals_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "sound_globals_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the sound_globals_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the sound_globals_block tag block.
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
