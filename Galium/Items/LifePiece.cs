using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class LifePiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Crystal Piece");
            Tooltip.SetDefault("You can feel Life itself...");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 3;
            item.value = Item.buyPrice(0, 1, 50, 0); 
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 2;
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }

    }
}