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

namespace Abide.Guerilla.Tags
{
    using Abide.Guerilla.Types;
    using Abide.HaloLibrary;
    using System;
    
    [Abide.Guerilla.Tags.FieldSetAttribute(152, 4)]
    [Abide.Guerilla.Tags.TagGroupAttribute("device", 1684371049u, 1868720741u, typeof(DeviceBlock))]
    public sealed class DeviceBlock : Abide.Guerilla.Tags.IReadable, Abide.Guerilla.Tags.IWritable
    {
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int32))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int32 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("power transition time:seconds", typeof(Single))]
        public Single PowerTransitionTime;
        [Abide.Guerilla.Tags.FieldAttribute("power acceleration time:seconds", typeof(Single))]
        public Single PowerAccelerationTime;
        [Abide.Guerilla.Tags.FieldAttribute("position transition time:seconds", typeof(Single))]
        public Single PositionTransitionTime;
        [Abide.Guerilla.Tags.FieldAttribute("position acceleration time:seconds", typeof(Single))]
        public Single PositionAccelerationTime;
        [Abide.Guerilla.Tags.FieldAttribute("depowered position transition time:seconds", typeof(Single))]
        public Single DepoweredPositionTransitionTime;
        [Abide.Guerilla.Tags.FieldAttribute("depowered position acceleration time:seconds", typeof(Single))]
        public Single DepoweredPositionAccelerationTime;
        [Abide.Guerilla.Tags.FieldAttribute("lightmap flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(LightmapFlagsOptions), true)]
        public Int16 LightmapFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("open (up)", typeof(TagReference))]
        public TagReference OpenUp;
        [Abide.Guerilla.Tags.FieldAttribute("close (down)", typeof(TagReference))]
        public TagReference CloseDown;
        [Abide.Guerilla.Tags.FieldAttribute("opened", typeof(TagReference))]
        public TagReference Opened;
        [Abide.Guerilla.Tags.FieldAttribute("closed", typeof(TagReference))]
        public TagReference Closed;
        [Abide.Guerilla.Tags.FieldAttribute("depowered", typeof(TagReference))]
        public TagReference Depowered;
        [Abide.Guerilla.Tags.FieldAttribute("repowered", typeof(TagReference))]
        public TagReference Repowered;
        [Abide.Guerilla.Tags.FieldAttribute("delay time:seconds", typeof(Single))]
        public Single DelayTime;
        [Abide.Guerilla.Tags.FieldAttribute("delay effect", typeof(TagReference))]
        public TagReference DelayEffect;
        [Abide.Guerilla.Tags.FieldAttribute("automatic activation radius:world units", typeof(Single))]
        public Single AutomaticActivationRadius;
        public int Size
        {
            get
            {
                return 152;
            }
        }
        public void Initialize()
        {
        }
        public void Read(System.IO.BinaryReader reader)
        {
        }
        public void Write(System.IO.BinaryWriter writer)
        {
        }
        public enum FlagsOptions
        {
            PositionLoops = 1,
            Unused = 2,
            AllowInterpolation = 4,
        }
        public enum LightmapFlagsOptions
        {
            DontUseInLightmap = 1,
            DontUseInLightprobe = 2,
        }
    }
}
#pragma warning restore CS1591
