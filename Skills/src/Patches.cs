using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using MelonLoader;


//var archeryObject = GameManager.GetSkillArchery();
//archeryObject.m_CurrentPoints = 58;
//GameManager.GetSkillArchery().SetPoints(58, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);

namespace Skills
{
    internal class Patches
    {

        [HarmonyPatch(typeof(Skill), "SetPoints")]

        internal class ChangeSkillLevels
        {
            //[HarmonyPrefix]
            private static void Prefix(Skill __instance, ref int points)
            {
                int intPoints;

                if (__instance.m_SkillType == SkillType.CarcassHarvesting)
                {

                    intPoints = GetCarcassHarvestingSkillPoints((Settings.options.carcassHarvestingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }

                }

                if (__instance.m_SkillType == SkillType.Cooking)
                {
                    intPoints = GetCookingSkillPoints((Settings.options.cookingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.Firestarting)
                {
                    intPoints = GetFireStartingSkillPoints((Settings.options.fireStartingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.IceFishing)
                {
                    intPoints = GetIceFishingSkillPoints((Settings.options.iceFishingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.Rifle)
                {
                    intPoints = GetRifleFirearmSkillPoints((Settings.options.rifleFirearmSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.Archery)
                {
                    intPoints = GetArcherySkillPoints((Settings.options.archerySkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.ClothingRepair)
                {
                    intPoints = GetMendingSkillPoints((Settings.options.mendingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.Revolver)
                {
                    intPoints = GetRevolverFirearmSkillPoints((Settings.options.revolverFirearmSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                if (__instance.m_SkillType == SkillType.Gunsmithing)
                {
                    intPoints = GetGunSmithingSkillPoints((Settings.options.gunsmithingSkillLevel));

                    if (intPoints >= points)
                    {
                        points = intPoints;
                    }
                }

                
            }
        }


        private static int GetCarcassHarvestingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 15;
            else if (level == 3) skillLevelPoints = 30;
            else if (level == 4) skillLevelPoints = 50;
            else if (level == 5) skillLevelPoints = 100;

            return skillLevelPoints;
        }

        private static int GetCookingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 25;
            else if (level == 3) skillLevelPoints = 75;
            else if (level == 4) skillLevelPoints = 150;
            else if (level == 5) skillLevelPoints = 350;

            return skillLevelPoints;
        }

        private static int GetFireStartingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 20;
            else if (level == 3) skillLevelPoints = 50;
            else if (level == 4) skillLevelPoints = 100;
            else if (level == 5) skillLevelPoints = 200;

            return skillLevelPoints;
        }

        private static int GetIceFishingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 10;
            else if (level == 3) skillLevelPoints = 50;
            else if (level == 4) skillLevelPoints = 150;
            else if (level == 5) skillLevelPoints = 250;

            return skillLevelPoints;
        }

        private static int GetRifleFirearmSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 10;
            else if (level == 3) skillLevelPoints = 25;
            else if (level == 4) skillLevelPoints = 50;
            else if (level == 5) skillLevelPoints = 100;

            return skillLevelPoints;
        }

        private static int GetArcherySkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 15;
            else if (level == 3) skillLevelPoints = 40;
            else if (level == 4) skillLevelPoints = 75;
            else if (level == 5) skillLevelPoints = 125;

            return skillLevelPoints;
        }

        private static int GetMendingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 25;
            else if (level == 3) skillLevelPoints = 75;
            else if (level == 4) skillLevelPoints = 150;
            else if (level == 5) skillLevelPoints = 350;

            return skillLevelPoints;
        }

        private static int GetRevolverFirearmSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 10;
            else if (level == 3) skillLevelPoints = 25;
            else if (level == 4) skillLevelPoints = 50;
            else if (level == 5) skillLevelPoints = 100;

            return skillLevelPoints;
        }

        private static int GetGunSmithingSkillPoints(float Skilllevel)
        {
            int a = 0;
            int skillLevelPoints = a;

            int level = (int)Skilllevel;

            if (level == 1) skillLevelPoints = 0;
            else if (level == 2) skillLevelPoints = 15;
            else if (level == 3) skillLevelPoints = 30;
            else if (level == 4) skillLevelPoints = 50;
            else if (level == 5) skillLevelPoints = 100;

            return skillLevelPoints;
        }

    }

}


