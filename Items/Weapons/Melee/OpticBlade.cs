using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{
    public class OpticBlade : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Optic Blade";
            item.damage = 14;
            item.melee = true;
            item.width = 23;
            item.height = 23;
            item.toolTip = "No enemy can hide from its might";
            item.useTime = 40;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6.5f;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.shoot = mod.ProjectileType("OpticBladeProj");
			item.shootSpeed = 5f;
        }

        public override void HoldItem(Player player)
        {
            if (Main.rand.Next(1) == 0)
            {
                player.AddBuff(BuffID.Hunter, 2);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OpticBar", 12);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}