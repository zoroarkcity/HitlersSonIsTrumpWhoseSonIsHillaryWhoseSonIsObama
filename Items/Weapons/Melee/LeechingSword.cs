using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items.Weapons.Melee {
public class LeechingSword : ModItem
{
        public override void SetDefaults()
        {
            item.name = "Leeching Sword";
            item.damage = 30;
            item.melee = true;
            item.width = 22;
            item.height = 24;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.toolTip = "Steals a small amount of health from enemies";
            item.autoReuse = true;
            item.useTurn = true;
        }
	
	public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			player.HealEffect(3);
			player.statLife += 3;
		}
	
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "UndeadEnergy", 10);
			recipe.AddIngredient(ItemID.Bone, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}