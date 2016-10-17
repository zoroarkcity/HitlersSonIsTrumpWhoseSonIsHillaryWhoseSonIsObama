using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{
    public class NecroSpear : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bone Lance";
            item.damage = 47;
            item.toolTip = "Impales the impurity.";
            item.melee = true;
            item.width = 52;
            item.height = 52;
            item.scale = 1.1f;
            item.maxStack = 1;
            item.useTime = 30;
            item.useAnimation = 30;
            item.knockBack = 5f;
            item.useSound = 1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useStyle = 5;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.shoot = mod.ProjectileType("NecroSpearP");  //put your Spear projectile name
            item.shootSpeed = 7;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "NecroBar", 12);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
