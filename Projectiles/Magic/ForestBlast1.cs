using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Magic {
public class ForestBlast1 : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.name = "Forest Energy";
		projectile.width = 20;
		projectile.height = 20;
		projectile.aiStyle = 0;
		projectile.penetrate = -1;
        projectile.friendly = true;
		projectile.alpha = 100;
		projectile.scale = 1.5f;
		projectile.timeLeft = 60;
	}
	public override bool PreAI()
{
    projectile.rotation += 0.05f;
    return true;
}
    public override void Kill(int timeLeft) //This code is incredibly messy. Too lazy to do anything about this
{
          
            int projectilea;
               projectilea = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 10f, 0f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
Main.projectile[projectilea].penetrate = -1;
Main.projectile[projectilea].timeLeft = 20;
int projectile2;
                projectile2 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -10f, 0f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
Main.projectile[projectile2].penetrate = -1;
Main.projectile[projectile2].timeLeft = 20;
int projectile3;
                projectile3 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 10f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
Main.projectile[projectile3].penetrate = -1;
Main.projectile[projectile3].timeLeft = 20;
int projectile4;
                projectile4 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, -10f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
				Main.projectile[projectile4].penetrate = -1;
Main.projectile[projectile4].timeLeft = 20;
int projectile5;
                projectile5 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, -5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
				Main.projectile[projectile5].penetrate = -1;
Main.projectile[projectile5].timeLeft = 20;
int projectile6;
                projectile6 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, -5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
				Main.projectile[projectile6].penetrate = -1;
Main.projectile[projectile6].timeLeft = 20;
int projectile7;
                projectile7 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -5f, 5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
				Main.projectile[projectile7].penetrate = -1;
				
Main.projectile[projectile7].timeLeft = 20;

int projectile8;
                projectile8 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 5f, 5f, 206, projectile.damage, 0f, projectile.owner, 0f, 0f);
				Main.projectile[projectile8].penetrate = -1;
Main.projectile[projectile8].timeLeft = 20;
            
    Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 34);
}
}
}	