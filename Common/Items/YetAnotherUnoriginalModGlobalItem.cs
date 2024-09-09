using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using YetAnotherUnoriginalMod.Common.Players;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Common.Items
{
    internal class YetAnotherUnoriginalModGlobalItem : GlobalItem
    {
        private readonly static List<int> FireWeapons =
            [
                ItemID.FieryGreatsword,
                ItemID.HelFire,
                ItemID.Flamarang,
                ItemID.FlamingMace,
                ItemID.Sunfury,
                ItemID.DayBreak,
                ItemID.SolarEruption,

                ItemID.HellwingBow,
                ItemID.MoltenFury,
                ItemID.DD2PhoenixBow,
                ItemID.PhoenixBlaster,
                ItemID.MolotovCocktail,
                ItemID.Flamethrower,
                ItemID.ElfMelter,

                ItemID.FlowerofFire,
                ItemID.Flamelash,
                ItemID.InfernoFork,
                ItemID.ApprenticeStaffT3,

                ItemID.ImpStaff,
                ItemID.DD2FlameburstTowerT1Popper,
                ItemID.DD2FlameburstTowerT2Popper,
                ItemID.DD2FlameburstTowerT3Popper,
                ItemID.FireWhip
            ];
        private readonly static List<int> EarthWeapons = [];
        private readonly static List<int> ElectricWeapons = [];
        private readonly static List<int> WindWeapons = [];
        private readonly static List<int> WaterWeapons = [];
        private readonly static List<int> PoisonWeapons = [];
        private readonly static List<int> ColdWeapons = [];
        private readonly static List<int> DarkWeapons = [];
        private readonly static List<int> LightWeapons = [];
        private readonly static List<int> NatureWeapons = [];

        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            switch (item.type)
            {
                case ItemID.DestroyerBossBag:
                case ItemID.SkeletronPrimeBossBag:
                case ItemID.TwinsBossBag:
                    itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechanicalGear>(), minimumDropped: 25, maximumDropped: 45));
                    break;
            }
        }

        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            YetAnotherUnoriginalModModPlayer modPlayer = player.GetModPlayer<YetAnotherUnoriginalModModPlayer>();

            if (FireWeapons.Contains(item.type))
            {
                damage *= modPlayer.fireDamage;
            }

            if (EarthWeapons.Contains(item.type))
            {
                damage *= modPlayer.earthDamage;
            }

            if (ElectricWeapons.Contains(item.type))
            {
                damage *= modPlayer.electricDamage;
            }

            if (WindWeapons.Contains(item.type))
            {
                damage *= modPlayer.windDamage;
            }

            if (WaterWeapons.Contains(item.type))
            {
                damage *= modPlayer.waterDamage;
            }

            if (PoisonWeapons.Contains(item.type))
            {
                damage *= modPlayer.poisonDamage;
            }

            if (ColdWeapons.Contains(item.type))
            {
                damage *= modPlayer.coldDamage;
            }

            if (DarkWeapons.Contains(item.type))
            {
                damage *= modPlayer.darkDamage;
            }

            if (LightWeapons.Contains(item.type))
            {
                damage *= modPlayer.lightDamage;
            }

            if (NatureWeapons.Contains(item.type))
            {
                damage *= modPlayer.natureDamage;
            }
        }
    }
}
