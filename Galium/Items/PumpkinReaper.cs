using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class PumpkinReaper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pumpkin Reaper");
			Tooltip.SetDefault("Swings of Pumpkins And Skeletons");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.melee = true;
			item.width = 56;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 2;
			item.crit = 13;
			item.value = 50000;
			item.rare = -11;
			item.UseSound = SoundID.Item71;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Pumpy"), 10);
			recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ItemID.SpookyWood, 35);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}