using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables
{
    public static class TreasureProfile_MagicItem
    {
        // indexed by TreasureDeath.MagicItemTreasureTypeSelectionChances

        private static ChanceTable<TreasureItemType> magicItemProfile1 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Weapon,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile2 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Armor,       1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile3 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Scroll,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile4 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Clothing,    1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile5 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Jewelry,     1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile6 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Gem,         1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile7 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.ArtObject,   1.0f ),
        };

        /// <summary>
        /// A very common MagicItem profile
        /// </summary>
        private static ChanceTable<TreasureItemType> magicItemProfile8 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType_Orig.Armor,              0.50f ),
            ( TreasureItemType_Orig.Weapon,             0.18f ),
            ( TreasureItemType_Orig.Jewelry,            0.21f ),
            ( TreasureItemType_Orig.Clothing,           0.09f ),
            ( TreasureItemType_Orig.Gem,                0.01f ),
            ( TreasureItemType_Orig.Cloak,              0.01f  ),
            //( TreasureItemType_Orig.Scroll,             0.14f ),
            //( TreasureItemType_Orig.ArtObject,          0.125f ),
            //( TreasureItemType_Orig.EncapsulatedSpirit, 0.005f ),
        };

        /// <summary>
        /// A very common MagicItem profile
        /// </summary>
        private static ChanceTable<TreasureItemType> magicItemProfile9 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType_Orig.Armor,              0.50f ),
          ( TreasureItemType_Orig.Weapon,             0.18f ),
          ( TreasureItemType_Orig.Jewelry,            0.21f ),
          ( TreasureItemType_Orig.Clothing,           0.09f ),
          ( TreasureItemType_Orig.Gem,                0.01f ),
          ( TreasureItemType_Orig.Cloak,              0.01f  ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile10 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType_Orig.Armor,              0.50f ),
          ( TreasureItemType_Orig.Weapon,             0.18f ),
          ( TreasureItemType_Orig.Jewelry,            0.21f ),
          ( TreasureItemType_Orig.Clothing,           0.09f ),
          ( TreasureItemType_Orig.Gem,                0.01f ),
          ( TreasureItemType_Orig.Cloak,              0.01f  ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile11 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType_Orig.Armor,              0.50f ),
          ( TreasureItemType_Orig.Weapon,             0.18f ),
          ( TreasureItemType_Orig.Jewelry,            0.21f ),
          ( TreasureItemType_Orig.Clothing,           0.09f ),
          ( TreasureItemType_Orig.Gem,                0.01f ),
          ( TreasureItemType_Orig.Cloak,              0.01f  ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile12 = new ChanceTable<TreasureItemType>()
        {
          ( TreasureItemType_Orig.Armor,              0.50f ),
          ( TreasureItemType_Orig.Weapon,             0.18f ),
          ( TreasureItemType_Orig.Jewelry,            0.21f ),
          ( TreasureItemType_Orig.Clothing,           0.09f ),
          ( TreasureItemType_Orig.Gem,                0.01f ),
          ( TreasureItemType_Orig.Cloak,              0.01f  ),
        };

        // added

        private static ChanceTable<TreasureItemType> magicItemProfile13 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyBreastplate,  1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile14 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyGauntlets,    1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile15 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyGirth,        1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile16 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyGreaves,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile17 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyHelm,         1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile18 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyPauldrons,    1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile19 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyTassets,      1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile20 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietyVambraces,    1.0f ),
        };

        private static ChanceTable<TreasureItemType> magicItemProfile21 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.SocietySollerets,    1.0f ),
        };

        // Legendary Chest
        private static ChanceTable<TreasureItemType> magicItemProfile22 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType_Orig.Weapon,             0.35f ),
            ( TreasureItemType_Orig.Armor,              0.40f ),
            ( TreasureItemType_Orig.Clothing,           0.10f ),
            ( TreasureItemType_Orig.Jewelry,            0.10f ),
            ( TreasureItemType_Orig.Cloak,              0.05f ),
            //( TreasureItemType_Orig.PetDevice,          0.05f ),
        };

        // Legendary Magic Chest
        private static ChanceTable<TreasureItemType> magicItemProfile23 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType_Orig.Clothing,           0.40f ),
            ( TreasureItemType_Orig.Jewelry,            0.30f ),
            ( TreasureItemType_Orig.Cloak,              0.30f ),
            //( TreasureItemType_Orig.PetDevice,          0.30f ),
        };

        // Mana Forge Chest
        private static ChanceTable<TreasureItemType> magicItemProfile24 = new ChanceTable<TreasureItemType>()
        {
            ( TreasureItemType.Weapon,              0.20f ),
            ( TreasureItemType.Armor,               0.20f ),
            ( TreasureItemType.Clothing,            0.30f ),
            ( TreasureItemType.Jewelry,             0.30f ),
        };

        /// <summary>
        /// TreasureDeath.MagicItemTreasureTypeSelectionChances indexes into these profiles
        /// </summary>
        public static List<ChanceTable<TreasureItemType>> magicItemProfiles = new List<ChanceTable<TreasureItemType>>()
        {
            magicItemProfile1,
            magicItemProfile2,
            magicItemProfile3,
            magicItemProfile4,
            magicItemProfile5,
            magicItemProfile6,
            magicItemProfile7,
            magicItemProfile8,
            magicItemProfile9,
            magicItemProfile10,
            magicItemProfile11,
            magicItemProfile12,
            magicItemProfile13,
            magicItemProfile14,
            magicItemProfile15,
            magicItemProfile16,
            magicItemProfile17,
            magicItemProfile18,
            magicItemProfile19,
            magicItemProfile20,
            magicItemProfile21,
            magicItemProfile22,
            magicItemProfile23,
            magicItemProfile24,
        };

        /// <summary>
        /// Rolls for a TreasureItemType for a TreasureItemCategory.MagicItem
        /// </summary>
        /// <param name="magicItemProfile">From TreasureDeath.MagicItemTreasureTypeSelectionChances</param>
        public static TreasureItemType Roll(int magicItemProfile)
        {
            if (magicItemProfile < 1 || magicItemProfile > magicItemProfiles.Count)
                return TreasureItemType.Undef;

            return magicItemProfiles[magicItemProfile - 1].Roll();
        }
    }
}
