using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Ammo {
public class PurpleDart : ModItem
{
	
    public override void SetDefaults()
    {
        item.name = "Purple Dart";
        item.damage = 5;
        item.ranged = true;
        item.width = 22;
        item.height = 22;
        item.toolTip = "Shot out of blowpipes, explodes into yellow fire on contact";
		item.shootSpeed = 2f;
		item.shoot = mod.ProjectileType("PurpleDartProj");
        item.knockBack = 1;
		item.UseSound = SoundID.Item1;
		item.scale = 1f;
        item.value = 10000;
        item.rare = 1;
		item.consumable = true;
		item.maxStack = 999;
        item.ammo = AmmoID.Dart;
	}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DarkSludge", 1);
            recipe.SetResult(this, 200);
            recipe.AddRecipe();
        }
    }
}