﻿using Terraria;
using Terraria.ModLoader;

namespace TGEM.Buffs
{
	public class ServantOfCthulhu : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Servant Of Cthulhu";
			Main.buffTip[Type] = "Become the Cthulhu";
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("Servant")] > 0)
			{
				modPlayer.Servant = true;
			}
			if (!modPlayer.Servant)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}