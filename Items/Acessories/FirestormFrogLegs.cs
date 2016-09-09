using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Acessories
{
    public class FirestormFrogLegs : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Firestorm Frog Legs";
            item.width = 34;
            item.height = 34;
            item.toolTip = "Enhances your jump, leaving behind fire, nullifying fall damage, and granting auto jump.";
            item.value = 150000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            ((EnergyPlayer)player.GetModPlayer(mod, "EnergyPlayer")).firestorm = true;
            player.jumpSpeedBoost += 2.8f;
            player.noFallDmg = true;
            player.fireWalk = true;
            player.autoJump = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(396, 1);
            recipe.AddIngredient(ItemID.FrogLeg, 1);
            recipe.AddIngredient(null, "FirestormBottle", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}