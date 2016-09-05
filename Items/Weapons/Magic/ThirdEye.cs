using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class ThirdEye : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "The Third Eye";
            item.damage = 16;
            item.magic = true;
            item.mana = 2;
            item.width = 16;
            item.height = 17;
            item.toolTip = "Predicts the locations of your enemies.";
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 5;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 14;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PsyBolt");
            item.shootSpeed = 2.25f;
        }

        public override void HoldItem(Player player)
        {
            if (Main.rand.Next(1) == 0)
            {
                player.AddBuff(BuffID.Hunter, 2);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OpticBar", 12);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}