using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class CursedKnifeP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Shuriken);
            projectile.name = "Cursed Knife";
            projectile.width = 18;       //projectile width
            projectile.height = 32;
            projectile.penetrate = -1;
            aiType = 48;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(39, 180, false);
        }

        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(39, 180, false);
            }
        }
        // This .cs file has 2 classes in it, which is totally fine. (What is important is that namespace+classname is unique. Remember that autoloaded textures follow the namespace+classname convention as well.)
        // This is an approach you can take to fit your organization style.
        public class CursedKnife : ModItem
        {

            public override void SetDefaults()
            {
                item.CloneDefaults(ItemID.Shuriken);
                item.damage = 45;
                item.shoot = mod.ProjectileType("CursedKnifeP");
                item.name = "Cursed Knife";
                item.rare = 4;
                item.shootSpeed = 16f;
				item.autoReuse = true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CursedFlame, 1);
                recipe.AddTile(16);
                recipe.SetResult(this, 50);
                recipe.AddRecipe();
            }
        }
    }
}
