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
    /// Represents the generated new_hud_dashlight_data_struct_block tag block.
    /// </summary>
    public sealed class NewHudDashlightDataStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewHudDashlightDataStructBlock"/> class.
        /// </summary>
        public NewHudDashlightDataStructBlock()
        {
            this.Fields.Add(new ExplanationField("dashlight data", "only relevant to new hud tags for weapons"));
            this.Fields.Add(new ShortIntegerField("low clip cutoff#the cutoff for showing the reload dashlight"));
            this.Fields.Add(new ShortIntegerField("low ammo cutoff#the cutoff for showing the low ammo dashlight"));
            this.Fields.Add(new RealField("age cutoff#the age cutoff for showing the low battery dashlight"));
        }
        /// <summary>
        /// Gets and returns the name of the new_hud_dashlight_data_struct_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "new_hud_dashlight_data_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the new_hud_dashlight_data_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "new_hud_dashlight_data_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the new_hud_dashlight_data_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the new_hud_dashlight_data_struct_block tag block.
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
