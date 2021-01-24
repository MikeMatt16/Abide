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
    /// Represents the generated look_function_block tag block.
    /// </summary>
    public sealed class LookFunctionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookFunctionBlock"/> class.
        /// </summary>
        public LookFunctionBlock()
        {
            this.Fields.Add(new RealField("scale"));
        }
        /// <summary>
        /// Gets and returns the name of the look_function_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "look_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the look_function_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "look_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the look_function_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 16;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the look_function_block tag block.
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
