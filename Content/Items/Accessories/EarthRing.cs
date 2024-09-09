using Terraria;
using Terraria.ID;
using YetAnotherUnoriginalMod.Common.Players;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class EarthRing : AccessoryBase
    {
        public override int Width => 30;

        public override int Height => 26;

        public override int Value => Item.sellPrice(gold: 2);

        public override int Rare => ItemRarityID.LightRed;

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 6)
                .AddIngredient(ItemID.FossilOre, 10)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            YetAnotherUnoriginalModModPlayer modPlayer = player.GetModPlayer<YetAnotherUnoriginalModModPlayer>();
            modPlayer.earthDamage *= 1.1f;
        }
    }
}
