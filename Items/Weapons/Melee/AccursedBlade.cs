using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{

    public class AccursedBlade : ModItem
    {

        public override void SetDefaults()
        {

            item.name = "Accursed Blade";
            item.damage = 62;
            item.crit = 8;
            item.melee = true;
            item.knockBack = 6;
            item.autoReuse = false;
            item.useTurn = true;
            item.width = 46;
            item.height = 48;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.rare = 5;
			item.autoReuse = true;
			item.useTurn = true;

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(2) == 0)
            {
                target.AddBuff(39, 360, false);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AccursedBar", 15);
            recipe.AddTile(26);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }



    }

}