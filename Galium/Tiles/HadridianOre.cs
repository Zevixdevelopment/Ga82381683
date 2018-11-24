using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Galium.Tiles
{
	public class HadridianOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = 88;
			drop = mod.ItemType("HadridianOre");
			AddMapEntry(new Color(0, 500, 700));
			soundType = 21;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.3f;
			b = 0.7f;
		}
	}
}