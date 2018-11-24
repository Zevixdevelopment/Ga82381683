using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
    public class BallofFlesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ball of Flesh");
            Tooltip.SetDefault("Increases All Damage by 10%, And Gives 10 Health");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 4;
            item.accessory = true;
            item.defense = 2;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
         player.bulletDamage  *= 1.05f;
         player.meleeDamage  *= 1.05f;
         player.magicDamage  *= 1.20f;
         player.thrownDamage  *= 1.20f;
         player.minionDamage *= 1.05f;
         player.statLifeMax2 += 10;
        }
    }
}