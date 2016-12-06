using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee {
public class SoaringBat : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Soaring Bat";
        item.damage = 17;
        item.melee = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 30;
        item.useAnimation = 30;
        item.useStyle = 1;
        item.knockBack = 4;
        item.value = 10000;
        item.rare = 1;
        item.UseSound = SoundID.Item1;
		item.toolTip = "Knocks enemies upward";
        item.autoReuse = true;
		item.useTurn = true;
    }
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
{
    if(!target.boss) 
    {
        target.velocity.Y -= 5; 
    }
}
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SoaringEnergy", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}