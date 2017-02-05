using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class DarkEnergy : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Nightly Essence";
			item.width = 10;
			item.height = 10;
			item.noMelee = true; 
			item.value = 20;
			item.rare = 0;
			item.scale = 0.75f;
			item.maxStack = 999;
		}
	}
}