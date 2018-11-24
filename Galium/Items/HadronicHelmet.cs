using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galium.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HadronicHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hadronic Helmet");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 16;
			item.value = 30000;
			item.rare = 1;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("HadronicChestPlate") && legs.type == mod.ItemType("HadronicPants");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.buffImmune[BuffID.Chilled] = true;
            player.statDefense += 2;
			player.setBonus = "Plus 2 Defense and Immunity to Chilled";
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HadridianBar"), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}