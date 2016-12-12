using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Armor
{
	public class GelatineBreastplate : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Body);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Gelatine Breastplate";
			item.width = 18;
			item.height = 18;
			AddTooltip("Increases your maxiumum minions by 1");
			item.value = 10000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions+= 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelatineBar", 10);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}