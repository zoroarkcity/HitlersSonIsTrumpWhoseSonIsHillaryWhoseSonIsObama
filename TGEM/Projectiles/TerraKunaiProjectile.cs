using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class TerraKunaiProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Terra Kunai";
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = -1;
            projectile.width = 11;
            projectile.height = 11;
            projectile.timeLeft = 200;   //how many time this projectile has before disepire
            projectile.light = 0.75f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
            aiType = 132;

        }

        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.785f;
        }
    }
}