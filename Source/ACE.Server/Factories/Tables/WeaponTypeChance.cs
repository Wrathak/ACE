using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables
{
    public static class WeaponTypeChance
    {
        private static ChanceTable<TreasureWeaponType> T1_T4_Chances = new ChanceTable<TreasureWeaponType>()
        {
            //( TreasureWeaponType.Sword,           0.09f ),
            //( TreasureWeaponType.Mace,            0.09f ),
            //( TreasureWeaponType.Axe,             0.08f ),
            //( TreasureWeaponType.Spear,           0.08f ),
            //( TreasureWeaponType.Staff,           0.09f ),
            //( TreasureWeaponType.Dagger,          0.09f ),
            ( TreasureWeaponType.Unarmed,         0.33f ),
            ( TreasureWeaponType.Bow,             0.33f ),
            ( TreasureWeaponType.Caster,          0.33f ),
        };

        private static ChanceTable<TreasureWeaponType> T5_T6_Chances = new ChanceTable<TreasureWeaponType>()
        {
          ( TreasureWeaponType.Unarmed,         0.33f ),
          ( TreasureWeaponType.Bow,             0.33f ),
          ( TreasureWeaponType.Caster,          0.33f ),
        };

        // from magloot corpse logs
        // it appears they might have gotten rid of the tier chances
        private static ChanceTable<TreasureWeaponType> RetailChances = new ChanceTable<TreasureWeaponType>()
        {
          ( TreasureWeaponType.Unarmed,         0.60f ),
          ( TreasureWeaponType.Bow,             0.20f ),
          ( TreasureWeaponType.Caster,          0.20f ),
        };

        /// <summary>
        /// Even chance for all melee weapon types
        /// Only used for test methods
        /// </summary>
        public static ChanceTable<TreasureWeaponType> MeleeChances = new ChanceTable<TreasureWeaponType>()
        {
            ( TreasureWeaponType.Sword,           0.993f ),
            ( TreasureWeaponType.Mace,            0.001f ),
            ( TreasureWeaponType.Axe,             0.001f ),
            ( TreasureWeaponType.Spear,           0.001f ),
            ( TreasureWeaponType.Unarmed,         0.001f ),
            ( TreasureWeaponType.Staff,           0.001f ),
            ( TreasureWeaponType.Dagger,          0.001f ),
            ( TreasureWeaponType.TwoHandedWeapon, 0.001f ),
        };

        /// <summary>
        /// Roughly even chance for all missile weapon types
        /// Only used for test methods
        /// </summary>
        public static ChanceTable<TreasureWeaponType> MissileChances = new ChanceTable<TreasureWeaponType>()
        {
            ( TreasureWeaponType.Bow,             0.998f ),
            ( TreasureWeaponType.Crossbow,        0.001f ),
            ( TreasureWeaponType.Atlatl,          0.001f ),
        };

        private static readonly List<ChanceTable<TreasureWeaponType>> weaponTiers = new List<ChanceTable<TreasureWeaponType>>()
        {
            T1_T4_Chances,
            T1_T4_Chances,
            T1_T4_Chances,
            T1_T4_Chances,
            T5_T6_Chances,
            T5_T6_Chances,
        };

        public static TreasureWeaponType Roll(int tier)
        {
            // todo: add unique profiles for t7 / t8?
            //tier = Math.Clamp(tier, 1, 6);

            //return weaponTiers[tier - 1].Roll();

            return RetailChances.Roll();
        }
    }
}
