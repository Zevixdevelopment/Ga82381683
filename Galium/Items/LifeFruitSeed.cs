using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class LifeFruitSeed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Fruit Seed");
            Tooltip.SetDefault("Grow Your Favorite Type of Fruit!");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.maxStack = 3;
            item.value = Item.buyPrice(0, 2, 0, 0); 
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 7;
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("JungleSoul"));
			recipe.AddIngredient(ItemID.BottledHoney);
			recipe.AddIngredient(ItemID.JungleGrassSeeds);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}