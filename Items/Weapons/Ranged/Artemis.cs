using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Ranged
{
    public class Artemis : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Artemis";
            item.damage = 20;
            item.noMelee = true;
            item.ranged = true;
            item.width = 14;
            item.height = 21;
            item.toolTip = "Fires a wave of night stars";
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 40;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 7;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
				Vector2 origVect = new Vector2(speedX, speedY);
				Vector2 newVect = origVect.RotatedBy(System.Math.PI / 15);
				Vector2 newVect2 = origVect.RotatedBy(-System.Math.PI / 15);
				Vector2 newVect3 = origVect.RotatedBy(System.Math.PI / 20);
				Vector2 newVect4 = origVect.RotatedBy(-System.Math.PI / 20);
				Vector2 newVect5 = origVect.RotatedBy(System.Math.PI / 10);
				Vector2 newVect6 = origVect.RotatedBy(-System.Math.PI / 10);
				
				Projectile.NewProjectile(position.X, position.Y, origVect.X, origVect.Y, mod.ProjectileType("NightArrow"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect2.X, newVect2.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect3.X, newVect3.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect4.X, newVect4.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect5.X, newVect5.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
				Projectile.NewProjectile(position.X, position.Y, newVect6.X , newVect6.Y, mod.ProjectileType("NightStar"), damage, knockBack, player.whoAmI, 0, 0);
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemonBow, 1);
            recipe.AddIngredient(ItemID.MoltenFury, 1);
			recipe.AddIngredient(null, "YoichiBow", 1);
			recipe.AddIngredient(null, "StingerBow", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TendonBow, 1);
            recipe.AddIngredient(ItemID.MoltenFury, 1);
			recipe.AddIngredient(null, "YoichiBow", 1);
			recipe.AddIngredient(null, "StingerBow", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
