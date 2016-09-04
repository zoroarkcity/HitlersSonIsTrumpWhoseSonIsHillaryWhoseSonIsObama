using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class Geode : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Geode";
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			AddTooltip("This is a modded item.");
			item.value = 100;
			item.rare = 1;
		}
	}
}