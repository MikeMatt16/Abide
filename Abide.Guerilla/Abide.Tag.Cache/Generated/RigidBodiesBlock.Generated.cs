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
    /// Represents the generated rigid_bodies_block tag block.
    /// </summary>
    public sealed class RigidBodiesBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RigidBodiesBlock"/> class.
        /// </summary>
        public RigidBodiesBlock()
        {
            this.Fields.Add(new ShortBlockIndexField("node*"));
            this.Fields.Add(new ShortBlockIndexField("region*"));
            this.Fields.Add(new ShortBlockIndexField("permutattion*"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new RealPoint3dField("bouding sphere offset*"));
            this.Fields.Add(new RealField("bounding sphere radius*"));
            this.Fields.Add(new WordFlagsField("flags", "no collisions w/self", "only collide w/env", "disable effects#this rigid body will not generate impact effects unless it hits a" +
                        "nother dynamic rigid body that does", "does not interact w/environment#set this flag if this rigid bodies won\'t touch th" +
                        "e environment, this allows us to open up some optimizations", "best early mover body:-)# if you have either of the early mover flags set in the " +
                        "object definitoin this body will be choosen as the one to make every thing local" +
                        " to, otherwise I pick ", "has no phantom power version#don\'t check this flag without talking to eamon"));
            this.Fields.Add(new EnumField("motion type", "sphere", "stabilized sphere", "box", "stabilized box", "keyframed", "fixed"));
            this.Fields.Add(new ShortBlockIndexField("no phantom power alt"));
            this.Fields.Add(new EnumField("size", "default", "tiny", "small", "medium", "large", "huge", "extra huge"));
            this.Fields.Add(new RealField("inertia tensor scale#0.0 defaults to 1.0"));
            this.Fields.Add(new RealField("linear damping#this goes from 0-10 (10 is really, really high)"));
            this.Fields.Add(new RealField("angular damping#this goes from 0-10 (10 is really, really high)"));
            this.Fields.Add(new RealVector3dField("center off mass offset"));
            this.Fields.Add(new EnumField("shape type*", "sphere", "pill", "box", "triangle", "polyhedron", "multi sphere", "unused 0", "unused 1", "unused 2", "unused 3", "unused 4", "unused 5", "unused 6", "unused 7", "list", "mopp"));
            this.Fields.Add(new ShortBlockIndexField("shape*"));
            this.Fields.Add(new RealField("mass*:kg"));
            this.Fields.Add(new RealVector3dField("center of mass*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("intertia tensor x*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("intertia tensor y*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealVector3dField("intertia tensor z*"));
            this.Fields.Add(new SkipField("", 4));
            this.Fields.Add(new RealField("bounding sphere pad#the bounding sphere for this rigid body will be outset by thi" +
                        "s much"));
            this.Fields.Add(new PadField("", 12));
        }
        /// <summary>
        /// Gets and returns the name of the rigid_bodies_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "rigid_bodies_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the rigid_bodies_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "rigid_bodies_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the rigid_bodies_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 64;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the rigid_bodies_block tag block.
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
