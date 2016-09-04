using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace TGEM.Items
{
    public class MinerEmblem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Miner Emblem";
            item.width = 14;
            item.height = 14;
            item.toolTip = "Doubles Mining Speed.";
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.pickSpeed *= 0.5f;
        }
    }
}