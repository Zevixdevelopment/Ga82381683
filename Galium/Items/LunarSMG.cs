using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria.ModLoader;


namespace Galium.Items
{
	public class LunarSMG : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar SMG");
            Tooltip.SetDefault("Legendary...");
		}

		public override void SetDefaults()
		{
			item.damage = 145;
            item.crit = 25;
			item.ranged = true;
			item.width = 54;
			item.height = 38;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 0;
			item.value = Item.buyPrice(5, 0, 0, 0); 
            item.value = Item.sellPrice(1, 0, 0, 0);
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ISMGE"));
            recipe.AddIngredient(ItemID.IllegalGunParts, 3);
            recipe.AddIngredient(ItemID.FragmentVortex, 35);
            recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddIngredient(mod.ItemType("Glowmite"), 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 6);
		}
        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 1.0f;
    	}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
			type = ProjectileID.MoonlordBullet; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
			int numberProjectiles = 3 + Main.rand.Next(2); // 5 or 6 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
        
    }
}


