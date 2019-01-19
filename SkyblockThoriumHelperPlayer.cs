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

            /*  
				8.9% if fishing power == 100
                roughly matches other biome crates 
			*/
            float baseChance = .00089f; 
            float scarletCrateChance = baseChance * power;
            int crateChance = 10;

            /*	
				Change crate rate to 1/5 if player has a crate potion.
				This doesn't behave the same really as other crates
				but it's fairly close.	
			*/
            if (player.cratePotion)
            {
                crateChance /= 2;
            }

            //if in cavern(3) or underworld and liquid is water and 1/CrateChance
            if (worldLayer >= 3 && liquidType == 0 && Main.rand.NextFloat() < scarletCrateChance && Main.rand.Next(crateChance) == 0)
            {
                caughtType = thoriumMod.ItemType("ScarletCrate");
            }
        }
    }
}
