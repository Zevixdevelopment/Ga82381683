using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class HadronPickAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hadron Pickaxe");
			Tooltip.SetDefault("Speedy Neon Light Pickaxe");
		}
		public override void SetDefaults()
		{
			item.damage = 0;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 7;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 50000;
			item.crit = 50;
            item.pick = 47;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianBar"), 4);
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
