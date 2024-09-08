using Terraria.ModLoader;

namespace YetAnotherUnoriginalMod.Common.Players
{
    class YetAnotherUnoriginalModModPlayer : ModPlayer
    {
        public float fireDamage;
        public float earthDamage;
        public float electricDamage;
        public float windDamage;
        public float waterDamage;
        public float poisonDamage;
        public float coldDamage;
        public float darkDamage;
        public float lightDamage;
        public float natureDamage;

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            fireDamage = 1f;
            earthDamage = 1f;
            electricDamage = 1f;
            windDamage = 1f;
            waterDamage = 1f;
            poisonDamage = 1f;
            coldDamage = 1f;
            darkDamage = 1f;
            lightDamage = 1f;
            natureDamage = 1f;
        }
    }
}
