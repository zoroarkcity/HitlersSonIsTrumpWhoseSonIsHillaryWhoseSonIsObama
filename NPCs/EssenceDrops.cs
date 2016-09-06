using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs {
public class EssenceDrops : GlobalNPC
{
public override void NPCLoot(NPC npc)
{
		if(npc.displayName == "Demon Eye" && Main.rand.Next(15) == 0) //Demon Eye Drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoaringEnergy"));
    }
	
	if(npc.type == 5 && Main.rand.Next(10) == 0) //Servant of Cthulhu drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoaringEnergy"));
    }
	
	if(npc.displayName == "Zombie" && Main.rand.Next(20) == 0) //Zombie drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadEnergy"));
    }

	if(npc.displayName == "Skeleton" && Main.rand.Next(2) == 0) //Skeleton drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadEnergy"));
    }
	
		if(npc.type == 161 && Main.rand.Next(7) == 0) //Zombie eskimo drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadEnergy"));
    }
	
	if(npc.displayName == "Angry Bones" && Main.rand.Next(20) == 0)  //Angry Bones drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadEnergy"));
    }
	
	if(npc.type == 32 && Main.rand.Next(20) == 0) //Dark Caster drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadEnergy"));
    }

		if(npc.type == 6 && Main.rand.Next(5) == 0) //Eater of souls drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
	
			if(npc.type == 239 && Main.rand.Next(5) == 0) //Blood Crawler drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
	
			if(npc.type == 240 && Main.rand.Next(5) == 0) //Blood Crawler drop on wall
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
	
			if(npc.type == 14 && Main.rand.Next(2) == 0) // Eater segment drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
	
				if(npc.type == 267 && Main.rand.Next(2) == 0) //Creeper drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkEnergy"));
    }
	
				if(npc.type == 48 && Main.rand.Next(5) == 0) //Harpy drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoaringEnergy"));
    }
	
				if(npc.type == 49 && Main.rand.Next(10) == 0) //Bat drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoaringEnergy"));
    }
	
				if(npc.type == 51 && Main.rand.Next(10) == 0) //Jungle bat drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoaringEnergy"));
    }
	
	if(npc.boss == true && Main.rand.Next(1) == 0) //Boss energy drop
    {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BossEnergy"));
    }
}
}}