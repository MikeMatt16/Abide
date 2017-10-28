#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Guerilla.Tags2
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(32, 4)]
    public class AnimationGraphNodeBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(StringId))]
        public StringId Name;
        [Abide.Guerilla.Tags.FieldAttribute("next sibling node index*", typeof(Int16))]
        public Int16 NextSiblingNodeIndex;
        [Abide.Guerilla.Tags.FieldAttribute("first child node index*", typeof(Int16))]
        public Int16 FirstChildNodeIndex;
        [Abide.Guerilla.Tags.FieldAttribute("parent node index*", typeof(Int16))]
        public Int16 ParentNodeIndex;
        [Abide.Guerilla.Tags.FieldAttribute("model flags*", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(ModelFlags), true)]
        public Byte ModelFlags1;
        [Abide.Guerilla.Tags.FieldAttribute("node joint flags", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(NodeJointFlagsOptions), true)]
        public Byte NodeJointFlags;
        [Abide.Guerilla.Tags.FieldAttribute("base vector*", typeof(Vector3))]
        public Vector3 BaseVector;
        [Abide.Guerilla.Tags.FieldAttribute("vector range*", typeof(Single))]
        public Single VectorRange;
        [Abide.Guerilla.Tags.FieldAttribute("z_pos*", typeof(Single))]
        public Single ZPos;
        public enum ModelFlags
        {
            PrimaryModel = 1,
            SecondaryModel = 2,
            LocalRoot = 4,
            LeftHand = 8,
            RightHand = 16,
            LeftArmMember = 32,
        }
        public enum NodeJointFlagsOptions
        {
            Ballsocket = 1,
            Hinge = 2,
            NoMovement = 4,
        }
    }
}
#pragma warning restore CS1591
