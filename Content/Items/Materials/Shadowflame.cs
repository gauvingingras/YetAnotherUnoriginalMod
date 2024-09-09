using Terraria;
using Terraria.ID;

namespace YetAnotherUnoriginalMod.Content.Items.Materials
{
    internal class Shadowflame : MaterialBase
    {
        public override int Width => 26;

        public override int Height => 30;

        public override int Value => Item.buyPrice(silver: 15);

        public override int Rare => ItemRarityID.White;
    }
}
