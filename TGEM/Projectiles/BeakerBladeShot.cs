using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class BeakerBladeShot : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Beaker Blade Shot";  //projectile name
            projectile.width = 23;       //projectile width
            projectile.height = 23;  //projectile height
            projectile.friendly = true;      //make that the projectile will not damage you
            projectile.melee = true;         // 
            projectile.tileCollide = true;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = -1;      //how many npc will penetrate
            projectile.timeLeft = 200;   //how many time this projectile has before disepire
            projectile.light = 0.75f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(24, 180, false);
            }
            if (Main.rand.Next(3) == 1)
            {
                target.AddBuff(39, 180, false);
            }
            if (Main.rand.Next(3) == 2)
            {
                target.AddBuff(44, 180, false);
            }
        }
        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.785f;
        }
    }
}