using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Ranged
{
    public class StingerBow : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Stinger Bow";
            item.damage = 20;
            item.noMelee = true;
            item.ranged = true;
            item.width = 14;
            item.height = 21;
            item.toolTip = "Transforms all arrows into stinger arrows";
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
            item.shootSpeed = 6.1f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("StingerArrow"), damage, knockBack, player.whoAmI, 0f, 0f);
            return false; //Makes sure to not fire the original projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Stinger, 4);
            recipe.AddIngredient(ItemID.JungleSpores, 8);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
