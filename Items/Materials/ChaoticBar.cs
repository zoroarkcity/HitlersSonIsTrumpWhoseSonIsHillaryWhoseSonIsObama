using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
    public class ChaoticBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Chaotic Bar";
            item.width = 34;
            item.height = 26;
            item.maxStack = 99;
            item.rare = 3;
			item.value = 20000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ichor, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddIngredient(ItemID.CrimtaneBar, 2);
            recipe.AddIngredient(ItemID.TissueSample, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();

        }

    }
}