using Terraria.Audio;
using Terraria.ID;

namespace YetAnotherUnoriginalMod.Content.Items.Weapons
{
    internal class PossessedSword : SwordBase
    {
        public override int Width => 44;

        public override int Height => 44;

        public override int UseTime => 20;

        public override bool AutoReuse => true;

        public override int Damage => 50;

        public override int KnockBack => 6;

        public override int Crit => 6;

        public override int Value => 0;

        public override int Rare => ItemRarityID.White;

        public override SoundStyle UseSound => SoundID.Item1;
    }
}
