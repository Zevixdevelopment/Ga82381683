using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class HadronHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hadron Hamaxe");
			Tooltip.SetDefault("ChOpPy AnD bReAkY");
		}
		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 36;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.crit = 5;
            item.axe = 16;
            item.hammer = 45;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianBar"), 5);
			recipe.AddIngredient(ItemID.WarAxeoftheNight);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void MeleeEffects( Player player, Rectangle hitbox)
        {
            Lighting.AddLight(new Vector2(hitbox.Center.X, hitbox.Center.Y), .0f, .3f, .7f);

			if (Main.rand.NextBool(3))
			{
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 88);
			}
        }
		
	}
}
