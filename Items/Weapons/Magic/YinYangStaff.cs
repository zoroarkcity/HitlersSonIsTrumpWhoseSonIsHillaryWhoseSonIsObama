using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Weapons.Magic
{
    public class YinYangStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Phantasmal Storm";
            item.damage = 999;
            item.magic = true;
            item.mana = 20;
            item.width = 23;
            item.height = 23;
            item.toolTip = "Contains a ridiculous amount of energy";
            item.useTime = 120;
            item.useAnimation = 120;
            item.useStyle = 5;
            Item.staff[item.type] = true; 
            item.noMelee = true; 
            item.knockBack = 5;
            item.value = 2000000;
            item.rare = 9;
            item.useSound = 20;
            item.autoReuse = true;
            item.shoot = 580;
            item.shootSpeed = 7f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 vector82 = -Main.player[Main.myPlayer].Center + Main.MouseWorld;
            float ai = Main.rand.Next(100);
            Vector2 vector83 = Vector2.Normalize(vector82) * item.shootSpeed;
            Projectile.NewProjectile(player.Center.X, player.Center.Y, vector83.X, vector83.Y, type, damage, .49f, player.whoAmI, vector82.ToRotation(), ai);
            return false;
        }
    }
}