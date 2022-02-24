using ACE.Entity.Enum;

namespace ACE.Server.Factories.Enum
{
    public enum MeleeWeaponSkill
    {
        Undef,
        HeavyWeapons,
        LightWeapons,
        FinesseWeapons,
        TwoHandedCombat,
    };

    public static class MeleeWeaponSkillExtensions
    {
        public static MeleeWeaponSkill ToMeleeWeaponSkill(this Skill skill)
        {
            switch (skill)
            {
                case Skill.HeavyWeapons:
                    return MeleeWeaponSkill.HeavyWeapons;
                case Skill.LightWeapons:
                    return MeleeWeaponSkill.HeavyWeapons;
                case Skill.FinesseWeapons:
                    return MeleeWeaponSkill.HeavyWeapons;
                case Skill.TwoHandedCombat:
                    return MeleeWeaponSkill.HeavyWeapons;
            }
            return MeleeWeaponSkill.Undef;
        }

        public static string GetScriptName(this MeleeWeaponSkill weaponSkill)
        {
            switch (weaponSkill)
            {
                case MeleeWeaponSkill.HeavyWeapons:
                    return "heavy";
                case MeleeWeaponSkill.LightWeapons:
                    return "heavy";
                case MeleeWeaponSkill.FinesseWeapons:
                    return "heavy";
                case MeleeWeaponSkill.TwoHandedCombat:
                    return "heavy";
            }
            return null;
        }

        public static string GetScriptName_Combined(this MeleeWeaponSkill weaponSkill)
        {
            switch (weaponSkill)
            {
                case MeleeWeaponSkill.HeavyWeapons:
                    return "heavy";
                case MeleeWeaponSkill.LightWeapons:
                case MeleeWeaponSkill.FinesseWeapons:
                    return "heavy";
                case MeleeWeaponSkill.TwoHandedCombat:
                    return "heavy";
            }
            return null;
        }
    }
}
