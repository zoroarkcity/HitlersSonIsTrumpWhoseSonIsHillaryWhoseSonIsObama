using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Projectiles.Ranged {
public class LeechingArrow : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Leeching Arrow";
		projectile.width = 10;
		projectile.height = 20;
		projectile.penetrate = 1;
		projectile.ranged = true;
		projectile.friendly = true;
		projectile.alpha = 0;
		projectile.aiStyle = 1;
	}
	
	public override void Kill(int timeLeft)
		{
			for (int i = 0; i < 5; i++)
			{
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5);
				Main.dust[dust].scale = 1.5f;
				Main.dust[dust].noGravity = true;
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
		}

	
	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	{
		Player player = Main.player[projectile.owner];
		player.HealEffect(2);
		player.statLife += 2;
	}
}	
}