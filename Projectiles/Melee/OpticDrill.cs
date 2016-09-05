using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Projectiles.Melee
{
    //ported from my tAPI mod because I don't want to make artwork
    public class OpticDrill : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Optic Drill";
            projectile.width = 22;
            projectile.height = 22;
            projectile.aiStyle = 20;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.hide = true;
            projectile.ownerHitCheck = true; //so you can't hit enemies through walls
            projectile.melee = true;
        }
    }
}