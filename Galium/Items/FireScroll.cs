using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace Galium.Items
{
	public class FireScroll : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire Scroll");
            Tooltip.SetDefault("Wizard Scroll - I");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
            item.crit = 6;
			item.magic = true;
			item.mana = 15;
			item.noUseGraphic = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
            item.shoot = ProjectileID.BallofFire;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 0;
			item.value = Item.buyPrice(0, 1, 0, 0); 
            item.value = Item.sellPrice(0, 0, 25, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EnchantedScroll"));
            recipe.AddIngredient(ItemID.WaterBolt);
			recipe.needLava = true;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}