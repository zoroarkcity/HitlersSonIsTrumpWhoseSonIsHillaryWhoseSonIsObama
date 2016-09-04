using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Items
{
    public class BerserkerEmblem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Berserker Emblem";
            item.width = 14;
            item.height = 14;
            item.toolTip = "Increases Melee Speed by 15%.";
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeSpeed *= 1.15f;
        }
    }
}