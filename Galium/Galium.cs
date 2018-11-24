using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium
{
	class Galium : Mod
	{
		public override void AddRecipes()
		{
			// waterbolt 1
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.SetResult(ItemID.WaterBolt);
			recipe.needWater = true;
			recipe.AddRecipe();
		
			// Aglet 2
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.IronBar, 5);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.Aglet);
    		recipe.AddRecipe();
		
			// Aglet 2
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.LeadBar, 5);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.Aglet);
    		recipe.AddRecipe();
			
			//HermesBoots 3
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Leather, 3);
			recipe.AddIngredient(null, "EnchantedScroll");
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.HermesBoots);
    		recipe.AddRecipe();

			//IceSkates 4
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.IceBlock, 35);
			recipe.AddIngredient(ItemID.IronBar, 3);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.IceSkates);
    		recipe.AddRecipe();

			//IceSkates 4
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.IceBlock, 35);
			recipe.AddIngredient(ItemID.LeadBar, 3);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.IceSkates);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Amethyst);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Ruby);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Diamond);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Sapphire);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Topaz);
			recipe.AddIngredient(ItemID.Amethyst);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//AnkletoftheWind 5
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope);
			recipe.AddIngredient(ItemID.Aglet);
			recipe.AddIngredient(ItemID.Emerald);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.AnkletoftheWind);
    		recipe.AddRecipe();

			//Flipper 6
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(null, "Rubber", 3);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.Flipper);
    		recipe.AddRecipe();

			//BlizzardinaBottle 7
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.Cloud, 3);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.IceBlock, 15);
			recipe.AddIngredient(null, "EnchantedScroll");
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.BlizzardinaBottle);
    		recipe.AddRecipe();

			//ShinyRedBalloon 8
			recipe = new ModRecipe(this);
    		recipe.AddIngredient(ItemID.Cloud, 3);
			recipe.AddIngredient(null, "Rubber");
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ShinyRedBalloon);
    		recipe.AddRecipe();

			//WhoopieCushion 9
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "Rubber", 5);
    		recipe.AddTile(TileID.WorkBenches);
    		recipe.SetResult(ItemID.WhoopieCushion);
    		recipe.AddRecipe();

			//CloudinaBottle 10
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 3);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(null, "Rubber");
    		recipe.AddTile(TileID.WorkBenches);
    		recipe.SetResult(ItemID.CloudinaBottle);
    		recipe.AddRecipe();

			//ClimbingClaws 11
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddIngredient(ItemID.LeadBar);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ClimbingClaws);
    		recipe.AddRecipe();

			//ClimbingClaws 11
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddIngredient(ItemID.IronBar);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ClimbingClaws);
    		recipe.AddRecipe();

			//FlyingCarpet 12
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 5);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddIngredient(ItemID.Silk, 3);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.FlyingCarpet);
    		recipe.AddRecipe();

			//LavaCharm 13
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.ObsidianSkinPotion);
    		recipe.needLava = true;
    		recipe.SetResult(ItemID.LavaCharm);
    		recipe.AddRecipe();

			//WaterWalkingBoots 14
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Leather);
			recipe.AddIngredient(ItemID.WaterWalkingPotion);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.WaterWalkingBoots);
    		recipe.AddRecipe();

			//LuckyHorseshoe 15
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBar, 6);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(null, "EnchantedScroll");
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.LuckyHorseshoe);
    		recipe.AddRecipe();

			//LuckyHorseshoe 15
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumBar, 6);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(null, "EnchantedScroll");
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.LuckyHorseshoe);
    		recipe.AddRecipe();

			//PDA 16
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GlowingMushroom, 6);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(null, "Scroll");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.PDA);
    		recipe.AddRecipe();

			//ShoeSpikes 17
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddIngredient(ItemID.IronBar);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ShoeSpikes);
    		recipe.AddRecipe();

			//ShoeSpikes 17
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Stinger, 3);
			recipe.AddIngredient(ItemID.LeadBar);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ShoeSpikes);
    		recipe.AddRecipe();

			

			//AdhesiveBandage 18
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Silk, 3);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.AdhesiveBandage);
    		recipe.AddRecipe();

			//ArmorBracing 19
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(null, "Rubber");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.ArmorBracing);
    		recipe.AddRecipe();

			//ArmorBracing 19
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddIngredient(null, "Rubber");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.ArmorBracing);
    		recipe.AddRecipe();

			//ArmorPolish 20
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.LeadChainmail);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.ArmorPolish);
    		recipe.AddRecipe();

			//ArmorPolish 20
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.IronChainmail);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.ArmorPolish);
    		recipe.AddRecipe();


			//Bezoar 21
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope, 2);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.Bezoar);
    		recipe.AddRecipe();

			//Blindfold 22 
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope, 2);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.Blindfold);
    		recipe.AddRecipe();

			//MoonCharm 23
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(null, "MoonPiece");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.MoonCharm);
    		recipe.AddRecipe();

			//FastClock 24
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.TinWatch);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.FastClock);
    		recipe.AddRecipe();

			//FastClock 24
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.CopperWatch);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.FastClock);
    		recipe.AddRecipe();

			//TrifoldMap 25
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.Silk, 3);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.TrifoldMap);
    		recipe.AddRecipe();

			//FeralClaws 26
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.VineRope, 3);
			recipe.AddIngredient(ItemID.Vine);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.FeralClaws);
    		recipe.AddRecipe();
			
			//FrozenTurtleShell 27
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.TurtleShell);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.FrozenTurtleShell);
    		recipe.AddRecipe();

			//MagicQuiver 28
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.WoodenArrow, 999);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.MagicQuiver);
    		recipe.AddRecipe();

			//MagmaStone 29
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.StoneBlock);
    		recipe.needLava = true;
    		recipe.SetResult(ItemID.MagmaStone);
    		recipe.AddRecipe();

			//Megaphone 30
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.SoulofFright);
			recipe.AddIngredient(ItemID.TinWatch);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.Megaphone);
    		recipe.AddRecipe();

			//Nazar 31
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.BandofStarpower);
			recipe.AddIngredient(ItemID.Chain);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.Nazar);
    		recipe.AddRecipe();

			//ObsidianRose 32
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.ObsidianSkinPotion);
			recipe.AddIngredient(ItemID.Daybloom);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ObsidianRose);
    		recipe.AddRecipe();

			//MoonStone 33
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(null, "MoonPiece");
			recipe.AddIngredient(ItemID.SoulofMight);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.MoonStone);
    		recipe.AddRecipe();

			//PaladinsShield 34
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.ObsidianShield);
			recipe.AddIngredient(ItemID.SoulofMight);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.PaladinsShield);
    		recipe.AddRecipe();

			//PocketMirrror 35
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Glass);
			recipe.AddIngredient(ItemID.SoulofSight);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.PocketMirror);
    		recipe.AddRecipe();

			//SharkToothNecklace 36
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.SharkFin, 3);
			recipe.AddIngredient(ItemID.Chain);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.SharkToothNecklace);
    		recipe.AddRecipe();

			//StarCloak 37
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.FallenStar, 5);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.StarCloak);
    		recipe.AddRecipe();

			//Vitamins 38
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.BowlofSoup);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.Vitamins);
    		recipe.AddRecipe();

			//DiscountCard 39
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumCoin);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.DiscountCard);
    		recipe.AddRecipe();

			//FlowerBoots 40
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.VineRope, 20);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.FlowerBoots);
    		recipe.AddRecipe();

			//GuidetoPlantFiberCordage 41
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "Scroll");
			recipe.AddIngredient(ItemID.Wood, 5);
    		recipe.SetResult(ItemID.CordageGuide);
    		recipe.AddRecipe();

			//ClothierVoodooDoll 42
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.GoldenKey);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.ClothierVoodooDoll);
    		recipe.AddRecipe();

			//NeptunesShell 43
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(ItemID.Coral, 15);
			recipe.AddIngredient(ItemID.Goldfish, 10);
			recipe.AddIngredient(ItemID.SharkFin, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.NeptunesShell);
    		recipe.AddRecipe();	

			//BandofStarpower 44
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.AddIngredient(ItemID.ManaCrystal);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.BandofStarpower);
    		recipe.AddRecipe();

			//BandofRegeneration 45
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll");
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.AddIngredient(ItemID.LifeCrystal);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.BandofRegeneration);
    		recipe.AddRecipe();
			
			//HeartCrystal 46
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "LifePiece", 3);
    		recipe.AddTile(TileID.HangingLanterns);
    		recipe.SetResult(ItemID.LifeCrystal);
    		recipe.AddRecipe();

			//LifeFruit 47
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "LifeFruitSeed");
    		recipe.needWater = true;
    		recipe.SetResult(ItemID.LifeFruit);
    		recipe.AddRecipe();

			//BrokenHeroSword 48
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "SpaceBar", 8);
			recipe.AddIngredient(null, "DarkMatter");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.BrokenHeroSword);
    		recipe.AddRecipe();

			//TheEyeofCthulhu //49
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "Retina", 2);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(null, "DarkMatter");
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.TheEyeOfCthulhu);
    		recipe.AddRecipe();

			//MothronWings 50
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "SpaceBar", 10);
			recipe.AddIngredient(ItemID.SoulofFlight, 25);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.MothronWings);
    		recipe.AddRecipe();

			//DeathSickle 51
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "DarkMatter", 3);
			recipe.AddIngredient(ItemID.SoulofNight);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.DeathSickle);
    		recipe.AddRecipe();

			//BrokenBatWing 52
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "DarkMatter", 5);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
    		recipe.AddTile(TileID.MythrilAnvil);
    		recipe.SetResult(ItemID.BrokenBatWing);
    		recipe.AddRecipe();

			//FlyingCarpet 53
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "EnchantedScroll", 3);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddIngredient(ItemID.CloudinaBottle);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.FlyingCarpet);
    		recipe.AddRecipe();

			//Hellforge 54
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Obsidian, 15);
			recipe.AddIngredient(ItemID.Hellstone, 20);
    		recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(ItemID.Hellforge);
    		recipe.AddRecipe();
		}
		 
	}
}
