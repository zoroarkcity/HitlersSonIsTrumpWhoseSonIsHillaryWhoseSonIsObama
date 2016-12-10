using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Projectiles.Melee {
public class OpticBladeProj : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Disconnected Eyeball";
		projectile.width = 16;
		projectile.height = 16;
		projectile.aiStyle = 14;
		projectile.penetrate = 1;
        projectile.timeLeft = 100;
		projectile.extraUpdates = 1;
		projectile.thrown = true;
		projectile.friendly = true;
	}
}
}	