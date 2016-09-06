using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class CobaltWand : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cobalt Wand";
            item.damage = 40;
            item.magic = true;
            item.mana = 6;
            item.width = 13;
            item.height = 14;
            item.toolTip = "Fires high-velocity bolts of energy!";
            item.useTime = 33;
            item.useAnimation = 33;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            item.value = 10000;
            Item.staff[item.type] = true;
            item.rare = 2;
            item.useSound = 14;
            item.autoReuse = true;
            item.shoot = (123);
            item.shootSpeed = 25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}