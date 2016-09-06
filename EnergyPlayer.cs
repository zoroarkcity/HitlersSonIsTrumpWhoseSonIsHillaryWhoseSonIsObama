using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM
{
	public class EnergyPlayer : ModPlayer
	{
		public bool treeMinion = true;
        public bool lifesteal = false;
		public bool firestorm = false;
		public bool canJumpFirestorm = true;
			public override void ResetEffects()
		{
			firestorm = false;
			treeMinion = false;
            lifesteal = false;
		}
		

            public override void OnHitAnything(float x, float y, Entity victim)
            {
                if (Main.rand.Next(15) == 0 && lifesteal == true)
                {
                    player.HealEffect(1);
                    player.statLife += 1;
                }
            }
			
			public override void PreUpdate()
			{
				if(player.controlJump && !player.mount.Active && canJumpFirestorm == true && firestorm == true)
				{
					if(player.controlLeft)
					{
						player.velocity.X = -10f;
					}
					if(player.controlRight)
					{
						player.velocity.X = 10f;
					}
					Main.PlaySound(2, (int)player.Center.X, (int)player.Center.Y, 34);
					
				int amountOfProjectiles = Main.rand.Next(5, 10);
			
				for (int i = 0; i < amountOfProjectiles; ++i)
					{
						float sX = (float)Main.rand.Next(-60, 61) * 0.1f;
						float sY = (float)Main.rand.Next(-60, 61) * 0.1f;
						int projectile = Projectile.NewProjectile(player.Center.X, player.Center.Y, sX, sY, 400, 15, 5f, player.whoAmI);
						Main.projectile[projectile].timeLeft = 100;
					}
					
					canJumpFirestorm = false;
				}
				
				if (player.justJumped == true)
				{
					canJumpFirestorm = true;
				}
				
			}
		}
	}