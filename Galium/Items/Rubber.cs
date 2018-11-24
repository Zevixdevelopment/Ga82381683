using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Rubber : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rubber");
            Tooltip.SetDefault("I could do something useful with this... OR MAKE A BALL OUT OF IT :D");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.value = 3;
            item.rare = 0;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Acorn);
            recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}