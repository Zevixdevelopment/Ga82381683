using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.NPCs
{
    class NPCdroploot : GlobalNPC
{
	public override void NPCLoot(NPC npc)
	{
		// Addtional if statements here if you would like to add drops to other vanilla npc.
		if(npc.type == NPCID.EyeofCthulhu) //1
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Retina"), 1);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Lens, 3);
		}

        if(npc.type == NPCID.GiantTortoise)//2
		if (Main.rand.Next(10) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.TurtleShell, 1);
		}

		if(npc.type == NPCID.Nurse)//3
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, 1);
		}

		if(npc.type == NPCID.SkeletronHead)//4
		if (Main.rand.Next(2) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"), 3);
		}
		if(npc.type == NPCID.SkeletronHead)//4
		if (Main.rand.Next(2) == 0) //1 in 3 chance
		{
		Item.NewItem(npc.getRect(), ItemID.Bone, Main.rand.Next(5, 15));
		}

		if(npc.type == NPCID.Plantera)//5
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Uzi, 1);
		}
		if(npc.type == NPCID.Plantera)//24
		if(Main.rand.Next(4) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		
		//angry bones, ph dun enemys
		if(npc.type == NPCID.AngryBones)//6
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBigMuscle)//7
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBig)//8
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.AngryBonesBigHelmet)//9
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.ShortBones)//10
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.BigBoned)//11
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.DarkCaster)//12
		if (Main.rand.Next(13) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifePiece"));
		}

		if(npc.type == NPCID.DungeonSlime)//13
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldenKey);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldenKey);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldCoin);
		}

		if(npc.type == NPCID.QueenBee)//14
		if (Main.rand.Next(2) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Boomstick);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IllegalGunParts);
		}

		if(npc.type == NPCID.BlueJellyfish)//15
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}

		if(npc.type == NPCID.PinkJellyfish)//16
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}

		if(npc.type == NPCID.GreenJellyfish)//17
		if (Main.rand.Next(5) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LifeJar"));
		}

		if(npc.type == NPCID.Frankenstein)//18
		if (Main.rand.Next(4) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarMoonPiece"), 2);
		}

		if(npc.type == NPCID.Mothron)//19
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarMoonPiece"), 13);
		}
		
		if(npc.type == NPCID.MothronSpawn)//20
		if (Main.rand.Next(10) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SolarMoonPiece"));
		}
		
		if(npc.type == NPCID.Reaper)//21
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkMatter"), 3);
		}

		if(npc.type == NPCID.Reaper)//21
		if (Main.rand.Next(3) == 0) //1 in 3 chance
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight, 5);
		}

		if(npc.type == NPCID.Lihzahrd)//22
		if(Main.rand.Next(8) == 0)
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LihzahrdPowerCell);
		}
		if(npc.type == NPCID.Lihzahrd)//24
		if(Main.rand.Next(4) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		
		if(npc.type == NPCID.LihzahrdCrawler)//23
		if(Main.rand.Next(8) == 0)
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LihzahrdPowerCell);
		}
		if(npc.type == NPCID.LihzahrdCrawler)//23
		if(Main.rand.Next(4) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		
		if(npc.type == NPCID.FlyingSnake)//24
		if(Main.rand.Next(8) == 0)
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LihzahrdPowerCell);
		}

		if(npc.type == NPCID.FlyingSnake)//24
		if(Main.rand.Next(4) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}

		if(npc.type == NPCID.Pumpking)//25
		{
		Item.NewItem(npc.getRect(), mod.ItemType("Pumpy"), Main.rand.Next(10, 20));
		}

		if(npc.type == NPCID.Scarecrow1)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}

		if(npc.type == NPCID.Scarecrow2)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow3)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow4)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow5)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow6)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow7)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow8)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow9)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}
		
		if(npc.type == NPCID.Scarecrow10)//26
		{
		Item.NewItem(npc.getRect(), ItemID.Hay, Main.rand.Next(20, 37));
		}

		if(npc.type == NPCID.WallofFlesh)//27
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BallofFlesh"));
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight, 15);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofLight, 15);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GravitationPotion);
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldCoin, 75);

		}

		if(npc.type == NPCID.MoonLordCore)//27
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Glowmite"));
		}
		if(npc.type == NPCID.Arapaima)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.AngryTrapper)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.GiantTortoise)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.GiantFlyingFox)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.Derpling)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.JungleCreeper)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.JungleCreeperWall)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.Moth)//24
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		Item.NewItem(npc.getRect(), ItemID.HoneyLamp, Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.BigMossHornet)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.GiantMossHornet)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.LittleMossHornet)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.MossHornet)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}
		if(npc.type == NPCID.TinyMossHornet)//24
		if(Main.rand.Next(3) == 0)
		{
		Item.NewItem(npc.getRect(), mod.ItemType("JungleSoul"), Main.rand.Next(1, 3));
		}

		if(npc.type == NPCID.Frog)//25
		if(Main.rand.Next(12) == 0)
		{
		Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FrogLeg);
		}
	}
	//buyslots
	public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
			//if (type == NPCID.ArmsDealer && Main.bloodMoon && Main.hardMode && NPC.downedAncientCultist)
            //{
            //    shop.item[nextSlot].SetDefaults(mod.ItemType<Items.Weapons.Tier_4.BlightedFang>());
            //    nextSlot++;
            //}
		

            if (type == NPCID.ArmsDealer)
            {

                shop.item[nextSlot].SetDefaults(mod.ItemType<Items.GunHandBook>());
                nextSlot++;
			}
			if (type == NPCID.ArmsDealer && Main.hardMode)
            {

				shop.item[nextSlot].SetDefaults(ItemID.GuideVoodooDoll);
				shop.item[nextSlot].shopCustomPrice = 50000;
                nextSlot++;
			}
		}
	}
}
