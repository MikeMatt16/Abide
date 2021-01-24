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
    /// Represents the generated scenario_starting_equipment_block tag block.
    /// </summary>
    public sealed class ScenarioStartingEquipmentBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioStartingEquipmentBlock"/> class.
        /// </summary>
        public ScenarioStartingEquipmentBlock()
        {
            this.Fields.Add(new LongFlagsField("Flags", "No Grenades", "Plasma Grenades"));
            this.Fields.Add(new EnumField("Game Type 1", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 2", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 3", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new EnumField("Game Type 4", "NONE", "Capture the Flag", "Slayer", "Oddball", "King of the Hill", "Race", "Headhunter", "Juggernaut", "Territories", "stub", "ignored3", "ignored4", "All Game Types", "All Except CTF", "All Except CTF & Race"));
            this.Fields.Add(new PadField("", 48));
            this.Fields.Add(new TagReferenceField("Item Collection 1", 1769237859));
            this.Fields.Add(new TagReferenceField("Item Collection 2", 1769237859));
            this.Fields.Add(new TagReferenceField("Item Collection 3", 1769237859));
            this.Fields.Add(new TagReferenceField("Item Collection 4", 1769237859));
            this.Fields.Add(new TagReferenceField("Item Collection 5", 1769237859));
            this.Fields.Add(new TagReferenceField("Item Collection 6", 1769237859));
            this.Fields.Add(new PadField("", 48));
        }
        /// <summary>
        /// Gets and returns the name of the scenario_starting_equipment_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "scenario_starting_equipment_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the scenario_starting_equipment_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "scenario_starting_equipment_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the scenario_starting_equipment_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 200;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the scenario_starting_equipment_block tag block.
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
