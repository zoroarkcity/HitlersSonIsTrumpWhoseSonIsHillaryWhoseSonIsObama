using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class BlessedKunaiP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.JestersArrow);
            projectile.name = "BlessedKunai";
            projectile.width = 7;       //projectile width
            projectile.height = 14;
            projectile.penetrate = -1;
            aiType = ProjectileID.JestersArrow;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
            }
        }
        // This .cs file has 2 classes in it, which is totally fine. (What is important is that namespace+classname is unique. Remember that autoloaded textures follow the namespace+classname convention as well.)
        // This is an approach you can take to fit your organization style.
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
