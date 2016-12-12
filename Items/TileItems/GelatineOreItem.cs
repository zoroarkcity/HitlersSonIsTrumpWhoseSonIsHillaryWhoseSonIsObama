using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.TileItems
{
    public class GelatineOreItem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gelatine Ore";
            item.width = 16; 
			item.height = 14;
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = 50;
            item.rare = 2;
			item.consumable = true;
			item.autoReuse = true;
            item.createTile = mod.TileType("GelatineOre");
        }
    }
}
