using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.NPCs
{
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/blushiemagic/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Stoner : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stoner");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 50;
			npc.height = 32;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath17;
			npc.value = 100f;
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 3;
			aiType = NPCID.WalkingAntlion;
            animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(SpawnCondition.Cavern.Chance > 0.0f)
				return SpawnCondition.Cavern.Chance / 4f;
			
			return SpawnCondition.Underground.Chance / 4f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = 0;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
        public override void NPCLoot()
        {
	    	Item.NewItem(npc.getRect(), ItemID.StoneBlock, Main.rand.Next(2, 5));
			if(Main.rand.Next(3) == 0)
			Item.NewItem(npc.getRect(), ItemID.Sapphire, Main.rand.Next(1, 2));
        }
		
        
	}
}