using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class GunHandBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gun Handbook");
            Tooltip.SetDefault("Increased Bullet Damage by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 22;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 5, 0, 0); 
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 5;
            item.accessory = true;
            item.defense = 1;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
         player.bulletDamage  *= 1.10f;
        }
    }
}