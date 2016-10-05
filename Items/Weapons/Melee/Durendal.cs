using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{

    public class Durendal : ModItem
    {

        public override void SetDefaults()
        {

            item.name = "Durendal";
            item.damage = 125;
            item.crit = 22;
            item.melee = true;
            item.knockBack = 6;
            item.autoReuse = true;
            item.useTurn = true;
            item.width = 82;
            item.height = 82;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.useSound = 1;
            item.value = 10000;
            item.rare = 12;
            item.shoot = mod.ProjectileType("DurendalP");
            item.shootSpeed = 12f;

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(1) == 0)
            {
                target.AddBuff(44, 360, false);
            }

            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(46, 360, false);
            }

        }



    }

}