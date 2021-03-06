using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Ranged
{
    public class YoichiBow : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Yoichi Bow";
            item.damage = 15;
            item.noMelee = true;
            item.ranged = true;
            item.width = 14;
            item.height = 21;
            item.toolTip = "Has a chance to release a swarm of waterbolts";
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 40;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 7;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 7f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			if (Main.rand.Next(3) == 0)
			{
				Vector2 origVect = new Vector2(speedX, speedY);
				Vector2 newVect = origVect.RotatedBy(System.Math.PI / 15);
				Vector2 newVect2 = origVect.RotatedBy(-System.Math.PI / 15);
				Vector2 newVect3 = origVect.RotatedBy(System.Math.PI / 20);
				Vector2 newVect4 = origVect.RotatedBy(-System.Math.PI / 20);

				int p = Projectile.NewProjectile(position.X, position.Y, newVect.X * 2f, newVect.Y * 2f, 27, damage / 2, knockBack, player.whoAmI, 0, 0);
				Main.projectile[p].penetrate = 1;
				Main.projectile[p].extraUpdates = 2;
				int p2 = Projectile.NewProjectile(position.X, position.Y, newVect2.X * 2f, newVect2.Y * 2f, 27, damage / 2, knockBack, player.whoAmI, 0, 0);
				Main.projectile[p2].penetrate = 1;
				Main.projectile[p2].extraUpdates = 2;
				int p3 = Projectile.NewProjectile(position.X, position.Y, newVect3.X * 2f, newVect3.Y * 2f, 27, damage / 2, knockBack, player.whoAmI, 0, 0);
				Main.projectile[p3].penetrate = 1;
				Main.projectile[p3].extraUpdates = 2;
				int p4 = Projectile.NewProjectile(position.X, position.Y, newVect4.X * 2f, newVect4.Y * 2f, 27, damage / 2, knockBack, player.whoAmI, 0, 0);
				Main.projectile[p4].penetrate = 1;
				Main.projectile[p4].extraUpdates = 2;
			}
            return true;
        }
    }
}
