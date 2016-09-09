using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Ammo {
public class FleshDart : ModItem
{
	
    public override void SetDefaults()
    {
        item.name = "Flesh Dart";
        item.damage = 6;
        item.ranged = true;
        item.width = 22;
        item.height = 22;
        item.toolTip = "Shot out of blowpipes, blood goes everywhere";
		item.shootSpeed = 2f;
		item.shoot = mod.ProjectileType("FleshDartProj");
        item.knockBack = 1;
		item.useSound = 1;
		item.scale = 1f;
        item.value = 10000;
        item.rare = 1;
        item.ammo = ProjectileID.Seed;
		item.maxStack = 999;
		item.consumable = true;
    }
	
	        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TissueSample, 1);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
}}