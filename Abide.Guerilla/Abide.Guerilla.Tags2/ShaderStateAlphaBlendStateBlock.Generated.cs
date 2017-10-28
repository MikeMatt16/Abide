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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(16, 4)]
    public class ShaderStateAlphaBlendStateBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("blend function", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(BlendFunctionOptions), false)]
        public Int16 BlendFunction;
        [Abide.Guerilla.Tags.FieldAttribute("blend src factor", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(BlendSrcFactorOptions), false)]
        public Int16 BlendSrcFactor;
        [Abide.Guerilla.Tags.FieldAttribute("blend dst factor", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(BlendDstFactorOptions), false)]
        public Int16 BlendDstFactor;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("blend color", typeof(ColorArgb))]
        public ColorArgb BlendColor;
        [Abide.Guerilla.Tags.FieldAttribute("logic-op flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(LogicopFlagsOptions), true)]
        public Int16 LogicopFlags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString1;
        public enum BlendFunctionOptions
        {
            Add = 0,
            Subtract = 1,
            ReverseSubtract = 2,
            Min = 3,
            Max = 4,
            AddSigned = 5,
            ReverseSubtractSigned = 6,
            Logicop = 7,
        }
        public enum BlendSrcFactorOptions
        {
            Zero = 0,
            One = 1,
            Srccolor = 2,
            SrccolorInverse = 3,
            Srcalpha = 4,
            SrcalphaInverse = 5,
            Dstcolor = 6,
            DstcolorInverse = 7,
            Dstalpha = 8,
            DstalphaInverse = 9,
            SrcalphaSaturate = 10,
            ConstantColor = 11,
            ConstantColorInverse = 12,
            ConstantAlpha = 13,
            ConstantAlphaInverse = 14,
        }
        public enum BlendDstFactorOptions
        {
            Zero = 0,
            One = 1,
            Srccolor = 2,
            SrccolorInverse = 3,
            Srcalpha = 4,
            SrcalphaInverse = 5,
            Dstcolor = 6,
            DstcolorInverse = 7,
            Dstalpha = 8,
            DstalphaInverse = 9,
            SrcalphaSaturate = 10,
            ConstantColor = 11,
            ConstantColorInverse = 12,
            ConstantAlpha = 13,
            ConstantAlphaInverse = 14,
        }
        public enum LogicopFlagsOptions
        {
            SrcEquals0DstEquals0 = 1,
            SrcEquals0DstEquals1 = 2,
            SrcEquals1DstEquals0 = 4,
            SrcEquals1DstEquals1 = 8,
        }
    }
}
#pragma warning restore CS1591
