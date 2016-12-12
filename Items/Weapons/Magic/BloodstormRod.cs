using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class BloodstormRod : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bloodstorm Rod";
            item.damage = 42;
            item.magic = true;
            item.mana = 8;
            item.width = 25;
            item.height = 26;
            item.toolTip = "Bloodstorm Rod";
            item.useTime = 40;
			item.UseSound = SoundID.Item20;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            Item.staff[item.type] = true;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BloodCloud");
            item.shootSpeed = 5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaoticBar", 10);
			recipe.AddIngredient(ItemID.CrimsonRod, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}