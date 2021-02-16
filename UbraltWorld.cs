using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace UbraltMod
{
    public class UbraltWorld : ModWorld
    {
        public static bool downedSharlteron;
        public static bool downedDragonFly;

        public override void Initialize()
        {
            downedSharlteron = false;
            downedDragonFly = false;
        }
        public override TagCompound Save()
        {
            var downed = new List<string>();
            if (downedSharlteron)
            {
                downed.Add("sharlteron");
            }
            if (downedDragonFly)
            {
                downed.Add("dragonFly");
            }

            return new TagCompound
            {
                ["downed"] = downed
            };
        }
        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedSharlteron = downed.Contains("shalteron");
            downedDragonFly = downed.Contains("dragonFly");
        }
        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                downedSharlteron = flags[0];
                downedDragonFly = flags[1];
            }
            else {
                mod.Logger.WarnFormat("UbraltMod: Unknown loadVersion: {0}", loadVersion);
            }
        }
        public override void NetSend(BinaryWriter writer)
        {
            var flags = new BitsByte();
            flags[0] = downedSharlteron;
            flags[1] = downedDragonFly;
            writer.Write(flags);
        }
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            downedSharlteron = flags[0];
            downedDragonFly = flags[1];
        }
    }
}
