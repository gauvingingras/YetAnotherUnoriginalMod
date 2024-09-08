using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class EarthRing : ModItem
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
                .AddIngredient(ItemID.Amber, 6)
                .AddIngredient(ItemID.FossilOre, 10)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }
    }
}
