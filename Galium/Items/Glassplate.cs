using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Glassplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glass Plate");
			Tooltip.SetDefault("Shattered");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.thrown = true;
			item.width = 24;
			item.height = 26;
            item.maxStack = 1;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 1;
			item.crit = 5;
			item.value = 50;
			item.rare = 5;
			item.UseSound = SoundID.Item19;
			item.autoReuse = true;
			item.useTurn = true;
            item.consumable = false;
			item.shootSpeed = 5f;
            item.noUseGraphic = true; 
			item.shoot = mod.ProjectileType<Glassplateproj>();         
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glass, 25);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
