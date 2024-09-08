using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using YetAnotherUnoriginalMod.Common.Players;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class RainbowRing : ModItem
    {
        public override void SetDefaults()
        {
            Item.DefaultToAccessory(30, 26);
            Item.value = Item.sellPrice(gold: 7);
            Item.rare = ItemRarityID.LightPurple;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FireRing>()
                .AddIngredient<EarthRing>()
                .AddIngredient<ElectricRing>()
                .AddIngredient<WindRing>()
                .AddIngredient<AquaRing>()
                .AddIngredient<ToxinRing>()
                .AddIngredient<FrostRing>()
                .AddIngredient<ShadowRing>()
                .AddIngredient<BrightRing>()
                .AddIngredient<NatureRing>()
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            YetAnotherUnoriginalModModPlayer modPlayer = player.GetModPlayer<YetAnotherUnoriginalModModPlayer>();

            modPlayer.fireDamage *= 1.1f;
            modPlayer.earthDamage *= 1.1f;
            modPlayer.electricDamage *= 1.1f;
            modPlayer.windDamage *= 1.1f;
            modPlayer.waterDamage *= 1.1f;
            modPlayer.poisonDamage *= 1.1f;
            modPlayer.coldDamage *= 1.1f;
            modPlayer.darkDamage *= 1.1f;
            modPlayer.lightDamage *= 1.1f;
            modPlayer.natureDamage *= 1.1f;
        }
    }
}
