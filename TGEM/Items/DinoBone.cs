using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class DinoBone : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dino Bone";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("This is a modded item.");
			item.value = 100;
			item.rare = 1;
		}
	}
}