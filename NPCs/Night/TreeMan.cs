using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs.Night
{
	public class TreeMan : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Tree Man";
			npc.displayName = "Tree Man";
			npc.width = 16;
			npc.height = 40;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 50;
			npc.soundHit = 7;
			npc.soundKilled = 3;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			return (tile == 2) && !Main.bloodMoon && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.1f : 0f;
		}
		
			public override void NPCLoot()
	{
			int amountToDrop = Main.rand.Next(3,10);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Wood, amountToDrop);
					if(Main.rand.Next(60) == 0)
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LivingTwig"));
    }
	}
	
			public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	}
}
