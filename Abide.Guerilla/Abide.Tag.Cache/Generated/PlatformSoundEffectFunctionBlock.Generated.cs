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
    /// Represents the generated platform_sound_effect_function_block tag block.
    /// </summary>
    public sealed class PlatformSoundEffectFunctionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformSoundEffectFunctionBlock"/> class.
        /// </summary>
        public PlatformSoundEffectFunctionBlock()
        {
            this.Fields.Add(new EnumField("input", "zero", "time", "scale", "rolloff"));
            this.Fields.Add(new EnumField("range", "zero", "time", "scale", "rolloff"));
            this.Fields.Add(new StructField<MappingFunctionBlock>("function"));
            this.Fields.Add(new RealField("time period: seconds"));
        }
        /// <summary>
        /// Gets and returns the name of the platform_sound_effect_function_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "platform_sound_effect_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the platform_sound_effect_function_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "platform_sound_effect_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the platform_sound_effect_function_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the platform_sound_effect_function_block tag block.
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
