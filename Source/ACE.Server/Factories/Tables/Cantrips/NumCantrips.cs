using System.Collections.Generic;

using ACE.Database.Models.World;
using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables
{
    public static class NumCantrips
    {
        private static ChanceTable<int> T1_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.95f ),
            ( 1, 0.05f ),
        };

        private static ChanceTable<int> T2_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.90f ),
            ( 1, 0.10f ),
        };

        private static ChanceTable<int> T3_NumCantrips = new ChanceTable<int>()
        {
            ( 0, 0.700f ),
            ( 1, 0.250f ),
            ( 2, 0.050f ),
        };

        private static ChanceTable<int> T4_NumCantrips = new ChanceTable<int>()
        {
          ( 0, 0.600f ),
          ( 1, 0.330f ),
          ( 2, 0.060f ),
          ( 3, 0.010f ),
        };

        private static ChanceTable<int> T5_NumCantrips = new ChanceTable<int>()
        {
          ( 0, 0.400f ),
          ( 1, 0.400f ),
          ( 2, 0.160f ),
          ( 3, 0.030f ),
          ( 4, 0.010f ),
        };

        private static ChanceTable<int> T6_NumCantrips = new ChanceTable<int>()
        {
          ( 0, 0.300f ),
          ( 1, 0.300f ),
          ( 2, 0.260f ),
          ( 3, 0.100f ),
          ( 4, 0.030f ),
          ( 5, 0.010f ),
        };

        private static ChanceTable<int> T7_T8_NumCantrips = new ChanceTable<int>()
        {
          ( 1, 0.800f ),
          ( 2, 0.160f ),
          ( 3, 0.030f ),
          ( 4, 0.010f ),
        };

        private static readonly List<ChanceTable<int>> numCantrips = new List<ChanceTable<int>>()
        {
            T1_NumCantrips,
            T2_NumCantrips,
            T3_NumCantrips,
            T4_NumCantrips,
            T5_NumCantrips,
            T6_NumCantrips,
            T7_T8_NumCantrips,
            T7_T8_NumCantrips,
        };

        public static int RollNumCantrips(TreasureDeath profile)
        {
            return numCantrips[profile.Tier - 1].Roll(profile.LootQualityMod);
        }

        private static ChanceTable<int> T1_T2_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 1.0f )
        };

        private static ChanceTable<int> T3_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.97f ),
            ( 2, 0.03f ),
        };

        private static ChanceTable<int> T4_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.90f ),
            ( 2, 0.10f ),
        };

        private static ChanceTable<int> T5_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.85f ),
            ( 2, 0.15f ),
        };

        private static ChanceTable<int> T6_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.80f ),
            ( 2, 0.20f ),
        };

        private static ChanceTable<int> T7_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.15f ),
            ( 2, 0.60f ),
            ( 3, 0.25f )
        };

        private static ChanceTable<int> T8_CantripLevel = new ChanceTable<int>()
        {
            ( 1, 0.02f ),
            ( 2, 0.46f ),
            ( 3, 0.42f ),
            ( 4, 0.10f )
        };

        private static readonly List<ChanceTable<int>> cantripLevels = new List<ChanceTable<int>>()
        {
            T1_T2_CantripLevel,
            T1_T2_CantripLevel,
            T3_CantripLevel,
            T4_CantripLevel,
            T5_CantripLevel,
            T6_CantripLevel,
            T7_CantripLevel,
            T8_CantripLevel,
        };

        public static int RollCantripLevel(TreasureDeath profile)
        {
            return cantripLevels[profile.Tier - 1].Roll(profile.LootQualityMod);
        }
    }
}
