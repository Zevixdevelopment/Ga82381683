using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Info : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Info");
            Tooltip.SetDefault("Welcome to the Galium Mod! I would like to give a thanks to Jacko, Drones, and Koid for making this mod possible! Enjoy!");
        }

        public override void SetDefaults()
        {
            item.width = 8;
            item.height = 8;
            item.maxStack = 1;
            item.rare = -1;
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }
    }
}