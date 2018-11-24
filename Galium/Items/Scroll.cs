using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Scroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scroll");
            Tooltip.SetDefault("Enchantable");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 26;
            item.maxStack = 999;
            item.value = 0;
            item.rare = 0;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}