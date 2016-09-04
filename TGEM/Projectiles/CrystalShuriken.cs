using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class CrystalShurikenP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(3);
            projectile.name = "Crystal Shuriken";
            projectile.width = 11;       //projectile width
            projectile.height = 11;
            projectile.penetrate = 2;
            aiType = 3;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;

        }
        public override void AI()
        {
            if (Main.rand.Next(10) == 0)
            {
                int rand = Main.rand.Next(5); //Generates integers from 0 to 4
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 90, (int)(projectile.damage * 1.5), projectile.knockBack, Main.myPlayer); // 296 is the explosion from the Inferno Fork
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
                item.shootSpeed = 25f;
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
