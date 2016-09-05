using Terraria.ModLoader;

namespace TGEM
{
	class TGEM : Mod
	{
		public TGEM()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
