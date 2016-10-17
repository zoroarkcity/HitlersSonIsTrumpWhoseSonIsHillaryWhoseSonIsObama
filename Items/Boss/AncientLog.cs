using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Boss {
public class AncientLog : ModItem
{
public override void SetDefaults()
    {
        item.name = "Ancient Log";
        item.width = 28;
        item.height = 32;
        item.maxStack = 20;
        item.toolTip = "Summons the Ghastly Ent";
        item.rare = 1;
        item.useAnimation = 45;
        item.useTime = 45;
        item.useStyle = 4;
        item.useSound = 0;
        item.consumable = true;
    }
	
	public override bool CanUseItem(Player player)
	{
		return !NPC.AnyNPCs(mod.NPCType("GhastlyEnt"));
	}
	
	public override bool UseItem(Player player)
    {
        NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("GhastlyEnt"));
        Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
        return true;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Ebonwood, 20);
		recipe.AddIngredient(ItemID.Wood, 20);
		recipe.AddIngredient(ItemID.CrimtaneBar, 5);
		recipe.AddTile(18);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Shadewood, 20);
		recipe.AddIngredient(ItemID.Wood, 20);
		recipe.AddIngredient(ItemID.DemoniteBar, 5);
		recipe.AddTile(18);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}