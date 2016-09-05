using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace TGEM.Items.Materials
{
	public class SpectrumBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Spectrum Bar";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("HEYEAYEAYEAYEA");
			item.value = 100;
			item.rare = 1;

        }

        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(15, 7);   //2 is the sprite frame, change of how many frames your sprite have
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3467, 2);
            recipe.AddIngredient(170, 20);
            recipe.AddTile(125);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(3467, 2);
            recipe.AddIngredient(170, 20);
            recipe.AddTile(125);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}