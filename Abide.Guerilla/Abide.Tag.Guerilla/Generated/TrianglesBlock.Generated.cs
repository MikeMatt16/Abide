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
    /// Represents the generated triangles_block tag block.
    /// </summary>
    public sealed class TrianglesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglesBlock"/> class.
        /// </summary>
        public TrianglesBlock()
        {
            this.Fields.Add(new StringIdField("name*^"));
            this.Fields.Add(new ShortBlockIndexField("material*"));
            this.Fields.Add(new WordFlagsField("flags", "unused"));
            this.Fields.Add(new RealField("relative mass scale"));
            this.Fields.Add(new RealFractionField("friction"));
            this.Fields.Add(new RealFractionField("restitution"));
            this.Fields.Add(new RealField("volume *"));
            this.Fields.Add(new RealField("mass*"));
            this.Fields.Add(new SkipField("", 2));
            this.Fields.Add(new ShortBlockIndexField("phantom*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new ShortIntegerField("size*"));
            this.Fields.Add(new ShortIntegerField("count*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealField("radius*"));
            this.Fields.Add(new RealVector3dField("point a*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("point b*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("point c*"));
            this.Fields.Add(new SkipField("", 4));
        }
        /// <summary>
        /// Gets and returns the name of the triangles_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "triangles_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the triangles_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "triangles_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the triangles_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1024;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the triangles_block tag block.
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
