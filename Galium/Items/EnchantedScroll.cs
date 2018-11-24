using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class EnchantedScroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Scroll");
			Tooltip.SetDefault("'The Essence of Strenght tingles in your Fingers as you Hold the Scroll'");
        }

        public override void SetDefaults()
        {
			item.width = 28;
			item.height = 26;
            item.maxStack = 30;
            item.value = 500;
            item.rare = 2;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Scroll"));
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}