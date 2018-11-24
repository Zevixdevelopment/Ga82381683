using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Pumpy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rotten Pumpkin");
			Tooltip.SetDefault("Gooey and Cursed");
        }

        public override void SetDefaults()
        {
			item.width = 26;
			item.height = 28;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 5, 0);
            item.rare = -11;
            // Set other item.X values here
        }
    }
}