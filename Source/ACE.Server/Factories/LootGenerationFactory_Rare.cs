using System;
using System.Collections.Generic;
using System.Linq;

using ACE.Common;
using ACE.Server.WorldObjects;

namespace ACE.Server.Factories
{
    public static partial class LootGenerationFactory
    {
        public static Dictionary<int, int> RareChances = new Dictionary<int, int>()
        {
            { 1, 100 },
            { 2, 200 },
            { 3, 600 },
            { 4, 3000 },
            { 5, 9000 },
            { 6, 36000 }
        };

        public static Dictionary<int, HashSet<int>> RareWCIDs;

        public static void InitRares()
        {
            RareWCIDs = new Dictionary<int, HashSet<int>>();

            var tier1Rares = new HashSet<int>() { 30183, 30186, 30194, 30196, 30202, 30205, 30206, 30215, 30224, 30225, 30228, 30229, 30232, 30234, 30240, 30242, 30246, 45366, 45368, 45369 };
            var tier2Rares = new HashSet<int>() { 30182, 30185, 30191, 30193, 30201, 30203, 30208, 30210, 30211, 30213, 30220, 30227, 30231, 30235, 30237, 30239 };
            var tier3Rares = new HashSet<int>() { 30258, 52034 };

            var tier4Rares = new HashSet<int>() { 30511, 30514, 30515, 30517, 30519, 30522, 30524, 30526, 30529, 30372, 30373, 30354, 30353, 30361 };
            var tier5Rares = new HashSet<int>() { 30094, 30095, 30096, 30097, 30098, 30099, 30100, 30101, 30102, 30103, 30104, 30105, 30106 };
            var tier6Rares = new HashSet<int>() { 30302, 30303, 30304, 30314, 30320, 30324, 45461, 30338, 30343, 30350, 30351, 30374, 30375, 30376, 30377, 30378 };

            RareWCIDs.Add(1, tier1Rares);
            RareWCIDs.Add(2, tier2Rares);
            RareWCIDs.Add(3, tier3Rares);
            RareWCIDs.Add(4, tier4Rares);
            RareWCIDs.Add(5, tier5Rares);
            RareWCIDs.Add(6, tier6Rares);
        }

        public static WorldObject TryCreateRare(int luck = 0)
        {
            //var t1_chance = 2500; // 1 in 2,500 chance // Old rate. Property default is 0.04 (which is 0.04%, or the same 1/2500)
            double rare_drop_rate_percent = (float)Managers.PropertyManager.GetDouble("rare_drop_rate_percent").Item;

            // Check to make sure there *IS* a chance. Less than/equal to 0 would mean zero chance, so we can stop here
            if (rare_drop_rate_percent <= 0)
                return null;

            rare_drop_rate_percent = Math.Min(rare_drop_rate_percent/100, 1);
            int t1_chance = (int)Math.Round(1 / rare_drop_rate_percent); // Default PropertyManager value results in a 1 in 2,500 chance
            t1_chance = Math.Max(t1_chance - luck, 1);

            int tier = 0;

            if (ThreadSafeRandom.Next(1, t1_chance) == 1)   // 1 in 250 chance
            {
                tier = 1;
                if (ThreadSafeRandom.Next(1, 2) == 1)      // 1 in 500 chance
                {
                    tier = 2;
                }
                if (ThreadSafeRandom.Next(1, 3) == 1)     // 1 in 2000 chance
                {
                    tier = 3;
                }
                if (ThreadSafeRandom.Next(1, 5) == 1)    // 1 in 8000 chance
                {
                    tier = 4;
                }
                if (ThreadSafeRandom.Next(1, 3) == 1)    // 1 in 24,000
                {
                    tier = 5;
                }
                if (ThreadSafeRandom.Next(1, 4) == 1)    // 1 in 96,000 chance
                {
                    tier = 6;
                }
            }

            if (tier == 0) return null;

            var tierRares = RareWCIDs[tier].ToList();

            var rng = ThreadSafeRandom.Next(0, tierRares.Count - 1);

            var rareWCID = tierRares[rng];

            var wo = WorldObjectFactory.CreateNewWorldObject((uint)rareWCID);

            if (wo == null)
                log.Error($"LootGenerationFactory_Rare.CreateRare(): failed to generate rare wcid {rareWCID}");

            return wo;
        }

        /// <summary>
        /// Returns the tier for a rare wcid
        /// </summary>
        public static int GetRareTier(uint rareWCID)
        {
            var wcid = (int)rareWCID;

            foreach (var kvp in RareWCIDs)
                if (kvp.Value.Contains(wcid))
                    return kvp.Key;

            return 0;
        }
    }
}
