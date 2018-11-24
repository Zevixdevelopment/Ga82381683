using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class SolarMoonPiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Moon Piece");
			Tooltip.SetDefault("Hot and Cold Combination");
        }

        public override void SetDefaults()
        {
			item.width = 30;
			item.height = 24;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 25, 0);
            item.rare = 8;
            // Set other item.X values here
        }
    }
}