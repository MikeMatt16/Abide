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
    /// Represents the generated runtime_levels_definition_block tag block.
    /// </summary>
    public sealed class RuntimeLevelsDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeLevelsDefinitionBlock"/> class.
        /// </summary>
        public RuntimeLevelsDefinitionBlock()
        {
            this.Fields.Add(new BlockField<RuntimeCampaignLevelBlock>("Campaign Levels", 20));
        }
        /// <summary>
        /// Gets and returns the name of the runtime_levels_definition_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "runtime_levels_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the runtime_levels_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "runtime_levels_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the runtime_levels_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the runtime_levels_definition_block tag block.
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
