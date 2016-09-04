using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TGEM.Items
{
    public class PaladinEmblem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Paladin Emblem";
            item.width = 28;
            item.height = 28;
            item.toolTip = "Reduces damage taken by 12%";
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += 0.12f;
        }
    }
}