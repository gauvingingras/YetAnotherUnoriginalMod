using Terraria.ID;

namespace YetAnotherUnoriginalMod.Content.Items.Materials
{
    internal class MechanicalCog : MaterialBase
    {
        public override int Width => 22;

        public override int Height => 22;

        public override int Value => 0;

        public override int Rare => ItemRarityID.White;

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
