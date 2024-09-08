using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class ToxinRing : ModItem
    {
        public override void SetDefaults()
        {
            Item.DefaultToAccessory(30, 26);
            Item.value = Item.sellPrice(gold: 2);
            Item.rare = ItemRarityID.LightRed;
        }

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
    }
}
