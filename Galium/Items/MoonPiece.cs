using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class MoonPiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MoonPiece");
            Tooltip.SetDefault("So Outer Space to where it doesn't even stick to the ground");
            ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 30;
            item.maxStack = 99;
            item.value = 15;
            item.rare = 0;
            // Set other item.X values here
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowCloudBlock, 3);
            recipe.AddIngredient(ItemID.Meteorite, 5);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}