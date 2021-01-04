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
    /// Represents the generated scenario_profiles_block tag block.
    /// </summary>
    public sealed class ScenarioProfilesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioProfilesBlock"/> class.
        /// </summary>
        public ScenarioProfilesBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new RealFractionField("Starting Health Damage:[0,1]"));
            this.Fields.Add(new RealFractionField("Starting Shield Damage:[0,1]"));
            this.Fields.Add(new TagReferenceField("Primary Weapon", 2003132784));
            this.Fields.Add(new ShortIntegerField("Rounds Loaded"));
            this.Fields.Add(new ShortIntegerField("Rounds Total"));
            this.Fields.Add(new TagReferenceField("Secondary Weapon", 2003132784));
            this.Fields.Add(new ShortIntegerField("Rounds Loaded"));
            this.Fields.Add(new ShortIntegerField("Rounds Total"));
            this.Fields.Add(new CharIntegerField("Starting Fragmentation Grenade Count"));
            this.Fields.Add(new CharIntegerField("Starting Plasma Grenade Count"));
            this.Fields.Add(new CharIntegerField("Starting <unknown> Grenade Count"));
            this.Fields.Add(new CharIntegerField("Starting <unknown> Grenade Count"));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_profiles_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "scenario_profiles_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_profiles_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_profiles_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_profiles_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_profiles_block tag block.
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
