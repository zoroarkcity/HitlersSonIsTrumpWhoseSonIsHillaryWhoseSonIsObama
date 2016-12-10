using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Magic
{
    public class NightStarM : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Night Star";
            projectile.width = 18; 
            projectile.height = 20; 
            projectile.aiStyle = 5; 
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 60;
            projectile.light = 1f;
			projectile.scale = 0.9f;
        }
    }
}