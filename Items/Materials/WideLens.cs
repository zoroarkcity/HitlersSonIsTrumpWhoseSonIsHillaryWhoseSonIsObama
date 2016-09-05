using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class WideLens : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Wide Lens";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("Eye can see all.");
			item.value = 100;
			item.rare = 1;
		}
	}
}