using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items
{
    public class BrainScarf : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Worm Scarf of Confusion";
            item.width = 26;
            item.height = 26;
            item.toolTip = "Reduces damage taken by 10%, and confuses nearby enemies when hit";
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 2;
            item.expert = true;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += 0.10f;
            player.brainOfConfusion = true;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(3224, 1);
            modRecipe.AddIngredient(3223, 1);
            modRecipe.AddTile(TileID.TinkerersWorkbench);
            modRecipe.SetResult(this, 1);
            modRecipe.AddRecipe();
        }

        public override void OnCraft(Recipe recipe)
        {
            this.SetDefaults();
            item.prefix = 0;
        }
    }
}