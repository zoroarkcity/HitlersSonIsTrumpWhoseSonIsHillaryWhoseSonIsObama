using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Melee
{
    public class EatersTooth : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Eater's Tooth";
            item.damage = 240;
            item.melee = true;
            item.width = 23;
            item.height = 23;
            item.toolTip = "'Great for impersonating Devs!.'";
            item.toolTip2 = "A Warrior once ripped off a tooth from the Eater of Worlds and proceded to kill the monster with its own tooth!.";
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 6.5f;
            item.value = 10000;
            item.rare = 10;
            item.shoot = 95;
            item.useSound = 1;
            item.autoReuse = true;
            item.shootSpeed = 8f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 95, 50, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            return false; 
        }
    }
}