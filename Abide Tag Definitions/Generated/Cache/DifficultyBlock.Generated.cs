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
    /// Represents the generated difficulty_block tag block.
    /// </summary>
    public sealed class DifficultyBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DifficultyBlock"/> class.
        /// </summary>
        public DifficultyBlock()
        {
            this.Fields.Add(new ExplanationField("health", "scale values for enemy health and damage settings"));
            this.Fields.Add(new RealField("easy enemy damage#enemy damage multiplier on easy difficulty"));
            this.Fields.Add(new RealField("normal enemy damage#enemy damage multiplier on normal difficulty"));
            this.Fields.Add(new RealField("hard enemy damage#enemy damage multiplier on hard difficulty"));
            this.Fields.Add(new RealField("imposs. enemy damage#enemy damage multiplier on impossible difficulty"));
            this.Fields.Add(new RealField("easy enemy vitality#enemy maximum body vitality scale on easy difficulty"));
            this.Fields.Add(new RealField("normal enemy vitality#enemy maximum body vitality scale on normal difficulty"));
            this.Fields.Add(new RealField("hard enemy vitality#enemy maximum body vitality scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. enemy vitality#enemy maximum body vitality scale on impossible difficulty" +
                        ""));
            this.Fields.Add(new RealField("easy enemy shield#enemy maximum shield vitality scale on easy difficulty"));
            this.Fields.Add(new RealField("normal enemy shield#enemy maximum shield vitality scale on normal difficulty"));
            this.Fields.Add(new RealField("hard enemy shield#enemy maximum shield vitality scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. enemy shield#enemy maximum shield vitality scale on impossible difficulty" +
                        ""));
            this.Fields.Add(new RealField("easy enemy recharge#enemy shield recharge scale on easy difficulty"));
            this.Fields.Add(new RealField("normal enemy recharge#enemy shield recharge scale on normal difficulty"));
            this.Fields.Add(new RealField("hard enemy recharge#enemy shield recharge scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. enemy recharge#enemy shield recharge scale on impossible difficulty"));
            this.Fields.Add(new RealField("easy friend damage#friend damage multiplier on easy difficulty"));
            this.Fields.Add(new RealField("normal friend damage#friend damage multiplier on normal difficulty"));
            this.Fields.Add(new RealField("hard friend damage#friend damage multiplier on hard difficulty"));
            this.Fields.Add(new RealField("imposs. friend damage#friend damage multiplier on impossible difficulty"));
            this.Fields.Add(new RealField("easy friend vitality#friend maximum body vitality scale on easy difficulty"));
            this.Fields.Add(new RealField("normal friend vitality#friend maximum body vitality scale on normal difficulty"));
            this.Fields.Add(new RealField("hard friend vitality#friend maximum body vitality scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. friend vitality#friend maximum body vitality scale on impossible difficul" +
                        "ty"));
            this.Fields.Add(new RealField("easy friend shield#friend maximum shield vitality scale on easy difficulty"));
            this.Fields.Add(new RealField("normal friend shield#friend maximum shield vitality scale on normal difficulty"));
            this.Fields.Add(new RealField("hard friend shield#friend maximum shield vitality scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. friend shield#friend maximum shield vitality scale on impossible difficul" +
                        "ty"));
            this.Fields.Add(new RealField("easy friend recharge#friend shield recharge scale on easy difficulty"));
            this.Fields.Add(new RealField("normal friend recharge#friend shield recharge scale on normal difficulty"));
            this.Fields.Add(new RealField("hard friend recharge#friend shield recharge scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. friend recharge#friend shield recharge scale on impossible difficulty"));
            this.Fields.Add(new RealField("easy infection forms#toughness of infection forms (may be negative) on easy diffi" +
                        "culty"));
            this.Fields.Add(new RealField("normal infection forms#toughness of infection forms (may be negative) on normal d" +
                        "ifficulty"));
            this.Fields.Add(new RealField("hard infection forms#toughness of infection forms (may be negative) on hard diffi" +
                        "culty"));
            this.Fields.Add(new RealField("imposs. infection forms#toughness of infection forms (may be negative) on impossi" +
                        "ble difficulty"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("ranged fire", "difficulty-affecting values for enemy ranged combat settings"));
            this.Fields.Add(new RealField("easy rate of fire#enemy rate of fire scale on easy difficulty"));
            this.Fields.Add(new RealField("normal rate of fire#enemy rate of fire scale on normal difficulty"));
            this.Fields.Add(new RealField("hard rate of fire#enemy rate of fire scale on hard difficulty"));
            this.Fields.Add(new RealField("imposs. rate of fire#enemy rate of fire scale on impossible difficulty"));
            this.Fields.Add(new RealField("easy projectile error#enemy projectile error scale, as a fraction of their base f" +
                        "iring error. on easy difficulty"));
            this.Fields.Add(new RealField("normal projectile error#enemy projectile error scale, as a fraction of their base" +
                        " firing error. on normal difficulty"));
            this.Fields.Add(new RealField("hard projectile error#enemy projectile error scale, as a fraction of their base f" +
                        "iring error. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. projectile error#enemy projectile error scale, as a fraction of their bas" +
                        "e firing error. on impossible difficulty"));
            this.Fields.Add(new RealField("easy burst error#enemy burst error scale; reduces intra-burst shot distance. on e" +
                        "asy difficulty"));
            this.Fields.Add(new RealField("normal burst error#enemy burst error scale; reduces intra-burst shot distance. on" +
                        " normal difficulty"));
            this.Fields.Add(new RealField("hard burst error#enemy burst error scale; reduces intra-burst shot distance. on h" +
                        "ard difficulty"));
            this.Fields.Add(new RealField("imposs. burst error#enemy burst error scale; reduces intra-burst shot distance. o" +
                        "n impossible difficulty"));
            this.Fields.Add(new RealField("easy new target delay#enemy new-target delay scale factor. on easy difficulty"));
            this.Fields.Add(new RealField("normal new target delay#enemy new-target delay scale factor. on normal difficulty" +
                        ""));
            this.Fields.Add(new RealField("hard new target delay#enemy new-target delay scale factor. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. new target delay#enemy new-target delay scale factor. on impossible diffi" +
                        "culty"));
            this.Fields.Add(new RealField("easy burst separation#delay time between bursts scale factor for enemies. on easy" +
                        " difficulty"));
            this.Fields.Add(new RealField("normal burst separation#delay time between bursts scale factor for enemies. on no" +
                        "rmal difficulty"));
            this.Fields.Add(new RealField("hard burst separation#delay time between bursts scale factor for enemies. on hard" +
                        " difficulty"));
            this.Fields.Add(new RealField("imposs. burst separation#delay time between bursts scale factor for enemies. on i" +
                        "mpossible difficulty"));
            this.Fields.Add(new RealField("easy target tracking#additional target tracking fraction for enemies. on easy dif" +
                        "ficulty"));
            this.Fields.Add(new RealField("normal target tracking#additional target tracking fraction for enemies. on normal" +
                        " difficulty"));
            this.Fields.Add(new RealField("hard target tracking#additional target tracking fraction for enemies. on hard dif" +
                        "ficulty"));
            this.Fields.Add(new RealField("imposs. target tracking#additional target tracking fraction for enemies. on impos" +
                        "sible difficulty"));
            this.Fields.Add(new RealField("easy target leading#additional target leading fraction for enemies. on easy diffi" +
                        "culty"));
            this.Fields.Add(new RealField("normal target leading#additional target leading fraction for enemies. on normal d" +
                        "ifficulty"));
            this.Fields.Add(new RealField("hard target leading#additional target leading fraction for enemies. on hard diffi" +
                        "culty"));
            this.Fields.Add(new RealField("imposs. target leading#additional target leading fraction for enemies. on impossi" +
                        "ble difficulty"));
            this.Fields.Add(new RealField("easy overcharge chance#overcharge chance scale factor for enemies. on easy diffic" +
                        "ulty"));
            this.Fields.Add(new RealField("normal overcharge chance#overcharge chance scale factor for enemies. on normal di" +
                        "fficulty"));
            this.Fields.Add(new RealField("hard overcharge chance#overcharge chance scale factor for enemies. on hard diffic" +
                        "ulty"));
            this.Fields.Add(new RealField("imposs. overcharge chance#overcharge chance scale factor for enemies. on impossib" +
                        "le difficulty"));
            this.Fields.Add(new RealField("easy special fire delay#delay between special-fire shots (overcharge, banshee bom" +
                        "bs) scale factor for enemies. on easy difficulty"));
            this.Fields.Add(new RealField("normal special fire delay#delay between special-fire shots (overcharge, banshee b" +
                        "ombs) scale factor for enemies. on normal difficulty"));
            this.Fields.Add(new RealField("hard special fire delay#delay between special-fire shots (overcharge, banshee bom" +
                        "bs) scale factor for enemies. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. special fire delay#delay between special-fire shots (overcharge, banshee " +
                        "bombs) scale factor for enemies. on impossible difficulty"));
            this.Fields.Add(new RealField("easy guidance vs player#guidance velocity scale factor for all projectiles target" +
                        "ed on a player. on easy difficulty"));
            this.Fields.Add(new RealField("normal guidance vs player#guidance velocity scale factor for all projectiles targ" +
                        "eted on a player. on normal difficulty"));
            this.Fields.Add(new RealField("hard guidance vs player#guidance velocity scale factor for all projectiles target" +
                        "ed on a player. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. guidance vs player#guidance velocity scale factor for all projectiles tar" +
                        "geted on a player. on impossible difficulty"));
            this.Fields.Add(new RealField("easy melee delay base#delay period added to all melee attacks, even when berserk." +
                        " on easy difficulty"));
            this.Fields.Add(new RealField("normal melee delay base#delay period added to all melee attacks, even when berser" +
                        "k. on normal difficulty"));
            this.Fields.Add(new RealField("hard melee delay base#delay period added to all melee attacks, even when berserk." +
                        " on hard difficulty"));
            this.Fields.Add(new RealField("imposs. melee delay base#delay period added to all melee attacks, even when berse" +
                        "rk. on impossible difficulty"));
            this.Fields.Add(new RealField("easy melee delay scale#multiplier for all existing non-berserk melee delay times." +
                        " on easy difficulty"));
            this.Fields.Add(new RealField("normal melee delay scale#multiplier for all existing non-berserk melee delay time" +
                        "s. on normal difficulty"));
            this.Fields.Add(new RealField("hard melee delay scale#multiplier for all existing non-berserk melee delay times." +
                        " on hard difficulty"));
            this.Fields.Add(new RealField("imposs. melee delay scale#multiplier for all existing non-berserk melee delay tim" +
                        "es. on impossible difficulty"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("grenades", "difficulty-affecting values for enemy grenade behavior"));
            this.Fields.Add(new RealField("easy grenade chance scale#scale factor affecting the desicions to throw a grenade" +
                        ". on easy difficulty"));
            this.Fields.Add(new RealField("normal grenade chance scale#scale factor affecting the desicions to throw a grena" +
                        "de. on normal difficulty"));
            this.Fields.Add(new RealField("hard grenade chance scale#scale factor affecting the desicions to throw a grenade" +
                        ". on hard difficulty"));
            this.Fields.Add(new RealField("imposs. grenade chance scale#scale factor affecting the desicions to throw a gren" +
                        "ade. on impossible difficulty"));
            this.Fields.Add(new RealField("easy grenade timer scale#scale factor affecting the delay period between grenades" +
                        " thrown from the same encounter (lower is more often). on easy difficulty"));
            this.Fields.Add(new RealField("normal grenade timer scale#scale factor affecting the delay period between grenad" +
                        "es thrown from the same encounter (lower is more often). on normal difficulty"));
            this.Fields.Add(new RealField("hard grenade timer scale#scale factor affecting the delay period between grenades" +
                        " thrown from the same encounter (lower is more often). on hard difficulty"));
            this.Fields.Add(new RealField("imposs. grenade timer scale#scale factor affecting the delay period between grena" +
                        "des thrown from the same encounter (lower is more often). on impossible difficul" +
                        "ty"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new ExplanationField("placement", "difficulty-affecting values for enemy placement"));
            this.Fields.Add(new RealField("easy major upgrade (normal)#fraction of actors upgraded to their major variant. o" +
                        "n easy difficulty"));
            this.Fields.Add(new RealField("normal major upgrade (normal)#fraction of actors upgraded to their major variant." +
                        " on normal difficulty"));
            this.Fields.Add(new RealField("hard major upgrade (normal)#fraction of actors upgraded to their major variant. o" +
                        "n hard difficulty"));
            this.Fields.Add(new RealField("imposs. major upgrade (normal)#fraction of actors upgraded to their major variant" +
                        ". on impossible difficulty"));
            this.Fields.Add(new RealField("easy major upgrade (few)#fraction of actors upgraded to their major variant when " +
                        "mix = normal. on easy difficulty"));
            this.Fields.Add(new RealField("normal major upgrade (few)#fraction of actors upgraded to their major variant whe" +
                        "n mix = normal. on normal difficulty"));
            this.Fields.Add(new RealField("hard major upgrade (few)#fraction of actors upgraded to their major variant when " +
                        "mix = normal. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. major upgrade (few)#fraction of actors upgraded to their major variant wh" +
                        "en mix = normal. on impossible difficulty"));
            this.Fields.Add(new RealField("easy major upgrade (many)#fraction of actors upgraded to their major variant when" +
                        " mix = many. on easy difficulty"));
            this.Fields.Add(new RealField("normal major upgrade (many)#fraction of actors upgraded to their major variant wh" +
                        "en mix = many. on normal difficulty"));
            this.Fields.Add(new RealField("hard major upgrade (many)#fraction of actors upgraded to their major variant when" +
                        " mix = many. on hard difficulty"));
            this.Fields.Add(new RealField("imposs. major upgrade (many)#fraction of actors upgraded to their major variant w" +
                        "hen mix = many. on impossible difficulty"));
            this.Fields.Add(new ExplanationField("vehicles", "difficulty-affecting values for vehicle driving/combat"));
            this.Fields.Add(new RealField("easy player vehicle ram chance#Chance of deciding to ram the player in a vehicle " +
                        "on easy difficulty"));
            this.Fields.Add(new RealField("normal player vehicle ram chance#Chance of deciding to ram the player in a vehicl" +
                        "e on normal difficulty"));
            this.Fields.Add(new RealField("hard player vehicle ram chance#Chance of deciding to ram the player in a vehicle " +
                        "on hard difficulty"));
            this.Fields.Add(new RealField("imposs. player vehicle ram chance#Chance of deciding to ram the player in a vehic" +
                        "le on impossible difficulty"));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 16));
            this.Fields.Add(new PadField("", 84));
        }
        /// <summary>
        /// Gets and returns the name of the difficulty_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "difficulty_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the difficulty_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "difficulty_block";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the difficulty_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the difficulty_block tag block.
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
