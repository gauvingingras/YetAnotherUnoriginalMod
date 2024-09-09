using Terraria;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    abstract class MaterialBase : ModItem
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract int Value { get; }
        public abstract int Rare { get; }

        public override sealed void SetDefaults()
        {
            Item.width = Width;
            Item.height = Height;
            Item.value = Value;
            Item.rare = Rare;
            Item.maxStack = Item.CommonMaxStack;
        }
    }
}
