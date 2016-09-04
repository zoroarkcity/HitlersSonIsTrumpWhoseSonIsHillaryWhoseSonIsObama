using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs
{
    public class TGEMGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Pumpking)
            {
                if (Main.rand.Next(3) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Pumpking")); //Item spawn
                }
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.IceQueen) //change Zombie with the npc you want
            {
                if (Main.rand.Next(3) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Snowyo"));  //put the item name that you want the npc to drop
                    return true;
                }
            }

            if (npc.type == NPCID.Golem)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GolemStaff"));
                return true;
            }
            return true;
        }
    }
}