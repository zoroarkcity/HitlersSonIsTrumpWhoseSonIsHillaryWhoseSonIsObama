using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Ranged
{
    public class GraniteBullet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Granite Shot";
            projectile.width = 2;
            projectile.height = 40;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.extraUpdates = 1;
            projectile.alpha = 0;
        }

        public override void AI()
        {
            {
                int dust;
                dust = Dust.NewDust(projectile.Center + projectile.velocity, projectile.width, projectile.height, 59, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
                Main.dust[dust].scale = 1.5f;
            }
            {
                projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            }
        }
    }
}