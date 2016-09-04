using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons
{
    public class MythrilStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "MythrilStaff";
            item.damage = 46;
            item.magic = true;
            item.mana = 8;
            item.width = 25;
            item.height = 26;
            item.toolTip = "Fires three bolts of energy!.";
            item.useTime = 31;
            item.useAnimation = 31;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            Item.staff[item.type] = true;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 14;
            item.autoReuse = true;
            item.shoot = (124);
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float spread = 45f * 0.0174f;
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
            double deltaAngle = spread / 8f;
            double offsetAngle;
            int i;
            for (i = 0; i < 3; i++)
            {
                offsetAngle = startAngle + deltaAngle * i;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), item.shoot, damage, knockBack, item.owner);
            }
            return false;
        }