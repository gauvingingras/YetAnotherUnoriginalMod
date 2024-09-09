using Terraria;
using Terraria.ID;

namespace YetAnotherUnoriginalMod.Content.Items.Materials
{
    internal class Ring : MaterialBase
    {
        public override int Width => 30;

        public override int Height => 26;

        public override int Value => Item.sellPrice(gold: 1);

        public override int Rare => ItemRarityID.White;
    }
}
