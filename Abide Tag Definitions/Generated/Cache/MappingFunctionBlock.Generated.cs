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
    /// Represents the generated mapping_function_block tag block.
    /// </summary>
    public sealed class MappingFunctionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingFunctionBlock"/> class.
        /// </summary>
        public MappingFunctionBlock()
        {
            this.Fields.Add(new BlockField<ByteBlock>("data", 1024));
        }
        /// <summary>
        /// Gets and returns the name of the mapping_function_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "mapping_function_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the mapping_function_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "mapping_function";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the mapping_function_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the mapping_function_block tag block.
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