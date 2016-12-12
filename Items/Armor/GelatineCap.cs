using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Armor
{
	public class GelatineCap : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Gelatine Cap";
			item.width = 18;
			item.height = 18;
			item.toolTip = "10% increased movement speed";
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GelatineBreastplate") && legs.type == mod.ItemType("GelatineGreaves");
		}

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;
        }

		public override void UpdateArmorSet(Player player)
		{
			((MyPlayer)player.GetModPlayer(mod, "MyPlayer")).slimeGuard = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelatineBar", 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}