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
            if (npc.type == NPCID.WallofFlesh)
            {
               int amountToDrop = Main.rand.Next(10,15);
               Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BrassAlloy"), amountToDrop); 
            }
			
			if (npc.type == 4)
            {
               int amountToDrop = Main.rand.Next(36,42);
               Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WideLens"), amountToDrop); 
            }
          
        }
    }
}