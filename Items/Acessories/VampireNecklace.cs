using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Acessories {
public class VampireNecklace : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Vampire Necklace";
        item.width = 24;
        item.height = 28;
        item.toolTip = "Gives you a chance to steal life on enemy hit, increased armor penetration";
        item.value = 10000;
        item.rare = 2;
        item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
	{
        ((EnergyPlayer)player.GetModPlayer(mod, "EnergyPlayer")).lifesteal = true;
		player.armorPenetration += 8;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "BloodHeart");
        recipe.AddIngredient(ItemID.SharkToothNecklace);
        recipe.AddTile(114);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}