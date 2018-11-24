using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Galium.Items
{
    public class HadridianOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hadridian");
            Tooltip.SetDefault("So bright your eyes glow just as bright when looking at it...");
        }

        public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
            item.rare = 1;
			item.autoReuse = true;
            item.value = Item.buyPrice(0, 0, 25, 0);
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("HadridianOre");
		}
          public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(item.Center, .0f, .2f, .7f); //rgb
        }

    }
}