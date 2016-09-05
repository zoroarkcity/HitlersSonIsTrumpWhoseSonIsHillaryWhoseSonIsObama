using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Ranged
{
    public class NightStar : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Night Star";
            projectile.width = 18; 
            projectile.height = 20; 
            projectile.aiStyle = 5; 
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 30;
            projectile.light = 1f;
			projectile.scale = 0.9f;
        }
    }
}