using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class SpaceBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Space Bar");
			Tooltip.SetDefault("You Hold It Tight So It doesn't Float Away");
        }

        public override void SetDefaults()
        {
			item.width = 30;
			item.height = 24;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 3, 0, 0);
            item.rare = 8;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("SolarMoonPiece"), 5);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}