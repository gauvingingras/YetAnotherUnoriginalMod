using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    internal class Onyx : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
        }
    }
}
