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
    /// Represents the generated structure_bsp_environment_object_block tag block.
    /// </summary>
    public sealed class StructureBspEnvironmentObjectBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspEnvironmentObjectBlock"/> class.
        /// </summary>
        public StructureBspEnvironmentObjectBlock()
        {
            this.Fields.Add(new StringField("Name^"));
            this.Fields.Add(new QuaternionField("Rotation"));
            this.Fields.Add(new RealPoint3dField("Translation"));
            this.Fields.Add(new ShortBlockIndexField("palette_index"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new LongIntegerField("Unique ID*"));
            this.Fields.Add(new TagField("Exported Object Type"));
            this.Fields.Add(new StringField("Scenario Object Name"));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_environment_object_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_environment_object_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_environment_object_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_environment_object_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_environment_object_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16384;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_environment_object_block tag block.
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
