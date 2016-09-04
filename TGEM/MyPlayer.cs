using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TGEM
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool Servant = false;
        public bool vampCharm = false;
        public static bool hasProjectile;

        public override void ResetEffects()
        {
            Servant = false;
        }
    }
}