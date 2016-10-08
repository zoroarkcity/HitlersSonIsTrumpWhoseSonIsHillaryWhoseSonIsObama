using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs.Town
{
	public class Pyro : ModNPC
	{
		
		public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
		{
			name = "Pyro";
			altTextures = new string[] { "TGEM/NPCs/Town/Pyro"};
			return mod.Properties.Autoload;
		}
		public override void SetDefaults()
		{
			npc.name = "Pyromaniac";
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.soundHit = 1;
			npc.soundKilled = 1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 500;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			animationType = NPCID.Demolitionist;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
            if (NPC.downedSlimeKing)
            {
                return true;
            }
            return false;
		}


		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(13))
			{
				case 0:
					return "Jimmy";
				case 1:
					return "Johnny";
				case 2:
					return "Barack";
                case 3:
                    return "Bill";
                case 4:
                    return "Steve";
                case 5:
                    return "Bill";
                case 6:
                    return "Blaine";
                case 7:
                    return "Brock";
                case 8:
                    return "Bernie";
                case 9:
                    return "Sid";
                case 10:
                    return "Ash";
                case 11:
                    return "Ted";
                case 12:
                    return "Richard";
				default:
					return "Colin";
			}
		}

		public override string GetChat()
		{
			int demo = NPC.FindFirstNPC(NPCID.Demolitionist);
			if (demo >= 0 && Main.rand.Next(4) == 0)
			{
				return "Wow, " + Main.npc[demo].displayName + " thinks blowing things up is fun. What a loser";
			}
			switch (Main.rand.Next(3))
			{
				case 0:
					return "I assume if you have come to me you want to burn down a forest! If it is that case, please buy everything!";
				case 1:
                    return "I promise won't burn down your house, but I can't guarantee that there will be no accidents";
				default:
					return "Fire is great, isn't it!";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28];
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
            shop.item[nextSlot].SetDefaults(ItemID.MolotovCocktail);
			nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.FlamingArrow);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("FireGrenade"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("FirestormBottle"));
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 30;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 1;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("FireGrenadeProj");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 15f;
			randomOffset = 2f;
		}
	}
}