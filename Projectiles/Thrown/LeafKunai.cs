using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class LeafKunaiP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Shuriken);
            projectile.name = "Leaf Kunai";
            projectile.width = 14;       //projectile width
            projectile.height = 22;
            projectile.penetrate = -1;
            aiType = 48;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
        }
    }
    public class LeafKunai : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Shuriken);
            item.damage = 65;
            item.shoot = mod.ProjectileType("LeafKunaiP");
            item.name = "Leaf Kunai";
            item.rare = 4;
            item.shootSpeed = 16f;
            item.autoReuse = true;
        }
    }
}
 
