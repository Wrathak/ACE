using System.Collections.Generic;

using ACE.Entity.Enum;
using ACE.Server.Factories.Tables;

namespace ACE.Server.Factories
{
    public static class LootTables
    {
        public static int[][] DefaultMaterial { get; } =
        {
          new int[] { (int)MaterialType.Steel, (int)MaterialType.Steel, (int)MaterialType.Alabaster, (int)MaterialType.ArmoredilloHide, (int)MaterialType.Bronze, (int)MaterialType.Ceramic, (int)MaterialType.Marble, (int)MaterialType.ReedSharkHide, (int)MaterialType.Wool, (int)MaterialType.Steel },                          // Armor
          new int[] { (int)MaterialType.Iron, (int)MaterialType.Iron, (int)MaterialType.Brass, (int)MaterialType.Brass, (int)MaterialType.Granite, (int)MaterialType.Mahogany, (int)MaterialType.Mahogany, (int)MaterialType.Velvet, (int)MaterialType.Velvet, (int)MaterialType.Velvet },                                          // Missile
          new int[] { (int)MaterialType.Iron, (int)MaterialType.Iron, (int)MaterialType.Brass, (int)MaterialType.Brass, (int)MaterialType.Granite, (int)MaterialType.Mahogany, (int)MaterialType.Mahogany, (int)MaterialType.Velvet, (int)MaterialType.Velvet, (int)MaterialType.Velvet },                                          // Melee
          new int[] { (int)MaterialType.BlackGarnet, (int)MaterialType.RedGarnet, (int)MaterialType.WhiteSapphire, (int)MaterialType.Emerald, (int)MaterialType.Emerald, (int)MaterialType.WhiteSapphire, (int)MaterialType.RedGarnet, (int)MaterialType.BlackGarnet },                                                             // Caster
          new int[] { (int)MaterialType.Granite, (int)MaterialType.Ceramic, (int)MaterialType.Porcelain, (int)MaterialType.Alabaster, (int)MaterialType.Marble },                                                                                                                                                                   // Dinnerware
          new int[] { (int)MaterialType.Peridot, (int)MaterialType.BlackOpal, (int)MaterialType.Zircon, (int)MaterialType.FireOpal, (int)MaterialType.FireOpal, (int)MaterialType.Sunstone, (int)MaterialType.Sunstone, (int)MaterialType.Peridot, (int)MaterialType.BlackOpal, (int)MaterialType.Zircon }                          // Clothes
        };

        // for logging epic/legendary drops
        public static HashSet<int> MinorCantrips;
        public static HashSet<int> MajorCantrips;
        public static HashSet<int> EpicCantrips;
        public static HashSet<int> LegendaryCantrips;

        private static List<SpellId[][]> cantripTables { get; } = new List<SpellId[][]>()
        {
            ArmorCantrips.Table,
            JewelryCantrips.Table,
            WandCantrips.Table,
            MeleeCantrips.Table,
            MissileCantrips.Table
        };

        static LootTables()
        {
            BuildCantripsTable(ref MinorCantrips, 0);
            BuildCantripsTable(ref MajorCantrips, 1);
            BuildCantripsTable(ref EpicCantrips, 2);
            BuildCantripsTable(ref LegendaryCantrips, 3);
        }

        private static void BuildCantripsTable(ref HashSet<int> table, int tier)
        {
            table = new HashSet<int>();

            foreach (var cantripTable in cantripTables)
            {
                foreach (var category in cantripTable)
                    table.Add((int)category[tier]);
            }
        }
    }
}
