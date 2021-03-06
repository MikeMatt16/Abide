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
    /// Represents the generated materials_block tag block.
    /// </summary>
    public sealed class MaterialsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialsBlock"/> class.
        /// </summary>
        public MaterialsBlock()
        {
            this.Fields.Add(new StringIdField("name^"));
            this.Fields.Add(new StringIdField("parent name"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new WordFlagsField("flags", "flammable", "biomass"));
            this.Fields.Add(new EnumField("old material type", "dirt", "sand", "stone", "snow", "wood", "metal (hollow)", "metal (thin)", "metal (thick)", "rubber", "glass", "force field", "grunt", "hunter armor", "hunter skin", "elite", "jackal", "jackal energy shield", "engineer skin", "engineer force field", "flood combat form", "flood carrier form", "cyborg armor", "cyborg energy shield", "human armor", "human skin", "sentinel", "monitor", "plastic", "water", "leaves", "elite energy shield", "ice", "hunter shield"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new StringIdField("general armor"));
            this.Fields.Add(new StringIdField("specific armor"));
            this.Fields.Add(new StructField<MaterialPhysicsPropertiesStructBlock>("physics properties"));
            this.Fields.Add(new TagReferenceField("old material physics", 1836082292));
            this.Fields.Add(new TagReferenceField("breakable surface", 1651729524));
            this.Fields.Add(new StructField<MaterialsSweetenersStructBlock>("sweeteners"));
            this.Fields.Add(new TagReferenceField("material effects", 1718579060));
        }
        /// <summary>
        /// Gets and returns the name of the materials_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "materials_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the materials_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "materials_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the materials_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 256;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the materials_block tag block.
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
