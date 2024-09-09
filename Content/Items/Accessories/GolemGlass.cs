using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class GolemGlass : AccessoryBase
    {
        public override int Width => 28;

        public override int Height => 28;

        public override int Value => 0;

        public override int Rare => ItemRarityID.White;

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MagnifyingGlass>()
                .AddIngredient(ItemID.EyeoftheGolem)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetCritChance(DamageClass.Generic) += 15;
        }
    }
}
