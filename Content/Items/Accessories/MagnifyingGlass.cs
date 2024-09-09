using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items.Accessories
{
    internal class MagnifyingGlass : AccessoryBase
    {
        public override int Width => 24;

        public override int Height => 24;

        public override int Value => 0;

        public override int Rare => ItemRarityID.White;

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetCritChance(DamageClass.Generic) += 5;
        }
    }
}
