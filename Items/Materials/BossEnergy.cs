using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class BossEnergy : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Boss Essence";
			item.width = 10;
			item.height = 10;
			item.noMelee = true; 
			item.value = 10000;
			item.rare = 0;
			item.scale = 0.75f;
			item.maxStack = 999;
		}
	}
}