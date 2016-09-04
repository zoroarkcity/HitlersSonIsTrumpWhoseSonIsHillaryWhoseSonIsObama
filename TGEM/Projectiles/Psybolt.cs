using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class PsyBolt : ModProjectile
    {
        private int[] dusts = { 44, 46 };

        public override void SetDefaults()
        {
            projectile.name = "Psychic Bolt";
            projectile.width = 8;
            projectile.height = 8;
            projectile.alpha = 255;
            projectile.aiStyle = 51;
            aiType = 297;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
            projectile.extraUpdates = 2;
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 3;
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void AI()
        {
            if (projectile.localAI[0] == 0f)
            {
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 20);
                projectile.localAI[0] = 1f;
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(255, 0, 217), 1.5f);
            Main.dust[dust].velocity *= 0.1f;
            if (projectile.velocity == Vector2.Zero)
            {
                Main.dust[dust].velocity.Y -= 1f;
                Main.dust[dust].scale = 1.2f;
            }
            else
            {
                Main.dust[dust].velocity += projectile.velocity * 0.2f;
            }
            Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].noGravity = true;
        }
    }
}