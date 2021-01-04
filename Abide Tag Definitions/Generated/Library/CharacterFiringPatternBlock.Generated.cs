//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.HaloLibrary.Halo2.Retail.Tag.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.HaloLibrary.Halo2.Retail.Tag;
    
    /// <summary>
    /// Represents the generated character_firing_pattern_block tag block.
    /// </summary>
    public sealed class CharacterFiringPatternBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterFiringPatternBlock"/> class.
        /// </summary>
        public CharacterFiringPatternBlock()
        {
            this.Fields.Add(new RealField("rate of fire#how many times per second we pull the trigger (zero = continuously h" +
                        "eld down)"));
            this.Fields.Add(new RealField("target tracking:[0,1]#how well our bursts track moving targets. 0.0= fire at the " +
                        "position they were standing when we started the burst. 1.0= fire at current posi" +
                        "tion"));
            this.Fields.Add(new RealField("target leading:[0,1]#how much we lead moving targets. 0.0= no prediction. 1.0= pr" +
                        "edict completely."));
            this.Fields.Add(new ExplanationField("burst geometry", @"at the start of every burst we pick a random point near the target to fire at, on either the left or the right side.
the burst origin angle controls whether this error is exactly horizontal or might have some vertical component.

over the course of the burst we move our projectiles back in the opposite direction towards the target. this return motion is also controlled by an angle that specifies how close to the horizontal it is.

for example if the burst origin angle and the burst return angle were both zero, and the return length was the same as the burst length, every burst would start the same amount away from the target (on either the left or right) and move back to exactly over the target at the end of the burst."));
            this.Fields.Add(new RealField("burst origin radius:world units#how far away from the target the starting point i" +
                        "s"));
            this.Fields.Add(new AngleField("burst origin angle:degrees#the range from the horizontal that our starting error " +
                        "can be"));
            this.Fields.Add(new RealBoundsField("burst return length:world units#how far the burst point moves back towards the ta" +
                        "rget (could be negative)"));
            this.Fields.Add(new AngleField("burst return angle:degrees#the range from the horizontal that the return directio" +
                        "n can be"));
            this.Fields.Add(new RealBoundsField("burst duration:seconds#how long each burst we fire is"));
            this.Fields.Add(new RealBoundsField("burst separation:seconds#how long we wait between bursts"));
            this.Fields.Add(new RealField("weapon damage modifier#what fraction of its normal damage our weapon inflicts (ze" +
                        "ro = no modifier)"));
            this.Fields.Add(new AngleField("projectile error:degrees#error added to every projectile we fire"));
            this.Fields.Add(new AngleField("burst angular velocity:degrees per second#the maximum rate at which we can sweep " +
                        "our fire (zero = unlimited)"));
            this.Fields.Add(new AngleField("maximum error angle:degrees#cap on the maximum angle by which we will miss target" +
                        " (restriction on burst origin radius"));
        }
        /// <summary>
        /// Gets and returns the name of the character_firing_pattern_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "character_firing_pattern_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the character_firing_pattern_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "character_firing_pattern_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the character_firing_pattern_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the character_firing_pattern_block tag block.
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
