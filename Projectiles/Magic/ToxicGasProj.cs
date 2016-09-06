using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Magic {
public class ToxicGasProj : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Toxic Gas";
		projectile.width = 8;
		projectile.height = 8;
		projectile.aiStyle = 0;
		projectile.penetrate = 5;
		projectile.magic = true;
		projectile.friendly = true;
		projectile.alpha = 100;
		projectile.timeLeft = 30;
		projectile.scale = 1.5f;
	}
	public override bool PreAI()
{
    projectile.rotation += 0.05f;
    return true;
}
	public override bool OnTileCollide(Vector2 oldVelocity)
{
if (projectile.scale <= 2f)
{
	projectile.scale = 3f;
	projectile.timeLeft = 30;
	projectile.velocity *= 0;
	projectile.aiStyle = 0;
}
return false;
}
}
}	