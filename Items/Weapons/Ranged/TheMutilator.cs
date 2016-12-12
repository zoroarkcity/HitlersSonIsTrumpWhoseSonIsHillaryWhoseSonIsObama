using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TGEM.Projectiles;

namespace TGEM.Items.Weapons.Ranged {
public class TheMutilator : ModItem
{
    public override void SetDefaults()
    {
		item.name = "The Mutilator";
        item.damage = 18;
        item.ranged = true;
        item.width = 22;
        item.height = 24;
        item.useTime = 10;
        item.useAnimation = 10;
		item.UseSound = SoundID.Item36;
        item.useStyle = 5;
        item.knockBack = 1.25f;
        item.value = 10000;
        item.rare = 1;
        item.autoReuse = false;
		item.toolTip = "Bullets fired inflict ichor";
        item.shoot = 10; 
		item.shootSpeed = 10f;
		item.useAmmo = AmmoID.Bullet;
    }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int p = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
			Main.projectile[p].GetModInfo<Info>(mod).Mutilator = true;
			return false;
		}
	
	public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaoticBar", 10);
			recipe.AddIngredient(800, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}