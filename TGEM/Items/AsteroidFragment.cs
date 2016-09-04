using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.Items
{
	public class AsteroidFragment : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Asteroid Fragment";
			item.width = 9;
			item.height = 9;
			item.maxStack = 999;
			AddTooltip("The primal energies of the cosmos.");
			item.value = 100;
			item.rare = 1;
		}
	}
}