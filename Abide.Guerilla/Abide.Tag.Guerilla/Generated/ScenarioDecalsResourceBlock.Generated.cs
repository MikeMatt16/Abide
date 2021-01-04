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
    /// Represents the generated scenario_decals_resource_block tag block.
    /// </summary>
    public sealed class ScenarioDecalsResourceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioDecalsResourceBlock"/> class.
        /// </summary>
        public ScenarioDecalsResourceBlock()
        {
            this.Fields.Add(new BlockField<ScenarioDecalPaletteBlock>("Palette", 128));
            this.Fields.Add(new BlockField<ScenarioDecalsBlock>("Decals", 65536));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_decals_resource_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_decals_resource_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_decals_resource_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_decals_resource";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_decals_resource_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_decals_resource_block tag block.
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
