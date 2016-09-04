using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons
{
    public class TheBowne : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "The Bowne";
            item.damage = 30;
            item.noMelee = true;
            item.ranged = true;
            item.width = 9;
            item.height = 20;
            item.toolTip = "Transforms Wooden arrows into Bone Arrows";
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 1;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 7;
            item.useSound = 5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BoneArrow, damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            return false; //Makes sure to not fire the original projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 100);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}