using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Lavator : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lavator");
			Tooltip.SetDefault("Caution! Hot Object!");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 2;
			item.crit = 13;
			item.value = 5000;
			item.rare = 5;
			item.shoot = 15; 
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.useTurn = true;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 1; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
			
		}
		public override void MeleeEffects( Player player, Rectangle hitbox)
        {
            Lighting.AddLight(new Vector2(hitbox.Center.X, hitbox.Center.Y), 1.0f, .5f, .0f);//rgb
            
           
        }






	}
}
