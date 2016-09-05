using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class IchorAxe : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Shuriken);
            projectile.name = "Ichor Throwing Axe";
            projectile.width = 15;       //projectile width
            projectile.height = 16;
            projectile.penetrate = -1;
            aiType = ProjectileID.Shuriken;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
                target.AddBuff(69, 180, false);
        }

        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(69, 180, false);
            }
        }
    }
    // This .cs file has 2 classes in it, which is totally fine. (What is important is that namespace+classname is unique. Remember that autoloaded textures follow the namespace+classname convention as well.)
    // This is an approach you can take to fit your organization style.
    public class IchorThrowingAxe : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Shuriken);
            item.damage = 25;
            item.shoot = mod.ProjectileType("IchorAxe");
            item.name = "Ichor Throwing Axe";
            item.rare = 4;
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ichor, 1);
            recipe.AddTile(16);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
