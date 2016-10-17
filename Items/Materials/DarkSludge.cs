using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class DarkSludge : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dark Sludge";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("Smells and looks disgusting");
			item.value = 100;
			item.rare = 1;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DarkEnergy", 1);
            recipe.AddTile(26);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}