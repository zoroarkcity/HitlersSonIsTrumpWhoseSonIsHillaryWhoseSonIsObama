using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class SteampunkBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Steampunk Bar";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("The name doesn't even make sense for this...");
			item.value = 100;
			item.rare = 1;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(391, 1);
            recipe.AddIngredient(3380, 5);
            recipe.AddIngredient(null, "DinoBone", 1);
            recipe.AddTile(133);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(1198, 1);
            recipe.AddIngredient(3380, 5);
            recipe.AddIngredient(null, "DinoBone", 1);
            recipe.AddTile(133);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}