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
    /// Represents the generated weather_system (weat) tag group.
    /// </summary>
    public class WeatherSystem : Group
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherSystem"/> class.
        /// </summary>
        public WeatherSystem()
        {
            // Add tag block to list.
            this.TagBlocks.Add(new WeatherSystemBlock());
        }
        /// <summary>
        /// Gets and returns the name of the weather_system tag group.
        /// </summary>
        public override string GroupName
        {
            get
            {
                return "weather_system";
            }
        }
        /// <summary>
        /// Gets and returns the group tag of the weather_system tag group.
        /// </summary>
        public override TagFourCc GroupTag
        {
            get
            {
                return "weat";
            }
        }
    }
}
