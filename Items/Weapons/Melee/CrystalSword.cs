using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee  
{
    public class CrystalSword: ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Crystal Sword";     
            item.damage = 125;            
            item.melee = true;            
            item.width = 34;              
            item.height = 34;            
            item.useTime = 15;          
            item.useAnimation = 15;     
            item.useStyle = 1;        
            item.knockBack = 5;      
            item.value = 100;        
            item.rare = 10;
            item.useSound = 1;       
            item.autoReuse = true;   
            item.useTurn = true;
            item.shoot = mod.ProjectileType("CrystalBladeP");
            item.shootSpeed = 5f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, 50, knockBack, player.whoAmI, 0f, 0f);
            return false; 
        }
        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);      
            recipe.AddIngredient(ItemID.SlapHand, 1);
            recipe.AddIngredient(ItemID.Bananarang, 20);
            recipe.AddTile(TileID.WorkBenches); 
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
