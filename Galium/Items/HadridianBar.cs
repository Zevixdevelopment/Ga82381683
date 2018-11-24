using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class HadridianBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hadridian Bar");
            Tooltip.SetDefault("Glowing in Power");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.rare = 1;
            item.value = Item.buyPrice(0, 0, 50, 0);
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianOre"), 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}