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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(20, 4)]
    public class ObjectAnimationBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("label^", typeof(StringId))]
        public StringId Label;
        [Abide.Guerilla.Tags.FieldAttribute("animation*", typeof(AnimationIndexStructBlock))]
        public AnimationIndexStructBlock Animation;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("function controls", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FunctionControlsOptions), false)]
        public Int16 FunctionControls;
        [Abide.Guerilla.Tags.FieldAttribute("function", typeof(StringId))]
        public StringId Function;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(4)]
        public Byte[] EmptyString1;
        public enum FunctionControlsOptions
        {
            Frame = 0,
            Scale = 1,
        }
    }
}
#pragma warning restore CS1591
