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
    /// Represents the generated ai_globals_gravemind_block tag block.
    /// </summary>
    public sealed class AiGlobalsGravemindBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiGlobalsGravemindBlock"/> class.
        /// </summary>
        public AiGlobalsGravemindBlock()
        {
            this.Fields.Add(new RealField("min retreat time:secs"));
            this.Fields.Add(new RealField("ideal retreat time:secs"));
            this.Fields.Add(new RealField("max retreat time:secs"));
        }
        /// <summary>
        /// Gets and returns the name of the ai_globals_gravemind_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "ai_globals_gravemind_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the ai_globals_gravemind_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "ai_globals_gravemind_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the ai_globals_gravemind_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the ai_globals_gravemind_block tag block.
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
