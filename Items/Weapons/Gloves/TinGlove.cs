using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Gloves {
	public class TinGlove : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tin Glove";
			item.width = 24;
			item.height = 24;
			item.noUseGraphic = true;
			item.useSound = 1;
			item.melee = true;
			item.noMelee = true;
			item.shootSpeed = 15f;
			item.knockBack = 3.75f;
			item.value = Item.sellPrice(0, 1, 30, 0);
			item.rare = 3;
			item.autoReuse = true;
			item.useStyle = 5;
			item.useTime = 10;
			item.useAnimation = 10;
			item.damage = 6;
			item.shoot = mod.ProjectileType("TinGloveProj2");
            item.toolTip = "Press S and M1 for special move!";
        }
	

		public override bool CanUseItem(Player player)
		{
			
			if (player.controlDown)
			{
				item.shootSpeed = 14f;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 10;
				item.shoot = mod.ProjectileType("TinGloveProj2");
			}
			else
			{
				item.shootSpeed = 15f;
				item.useTime = 10;
				item.useAnimation = 10;
				item.damage = 6;
				item.shoot = mod.ProjectileType("TinGloveProj");
			}
			return true;
		}
						        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
}}