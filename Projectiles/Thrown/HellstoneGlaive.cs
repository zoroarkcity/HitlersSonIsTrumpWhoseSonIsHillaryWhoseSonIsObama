using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Thrown
{
    public class HellstoneGlaiveP : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Shuriken);
            projectile.name = "Hellstone Glaive";
            projectile.width = 22;       //projectile width
            projectile.height = 22;
            projectile.penetrate = 2;
            aiType = ProjectileID.Shuriken;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
                target.AddBuff(24, 180, false);
			Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 0f, mod.ProjectileType("HellstoneGlaiveBoom"), projectile.damage, 0f, projectile.owner, 0f, 0f);
        }

        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(24, 180, false);
            }
        }
    }

	
    public class HellstoneGlaive : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Shuriken);
            item.damage = 30;
            item.shoot = mod.ProjectileType("HellstoneGlaiveP");
            item.name = "Hellstone Glaive";
            item.rare = 4;
            item.shootSpeed = 15f;
			item.autoReuse = true;
			item.useTime = 25;
			item.useAnimation = 25;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(175, 1);
            recipe.AddTile(16);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
	
		public class HellstoneGlaiveBoom : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.name = "Hellstone Glaive";
			projectile.width = 55;
			projectile.height = 55;
			projectile.aiStyle = 2;
			projectile.penetrate = -1;
			projectile.thrown = true;
			projectile.timeLeft = 3;
			projectile.friendly = true;
			projectile.alpha = 255;
			projectile.tileCollide = false;
		}
		public override bool PreAI()
	{
		int amountOfProjectiles = 5;
		for (int i = 0; i < amountOfProjectiles; ++i)
		{
			projectile.tileCollide = false;
			int dust;
			dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 6, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			Main.dust[dust].scale = 2.5f;
			Main.dust[dust].noGravity = true;
		}
		return false;
	}
		public virtual bool OnTileCollide(Vector2 oldVelocity)
		{
			return false;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
				target.AddBuff(BuffID.OnFire, 180, false);
		}
}
}
