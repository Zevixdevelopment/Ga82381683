using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;
using System;
using Terraria.ModLoader.IO;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace Galium.Tiles
{
    public class GaliumWorld : ModWorld
    {
        public bool hasGeneratedHadridianOre;
        
        public override void Initialize()
        {
            hasGeneratedHadridianOre = false;
            
        }
        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"genned", hasGeneratedHadridianOre}
                
            };
        }
        public override void Load(TagCompound tag)
        {
            hasGeneratedHadridianOre = tag.GetBool("genned");
            
        }
        public override void PreUpdate()
        {
            
           
            if (!hasGeneratedHadridianOre && NPC.downedBoss1)
            {
                
                for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 20E-5); i++)
                {
                    WorldGen.OreRunner(
                        WorldGen.genRand.Next(0, Main.maxTilesX), // X Coord of the tile
                        WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY - 200), // Y Coord of the tile
                        (double)WorldGen.genRand.Next(8, 9), // Strength (High = more)
                        WorldGen.genRand.Next(2, 6), // Steps 
                        (ushort)mod.TileType("HadridianOre") // The tile type that will be spawned
                       ); // Overrides existing tiles
                }
                string key = "Hadridian Ore Glows in the Depths Below";
                Color messageColor = Color.Cyan;
                if (Main.netMode == 2) // Server
                {
                    NetMessage.BroadcastChatMessage(NetworkText.FromLiteral(key), messageColor);
                }
                else if (Main.netMode == 0) // Single Player
                {
                    Main.NewText(Language.GetTextValue(key), messageColor);
                }
                hasGeneratedHadridianOre = true;
            }
        }
        
        
    }


}