using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    internal class Jade : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 18;
            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
        }
    }
}
