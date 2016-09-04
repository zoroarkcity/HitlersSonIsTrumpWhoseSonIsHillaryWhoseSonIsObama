using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class CursedEssence : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cursed Essence";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("You can hear screams for help from it.");
			item.value = 100;
			item.rare = 1;
		}
	}
}