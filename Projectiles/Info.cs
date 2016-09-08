using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles
{
    public class Info : ProjectileInfo
    {
		public bool Paradox = false;      
    }
	
	public class Stuff : GlobalProjectile
	{
		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0 && projectile.GetModInfo<Info>(mod).Paradox == true)
			{
			int z = Projectile.NewProjectile(projectile.Center.X + projectile.velocity.X * 100f, projectile.Center.Y + projectile.velocity.Y * 100f, projectile.velocity.X * -1, projectile.velocity.Y * -1, projectile.type, projectile.damage, 0f, projectile.owner, 0f, 0f);
			Main.projectile[z].GetModInfo<Info>(mod).Paradox = true;
			Main.projectile[z].tileCollide = false;
			Main.projectile[z].penetrate = 1;
			}
		}
	}
}
