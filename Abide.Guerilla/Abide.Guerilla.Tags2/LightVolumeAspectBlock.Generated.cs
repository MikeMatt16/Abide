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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(36, 4)]
    public class LightVolumeAspectBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("along axis", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock AlongAxis;
        [Abide.Guerilla.Tags.FieldAttribute("away from axis", typeof(ScalarFunctionStructBlock))]
        public ScalarFunctionStructBlock AwayFromAxis;
        [Abide.Guerilla.Tags.FieldAttribute("parallel scale", typeof(Single))]
        public Single ParallelScale1;
        [Abide.Guerilla.Tags.FieldAttribute("parallel threshold angle:degrees", typeof(Single))]
        public Single ParallelThresholdAngle;
        [Abide.Guerilla.Tags.FieldAttribute("parallel exponent", typeof(Single))]
        public Single ParallelExponent;
    }
}
#pragma warning restore CS1591