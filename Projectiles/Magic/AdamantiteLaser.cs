using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Magic
{
    public class AdamantiteLaser : ModProjectile
    {
        public override bool Autoload(ref string name, ref string texture)
        {
            // Use this to use Vanilla textures. The number corresponds to the ProjectileID of hte vanilla projectile.
            texture = "Terraria/Projectile_260";
            return true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(260);
            projectile.name = "AdamantiteLaser";
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            aiType = 260;
        }
    }
}