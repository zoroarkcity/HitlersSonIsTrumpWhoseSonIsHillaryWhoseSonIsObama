using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class CrystalArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Crystal Arrow";
            projectile.width = 14;
            projectile.height = 32;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.light = 1f;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.JestersArrow;
        }
    }
}