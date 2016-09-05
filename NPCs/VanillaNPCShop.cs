using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM.NPCs
{
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Dryad:  //change Dryad whith what NPC you want
                    {    //This make that the npc will always sell this
                        shop.item[nextSlot].SetDefaults(ItemID.SlimeStaff);     //this is an example of how to add a terraria item
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}