using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Content.Items
{
    internal class YetAnotherUnoriginalModRecipes : ModSystem
    {
        public static RecipeGroup IronOreRecipeGroup;
        public static RecipeGroup CursedFlameRecipeGroup;

        public override void Unload()
        {
            IronOreRecipeGroup = null;
            CursedFlameRecipeGroup = null;
        }

        public override void AddRecipeGroups()
        {
            IronOreRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.IronOre)}",
                ItemID.IronOre,
                ItemID.LeadOre);
            RecipeGroup.RegisterGroup(nameof(ItemID.IronOre), IronOreRecipeGroup);

            CursedFlameRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CursedFlame)}",
                ItemID.CursedFlame,
                ItemID.Ichor);
            RecipeGroup.RegisterGroup(nameof(ItemID.CursedFlame), CursedFlameRecipeGroup);
        }
    }
}
