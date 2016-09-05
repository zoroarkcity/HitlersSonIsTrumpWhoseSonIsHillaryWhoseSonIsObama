using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class BlessedKunaiP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.JestersArrow);
            projectile.name = "BlessedKunai";
            projectile.width = 7;
            projectile.height = 14;
            projectile.penetrate = -1;
            aiType = ProjectileID.JestersArrow;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
            }
        }
        
        public class BlessedKunai : ModItem
        {

            public override void SetDefaults()
            {
                item.CloneDefaults(ItemID.Shuriken);
                item.damage = 55;
                item.shoot = mod.ProjectileType("BlessedKunaiP");
                item.name = "Blessed Kunai";
                item.rare = 4;
                item.shootSpeed = 10f;
				item.autoReuse = true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.HallowedBar, 1);
                recipe.AddTile(134);
                recipe.SetResult(this, 45);
                recipe.AddRecipe();
            }
        }
    }
