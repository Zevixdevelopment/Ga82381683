using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class JungleSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jungle Soul");
			Tooltip.SetDefault("Soul of The Jungle Creatures");
            // ticksperframe, frameCount
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
			item.width = 22;
			item.height = 20;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 5, 0);
            item.rare = 7;
        }
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(item.Center, .0f, .5f, .2f); //rgb
        }
    }
}