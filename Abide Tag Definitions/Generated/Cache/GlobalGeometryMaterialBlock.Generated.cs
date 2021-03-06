//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated global_geometry_material_block tag block.
    /// </summary>
    public sealed class GlobalGeometryMaterialBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalGeometryMaterialBlock"/> class.
        /// </summary>
        public GlobalGeometryMaterialBlock()
        {
            this.Fields.Add(new TagReferenceField("Old Shader*", 1936220516));
            this.Fields.Add(new TagReferenceField("Shader*^", 1936220516));
            this.Fields.Add(new BlockField<GlobalGeometryMaterialPropertyBlock>("Properties*", 16));
            this.Fields.Add(new PadField("", 4));
            this.Fields.Add(new CharIntegerField("Breakable Surface Index*"));
            this.Fields.Add(new PadField("", 3));
        }
        /// <summary>
        /// Gets and returns the name of the global_geometry_material_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "global_geometry_material_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the global_geometry_material_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "material";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the global_geometry_material_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the global_geometry_material_block tag block.
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
