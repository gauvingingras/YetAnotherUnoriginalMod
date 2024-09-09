using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Materials
{
    internal class MechanicalCog : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MechanicalGear>(5)
                .AddIngredient(ItemID.Cog, 15)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
