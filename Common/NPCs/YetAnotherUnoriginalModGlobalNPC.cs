using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using YetAnotherUnoriginalMod.Content.Items.Materials;

namespace YetAnotherUnoriginalMod.Common.NPCs
{
    internal class YetAnotherUnoriginalModGlobalNPC : GlobalNPC
    {
        private static CommonDrop CommonWithNumerator(int itemId, int chanceNumerator = 1, int chanceDenominator = 1, int minimumDropped = 1, int maximumDropped = 1) => new(itemId, chanceDenominator, minimumDropped, maximumDropped, chanceNumerator);

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                case NPCID.LavaSlime:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MoltenCore>()));
                    break;

                case NPCID.Demon:
                case NPCID.VoodooDemon:
                    npcLoot.Add(CommonWithNumerator(ModContent.ItemType<DemonHorn>(), chanceNumerator: 2, chanceDenominator: 3, maximumDropped: 2));
                    break;

                case NPCID.Retinazer:
                case NPCID.Spazmatism:
                    npcLoot.Add(ItemDropRule.ByCondition(new Conditions.MissingTwin(), ModContent.ItemType<MechanicalGear>(), minimumDropped: 25, maximumDropped: 45));
                    break;

                case NPCID.SkeletronPrime:
                case NPCID.TheDestroyer:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MechanicalGear>(), minimumDropped: 25, maximumDropped: 45));
                    break;

                case NPCID.MartianSaucerCore:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MartianPowerCell>(), minimumDropped: 3, maximumDropped: 5));
                    break;

                case NPCID.GoblinSummoner:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Shadowflame>(), maximumDropped: 5));
                    break;

                case NPCID.MartianWalker:
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MartianPowerCell>()));
                    break;
            }
        }

        public override void ModifyShop(NPCShop shop)
        {
            switch (shop.NpcType)
            {
                case NPCID.Wizard:
                    shop.Add<Ring>();
                    break;

                case NPCID.Cyborg:
                    shop.Add<MartianPowerCell>(Condition.DownedMartians);
                    break;

                case NPCID.WitchDoctor:
                    shop.Add<Shadowflame>(Condition.DownedGoblinArmy); // TODO: Should check if goblin army is downed in hardmode, not only hardmode + goblin army
                    break;
            }
        }
    }
}
