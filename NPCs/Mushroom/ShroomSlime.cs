using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs.Mushroom
{
	public class ShroomSlime : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Shroom Slime";
			npc.displayName = "Shroom Slime";
			npc.width = 48;
			npc.height = 36;
			npc.damage = 20;
			npc.defense = 10;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}

		public override float CanSpawn(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			return (tile == 70) && spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.2f : 0f;
		}
		
					public override void NPCLoot()
	{
			int amountToDrop = Main.rand.Next(1,5);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, amountToDrop);
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GlowingMushroom, amountToDrop);
			
	}
	
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
	{
		npc.lifeMax = (int)(npc.lifeMax * 1f);
		npc.damage = (int)(npc.damage * 1f);
	}
	
	}
}
