using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Ranged {
public class SoulShatterer : ModItem
{
    public override void SetDefaults()
    {
		item.name = "Soul Shatterer";
        item.damage = 20;
        item.ranged = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 40;
        item.useAnimation = 40;
		item.UseSound = SoundID.Item36;
        item.useStyle = 5;
        item.knockBack = 3;
        item.value = 10000;
        item.rare = 1;
        item.autoReuse = true;
		item.toolTip = "Fires 5 cursed bullets";
        item.shoot = 10; 
		item.shootSpeed = 10f;
		item.useAmmo = AmmoID.Bullet;
    }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 104, damage, knockBack, player.whoAmI);
        Projectile.NewProjectile(position.X, position.Y, speedX * 0.9f, speedY * 0.9f, 104, damage, knockBack, player.whoAmI);
		Projectile.NewProjectile(position.X, position.Y, speedX * 0.8f, speedY * 0.8f, 104, damage, knockBack, player.whoAmI);
		Projectile.NewProjectile(position.X, position.Y, speedX * 0.7f, speedY * 0.7f, 104, damage, knockBack, player.whoAmI);
		Projectile.NewProjectile(position.X, position.Y, speedX * 0.6f, speedY * 0.6f, 104, damage, knockBack, player.whoAmI);
        return false;
    }
	
	public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AccursedBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}