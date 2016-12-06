using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{

    public class ChaoticBlade : ModItem
    {

        public override void SetDefaults()
        {

            item.name = "Chaotic Blade";
            item.damage = 62;
            item.crit = 8;
            item.melee = true;
            item.knockBack = 6;
            item.autoReuse = false;
            item.useTurn = true;
            item.width = 46;
            item.height = 48;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.rare = 5;

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(4) == 0)
            {
                target.AddBuff(69, 360, false);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChaoticBar", 15);
            recipe.AddTile(26);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }



    }

}