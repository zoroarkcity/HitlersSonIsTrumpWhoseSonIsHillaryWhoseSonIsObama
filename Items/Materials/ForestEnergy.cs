using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class ForestEnergy : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Ancient Foliage";
			item.width = 10;
			item.height = 10;
			item.noMelee = true; 
			item.value = 10000;
			item.rare = 1;
			item.scale = 0.75f;
			item.maxStack = 999;
		}
	}
}