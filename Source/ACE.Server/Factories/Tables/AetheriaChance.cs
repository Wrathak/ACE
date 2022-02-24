using System.Collections.Generic;

using ACE.Database.Models.World;
using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class AetheriaChance
    {
        private static ChanceTable<int> T5_ItemMaxLevel = new ChanceTable<int>()
        {
            ( 1, 0.60f ),
            ( 2, 0.40f ),
        };

        private static ChanceTable<int> T6_ItemMaxLevel = new ChanceTable<int>()
        {
            ( 1, 0.550f ),
            ( 2, 0.345f ),
            ( 3, 0.100f ),
            ( 4, 0.005f ),
        };

        // lack of data samples here for 4+
        private static ChanceTable<int> T7_ItemMaxLevel = new ChanceTable<int>()
        {
            ( 1, 0.55000f ),
            ( 2, 0.34475f ),
            ( 3, 0.10000f ),
            ( 4, 0.00500f ),
            ( 5, 0.00025f ),
        };

        // also lack of data samples for level 5,
        // there was possibly no indication it was more common than t7
        private static ChanceTable<int> T8_ItemMaxLevel = new ChanceTable<int>()
        {
            ( 1, 0.000f ),
            ( 2, 0.500f ),
            ( 3, 0.450f ),
            ( 4, 0.045f ),
            ( 5, 0.005f ),
        };

        private static readonly List<ChanceTable<int>> itemMaxLevels = new List<ChanceTable<int>>()
        {
            T5_ItemMaxLevel,
            T6_ItemMaxLevel,
            T7_ItemMaxLevel,
            T8_ItemMaxLevel
        };

        public static int Roll_ItemMaxLevel(TreasureDeath profile)
        {
            if (profile.Tier < 5)
                return 0;

            var table = itemMaxLevels[profile.Tier - 5];

            return table.Roll(profile.LootQualityMod);
        }
    }
}
