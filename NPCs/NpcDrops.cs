using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SkyblockThoriumHelper.NPCs {
    public class NpcDrops : GlobalNPC {
        public override void NPCLoot(NPC npc) {
            Mod thoriumMod = ModLoader.GetMod("ThoriumMod");
            if ((int)npc.position.Y >= 1300){ //Specifically for this skyblcok
                if (Main.rand.Next(1) == 0){ // 50% chance
                    Item.NewItem(npc.getRect(),
                                 thoriumMod.ItemType("MagmaOre"),
                                 Main.rand.Next(3, 8));
                }
            }
        }
    }
}
