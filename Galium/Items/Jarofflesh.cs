using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Jarofflesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jar o' Flesh");
            Tooltip.SetDefault("Increases health by 60 and All damage is increased by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 22;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 1, 0, 0); 
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = 5;
            item.accessory = true;
            item.defense = 3;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(mod.ItemType("LifeJar"));
        recipe.AddIngredient(mod.ItemType("BallofFlesh"));
		recipe.AddTile(TileID.TinkerersWorkbench);
		recipe.SetResult(this);
		recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.statLifeMax2 += 60;
        player.bulletDamage  *= 1.05f;
        player.meleeDamage  *= 1.05f;
        player.thrownDamage  *= 1.20f;
        player.minionDamage *= 1.05f;
        player.magicDamage  *= 1.20f;
        }
    }
}