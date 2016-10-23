using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Projectiles.Boss {
public class SapBall : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Corrosive Sap";
		projectile.width = 18;
		projectile.height = 30;
		projectile.penetrate = 1;
		projectile.friendly = false;
		projectile.hostile = true;
		projectile.alpha = 0;
		projectile.aiStyle = 1;
		aiType = ProjectileID.Bullet;
	}
	
	
		public override void AI()
	{
		if (Main.rand.Next(3) == 0)
		{
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 64, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
		}
	}
	
		   public override void Kill(int timeLeft)
		{
			Main.PlaySound(3, (int)projectile.position.X, (int)projectile.position.Y, 1);
			int amountOfProjectiles = Main.rand.Next(1, 5);
			
			for (int i = 0; i < amountOfProjectiles; ++i)
				{
					float sX = (float)Main.rand.Next(-60, 61) * 0.2f;
					float sY = (float)Main.rand.Next(-60, 61) * 0.2f;
					Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, mod.ProjectileType("MiniSap"), projectile.damage, 5f, projectile.owner);
				}
		}
	
}	
}