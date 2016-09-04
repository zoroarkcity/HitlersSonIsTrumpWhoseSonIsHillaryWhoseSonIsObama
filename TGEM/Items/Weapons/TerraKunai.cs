using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons
{
	public class TerraKunai : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Terra Kunai";
			item.damage = 95;
			item.noMelee = true;
			item.thrown = true;
			item.width = 22;
			item.height = 22;
			item.toolTip = "Here we are!";
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.rare = 3;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.useSound = 1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("TerraKunaiProjectile");
			item.shootSpeed = 12f;
			item.useTurn = true;
			item.maxStack = 1;
			item.consumable = false;
			item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            //create velocity vectors for the two angled projectiles (outwards at PI/15 radians)
            Vector2 origVect = new Vector2(speedX, speedY);
            Vector2 newVect = origVect.RotatedBy(System.Math.PI / 15);
            Vector2 newVect2 = origVect.RotatedBy(-System.Math.PI / 15);

            //create three Crystishae projectiles
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0, 0);
            Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, 132, (int)(damage * 0.5), knockBack, player.whoAmI, 0, 0);
            Projectile.NewProjectile(position.X, position.Y, newVect2.X, newVect2.Y, 132, (int)(damage * 0.5), knockBack, player.whoAmI, 0, 0);
            return false;
        }
    }
}