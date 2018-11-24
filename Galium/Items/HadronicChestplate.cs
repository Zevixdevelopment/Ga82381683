using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    [AutoloadEquip(EquipType.Body)]
    public class HadronicChestPlate : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hadronic Chestplate");
            Tooltip.SetDefault("Gives 5 Health");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 0, 50, 0);
            item.rare = 1;
            item.defense = 4;
            // Set other item.X values here
            //item.value = Item.buyPrice(0, 0, 0, 0);  plat gold silv cop
            //item.value = Item.sellPrice(0, 0, 0, 0);
        }
        public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 5;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianBar"), 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}