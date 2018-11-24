using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class RubberBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rubber Ball");
            Tooltip.SetDefault("Ok the end of that line was a joke...");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = 5;
            item.rare = 0;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Rubber"), 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}