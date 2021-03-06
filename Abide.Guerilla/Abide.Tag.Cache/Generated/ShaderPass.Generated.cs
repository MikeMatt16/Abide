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
    /// Represents the generated shader_pass (spas) tag group.
    /// </summary>
    public class ShaderPass : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderPass"/> class.
        /// </summary>
        public ShaderPass()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new ShaderPassBlock());
        }
        /// <summary>
        /// Gets and returns the name of the shader_pass tag group.
        /// </summary>
        public override string Name
        {
            get
            {
                return "shader_pass";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the shader_pass tag group.
        /// </summary>
        public override TagFourCc Tag
        {
            get
            {
                return "spas";
            }
        }
    }
}
