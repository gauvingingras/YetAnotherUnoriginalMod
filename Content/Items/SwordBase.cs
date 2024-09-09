using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    abstract class SwordBase : ModItem
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract int UseTime { get; }
        public abstract bool AutoReuse { get; }
        public abstract int Damage { get; }
        public abstract int KnockBack { get; }
        public abstract int Crit { get; }
        public abstract int Value { get; }
        public abstract int Rare { get; }
        public abstract SoundStyle UseSound { get; }

        public override sealed void SetDefaults()
        {
            Item.width = Width;
            Item.height = Height;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = UseTime;
            Item.useAnimation = UseTime;
            Item.autoReuse = AutoReuse;
            Item.DamageType = DamageClass.Melee;
            Item.damage = Damage;
            Item.knockBack = KnockBack;
            Item.crit = Crit;
            Item.value = Value;
            Item.rare = Rare;
            Item.UseSound = UseSound;
        }
    }
}
