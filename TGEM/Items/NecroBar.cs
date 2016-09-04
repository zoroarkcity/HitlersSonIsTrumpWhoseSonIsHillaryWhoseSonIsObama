using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class NecroBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Necro Bar";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("The work of a master of necromancy.");
			item.value = 100;
			item.rare = 1;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(154, 4);
            recipe.AddIngredient(150, 20);
            recipe.AddIngredient(175, 1);
            recipe.AddIngredient(null, "CursedEssence", 1);
            recipe.AddTile(26);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}