using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SkyblockThoriumHelper.NPCs {
    public class NpcDrops : GlobalNPC {
        public override void NPCLoot(NPC npc) {
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");

            // Magma Ore
            Point center = npc.Center.ToTileCoordinates();
            if (center.Y >= Main.maxTilesY - 300){
                if (!npc.friendly && !npc.boss && npc.lifeMax > 10 &&
                    Main.rand.Next(2) == 0) { // 50% chance
                    Item.NewItem(npc.getRect(),
                                 thoriumMod.ItemType("MagmaOre"),
                                 Main.rand.Next(3, 8));
                }
            }

            // Bag of Potential
            float bopChance = 0.0F;
            float baseChance = 0.03F;
            if (NPC.downedBoss1) bopChance += 3*baseChance;
            if (NPC.downedBoss2) bopChance += baseChance;
            if (NPC.downedBoss3) bopChance += baseChance;
            if (NPC.downedSlimeKing) bopChance += baseChance;
            if (NPC.downedQueenBee) bopChance += baseChance;

            if (!npc.friendly && !npc.boss && npc.lifeMax > 10 &&
                Main.rand.NextFloat() < bopChance) {

                Item.NewItem(npc.getRect(),
                             thoriumMod.ItemType("ThoriumBag"), 1); //Bag of Potential
            }

        }
    }
}
