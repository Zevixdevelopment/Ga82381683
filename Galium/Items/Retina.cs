using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Retina : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Retina");
            Tooltip.SetDefault("Its gooey...");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 22;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 1, 0, 0); 
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = 2;
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }

    }
}