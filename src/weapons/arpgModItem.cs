using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace AbsoluteRPGRevived.Weapons {

    public class arpgModItem : GlobalItem
    {
        public override bool CanPickup(Item item, Player player)
        {
            // 4280690214 = black
            // 4294967295 = white
            if (player.skinColor.PackedValue > 4287828754.5)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}