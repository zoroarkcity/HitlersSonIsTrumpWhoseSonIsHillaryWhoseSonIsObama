using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Tool {
public class MeteorPickaxe : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Meteor Pickaxe";
        item.damage = 12;
        item.melee = true;
        item.width = 32;
        item.height = 32;
        item.useTime = 14;
        item.useAnimation = 14;
        item.useStyle = 1;
        item.knockBack = 1;
        item.value = 10000;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
        item.autoReuse = true;
		item.pick = 65;
    }
	
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}