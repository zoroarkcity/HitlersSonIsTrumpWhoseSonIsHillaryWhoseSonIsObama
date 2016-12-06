using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class AdamantiteStave : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Adamantite Laser Staff";
            item.damage = 59;
            item.magic = true;
            item.mana = 10;
            item.width = 28;
            item.height = 30;
            item.toolTip = "Fires a concentrated laser!";
            item.useTime = 27;
            item.useAnimation = 37;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            item.value = 10000;
            Item.staff[item.type] = true;
            item.rare = 2;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AdamantiteLaser");
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}