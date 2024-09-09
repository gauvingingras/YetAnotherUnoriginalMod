using Terraria;
using Terraria.ID;
using YetAnotherUnoriginalMod.Common.Players;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class BrightRing : AccessoryBase
    {
        public override int Width => 30;

        public override int Height => 26;

        public override int Value => Item.sellPrice(gold: 2);

        public override int Rare => ItemRarityID.LightRed;

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Aventurine>(6)
                .AddIngredient(ItemID.CrystalShard, 5)
                .AddIngredient(ItemID.SoulofLight, 5)
                .AddIngredient(ItemID.SoulofMight, 10)
                .AddIngredient<Ring>()
                .Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            YetAnotherUnoriginalModModPlayer modPlayer = player.GetModPlayer<YetAnotherUnoriginalModModPlayer>();
            modPlayer.lightDamage *= 1.1f;
        }
    }
}
