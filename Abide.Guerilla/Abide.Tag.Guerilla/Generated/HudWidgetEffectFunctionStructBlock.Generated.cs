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
    /// Represents the generated hud_widget_effect_function_struct_block tag block.
    /// </summary>
    public sealed class HudWidgetEffectFunctionStructBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HudWidgetEffectFunctionStructBlock"/> class.
        /// </summary>
        public HudWidgetEffectFunctionStructBlock()
        {
            this.Fields.Add(new StringIdField("input name"));
            this.Fields.Add(new StringIdField("range name"));
            this.Fields.Add(new RealField("time period in seconds"));
            this.Fields.Add(new StructField<ScalarFunctionStructBlock>("function"));
        }
        /// <summary>
        /// Gets and returns the name of the hud_widget_effect_function_struct_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "hud_widget_effect_function_struct_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the hud_widget_effect_function_struct_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "hud_widget_effect_function_struct";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the hud_widget_effect_function_struct_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the hud_widget_effect_function_struct_block tag block.
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
