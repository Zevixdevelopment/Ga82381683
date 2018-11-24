using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;


namespace Galium.Items
{
	public class PumpkinStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pumpkin Staff");
            Tooltip.SetDefault("sPoOkY....");
		}

		public override void SetDefaults()
		{
			item.damage = 82;
            item.crit = 4;
			item.magic = true;
			item.mana = 12;
			item.noUseGraphic = false;
			item.width = 38;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
            item.shoot = ProjectileID.MolotovFire;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 1;
			item.value = Item.buyPrice(0, 50, 0, 0); 
            item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = -11;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Pumply"), 50);
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ItemID.SpookyWood, 10);
            recipe.AddIngredient(mod.ItemType("EnchantedScroll"));
            recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, -8);
		}
    }
}