using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class CrystalShurikenP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(3);
            projectile.name = "Crystal Shuriken";
            projectile.width = 22;       //projectile width
            projectile.height = 22;
            projectile.penetrate = 2;
            aiType = 3;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;

        }
        public override void Kill(int timeLeft)
			{
				int amountOfProjectiles = Main.rand.Next(5, 10);
			
				for (int i = 0; i < amountOfProjectiles; ++i)
					{
						float sX = (float)Main.rand.Next(-60, 61) * 0.2f;
						float sY = (float)Main.rand.Next(-60, 61) * 0.2f;
						Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, 90, 15, 5f, projectile.owner);
					}
			}
        }

        public class CrystalShuriken : ModItem
        {

            public override void SetDefaults()
            {
                item.CloneDefaults(ItemID.Shuriken);
                item.damage = 40;
                item.shoot = mod.ProjectileType("CrystalShurikenP");
                item.name = "Crystal Shuriken";
                item.rare = 4;
                item.shootSpeed = 15f;
				item.autoReuse = true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CrystalShard, 1);
                recipe.AddTile(16);
                recipe.SetResult(this, 50);
                recipe.AddRecipe();
            }
        }
    }
