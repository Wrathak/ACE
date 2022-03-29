using System.Collections.Generic;

using ACE.Entity.Enum;
using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables
{
    /// <summary>
    /// Defines which spells can be found on item types
    /// </summary>
    public static class SpellSelectionTable
    {
        // thanks to Sapphire Knight and Butterflygolem for helping to figure this part out!

        // gems
        private static ChanceTable<SpellId> spellSelectionGroup1 = new ChanceTable<SpellId>()
        {
            ( SpellId.StrengthSelf1,            0.06f ),
            ( SpellId.EnduranceSelf1,           0.06f ),
            ( SpellId.CoordinationSelf1,        0.06f ),
            ( SpellId.QuicknessSelf1,           0.06f ),
            ( SpellId.FocusSelf1,               0.06f ),
            ( SpellId.WillpowerSelf1,           0.06f ),
            ( SpellId.RegenerationSelf1,        0.11f ),
            ( SpellId.RejuvenationSelf1,        0.11f ),
            ( SpellId.ManaRenewalSelf1,         0.11f ),
            ( SpellId.AcidProtectionSelf1,      0.03f ),
            ( SpellId.BludgeonProtectionSelf1,  0.03f ),
            ( SpellId.ColdProtectionSelf1,      0.03f ),
            ( SpellId.LightningProtectionSelf1, 0.03f ),
            ( SpellId.FireProtectionSelf1,      0.03f ),
            ( SpellId.BladeProtectionSelf1,     0.03f ),
            ( SpellId.PiercingProtectionSelf1,  0.03f ),
            ( SpellId.ArmorSelf1,               0.10f ),
        };

        // jewelry
        private static ChanceTable<SpellId> spellSelectionGroup2 = new ChanceTable<SpellId>()
        {
            ( SpellId.ArmorSelf1,               0.08f ),
            ( SpellId.AcidProtectionSelf1,      0.08f ),
            ( SpellId.BludgeonProtectionSelf1,  0.08f ),
            ( SpellId.ColdProtectionSelf1,      0.08f ),
            ( SpellId.LightningProtectionSelf1, 0.08f ),
            ( SpellId.FireProtectionSelf1,      0.08f ),
            ( SpellId.BladeProtectionSelf1,     0.08f ),
            ( SpellId.PiercingProtectionSelf1,  0.08f ),

            ( SpellId.ManaRenewalSelf1,         0.05f ),
            ( SpellId.RegenerationSelf1,        0.05f ),
            ( SpellId.RejuvenationSelf1,        0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1, 0.05f ),

            ( SpellId.ItemExpertiseSelf1,       0.04f ),
            ( SpellId.ArmorExpertiseSelf1,      0.04f ),
            ( SpellId.MagicItemExpertiseSelf1,  0.04f ),
            ( SpellId.WeaponExpertiseSelf1,     0.04f ),

            //( SpellId.ManaMasterySelf1,         0.04f ),
            //( SpellId.MagicResistanceSelf1,     0.08f ),
            //( SpellId.MonsterAttunementSelf1,   0.01f ),
            //( SpellId.PersonAttunementSelf1,    0.01f ),
        };

        // crowns
        private static ChanceTable<SpellId> spellSelectionGroup3 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // orbs
        private static ChanceTable<SpellId> spellSelectionGroup4 = new ChanceTable<SpellId>()
        {
          ( SpellId.ManaMasterySelf1,                0.15f ),

          ( SpellId.LifeMagicMasterySelf1,           0.15f ),
          ( SpellId.WarMagicMasterySelf1,            0.15f ),
          ( SpellId.ItemEnchantmentMasterySelf1,     0.15f ),

          ( SpellId.ItemExpertiseSelf1,        0.10f ),
          ( SpellId.ArmorExpertiseSelf1,       0.10f ),
          ( SpellId.MagicItemExpertiseSelf1,   0.10f ),
          ( SpellId.WeaponExpertiseSelf1,      0.10f ),

          //( SpellId.CreatureEnchantmentMasterySelf1, 0.15f ),
        };

        // wands, staffs, sceptres, batons
        private static ChanceTable<SpellId> spellSelectionGroup5 = new ChanceTable<SpellId>()
        {
          ( SpellId.ManaMasterySelf1,                0.15f ),

          ( SpellId.LifeMagicMasterySelf1,           0.15f ),
          ( SpellId.WarMagicMasterySelf1,            0.15f ),
          ( SpellId.ItemEnchantmentMasterySelf1,     0.15f ),

          ( SpellId.ItemExpertiseSelf1,        0.10f ),
          ( SpellId.ArmorExpertiseSelf1,       0.10f ),
          ( SpellId.MagicItemExpertiseSelf1,   0.10f ),
          ( SpellId.WeaponExpertiseSelf1,      0.10f ),
        };

        // one-handed melee weapons
        private static ChanceTable<SpellId> spellSelectionGroup6 = new ChanceTable<SpellId>()
        {
            ( SpellId.HeavyWeaponsMasterySelf1,  0.25f ),

            ( SpellId.DirtyFightingMasterySelf1, 0.15f ),
            ( SpellId.RecklessnessMasterySelf1,  0.15f ),
            ( SpellId.SneakAttackMasterySelf1,   0.15f ),

            ( SpellId.ItemExpertiseSelf1,        0.075f ),
            ( SpellId.ArmorExpertiseSelf1,       0.075f ),
            ( SpellId.MagicItemExpertiseSelf1,   0.075f ),
            ( SpellId.WeaponExpertiseSelf1,      0.075f ),
        };

        // bracers, breastplates, coats, cuirasses, girths, hauberks, pauldrons, chest armor, sleeves
        private static ChanceTable<SpellId> spellSelectionGroup7 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // shields
        private static ChanceTable<SpellId> spellSelectionGroup8 = new ChanceTable<SpellId>()
        {
          ( SpellId.ShieldMasterySelf1,        0.50f ),

          ( SpellId.DirtyFightingMasterySelf1, 0.10f ),
          ( SpellId.RecklessnessMasterySelf1,  0.10f ),
          ( SpellId.SneakAttackMasterySelf1,   0.10f ),

          ( SpellId.ItemExpertiseSelf1,        0.05f ),
          ( SpellId.ArmorExpertiseSelf1,       0.05f ),
          ( SpellId.MagicItemExpertiseSelf1,   0.05f ),
          ( SpellId.WeaponExpertiseSelf1,      0.05f ),
        };

        // gauntlets
        private static ChanceTable<SpellId> spellSelectionGroup9 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // helms, basinets, helmets, coifs, cowls, heaumes, kabutons
        private static ChanceTable<SpellId> spellSelectionGroup10 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // boots, chiran sandals, sollerets
        private static ChanceTable<SpellId> spellSelectionGroup11 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // breeches, jerkins, shirts, pants, tunics, doublets, trousers, pantaloons
        private static ChanceTable<SpellId> spellSelectionGroup12 = new ChanceTable<SpellId>()
        {
          ( SpellId.ArmorSelf1,               0.08f ),
          ( SpellId.AcidProtectionSelf1,      0.08f ),
          ( SpellId.BludgeonProtectionSelf1,  0.08f ),
          ( SpellId.ColdProtectionSelf1,      0.08f ),
          ( SpellId.LightningProtectionSelf1, 0.08f ),
          ( SpellId.FireProtectionSelf1,      0.08f ),
          ( SpellId.BladeProtectionSelf1,     0.08f ),
          ( SpellId.PiercingProtectionSelf1,  0.08f ),

          ( SpellId.ManaRenewalSelf1,         0.05f ),
          ( SpellId.RegenerationSelf1,        0.05f ),
          ( SpellId.RejuvenationSelf1,        0.05f ),
          ( SpellId.ArcaneEnlightenmentSelf1, 0.05f ),

          ( SpellId.ItemExpertiseSelf1,       0.04f ),
          ( SpellId.ArmorExpertiseSelf1,      0.04f ),
          ( SpellId.MagicItemExpertiseSelf1,  0.04f ),
          ( SpellId.WeaponExpertiseSelf1,     0.04f ),
        };

        // caps, qafiyas, turbans, fezs, berets
        private static ChanceTable<SpellId> spellSelectionGroup13 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // cloth gloves (1 entry?)
        private static ChanceTable<SpellId> spellSelectionGroup14 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // greaves, leggings, tassets, leather pants
        private static ChanceTable<SpellId> spellSelectionGroup15 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // dinnerware
        private static ChanceTable<SpellId> spellSelectionGroup16 = new ChanceTable<SpellId>()
        {
            ( SpellId.AlchemyMasterySelf1,     0.09f ),
            ( SpellId.CookingMasterySelf1,     0.09f ),
            ( SpellId.FletchingMasterySelf1,   0.09f ),
            ( SpellId.LockpickMasterySelf1,    0.08f ),
            ( SpellId.ArcanumSalvagingSelf1,   0.08f ),
            ( SpellId.ArmorExpertiseSelf1,     0.08f ),
            ( SpellId.ItemExpertiseSelf1,      0.08f ),
            ( SpellId.MagicItemExpertiseSelf1, 0.08f ),
            ( SpellId.WeaponExpertiseSelf1,    0.08f ),
            ( SpellId.WillpowerSelf1,          0.05f ),
            ( SpellId.StrengthSelf1,           0.04f ),
            ( SpellId.EnduranceSelf1,          0.04f ),
            ( SpellId.CoordinationSelf1,       0.04f ),
            ( SpellId.QuicknessSelf1,          0.04f ),
            ( SpellId.FocusSelf1,              0.04f ),
        };

        // added

        // missile weapons, two-handed weapons
        private static ChanceTable<SpellId> spellSelectionGroup17 = new ChanceTable<SpellId>()
        {
            ( SpellId.MissileWeaponsMasterySelf1, 0.25f ),
            ( SpellId.FletchingMasterySelf1,     0.125f ),
            ( SpellId.AlchemyMasterySelf1,       0.125f ),

            ( SpellId.DirtyFightingMasterySelf1, 0.10f ),
            ( SpellId.RecklessnessMasterySelf1,  0.10f ),
            ( SpellId.SneakAttackMasterySelf1,   0.10f ),

            ( SpellId.ItemExpertiseSelf1,        0.05f ),
            ( SpellId.ArmorExpertiseSelf1,       0.05f ),
            ( SpellId.MagicItemExpertiseSelf1,   0.05f ),
            ( SpellId.WeaponExpertiseSelf1,      0.05f ),
        };

        // shoes, loafers, slippers, sandals
        private static ChanceTable<SpellId> spellSelectionGroup18 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        // nether caster
        private static ChanceTable<SpellId> spellSelectionGroup19 = new ChanceTable<SpellId>()
        {
            ( SpellId.ManaMasterySelf1,                0.15f ),

            ( SpellId.LifeMagicMasterySelf1,           0.15f ),
            ( SpellId.VoidMagicMasterySelf1,           0.15f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.15f ),

            ( SpellId.ItemExpertiseSelf1,        0.10f ),
            ( SpellId.ArmorExpertiseSelf1,       0.10f ),
            ( SpellId.MagicItemExpertiseSelf1,   0.10f ),
            ( SpellId.WeaponExpertiseSelf1,      0.10f ),
        };

        // leather cap (1 entry?)
        private static ChanceTable<SpellId> spellSelectionGroup20 = new ChanceTable<SpellId>()
        {
          ( SpellId.StrengthSelf1,             0.08f ),
          ( SpellId.EnduranceSelf1,            0.08f ),
          ( SpellId.CoordinationSelf1,         0.08f ),
          ( SpellId.QuicknessSelf1,            0.08f ),
          ( SpellId.FocusSelf1,                0.08f ),
          ( SpellId.WillpowerSelf1,            0.08f ),

          ( SpellId.MagicResistanceSelf1,      0.08f ),
          ( SpellId.ImpregnabilitySelf1,       0.08f ),
          ( SpellId.InvulnerabilitySelf1,      0.09f ),

          ( SpellId.HealingMasterySelf1,       0.09f ),
          ( SpellId.SprintSelf1,               0.09f ),
          ( SpellId.ArcanumSalvagingSelf1,     0.09f ),
        };

        /// <summary>
        /// Key is (PropertyInt.TsysMutationData >> 24) - 1
        /// </summary>
        private static readonly List<ChanceTable<SpellId>> spellSelectionGroup = new List<ChanceTable<SpellId>>()
        {
            spellSelectionGroup1,
            spellSelectionGroup2,
            spellSelectionGroup3,
            spellSelectionGroup4,
            spellSelectionGroup5,
            spellSelectionGroup6,
            spellSelectionGroup7,
            spellSelectionGroup8,
            spellSelectionGroup9,
            spellSelectionGroup10,
            spellSelectionGroup11,
            spellSelectionGroup12,
            spellSelectionGroup13,
            spellSelectionGroup14,
            spellSelectionGroup15,
            spellSelectionGroup16,
            spellSelectionGroup17,
            spellSelectionGroup18,
            spellSelectionGroup19,
            spellSelectionGroup20,
        };

        /// <summary>
        /// Rolls for a creature / life spell for an item
        /// </summary>
        /// <param name="spellCode">the SpellCode from WorldObject</param>
        public static SpellId Roll(int spellCode)
        {
            return spellSelectionGroup[spellCode - 1].Roll();
        }
    }
}
