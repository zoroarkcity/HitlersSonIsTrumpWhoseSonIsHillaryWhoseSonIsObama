using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TGEM.Projectiles;

namespace TGEM.Items.Weapons.Ranged
{
	public class ParadoxPistols : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Paradox Pistols";
			item.damage = 150;
			item.ranged = true;
			item.width = 23;
			item.height = 13;
			item.toolTip = "Fires another bullet when a bullet hits an enemy, which can create another bullet, which can create another bullet...";
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.useSound = 11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 16f;
			item.useAmmo = ProjectileID.Bullet;
			item.scale = 0.8f;
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 2; ++i)
			{
				float sX = speedX;
				float sY = speedY;
				sX += (float)Main.rand.Next(-30, 30) * 0.05f;
				sY += (float)Main.rand.Next(-30, 30) * 0.05f;
				int p = Projectile.NewProjectile(position.X, position.Y, sX, sY, type, damage, knockBack, player.whoAmI);
				Main.projectile[p].GetModInfo<Info>(mod).Paradox = true;
				Main.projectile[p].tileCollide = false;
				Main.projectile[p].penetrate = 1;
			}
			return false;
		}


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 12);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}