using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Items.Acessories
{
    public class BerserkerEmblem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Berserker Emblem";
            item.width = 14;
            item.height = 14;
            item.toolTip = "Increases Melee Speed by 15%.";
            item.value = 100000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeSpeed *= 1.15f;
        }
    }
}