using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SkyblockThoriumHelper.NPCs {
    public class NpcDrops : GlobalNPC {
        public override void NPCLoot(NPC npc) {
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");
            Point center = npc.Center.ToTileCoordinates();
            if (center.Y >= Main.maxTilesY - 300){
                if (!npc.friendly && !npc.boss && npc.lifeMax > 10 &&
                    Main.rand.Next(2) == 0) { // 50% chance
                    Item.NewItem(npc.getRect(),
                                 thoriumMod.ItemType("MagmaOre"),
                                 Main.rand.Next(3, 8));
                }
            }
        }
    }
}
