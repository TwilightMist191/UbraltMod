using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace UbraltMod
{
    public class UbraltMod : Mod
    {
        public UbraltMod()
        {

        }
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if(bossChecklist != null)
            {
                bossChecklist.Call(
                    "AddToBossLoot",
                    this,
                    "Golem",
                    ModContent.ItemType<Items.Summons.Boss.CursedSkull>());
                
                bossChecklist.Call(
                    "AddBoss",
                    11.5f,
                    ModContent.NPCType<NPCs.Boss.Sharlteron.Sharlteron>(),
                    this,
                    "Sharlteron",
                    UbraltWorld.downedSharlteron,
                    ModContent.ItemType<Items.Summons.Boss.CursedSkull>(),
                    ItemID.MusicBoxLunarBoss,
                    ItemID.TerraBlade);

                bossChecklist.Call(
                    "AddBoss",
                    4.5f,
                    ModContent.NPCType<NPCs.Boss.Sharlteron.Sharlteron>(),
                    this,
                    "Dragon Fly",
                    UbraltWorld.downedDragonFly,
                    ModContent.ItemType<Items.Summons.Boss.CursedSkull>(),
                    ItemID.MusicBoxLunarBoss,
                    ItemID.TerraBlade);
            }
        }
    }
}
