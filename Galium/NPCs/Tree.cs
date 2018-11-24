using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.NPCs
{
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/blushiemagic/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Tree : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seed");
			Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.width = 16;
			npc.height = 22;
			npc.damage = 1;
			npc.defense = 1;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 5f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 0;
            
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 1f;
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
	    	Item.NewItem(npc.getRect(), ItemID.Wood, Main.rand.Next(10, 15));
        }
        
	}
}