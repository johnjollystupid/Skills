using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModSettings;

namespace Skills
{
    
    
    internal class SkillSettings : JsonModSettings
    {
        [Section("Skills")]

        [Name("Carcass Harvesting")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float carcassHarvestingSkillLevel = 1;

        [Name("Cooking")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float cookingSkillLevel = 1;

        [Name("Fire Starting")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float fireStartingSkillLevel = 1;

        [Name("Ice Fishing")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float iceFishingSkillLevel = 1;

        [Name("Rifle Firearm")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float rifleFirearmSkillLevel = 1;

        [Name("Archery")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float archerySkillLevel = 1;

        [Name("Mending")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float mendingSkillLevel = 1;

        [Name("Revolver Firearm")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float revolverFirearmSkillLevel = 1;

        [Name("Gunsmithing")]
        [Description("Set skill level")]
        [Slider(1, 5, 5)]
        public float gunsmithingSkillLevel = 1;
    }

    internal static class Settings
    {
        internal static SkillSettings options = new SkillSettings();

        internal static void OnLoad()
        {
            //options = new SkillSettings();
            options.AddToModSettings("Skills", MenuType.MainMenuOnly);
        }

    }

}
