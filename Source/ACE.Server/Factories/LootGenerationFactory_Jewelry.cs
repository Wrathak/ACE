using System.Linq;

using ACE.Common;
using ACE.Database.Models.World;
using ACE.Entity.Enum;
using ACE.Server.Entity;
using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Tables;
using ACE.Server.WorldObjects;

namespace ACE.Server.Factories
{
    public static partial class LootGenerationFactory
    {
        private static WorldObject CreateJewelry(TreasureDeath profile, bool isMagical, bool mutate = true)
        {
            // 31% chance ring, 31% chance bracelet, 30% chance necklace 8% chance Trinket

            int jewelrySlot = ThreadSafeRandom.Next(1, 100);
            int jewelType;

            // Made this easier to read (switch -> if statement)
            if (jewelrySlot <= 31)
                jewelType = LootTables.ringItems[ThreadSafeRandom.Next(0, LootTables.ringItems.Length - 1)];
            else if (jewelrySlot <= 62)
                jewelType = LootTables.braceletItems[ThreadSafeRandom.Next(0, LootTables.braceletItems.Length - 1)];
            else if (jewelrySlot <= 92)
                jewelType = LootTables.necklaceItems[ThreadSafeRandom.Next(0, LootTables.necklaceItems.Length - 1)];
            else
                jewelType = LootTables.trinketItems[ThreadSafeRandom.Next(0, LootTables.trinketItems.Length - 1)];

            WorldObject wo = WorldObjectFactory.CreateNewWorldObject((uint)jewelType);

            if (wo != null && mutate)
                MutateJewelry(wo, profile, isMagical);

            return wo;
        }

        private static void MutateJewelry(WorldObject wo, TreasureDeath profile, bool isMagical, TreasureRoll roll = null)
        {
            // material type
            var materialType = GetMaterialType(wo, profile.Tier);
            if (materialType > 0)
                wo.MaterialType = materialType;

            // 35% chance ring, 35% chance bracelet, 30% chance necklace
            int ringPercent = 40;
            int braceletPercent = 40;
            int necklacePercent = 20;

            int jewelrySlot = ThreadSafeRandom.Next(0, ringPercent + braceletPercent + necklacePercent);
            int jewelType;

            switch (jewelrySlot)
            {
                case int n when (n <= ringPercent):
                    jewelType = LootTables.ringItems[ThreadSafeRandom.Next(0, LootTables.ringItems.Length - 1)];
                    break;
                case int n when (n <= ringPercent + braceletPercent && n > ringPercent):
                    jewelType = LootTables.braceletItems[ThreadSafeRandom.Next(0, LootTables.braceletItems.Length - 1)];
                    break;
                case int n when (n <= ringPercent + braceletPercent + necklacePercent && n > ringPercent + braceletPercent):
                    jewelType = LootTables.necklaceItems[ThreadSafeRandom.Next(0, LootTables.necklaceItems.Length - 1)];
                    break;
                default:
                    return null;
            }

            //int rank = 0;
            //int skill_level_limit = 0;

            WorldObject wo = WorldObjectFactory.CreateNewWorldObject((uint)jewelType);

            if (wo == null)
                return null;

            // gem count / gem material
            if (wo.GemCode != null)
                wo.GemCount = GemCountChance.Roll(wo.GemCode.Value, profile.Tier);
            else
                wo.GemCount = ThreadSafeRandom.Next(1, 5);

            wo.GemType = RollGemType(profile.Tier);

            // workmanship
            wo.ItemWorkmanship = WorkmanshipChance.Roll(profile.Tier);

            // wield level requirement for t7+
            if (profile.Tier > 6)
                RollWieldLevelReq_T7_T8(wo, profile);

            // assign magic
            if (isMagical)
                AssignMagic(wo, profile, roll);
            else
            {
                wo.ItemManaCost = null;
                wo.ItemMaxMana = null;
                wo.ItemCurMana = null;
                wo.ItemSpellcraft = null;
                wo.ItemDifficulty = null;
                wo.ManaRate = null;
            }

            // gear rating (t8)
            if (roll != null && profile.Tier == 8)
                TryMutateGearRating(wo, profile, roll);

            // item value
            //  if (wo.HasMutateFilter(MutateFilter.Value))     // fixme: data
                MutateValue(wo, profile.Tier, roll);

            wo.LongDesc = GetLongDesc(wo);
        }

        private static bool GetMutateJewelryData(uint wcid)
        {
            foreach (var jewelryTable in LootTables.jewelryTables)
            {
                if (jewelryTable.Contains((int)wcid))
                    return true;
            }
            return false;
        }
    }
}
