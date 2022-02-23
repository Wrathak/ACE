using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables
{
    public static class WorkmanshipChance
    {
        private static ChanceTable<int> T1_Chances = new ChanceTable<int>()
        {
            ( 1, 0.05f ),
            ( 2, 0.10f ),
            ( 3, 0.25f ),
            ( 4, 0.20f ),
            ( 5, 0.4f ),
        };

        private static ChanceTable<int> T2_Chances = new ChanceTable<int>()
        {
            ( 2, 0.05f ),
            ( 3, 0.10f ),
            ( 4, 0.25f ),
            ( 5, 0.20f ),
            ( 6, 0.4f ),
        };

        private static ChanceTable<int> T3_Chances = new ChanceTable<int>()
        {
            ( 3, 0.05f ),
            ( 4, 0.10f ),
            ( 5, 0.25f ),
            ( 6, 0.20f ),
            ( 7, 0.4f ),
        };

        private static ChanceTable<int> T4_Chances = new ChanceTable<int>()
        {
            ( 3, 0.01f ),
            ( 4, 0.05f ),
            ( 5, 0.15f ),
            ( 6, 0.19f ),
            ( 7, 0.2f ),
            ( 8, 0.4f ),
        };

        private static ChanceTable<int> T5_Chances = new ChanceTable<int>()
        {
            ( 3, 0.01f ),
            ( 4, 0.03f ),
            ( 5, 0.05f ),
            ( 6, 0.25f ),
            ( 7, 0.41f ),
            ( 8, 0.15f ),
            ( 9, 0.10f ),
        };

        private static ChanceTable<int> T6_Chances = new ChanceTable<int>()
        {
            ( 4, 0.01f ),
            ( 5, 0.04f ),
            ( 6, 0.20f ),
            ( 7, 0.25f ),
            ( 8, 0.25f ),
            ( 9, 0.15f ),
            ( 10, 0.10f ),
        };

        private static readonly List<ChanceTable<int>> workmanshipChances = new List<ChanceTable<int>>()
        {
            T1_Chances,
            T2_Chances,
            T3_Chances,
            T4_Chances,
            T5_Chances,
            T6_Chances,
        };

        /// <summary>
        /// Rolls for a 1-10 workmanship for an item
        /// </summary>
        public static int Roll(int tier)
        {
            // todo: add t7 / t8
            tier = Math.Clamp(tier, 1, 6);

            var workmanshipChance = workmanshipChances[tier - 1];

            return workmanshipChance.Roll();
        }

        /// <summary>
        /// Returns the workmanship modifier for an item
        /// </summary>
        public static float GetModifier(int? workmanship)
        {
            var modifier = 1.0f;

            if (workmanship != null)
                modifier += workmanship.Value / 9.0f;

            return modifier;
        }
    }
}
