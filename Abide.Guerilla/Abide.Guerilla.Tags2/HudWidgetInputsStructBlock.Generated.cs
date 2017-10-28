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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(4, 4)]
    public class HudWidgetInputsStructBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("input 1", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Input1Options), false)]
        public Byte Input1;
        [Abide.Guerilla.Tags.FieldAttribute("input 2", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Input2Options), false)]
        public Byte Input2;
        [Abide.Guerilla.Tags.FieldAttribute("input 3", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Input3Options), false)]
        public Byte Input3;
        [Abide.Guerilla.Tags.FieldAttribute("input 4", typeof(Byte))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(Input4Options), false)]
        public Byte Input4;
        public enum Input1Options
        {
            BasicZero = 0,
            BasicOne = 1,
            BasicTime = 2,
            BasicGlobalHudFade = 3,
            EmptyString = 4,
            EmptyString1 = 5,
            EmptyString2 = 6,
            EmptyString3 = 7,
            EmptyString4 = 8,
            EmptyString5 = 9,
            EmptyString6 = 10,
            EmptyString7 = 11,
            EmptyString8 = 12,
            EmptyString9 = 13,
            EmptyString10 = 14,
            EmptyString11 = 15,
            UnitShield = 16,
            UnitBody = 17,
            UnitAutoaimed = 18,
            UnitHasNoGrenades = 19,
            UnitFragGrenCnt = 20,
            UnitPlasmaGrenCnt = 21,
            UnitTimeOnDplShld = 22,
            UnitZoomFraction = 23,
            UnitCamoValue = 24,
            EmptyString12 = 25,
            EmptyString13 = 26,
            EmptyString14 = 27,
            EmptyString15 = 28,
            EmptyString16 = 29,
            EmptyString17 = 30,
            EmptyString18 = 31,
            ParentShield = 32,
            ParentBody = 33,
            EmptyString19 = 34,
            EmptyString20 = 35,
            EmptyString21 = 36,
            EmptyString22 = 37,
            EmptyString23 = 38,
            EmptyString24 = 39,
            EmptyString25 = 40,
            EmptyString26 = 41,
            EmptyString27 = 42,
            EmptyString28 = 43,
            EmptyString29 = 44,
            EmptyString30 = 45,
            EmptyString31 = 46,
            EmptyString32 = 47,
            WeaponClipAmmo = 48,
            WeaponHeat = 49,
            WeaponBattery = 50,
            WeaponTotalAmmo = 51,
            WeaponBarrelSpin = 52,
            WeaponOverheated = 53,
            WeaponClipAmmoFraction = 54,
            WeaponTimeOnOverheat = 55,
            WeaponBatteryFraction = 56,
            WeaponLockingFraction = 57,
            EmptyString33 = 58,
            EmptyString34 = 59,
            EmptyString35 = 60,
            EmptyString36 = 61,
            EmptyString37 = 62,
            EmptyString38 = 63,
            EmptyString39 = 64,
            UserScoreFraction = 65,
            OtherUserScoreFraction = 66,
            UserWinning = 67,
            BombArmingAmount = 68,
            EmptyString40 = 69,
            EmptyString41 = 70,
            EmptyString42 = 71,
            EmptyString43 = 72,
            EmptyString44 = 73,
            EmptyString45 = 74,
            EmptyString46 = 75,
            EmptyString47 = 76,
            EmptyString48 = 77,
            EmptyString49 = 78,
            EmptyString50 = 79,
            EmptyString51 = 80,
        }
        public enum Input2Options
        {
            BasicZero = 0,
            BasicOne = 1,
            BasicTime = 2,
            BasicGlobalHudFade = 3,
            EmptyString = 4,
            EmptyString1 = 5,
            EmptyString2 = 6,
            EmptyString3 = 7,
            EmptyString4 = 8,
            EmptyString5 = 9,
            EmptyString6 = 10,
            EmptyString7 = 11,
            EmptyString8 = 12,
            EmptyString9 = 13,
            EmptyString10 = 14,
            EmptyString11 = 15,
            UnitShield = 16,
            UnitBody = 17,
            UnitAutoaimed = 18,
            UnitHasNoGrenades = 19,
            UnitFragGrenCnt = 20,
            UnitPlasmaGrenCnt = 21,
            UnitTimeOnDplShld = 22,
            UnitZoomFraction = 23,
            UnitCamoValue = 24,
            EmptyString12 = 25,
            EmptyString13 = 26,
            EmptyString14 = 27,
            EmptyString15 = 28,
            EmptyString16 = 29,
            EmptyString17 = 30,
            EmptyString18 = 31,
            ParentShield = 32,
            ParentBody = 33,
            EmptyString19 = 34,
            EmptyString20 = 35,
            EmptyString21 = 36,
            EmptyString22 = 37,
            EmptyString23 = 38,
            EmptyString24 = 39,
            EmptyString25 = 40,
            EmptyString26 = 41,
            EmptyString27 = 42,
            EmptyString28 = 43,
            EmptyString29 = 44,
            EmptyString30 = 45,
            EmptyString31 = 46,
            EmptyString32 = 47,
            WeaponClipAmmo = 48,
            WeaponHeat = 49,
            WeaponBattery = 50,
            WeaponTotalAmmo = 51,
            WeaponBarrelSpin = 52,
            WeaponOverheated = 53,
            WeaponClipAmmoFraction = 54,
            WeaponTimeOnOverheat = 55,
            WeaponBatteryFraction = 56,
            WeaponLockingFraction = 57,
            EmptyString33 = 58,
            EmptyString34 = 59,
            EmptyString35 = 60,
            EmptyString36 = 61,
            EmptyString37 = 62,
            EmptyString38 = 63,
            EmptyString39 = 64,
            UserScoreFraction = 65,
            OtherUserScoreFraction = 66,
            UserWinning = 67,
            BombArmingAmount = 68,
            EmptyString40 = 69,
            EmptyString41 = 70,
            EmptyString42 = 71,
            EmptyString43 = 72,
            EmptyString44 = 73,
            EmptyString45 = 74,
            EmptyString46 = 75,
            EmptyString47 = 76,
            EmptyString48 = 77,
            EmptyString49 = 78,
            EmptyString50 = 79,
            EmptyString51 = 80,
        }
        public enum Input3Options
        {
            BasicZero = 0,
            BasicOne = 1,
            BasicTime = 2,
            BasicGlobalHudFade = 3,
            EmptyString = 4,
            EmptyString1 = 5,
            EmptyString2 = 6,
            EmptyString3 = 7,
            EmptyString4 = 8,
            EmptyString5 = 9,
            EmptyString6 = 10,
            EmptyString7 = 11,
            EmptyString8 = 12,
            EmptyString9 = 13,
            EmptyString10 = 14,
            EmptyString11 = 15,
            UnitShield = 16,
            UnitBody = 17,
            UnitAutoaimed = 18,
            UnitHasNoGrenades = 19,
            UnitFragGrenCnt = 20,
            UnitPlasmaGrenCnt = 21,
            UnitTimeOnDplShld = 22,
            UnitZoomFraction = 23,
            UnitCamoValue = 24,
            EmptyString12 = 25,
            EmptyString13 = 26,
            EmptyString14 = 27,
            EmptyString15 = 28,
            EmptyString16 = 29,
            EmptyString17 = 30,
            EmptyString18 = 31,
            ParentShield = 32,
            ParentBody = 33,
            EmptyString19 = 34,
            EmptyString20 = 35,
            EmptyString21 = 36,
            EmptyString22 = 37,
            EmptyString23 = 38,
            EmptyString24 = 39,
            EmptyString25 = 40,
            EmptyString26 = 41,
            EmptyString27 = 42,
            EmptyString28 = 43,
            EmptyString29 = 44,
            EmptyString30 = 45,
            EmptyString31 = 46,
            EmptyString32 = 47,
            WeaponClipAmmo = 48,
            WeaponHeat = 49,
            WeaponBattery = 50,
            WeaponTotalAmmo = 51,
            WeaponBarrelSpin = 52,
            WeaponOverheated = 53,
            WeaponClipAmmoFraction = 54,
            WeaponTimeOnOverheat = 55,
            WeaponBatteryFraction = 56,
            WeaponLockingFraction = 57,
            EmptyString33 = 58,
            EmptyString34 = 59,
            EmptyString35 = 60,
            EmptyString36 = 61,
            EmptyString37 = 62,
            EmptyString38 = 63,
            EmptyString39 = 64,
            UserScoreFraction = 65,
            OtherUserScoreFraction = 66,
            UserWinning = 67,
            BombArmingAmount = 68,
            EmptyString40 = 69,
            EmptyString41 = 70,
            EmptyString42 = 71,
            EmptyString43 = 72,
            EmptyString44 = 73,
            EmptyString45 = 74,
            EmptyString46 = 75,
            EmptyString47 = 76,
            EmptyString48 = 77,
            EmptyString49 = 78,
            EmptyString50 = 79,
            EmptyString51 = 80,
        }
        public enum Input4Options
        {
            BasicZero = 0,
            BasicOne = 1,
            BasicTime = 2,
            BasicGlobalHudFade = 3,
            EmptyString = 4,
            EmptyString1 = 5,
            EmptyString2 = 6,
            EmptyString3 = 7,
            EmptyString4 = 8,
            EmptyString5 = 9,
            EmptyString6 = 10,
            EmptyString7 = 11,
            EmptyString8 = 12,
            EmptyString9 = 13,
            EmptyString10 = 14,
            EmptyString11 = 15,
            UnitShield = 16,
            UnitBody = 17,
            UnitAutoaimed = 18,
            UnitHasNoGrenades = 19,
            UnitFragGrenCnt = 20,
            UnitPlasmaGrenCnt = 21,
            UnitTimeOnDplShld = 22,
            UnitZoomFraction = 23,
            UnitCamoValue = 24,
            EmptyString12 = 25,
            EmptyString13 = 26,
            EmptyString14 = 27,
            EmptyString15 = 28,
            EmptyString16 = 29,
            EmptyString17 = 30,
            EmptyString18 = 31,
            ParentShield = 32,
            ParentBody = 33,
            EmptyString19 = 34,
            EmptyString20 = 35,
            EmptyString21 = 36,
            EmptyString22 = 37,
            EmptyString23 = 38,
            EmptyString24 = 39,
            EmptyString25 = 40,
            EmptyString26 = 41,
            EmptyString27 = 42,
            EmptyString28 = 43,
            EmptyString29 = 44,
            EmptyString30 = 45,
            EmptyString31 = 46,
            EmptyString32 = 47,
            WeaponClipAmmo = 48,
            WeaponHeat = 49,
            WeaponBattery = 50,
            WeaponTotalAmmo = 51,
            WeaponBarrelSpin = 52,
            WeaponOverheated = 53,
            WeaponClipAmmoFraction = 54,
            WeaponTimeOnOverheat = 55,
            WeaponBatteryFraction = 56,
            WeaponLockingFraction = 57,
            EmptyString33 = 58,
            EmptyString34 = 59,
            EmptyString35 = 60,
            EmptyString36 = 61,
            EmptyString37 = 62,
            EmptyString38 = 63,
            EmptyString39 = 64,
            UserScoreFraction = 65,
            OtherUserScoreFraction = 66,
            UserWinning = 67,
            BombArmingAmount = 68,
            EmptyString40 = 69,
            EmptyString41 = 70,
            EmptyString42 = 71,
            EmptyString43 = 72,
            EmptyString44 = 73,
            EmptyString45 = 74,
            EmptyString46 = 75,
            EmptyString47 = 76,
            EmptyString48 = 77,
            EmptyString49 = 78,
            EmptyString50 = 79,
            EmptyString51 = 80,
        }
    }
}
#pragma warning restore CS1591
