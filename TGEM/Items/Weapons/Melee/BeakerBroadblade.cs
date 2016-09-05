using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{
    public class BeakerBroadblade : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Adamzam's Beaker Blade";
            item.damage = 120;
            item.melee = true;
            item.width = 64;
            item.height = 64;
            item.toolTip = "This is a modded sword.";
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 6.5f;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BeakerBladeShot");
            item.shootSpeed = 12f;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(24, 180, false);
            }
            if (Main.rand.Next(3) == 1)
            {
                target.AddBuff(39, 180, false);
            }
            if (Main.rand.Next(3) == 2)
            {
                target.AddBuff(44, 180, false);
            }
        }
    }
}