using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items.Materials
{
	public class DinoBone : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dino Bone";
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			AddTooltip("The bones of a great dinosaur");
			item.value = 100;
			item.rare = 1;
		}
	}
}