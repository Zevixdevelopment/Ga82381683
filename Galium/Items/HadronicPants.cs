using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class HadronicPants : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Hadronic Leggings");
			Tooltip.SetDefault("3% Faster movement");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.03f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianBar"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}