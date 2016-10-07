using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class Stingyleaf : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Primal Wrath";
            item.damage = 17;
            item.magic = true;
            item.mana = 8;
            item.width = 38;
            item.height = 38;
            item.toolTip = "Fires bursts of 4 inaccurate leaves";
            item.useTime = 4;
            item.useAnimation = 16;
            item.reuseDelay = 14;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            Item.staff[item.type] = true;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 20;
            item.autoReuse = false;
            item.shoot = (206);
            item.shootSpeed = 11f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(331, 12);
            recipe.AddIngredient(210, 4);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float spread = 45f * 0.0174f;//45 degrees converted to radians
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double baseAngle = Math.Atan2(speedX, speedY);
            double randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
            speedX = baseSpeed * (float)Math.Sin(randomAngle);
            speedY = baseSpeed * (float)Math.Cos(randomAngle);
            return true;
        }
    }
}