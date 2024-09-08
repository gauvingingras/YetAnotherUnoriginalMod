using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class ShadowRing : ModItem
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
                .AddIngredient<Onyx>(6)
                .AddRecipeGroup(YetAnotherUnoriginalModRecipes.CursedFlameRecipeGroup, 5)
                .AddIngredient(ItemID.SoulofNight, 5)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }
    }
}
