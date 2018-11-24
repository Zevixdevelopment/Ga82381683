using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Glassplateproj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glass Plate");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}

		public override void SetDefaults()
		{
			projectile.width = 24;               //The width of projectile hitbox
			projectile.height = 26;              //The height of projectile hitbox
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 0;            //Set to above 0 if you want the projectile to update multiple time in a frame
			//aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
			projectile.velocity.Y = projectile.velocity.Y + 0.5f;
			projectile.aiStyle = 3;
			
			
		}
	}
}