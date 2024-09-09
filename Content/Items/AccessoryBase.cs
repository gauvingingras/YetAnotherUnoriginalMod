using Terraria;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    abstract class AccessoryBase : ModItem
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract int Value { get; }
        public abstract int Rare { get; }

        public override sealed void SetDefaults()
        {
            Item.DefaultToAccessory(Width, Height);
            Item.value = Value;
            Item.rare = Rare;
        }
    }
}
