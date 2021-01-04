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
    /// Represents the generated polyhedron_four_vectors_block tag block.
    /// </summary>
    public sealed class PolyhedronFourVectorsBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolyhedronFourVectorsBlock"/> class.
        /// </summary>
        public PolyhedronFourVectorsBlock()
        {
            this.Fields.Add(new RealVector3dField("four vectors x*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("four vectors y*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("four vectors z*"));
            this.Fields.Add(new SkipField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the polyhedron_four_vectors_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "polyhedron_four_vectors_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the polyhedron_four_vectors_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "polyhedron_four_vectors_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the polyhedron_four_vectors_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 4096;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the polyhedron_four_vectors_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
    }
}
