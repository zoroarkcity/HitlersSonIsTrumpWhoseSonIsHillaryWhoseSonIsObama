using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Minions
{
    public class TreeMinion : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Raven);
            projectile.name = "Tree Minion";
            Main.projFrames[projectile.type] = 1; 
            Main.projPet[projectile.type] = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            aiType = ProjectileID.Raven;
            drawOffsetX = 10; 
            drawOriginOffsetY = 10; 
			projectile.penetrate = -1;
			projectile.tileCollide = false;
        }
		
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			EnergyPlayer modPlayer = (EnergyPlayer)player.GetModPlayer(mod, "EnergyPlayer");
			if (player.dead)
			{
				modPlayer.treeMinion = false;
			}
			if (modPlayer.treeMinion)
			{
				projectile.timeLeft = 2;
			}
		}

        public override bool MinionContactDamage()
        {
            return true;
        }
		

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	{
		projectile.position.Y -= 300;
		Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 5f, 207, projectile.damage, 0f, projectile.owner, 0f, 0f);
		int amountOfDust = 20;
		for (int i = 0; i < amountOfDust; ++i)
		{
			projectile.tileCollide = false;
			int dust;
			dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 39, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			Main.dust[dust].scale = 1.5f;
		}
}
}
}