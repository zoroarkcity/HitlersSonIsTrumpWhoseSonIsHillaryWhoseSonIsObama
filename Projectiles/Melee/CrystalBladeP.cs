using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Melee
{
    public class  CrystalBladeP: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(24);
            projectile.width = 14; //Projectile's width in pixels
            projectile.height = 14; //Projectile's height in pixels
            projectile.aiStyle = 14; //The ai style. Info on AI styles is in the tmodloader documentation
            projectile.friendly = true; //Determines if it can damage you
            projectile.melee = true; //Damage type of the projectile.
            projectile.penetrate = 7; //How many enemies it can hit.
            projectile.timeLeft = 300; //How long in ticks the projectile lasts
            projectile.extraUpdates = 1;
            aiType = 24; //The AI it copies. 1 is a wooden arrow's projectile ID, 3 is for a shuriken  
        }

    }
}