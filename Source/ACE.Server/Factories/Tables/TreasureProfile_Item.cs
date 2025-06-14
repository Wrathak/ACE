using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables
{
    public static class TreasureProfile_Item
    {
        // indexed by TreasureDeath.ItemTreasureTypeSelectionChances

        private static ChanceTable<TreasureItemType> itemProfile1 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Weapon,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile2 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Armor,       1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile3 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Scroll,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile4 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Clothing,    1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile5 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Jewelry,     1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile6 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Gem,         1.0f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile7 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.ArtObject,   1.0f ),
        };

        /// <summary>
        /// The second most common ItemProfile
        /// </summary>
        private static ChanceTable<TreasureItemType> itemProfile8 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType.Armor,       0.47f ),
          ( TreasureItemType.Weapon,      0.21f ),
          ( TreasureItemType.Clothing,    0.09f ),
          ( TreasureItemType.Jewelry,     0.21f ),
          ( TreasureItemType.Gem,         0.02f ),
        };

        /// <summary>
        /// The most common ItemProfile
        /// </summary>
        private static ChanceTable<TreasureItemType> itemProfile9 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType.Armor,       0.47f ),
          ( TreasureItemType.Weapon,      0.21f ),
          ( TreasureItemType.Clothing,    0.09f ),
          ( TreasureItemType.Jewelry,     0.21f ),
          ( TreasureItemType.Gem,         0.02f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile10 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType.Armor,       0.47f ),
          ( TreasureItemType.Weapon,      0.21f ),
          ( TreasureItemType.Clothing,    0.09f ),
          ( TreasureItemType.Jewelry,     0.21f ),
          ( TreasureItemType.Gem,         0.02f ),
        };

        private static ChanceTable<TreasureItemType> itemProfile11 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType.Armor,       0.47f ),
          ( TreasureItemType.Weapon,      0.21f ),
          ( TreasureItemType.Clothing,    0.09f ),
          ( TreasureItemType.Jewelry,     0.21f ),
          ( TreasureItemType.Gem,         0.02f ),
        };

        /// <summary>
        /// TreasureDeath.ItemTreasureTypeSelectionChances indexes into these profiles
        /// </summary>
        private static readonly List<ChanceTable<TreasureItemType>> itemProfiles = new List<ChanceTable<TreasureItemType>>()
        {
            itemProfile1,
            itemProfile2,
            itemProfile3,
            itemProfile4,
            itemProfile5,
            itemProfile6,
            itemProfile7,
            itemProfile8,
            itemProfile9,
            itemProfile10,
            itemProfile11,
        };

        /// <summary>
        /// Rolls for a TreasureItemType for a non-magical TreasureItemCategory.Item
        /// </summary>
        /// <param name="itemProfile">From TreasureDeath.ItemTreasureTypeSelectionChances</param>
        public static TreasureItemType Roll(int itemProfile)
        {
            if (itemProfile < 1 || itemProfile > itemProfiles.Count)
                return TreasureItemType.Undef;

            return itemProfiles[itemProfile - 1].Roll();
        }
    }
}
