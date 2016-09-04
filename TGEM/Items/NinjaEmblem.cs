using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Items
{
    public class NinjaEmblem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ninja Emblem";
            item.width = 14;
            item.height = 14;
            item.toolTip = "Increases Thrown Damage by 15%.";
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage *= 1.15f;
        }
    }
}