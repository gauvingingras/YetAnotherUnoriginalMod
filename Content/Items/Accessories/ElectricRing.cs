using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class ElectricRing : ModItem
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
                .AddIngredient(ItemID.Topaz, 6)
                .AddRecipeGroup(YetAnotherUnoriginalModRecipes.IronOreRecipeGroup, 10)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }
    }
}
