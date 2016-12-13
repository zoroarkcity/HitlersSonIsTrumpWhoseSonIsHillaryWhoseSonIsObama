using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Tool {
public class GelatinePick : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Gelatine Pick";
        item.damage = 8;
        item.melee = true;
        item.width = 28;
        item.height = 28;
        item.useTime = 16;
        item.useAnimation = 16;
        item.useStyle = 1;
        item.knockBack = 1;
        item.value = 10000;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
		item.pick = 59;
    }
	
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelatineBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}