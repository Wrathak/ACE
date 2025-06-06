using ACE.Common;
using ACE.Database.Models.World;
using ACE.Server.Entity.Mutations;
using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;
using ACE.Server.Factories.Tables;
using ACE.Server.Factories.Tables.Wcids;
using ACE.Server.WorldObjects;

namespace ACE.Server.Factories
{
    public static partial class LootGenerationFactory
    {
        public static WorldObject CreateMeleeWeapon(TreasureDeath profile, bool isMagical)
        {
            // this function is only used by test methods, and is not part of regular lootgen
            var treasureRoll = new TreasureRoll(TreasureItemType.Weapon);
            treasureRoll.WeaponType = WeaponTypeChance.MeleeChances.Roll();
            treasureRoll.Wcid = WeaponWcids.Roll(profile, ref treasureRoll.WeaponType);

            var wo = WorldObjectFactory.CreateNewWorldObject((uint)treasureRoll.Wcid);

            if (weaponSkill == MeleeWeaponSkill.Undef)
                weaponSkill = (MeleeWeaponSkill)ThreadSafeRandom.Next(1, 1);


            switch (weaponSkill)
            {
                case MeleeWeaponSkill.HeavyWeapons:

                    weaponType = ThreadSafeRandom.Next(0, LootTables.HeavyWeaponsMatrix.Length - 1);
                    wcid = LootTables.HeavyWeaponsMatrix[weaponType][eleType];
                    break;

                case MeleeWeaponSkill.LightWeapons:

                    weaponType = ThreadSafeRandom.Next(0, LootTables.LightWeaponsMatrix.Length - 1);
                    wcid = LootTables.LightWeaponsMatrix[weaponType][eleType];
                    break;

                case MeleeWeaponSkill.FinesseWeapons:

                    weaponType = ThreadSafeRandom.Next(0, LootTables.FinesseWeaponsMatrix.Length - 1);
                    wcid = LootTables.FinesseWeaponsMatrix[weaponType][eleType];
                    break;

                case MeleeWeaponSkill.TwoHandedCombat:

                    weaponType = ThreadSafeRandom.Next(0, LootTables.TwoHandedWeaponsMatrix.Length - 1);
                    wcid = LootTables.TwoHandedWeaponsMatrix[weaponType][eleType];
                    break;
            }

            var wo = WorldObjectFactory.CreateNewWorldObject((uint)wcid);

            if (wo != null && mutate)
            {
                if (!MutateMeleeWeapon(wo, profile, isMagical))
                {
                    log.Warn($"[LOOT] {wo.WeenieClassId} - {wo.Name} is not a MeleeWeapon");
                    return null;
                }
            }
            return wo;
        }

        private static void MutateMeleeWeapon(WorldObject wo, TreasureDeath profile, bool isMagical, TreasureRoll roll)
        {
            // thanks to 4eyebiped for helping with the data analysis of magloot retail logs
            // that went into reversing these mutation scripts

            var weaponSkill = wo.WeaponSkill.ToMeleeWeaponSkill();

            // mutate Damage / WieldDifficulty / Variance
            var scriptName = GetDamageScript(weaponSkill, roll.WeaponType);

            var mutationFilter = MutationCache.GetMutation(scriptName);

            mutationFilter.TryMutate(wo, profile.Tier);

            // mutate WeaponOffense / WeaponDefense
            scriptName = GetOffenseDefenseScript(weaponSkill, roll.WeaponType);

            mutationFilter = MutationCache.GetMutation(scriptName);

            mutationFilter.TryMutate(wo, profile.Tier);

            // weapon speed
            if (wo.WeaponTime != null)
            {
                var weaponSpeedMod = RollWeaponSpeedMod(profile);
                wo.WeaponTime = (int)(wo.WeaponTime * weaponSpeedMod);
            }

            // material type
            var materialType = GetMaterialType(wo, profile.Tier);
            if (materialType > 0)
                wo.MaterialType = materialType;

            // item color
            MutateColor(wo);

            // gem count / gem material
            if (wo.GemCode != null)
                wo.GemCount = GemCountChance.Roll(wo.GemCode.Value, profile.Tier);
            else
                wo.GemCount = ThreadSafeRandom.Next(1, 5);

            wo.GemType = RollGemType(profile.Tier);

            // workmanship
            wo.ItemWorkmanship = WorkmanshipChance.Roll(profile.Tier);

            // burden
            MutateBurden(wo, profile, true);

            // missile / magic defense
            wo.WeaponMissileDefense = MissileMagicDefense.Roll(profile.Tier);
            wo.WeaponMagicDefense = MissileMagicDefense.Roll(profile.Tier);

            // spells
            if (!isMagical)
            {
                // clear base
                wo.ItemManaCost = null;
                wo.ItemMaxMana = null;
                wo.ItemCurMana = null;
                wo.ItemSpellcraft = null;
                wo.ItemDifficulty = null;
            }
            else
                AssignMagic(wo, profile, roll);

            // item value
            //if (wo.HasMutateFilter(MutateFilter.Value))   // fixme: data
                MutateValue(wo, profile.Tier, roll);

            // long description
            wo.LongDesc = GetLongDesc(wo);
        }

        private static string GetDamageScript(MeleeWeaponSkill weaponSkill, TreasureWeaponType weaponType)
        {
            return "MeleeWeapons.Damage_WieldDifficulty_DamageVariance." + weaponSkill.GetScriptName_Combined() + "_" + weaponType.GetScriptName() + ".txt";
        }

        private static string GetOffenseDefenseScript(MeleeWeaponSkill weaponSkill, TreasureWeaponType weaponType)
        {
            return "MeleeWeapons.WeaponOffense_WeaponDefense." + weaponType.GetScriptShortName() + "_offense_defense.txt";
        }
    }
}
