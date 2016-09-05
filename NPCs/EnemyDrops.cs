using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs
{
    public class EnemyDrops : GlobalNPC
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
            if (npc.type == NPCID.IceQueen) 
            {
                if (Main.rand.Next(3) == 0)   //item rarity
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Snowyo"));  
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