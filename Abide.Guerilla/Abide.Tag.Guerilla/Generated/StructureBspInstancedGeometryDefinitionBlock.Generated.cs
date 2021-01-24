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
    /// Represents the generated structure_bsp_instanced_geometry_definition_block tag block.
    /// </summary>
    public sealed class StructureBspInstancedGeometryDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructureBspInstancedGeometryDefinitionBlock"/> class.
        /// </summary>
        public StructureBspInstancedGeometryDefinitionBlock()
        {
            this.Fields.Add(new StructField<StructureInstancedGeometryRenderInfoStructBlock>("Render Info"));
            this.Fields.Add(new LongIntegerField("Checksum*"));
            this.Fields.Add(new RealPoint3dField("Bounding Sphere Center"));
            this.Fields.Add(new RealField("Bounding Sphere Radius"));
            this.Fields.Add(new StructField<GlobalCollisionBspStructBlock>("Collision Info"));
            this.Fields.Add(new BlockField<CollisionBspPhysicsBlock>("bsp_physics*", 1024));
            this.Fields.Add(new BlockField<StructureBspLeafBlock>("Render Leaves*", 65536));
            this.Fields.Add(new BlockField<StructureBspSurfaceReferenceBlock>("Surface References*", 262144));
        }
        /// <summary>
        /// Gets and returns the name of the structure_bsp_instanced_geometry_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "structure_bsp_instanced_geometry_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the structure_bsp_instanced_geometry_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "structure_bsp_instanced_geometry_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the structure_bsp_instanced_geometry_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 512;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the structure_bsp_instanced_geometry_definition_block tag block.
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
