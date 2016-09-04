using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class OpticBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Optic Bar";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("All becomes clear");
			item.value = 100;
			item.rare = 1;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(57, 1);
            recipe.AddIngredient(38, 5);
            recipe.AddIngredient(null, "WideLens", 1);
            recipe.AddTile(26);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(1257, 1);
            recipe.AddIngredient(38, 5);
            recipe.AddIngredient(null, "WideLens", 1);
            recipe.AddTile(26);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}