using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Tool {
public class SoaringHammer : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Soaring Hammer";
        item.damage = 5;
        item.melee = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 11;
        item.useAnimation = 15;
        item.useStyle = 1;
        item.knockBack = 1;
        item.value = 10000;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
		item.hammer = 35;
    }
	
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SoaringEnergy", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}