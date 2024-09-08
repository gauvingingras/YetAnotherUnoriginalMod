using Terraria.ID;
using Terraria.ModLoader;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Common.NPCs
{
    internal class YetAnotherUnoriginalModGlobalNPC : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            switch (shop.NpcType)
            {
                case NPCID.Wizard:
                    shop.Add<Ring>();
                    break;
            }
        }
    }
}
