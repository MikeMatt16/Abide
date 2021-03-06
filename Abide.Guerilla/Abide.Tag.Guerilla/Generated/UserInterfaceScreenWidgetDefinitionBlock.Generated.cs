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
    /// Represents the generated user_interface_screen_widget_definition_block tag block.
    /// </summary>
    public sealed class UserInterfaceScreenWidgetDefinitionBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInterfaceScreenWidgetDefinitionBlock"/> class.
        /// </summary>
        public UserInterfaceScreenWidgetDefinitionBlock()
        {
            this.Fields.Add(new ExplanationField("Notes on screen widgets", @"- the widget coordinate system is a left-handed system (+x to the right, +y up, +z into the screen)
  with the origin centered in the display (regardless of display size)
- for widget component placement, all coordinates you define in the tag specifiy the object's
  placement prior to the application of any animation
- all coordinates you define are local to that object
- all text specific to objects in the screen comes from the screen's string list tag
  all of the string indices you may need to specify will refer to the screen's string list tag
- a pane may contain either buttons OR a list OR a table-view, but never a combination of those
  (widget won't function correctly if you try that)
- all text is centered unless you specify otherwise"));
            this.Fields.Add(new ExplanationField("Flags", "Set misc. screen behavior here"));
            this.Fields.Add(new LongFlagsField("flags", "1/4 screen dialog", "multiple panes are for list flavor items", "no header text", "1/2 screen dialog", "large dialog", "disable overlay effect"));
            this.Fields.Add(new EnumField("screen ID", "Test #1", "Test #2", "Test #3", "Test #4", "Test #5", "Game Shell Background", "Main Menu", "Error Dialog OK Cancel", "Error Dialog OK", "Press Start Intro", "Player Profile Select", "SP Level Select", "SP Difficulty Select", "Network Squad Browser", "MP Pregame Lobby", "Custom Game Menu", "Postgame Stats", "MP Map Select", "SP Pause Game", "Settings", "Gamertag Select", "Gamertag Passcode Entry", "Multiplayer Protocol", "Squad Settings", "Squad Game Settings", "Squad Privacy Settings", "Y Menu-Gameshell", "Y Menu-Gameshell Collapsed", "Y Menu-InGame", "Y Menu-InGame Collapsed", "4way join screen", "Y Menu-Player Selected Options", "Player Selected Options", "Confirmation Dialog", "Live Feedback Menu Dialog", "Live Message Type Dialog", "Voice Msg Dialog", "Stereo Faceplate", "Player Profile Edit Menu", "PP Controller Settings", "PP Button Settings", "PP Thumbstick Settings", "PP Look Sensitivity Settings", "PP Invert Look Settings", "PP Autolevel Settings", "PP Handicap Settings", "PP High Score Rec Settings", "PP Multiplayer Settings Menu", "PP Profile Delete Confirmation Dlg", "PP Choose Foreground Emblem", "PP Choose Primary Color", "PP Choose Secondary Color", "PP Choose Model", "PP Voice Settings Menu", "PP Choose Voice Mask", "PP Voice thru TV", "PP Edit Rotation List", "PP XBL Status Menu", "PP Appear Offline", "PP Auto-Offline", "Game Engine Category Listing", "Edit Slayer Menu", "Edit KOTH Menu", "Edit Race Menu", "Edit Oddball Menu", "Edit Juggernaut Menu", "Edit Headhunter Menu", "Edit CTF Menu", "Edit Assault Menu", "Edit Slayer Score to Win", "Edit Slayer Time Limit", "Edit Slayer Teams", "Edit Slayer Score 4 Killing", "Edit Slayer Kill in Order", "Edit Slayer Death Pt Loss", "Edit Slayer Suicide Pt Loss", "Edit Slayer Dmg After Kill", "Edit Slayer Dmg After Death", "Edit Slayer Speed After Kill", "Edit Slayer Speed After Death", "Edit KOTH Score to Win", "Edit KOTH Time Limit", "Edit KOTH Teams", "Edit KOTH Moving Hills", "Edit KOTH Uncontesed Control", "Edit KOTH Xtra Dmg", "Edit Race Laps to Win", "Edit Race Time Limit", "Edit Race Teams", "Edit Race Team Scoring", "Edit Race Type", "Edit Race Flag Order", "Edit Race Game End Condition", "Edit Race Dmg with Laps", "Edit Race Speed with Laps", "Edit Oddball Time to Win", "Edit Oddball Time Limit", "Edit Oddball Teams", "Edit Oddball Ball Spawn Count", "Edit Oddball Ball Waypoints", "Edit Oddball Damage with Ball", "Edit Oddball Speed with Ball", "Edit Oddball Invisibility with Ball", "Edit Jug Score to Win", "Edit Jug Time Limit", "Edit Jug Pts for Killing Jugger", "Edit Jug Count", "Edit Jug Species", "Edit Jug Starting Equip", "Edit Jug Damage", "Edit Jug Health", "Edit Jug Speed", "Edit Jug Regeneration", "Edit Jug Waypoints", "Edit HH Score to Win", "Edit HH Time Limit", "Edit HH Teams", "Edit HH Death Pt Loss", "Edit HH Suicide Pt Loss", "Edit HH Speed with Token", "Edit HH Dropped Token Lifetime", "Edit HH Score Multiplier", "Edit CTF Score to Win", "Edit CTF Time Limit", "Edit CTF Tie Resolution", "Edit CTF Single Flag", "Edit CTF Role Swapping", "Edit CTF Flag at Home to Score", "Edit CTF Flag Must Reset", "Edit CTF Dmg with Flag", "Edit CTF Speed with Flag", "Edit Assault Score to Win", "Edit Assault Time Limit", "Edit Assault Tie Resolution", "Edit Assault Single Flag", "Edit Assault Role Swapping", "Edit Assault Enemy Flag at Home to Score", "Edit Assault Flag Must Reset", "Edit Assault Dmg with Flag", "Edit Assault Speed with Flag", "Edit Player Number of Lives", "Edit Player Max Health", "Edit Player Shields", "Edit Player Respawn Time", "Edit Player Count", "Edit Player Invisibility", "Edit Player Suicide Penalty", "Edit Player Friendly Fire", "Edit Item Respawn Grenades", "Edit Item Powerups", "Edit Item Weapon Set", "Edit Item Starting Equipment", "Edit Item Warthogs", "Edit Item Ghosts", "Edit Item Scorpions", "Edit Item Banshees", "Edit Item Mongeese", "Edit Item Shadows", "Edit Item Wraiths", "Edit Indicator Objectives", "Edit Indicator Players on Motion Sensor", "Edit Indicator Invisible Players on Motion Sensor", "Edit Indicator Friends", "Edit Indicator Enemies", "Edit Player Options", "Edit Item Options", "Edit Indicator Options", "Virtual Keyboard", "Custom Game Menu", "Slayer Quick Options", "KOTH Quick Options", "Race Quick Options", "Oddball Quick Options", "Jugger Quick Options", "HH Quick Options", "CTF Quick Options", "Assault Quick Options", "Pick New Squad Leader", "Variant Editing Options Menu", "Playlist List-Settings", "Playlist Contents", "Playlist Selected Options", "Xbox Live Task Progress", "PP Vibration Settings", "Boot Player Dialog", "Postgame Stats-Lobby", "XBox Live Main Menu", "Edit Terries Menu", "Edit Terries Score to Win", "Edit Terries Time Limit", "Edit Terries Teams", "Terries Quick Options", "XBox Live Notification Beeper", "Player Profile Select-Fancy", "Saved Game File Actions Dialog", "MP Start Menu", "MP Start Player Settings", "MP Start Handicap Settings", "MP Start Change Teams", "MP Start Admin Settings", "MP Start Controller Settings", "MP Start Voice Settings", "MP Start Online Status", "MPAlpha Legal Warning", "Squad Join Progress Dialog", "MP Alpha Postgame Legal Warning", "MP Map Select-Lobby", "MP Variant Type-Lobby", "MP Variant List-Lobby", "Loading Progress", "Matchmaking Progress", "Live Message Display", "Fade-in From Black", "Live Player Profile", "Live Clan Profile", "Live Message Send", "Friends Options Dialog", "Clan Options Dialog", "Campaign Options Dialog", "Optimatch Hoppers Fullscreen", "Playlist List-dialog", "Variant Editing Format", "Variant Quick Options Format", "Variant Param Setting Format", "Vehicle Options", "Match Options", "Player Options", "Team Options", "Game Options", "Equipment Options", "Multiple Choice Dialog", "Network Transition Progress", "Xbox Live Stats", "PP Choose Background Emblem", "PP Buttons Qtr", "PP Stix Qtr", "Clan Member Privs", "Optimatch Hoppers Lobby", "Saved game file dialog", "XYZZY", "Error OK Cancel Large", "YZZYX", "Subtitle Display", "PP Keyboard Settings", "PP Keyboard Settings Qtr", "PP Invert Dual Wield", "System Settings", "Bungie News", "Filter Select", "Live Game Browser", "Game Details", "MP Custom Map Select", "MP All Maps Select", "PP Advanced Keyboard Settings", "PP Advanced Keyboard Settings Qtr", "Network Adapter Settings"));
            this.Fields.Add(new ExplanationField("Button Key", "The labels here are just a guide; the actual string used comes from the Nth posit" +
                        "ion\nof this button key entry as found in the ui globals button key string list t" +
                        "ag"));
            this.Fields.Add(new EnumField("button key type", "NONE", "A=SELECT B=BACK", "A=SELECT B=CANCEL", "A=ENTER B=CANCEL", "Y=XBOX LIVE PLAYERS", "X=FRIENDS OPTIONS", "X=CLAN OPTIONS", "X=RECENT PLAYERS OPTIONS", "X=OPTIONS", "A=SELECT", "X=SETTINGS A=SELECT B=BACK", "X=DELETE A=SELECT B=DONE", "A=ACCEPT", "B=CANCEL", "Y=XBOX_LIVE_PLAYERS A=SELECT B=BACK", "Y=XBOX_LIVE_PLAYERS A=SELECT B=CANCEL", "Y=XBOX_LIVE_PLAYERS A=ENTER B=CANCEL", "Y=XBOX_LIVE_PLAYERS A=SELECT", "Y=XBOX_LIVE_PLAYERS A=SELECT B=DONE", "Y=XBOX_LIVE_PLAYERS A=ACCEPT", "Y=XBOX_LIVE_PLAYERS B=CANCEL", "X=DELETE A=SELECT B=BACK", "A=OK"));
            this.Fields.Add(new ExplanationField("Default Text Color", "Any ui elements that don\'t explicitly set a text color will use this color"));
            this.Fields.Add(new RealArgbColorField("text color"));
            this.Fields.Add(new ExplanationField("Screen Text", "All text specific to this screen"));
            this.Fields.Add(new TagReferenceField("string list tag", 1970170211));
            this.Fields.Add(new ExplanationField("Panes", "Define the screen\'s panes here (normal screens have 1 pane, tab-view screens have" +
                        " 2+ panes)"));
            this.Fields.Add(new BlockField<WindowPaneReferenceBlock>("panes", 16));
            this.Fields.Add(new ExplanationField("Shape Group", "If the screen is to have a shape group, specify it here (references group in user" +
                        " interface globals tag)"));
            this.Fields.Add(new EnumField("shape group", "NONE", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"));
            this.Fields.Add(new PadField("", 2));
            this.Fields.Add(new ExplanationField("More Screen Parameters", "These are down here because they got added on later. Have a nice day."));
            this.Fields.Add(new StringIdField("header string id"));
            this.Fields.Add(new ExplanationField("Local strings", "String IDs here allow defining new string ids that are visible only to this scree" +
                        "n."));
            this.Fields.Add(new BlockField<LocalStringIdListSectionReferenceBlock>("local strings", 16));
            this.Fields.Add(new ExplanationField("Local bitmaps", "Bitmaps here allow adding a bitmap that\'s accessible in code for use in this scre" +
                        "en."));
            this.Fields.Add(new BlockField<LocalBitmapReferenceBlock>("local bitmaps", 16));
            this.Fields.Add(new ExplanationField("LEVEL LOAD PROGRESS FIELDS", "These are used only for level load progress bitmaps"));
            this.Fields.Add(new RealRgbColorField("source color"));
            this.Fields.Add(new RealRgbColorField("destination color"));
            this.Fields.Add(new RealField("accumulate zoom scale x"));
            this.Fields.Add(new RealField("accumulate zoom scale y"));
            this.Fields.Add(new RealField("refraction scale x"));
            this.Fields.Add(new RealField("refraction scale y"));
        }
        /// <summary>
        /// Gets and returns the name of the user_interface_screen_widget_definition_block tag block.
        /// </summary>
        public override string Name
        {
            get
            {
                return "user_interface_screen_widget_definition_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the user_interface_screen_widget_definition_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "user_interface_screen_widget_definition";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the user_interface_screen_widget_definition_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the user_interface_screen_widget_definition_block tag block.
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
