using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class DarkMatter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Matter");
			Tooltip.SetDefault("That's Dark!");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 8));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
			item.width = 44;
			item.height = 46;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 95, 0);
            item.rare = 11;
            // Set other item.X values here
        }
    }
}