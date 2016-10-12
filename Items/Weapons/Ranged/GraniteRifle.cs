using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Ranged
{
    public class GraniteRifle : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Granite Decimator";
            item.damage = 32;
            item.ranged = true;
            item.width = 31;
            item.height = 32;
            item.crit = 15;
            item.toolTip = "Destroyes your enemies with ease";
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 12f;
            item.useAmmo = ProjectileID.Bullet;
        }
    }
}