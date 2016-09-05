using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class KnifeOfCthulhuP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Shuriken);
            projectile.name = "Knife Of Cthulhu";
            projectile.penetrate = 3;
            projectile.width = 11;       //projectile width
            projectile.height = 18;
            aiType = 48;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
        }
    }
        // This .cs file has 2 classes in it, which is totally fine. (What is important is that namespace+classname is unique. Remember that autoloaded textures follow the namespace+classname convention as well.)
        // This is an approach you can take to fit your organization style.
        public class KnifeOfCthulhu : ModItem
        {

            public override void SetDefaults()
            {
                item.CloneDefaults(ItemID.Shuriken);
                item.damage = 15;
                item.shoot = mod.ProjectileType("KnifeOfCthulhuP");
                item.name = "Knife Of Cthulhu";
                item.rare = 4;
                item.shootSpeed = 15f;
        }

        public override void HoldItem(Player player)
        {
            if (Main.rand.Next(1) == 0)
            {
                player.AddBuff(BuffID.Hunter, 2);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OpticBar", 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
}