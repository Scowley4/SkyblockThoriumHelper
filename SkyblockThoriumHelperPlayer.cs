using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace SkyblockThoriumHelper {
    public class SkyblockThoriumHelperPlayer : ModPlayer {
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk) {
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");

            /*  8.9% if fishing power == 100
                roughly matches other biome crates */
            float baseChance = .00089f; 
            float scarletCrateChance = baseChance * power;
            int crateChance = 10;

            /*	Change crate rate to 1/5 if player has a crate potion.
				This doesn't behave the same exactly as other crates
				but it's fairly close. */
            if (Main.player[Main.myPlayer].cratePotion) crateChance /= 2;

            //Determine if Scarlet Crate should be fished
            if (worldLayer >= 3 && liquidType == 0 
                && Main.rand.NextFloat() < scarletCrateChance 
                && Main.rand.Next(crateChance) == 0) {

                caughtType = thoriumMod.ItemType("ScarletCrate");
            }
        }
    }
}
