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
    /// Represents the generated global_geometry_material_property_block tag block.
    /// </summary>
    public sealed class GlobalGeometryMaterialPropertyBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryMaterialPropertyBlock"/> class.
        /// </summary>
        public GlobalGeometryMaterialPropertyBlock()
        {
            this.Fields.Add(new EnumField("Type*", "Lightmap Resolution", "Lightmap Power", "Lightmap Half Life", "Lightmap Diffuse Scale"));
            this.Fields.Add(new ShortIntegerField("Int Value*"));
            this.Fields.Add(new RealField("Real Value*"));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_material_property_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "global_geometry_material_property_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_material_property_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material property";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_material_property_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_material_property_block tag block.
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
