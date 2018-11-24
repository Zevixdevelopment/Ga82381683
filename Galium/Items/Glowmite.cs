using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class Glowmite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glowmite");
			Tooltip.SetDefault("Area 51 Stuff");
            // ticksperframe, frameCount
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
			item.width = 22;
			item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 14, 0);
            item.rare = -12;
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(item.Center, .0f, .7f, .5f); //rgb
        }
    }
}