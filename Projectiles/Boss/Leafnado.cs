using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Boss {
public class Leafnado : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Leafnado";
		projectile.width = 20;
		projectile.height = 20;
		projectile.aiStyle = 0;
		projectile.penetrate = 5;
		projectile.hostile = true;
        projectile.friendly = false;
		projectile.alpha = 100;
		projectile.scale = 1f;
		projectile.tileCollide = false;
		Main.projFrames[projectile.type] = 6;
	}
	
	
			public override void AI()
        {
			projectile.frameCounter++;
            if (projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                projectile.frame = (projectile.frame + 1) % 4;
            } 
		}
}
}	