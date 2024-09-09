using Terraria;
using Terraria.ID;
using YetAnotherUnoriginalMod.Common.Players;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class ToxinRing : AccessoryBase
    {
        public override int Width => 30;

        public override int Height => 26;

        public override int Value => Item.sellPrice(gold: 2);

        public override int Rare => ItemRarityID.LightRed;

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amethyst, 6)
                .AddIngredient(ItemID.Stinger, 3)
                .AddIngredient(ItemID.SpiderFang, 2)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            YetAnotherUnoriginalModModPlayer modPlayer = player.GetModPlayer<YetAnotherUnoriginalModModPlayer>();
            modPlayer.poisonDamage *= 1.1f;
        }
    }
}
