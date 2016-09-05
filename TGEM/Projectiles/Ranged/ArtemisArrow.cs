using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Ranged
{
    public class ArtemisArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Artemis Arrow"; //name
            projectile.width = 14; //Projectile's width in pixels
            projectile.height = 32; //Projectile's height in pixels
            projectile.aiStyle = 1; //The ai style. Info on AI styles is in the tmodloader documentation
            projectile.friendly = true; //Determines if it can damage you
            projectile.ranged = true; //Damage type of the projectile.
            projectile.penetrate = 1; //How many enemies it can hit.
            projectile.timeLeft = 600; //How long in ticks the projectile lasts
            projectile.alpha = 255;
            projectile.light = 1f; //light the projectile gives off
            projectile.extraUpdates = 1;
            aiType = 1; //The AI it copies. 1 is a wooden arrow's projectile ID, 3 is for a shuriken
        }
    }
}