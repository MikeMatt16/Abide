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
    /// Represents the generated globals_obsolete_sound_block tag block.
    /// </summary>
    internal sealed class GlobalsObsoleteSoundBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalsObsoleteSoundBlock"/> class.
        /// </summary>
        public GlobalsObsoleteSoundBlock()
        {
            this.Fields.Add(new TagReferenceField("", 1936614433));
        }
        /// <summary>
        /// Gets and returns the name of the globals_obsolete_sound_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "globals_obsolete_sound_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the globals_obsolete_sound_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "globals_obsolete_sound_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the globals_obsolete_sound_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 32767;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the globals_obsolete_sound_block tag block.
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
