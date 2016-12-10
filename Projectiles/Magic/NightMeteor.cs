using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Magic
{
    public class NightMeteor : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Night Meteor";
            projectile.width = 34; 
            projectile.height = 90; 
            projectile.aiStyle = 5; 
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 180;
            projectile.light = 1f;
			projectile.scale = 0.9f;
		}
		
        public override void Kill(int timeLeft)
			{
				int amountOfProjectiles = Main.rand.Next(1, 4);
			
				for (int i = 0; i < amountOfProjectiles; ++i)
					{
						float sX = (float)Main.rand.Next(-60, 61) * 0.2f;
						float sY = (float)Main.rand.Next(-60, 61) * 0.2f;
						Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, mod.ProjectileType("NightStarM"), 30, 5f, projectile.owner);
					}
			}
    }
}