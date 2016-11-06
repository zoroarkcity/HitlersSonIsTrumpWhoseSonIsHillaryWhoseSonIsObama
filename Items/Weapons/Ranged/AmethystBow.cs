using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Ranged
{
    public class AmethystBow : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Amethyst Longbow";
            item.damage = 12;
            item.noMelee = true;
            item.ranged = true;
            item.width = 27;
            item.height = 11;
            item.toolTip = "Arrows penetrate enemies";
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 1;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 7;
            item.useSound = 5;
            item.autoReuse = true;
            item.shootSpeed = 10f;
        }

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int p = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
			Main.projectile[p].penetrate += 1;
				
			return false;
		}
		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}