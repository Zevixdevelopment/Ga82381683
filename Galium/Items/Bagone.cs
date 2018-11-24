using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	public class Bagone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Explorer's Bag");
			Tooltip.SetDefault("<right> for goodies!");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 32;
			item.expert = false;
			item.height = 32;
			item.rare = 0;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
                    
                        
		    player.QuickSpawnItem(ItemID.WoodenSword); //item here
            player.QuickSpawnItem(ItemID.SilverCoin,50); 
            player.QuickSpawnItem(ItemID.SlimeCrown); 
            player.QuickSpawnItem(ItemID.Wood,150); 
            player.QuickSpawnItem(ItemID.Torch,5); 
            player.QuickSpawnItem(ItemID.Bomb,3); 
            player.QuickSpawnItem(mod.ItemType("Info")); 
            player.QuickSpawnItem(ItemID.ShinePotion,5); 
            player.QuickSpawnItem(ItemID.SpelunkerPotion,2); 
            player.QuickSpawnItem(ItemID.MagicMirror); 
            player.QuickSpawnItem(ItemID.LesserHealingPotion, 5); 
            player.QuickSpawnItem(ItemID.WoodenBoomerang); 
            player.QuickSpawnItem(mod.ItemType("Rubber")); 
            player.QuickSpawnItem(mod.ItemType("Scroll"), 2); 
            player.QuickSpawnItem(mod.ItemType("EnchantedScroll")); 
            player.QuickSpawnItem(ItemID.SwiftnessPotion, 5); 
            
		}
	}
}