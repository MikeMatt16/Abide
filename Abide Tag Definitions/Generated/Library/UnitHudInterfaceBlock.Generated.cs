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
    /// Represents the generated unit_hud_interface_block tag block.
    /// </summary>
    public sealed class UnitHudInterfaceBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitHudInterfaceBlock"/> class.
        /// </summary>
        public UnitHudInterfaceBlock()
        {
            this.Fields.Add(new ExplanationField("Weapon hud screen alignment", ""));
            this.Fields.Add(new EnumField("anchor", "top left", "top right", "bottom left", "bottom right", "center", "crosshair"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new ExplanationField("Unit hud background", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", 1651078253));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("Shield panel background", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", 1651078253));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("Shield panel meter", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("meter bitmap", 1651078253));
            this.Fields.Add(new RgbColorField("color at meter minimum"));
            this.Fields.Add(new RgbColorField("color at meter maximum"));
            this.Fields.Add(new RgbColorField("flash color"));
            this.Fields.Add(new ArgbColorField("empty color"));
            this.Fields.Add(new ByteFlagsField("flags", "use min/max for state changes", "interpolate between min/max flash colors as state changes", "interpolate color along hsv space", "...more colors for hsv interpolation", "invert interpolation"));
            this.Fields.Add(new CharIntegerField("minumum meter value"));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new CharIntegerField("alpha multiplier"));
            this.Fields.Add(new CharIntegerField("alpha bias"));
            this.Fields.Add(new ShortIntegerField("value scale#used for non-integral values, i.e. health and shields"));
            this.Fields.Add(new RealField("opacity"));
            this.Fields.Add(new RealField("translucency"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RgbColorField("overcharge minimum color"));
            this.Fields.Add(new RgbColorField("overcharge maximum color"));
            this.Fields.Add(new RgbColorField("overcharge flash color"));
            this.Fields.Add(new RgbColorField("overcharge empty color"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("Health panel background", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", 1651078253));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("Health panel meter", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("meter bitmap", 1651078253));
            this.Fields.Add(new RgbColorField("color at meter minimum"));
            this.Fields.Add(new RgbColorField("color at meter maximum"));
            this.Fields.Add(new RgbColorField("flash color"));
            this.Fields.Add(new ArgbColorField("empty color"));
            this.Fields.Add(new ByteFlagsField("flags", "use min/max for state changes", "interpolate between min/max flash colors as state changes", "interpolate color along hsv space", "...more colors for hsv interpolation", "invert interpolation"));
            this.Fields.Add(new CharIntegerField("minumum meter value"));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new CharIntegerField("alpha multiplier"));
            this.Fields.Add(new CharIntegerField("alpha bias"));
            this.Fields.Add(new ShortIntegerField("value scale#used for non-integral values, i.e. health and shields"));
            this.Fields.Add(new RealField("opacity"));
            this.Fields.Add(new RealField("translucency"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new BlockField<GNullBlock>("", 0));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new RgbColorField("medium health left color"));
            this.Fields.Add(new RealField("max color health fraction cutoff"));
            this.Fields.Add(new RealField("min color health fraction cutoff"));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new ExplanationField("Motion sensor background", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", 1651078253));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ExplanationField("Motion sensor foreground", ""));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new TagReferenceField("interface bitmap", 1651078253));
            this.Fields.Add(new ArgbColorField("default color"));
            this.Fields.Add(new ArgbColorField("flashing color"));
            this.Fields.Add(new RealField("flash period"));
            this.Fields.Add(new RealField("flash delay#time between flashes"));
            this.Fields.Add(new ShortIntegerField("number of flashes"));
            this.Fields.Add(new WordFlagsField("flash flags", "reverse default/flashing colors"));
            this.Fields.Add(new RealField("flash length#time of each flash"));
            this.Fields.Add(new ArgbColorField("disabled color"));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new ShortIntegerField("sequence index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new BlockField<GlobalHudMultitextureOverlayDefinition>("multitex overlay", 30));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new ExplanationField("Motion sensor center", "The blips use this as a reference point"));
            this.Fields.Add(new Point2dField("anchor offset"));
            this.Fields.Add(new RealField("width scale"));
            this.Fields.Add(new RealField("height scale"));
            this.Fields.Add(new WordFlagsField("scaling flags", "don\'t scale offset", "don\'t scale size"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 20));
            this.Fields.Add(new ExplanationField("Auxilary overlays", ""));
            this.Fields.Add(new EnumField("anchor", "top left", "top right", "bottom left", "bottom right", "center", "crosshair"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new PadField("", 32));
            this.Fields.Add(new BlockField<UnitHudAuxilaryOverlayBlock>("overlays", 16));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("Hud warning sounds", ""));
            this.Fields.Add(new BlockField<UnitHudSoundBlock>("sounds", 12));
            this.Fields.Add(new ExplanationField("Auxilary hud meters", ""));
            this.Fields.Add(new BlockField<UnitHudAuxilaryPanelBlock>("meters", 16));
            this.Fields.Add(new ExplanationField("NEW hud", ""));
            this.Fields.Add(new TagReferenceField("new hud", 1852335220));
            this.Fields.Add(new PadField("", 356));
            this.Fields.Add(new PadField("", 48));
        }
        /// <summary>
        /// Gets and returns the name of the unit_hud_interface_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "unit_hud_interface_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the unit_hud_interface_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "unit_hud_interface";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the unit_hud_interface_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the unit_hud_interface_block tag block.
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
