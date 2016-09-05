using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Acessories
{
    public class ShieldOfSpazmatism : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Shield of Spazmatism";
            item.melee = true;
            item.defense = 4;
            item.damage = 60;
            item.width = 30;
            item.height = 32;
            item.toolTip = "Allows the player to dash into the enemy";
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 2;
            item.expert = true;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.dash = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(3354, 1);
            modRecipe.AddIngredient(ItemID.EoCShield, 1);
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