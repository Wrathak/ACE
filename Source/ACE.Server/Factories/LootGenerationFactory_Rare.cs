using System.Linq;
using System.Collections.Generic;

using ACE.Common;
using ACE.Server.WorldObjects;

namespace ACE.Server.Factories
{
    public static partial class LootGenerationFactory
    {
        public static Dictionary<int, int> RareChances = new Dictionary<int, int>()
        {
            { 1, 200 },
            { 2, 400 },
            { 3, 800 },
            { 4, 2400 },
            { 5, 7200 },
            { 6, 20000 }
        };

        public static Dictionary<int, HashSet<int>> RareWCIDs;

        public static void InitRares()
        {
            RareWCIDs = new Dictionary<int, HashSet<int>>();

            var tier1Rares = new HashSet<int>() { 30183, 30186, 30194, 30196, 30202, 30205, 30206, 30215, 30224, 30225, 30228, 30229, 30232, 30234, 30240, 30242, 30246, 45366, 45368, 45369 };
            var tier2Rares = new HashSet<int>() { 30181, 30182, 30185, 30190, 30191, 30192, 30193, 30201, 30203, 30204, 30207, 30208, 30210, 30211, 30213, 30219, 30220, 30227, 30230, 30231, 30235, 30237, 30239, 30241 };
            var tier3Rares = new HashSet<int>() { 30258, 52034 };

            var tier4Rares = new HashSet<int>() { 30354, 30356, 30357, 30359, 30360, 30361, 30362, 30363, 30365, 30367, 30368, 30369, 30370, 30371, 30372, 30373, 30510, 30511, 30512, 30513, 30514, 30515, 30516, 30517, 30518, 30519, 30520, 30521, 30522, 30523, 30524, 30525, 30526, 30527, 30528, 30529, 30530, 30531, 30532, 30533, 30534 };
            var tier5Rares = new HashSet<int>() { 30074, 30075, 30076, 30077, 30078, 30079, 30080, 30081, 30096, 30098, 30101, 30105, 30106, 30112, 30113, 30114, 30115, 30116, 30117, 30121, 30122, 30123, 30124, 30125, 30126, 30127, 30128, 30129, 30132, 30134, 30135, 30136, 30137, 30139, 30140, 30141, 30142, 30143, 30144, 30145, 30146, 30147, 30150, 30151, 30152, 30153, 30154, 30156, 30157, 30158, 30159, 30160, 30161, 30162, 30163, 30164, 30166, 30167, 30168, 30169, 30171, 30173, 30174, 30175, 30176, 30179, 30180, 30253, 30936 };
            var tier6Rares = new HashSet<int>() { 30302, 30303, 30304, 30305, 30306, 30307, 30308, 30309, 30310, 30314, 30315, 30320, 30324, 30328, 45461, 30333, 30338, 30342, 30343, 30350, 30351, 30374, 30375, 30376, 30377, 30378 };

            RareWCIDs.Add(1, tier1Rares);
            RareWCIDs.Add(2, tier2Rares);
            RareWCIDs.Add(3, tier3Rares);
            RareWCIDs.Add(4, tier4Rares);
            RareWCIDs.Add(5, tier5Rares);
            RareWCIDs.Add(6, tier6Rares);
        }

        public static WorldObject CreateRare()
        {
            int tier = 0;

            if (ThreadSafeRandom.Next(1, 200) == 1)   // 1 in 200 chance
            {
                tier = 1;
                if (ThreadSafeRandom.Next(1, 2) == 1)  // 1 in 400 chance
                {
                    tier = 2;
                }
                if (ThreadSafeRandom.Next(1, 4) == 1)  // 1 in 800 chance
                {
                    tier = 3;
                }
                if (ThreadSafeRandom.Next(1, 12) == 1)  // 1 in 2,400 chance
                {
                    tier = 4;
                }
                if (ThreadSafeRandom.Next(1, 36) == 1)  // 1 in 7,200
                {
                    tier = 5;
                }
                if (ThreadSafeRandom.Next(1, 100) == 1)  // 1 in 20,000 chance
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
