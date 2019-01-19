using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace SkyblockThoriumHelper
{
    public class SkyblockThoriumHelperPlayer : ModPlayer
    {
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");
            var player = Main.player[Main.myPlayer];

            /*  8.9% if fishing power == 100
                roughly matches other biome crates although 
                it's techinically outside the regular fishing % 
                so it's a bit wonky     */
            float baseChance = .00089f; //* (player.cratePotion ? 2 : 1);
            float scarletCrateChance = baseChance * power;
            int crateChance = 10;

            //Not really sure if this is an appropriate way to handle crate potions.
            if (player.cratePotion)
            {
                crateChance /= 2;
            }

            //if in cavern or underworld and water and 1/CrateChance
            if (worldLayer >= 3 && liquidType == 0 && Main.rand.NextFloat() < scarletCrateChance && Main.rand.Next(crateChance) == 0)
            {
                caughtType = thoriumMod.ItemType("ScarletCrate");
            }
        }
    }
}
