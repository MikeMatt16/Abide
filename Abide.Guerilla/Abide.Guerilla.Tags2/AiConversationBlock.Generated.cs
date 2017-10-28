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
    
    [Abide.Guerilla.Tags.FieldSetAttribute(116, 4)]
    public class AiConversationBlock
    {
        [Abide.Guerilla.Tags.FieldAttribute("name^", typeof(String32))]
        public String32 Name;
        [Abide.Guerilla.Tags.FieldAttribute("flags", typeof(Int16))]
        [Abide.Guerilla.Tags.OptionsAttribute(typeof(FlagsOptions), true)]
        public Int16 Flags;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(2)]
        public Byte[] EmptyString;
        [Abide.Guerilla.Tags.FieldAttribute("trigger distance:world units#distance the player must enter before the conversati" +
            "on can trigger", typeof(Single))]
        public Single TriggerDistance;
        [Abide.Guerilla.Tags.FieldAttribute("run-to-player dist:world units#if the \'involves player\' flag is set, when trigger" +
            "ed the conversation\'s participant(s) will run to within this distance of the pla" +
            "yer", typeof(Single))]
        public Single RuntoplayerDist;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(Byte[]))]
        [Abide.Guerilla.Tags.PaddingAttribute(36)]
        public Byte[] EmptyString1;
        [Abide.Guerilla.Tags.FieldAttribute("participants", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Ai Conversation Participant Block", 8, typeof(AiConversationParticipantBlock))]
        public TagBlock Participants;
        [Abide.Guerilla.Tags.FieldAttribute("lines", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("Ai Conversation Line Block", 32, typeof(AiConversationLineBlock))]
        public TagBlock Lines;
        [Abide.Guerilla.Tags.FieldAttribute("", typeof(TagBlock))]
        [Abide.Guerilla.Tags.BlockAttribute("G Null Block", 0, typeof(GNullBlock))]
        public TagBlock EmptyString2;
        public enum FlagsOptions
        {
            StopIfDeath = 1,
            StopIfDamaged = 2,
            StopIfVisibleEnemy = 4,
            StopIfAlertedToEnemy = 8,
            PlayerMustBeVisible = 16,
            StopOtherActions = 32,
            KeepTryingToPlay = 64,
            PlayerMustBeLooking = 128,
        }
    }
}
#pragma warning restore CS1591
