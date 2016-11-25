using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Ranged
{
    public class SapphireArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Sapphire Arrow";
            projectile.width = 10;
            projectile.height = 32;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
            projectile.extraUpdates = 1;
            aiType = 1;
        }

        public override void AI()
        {
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 59, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
    }
}