using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UbraltMod.NPCs.Boss.Sharlteron
{
    //[AutoloadBossHead]
    public class Sharlteron : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shalteron");
            Main.npcFrameCount[npc.type] = 12;
        }

        public override void SetDefaults()
        {
			npc.aiStyle = -1;
			npc.lifeMax = 48500;
			npc.damage = 88;
			npc.defense = 55;
			npc.knockBackResist = 0f;
			npc.width = 224;
			npc.height = 146;
			npc.value = Item.buyPrice(0, 25, 0, 0);
			npc.npcSlots = 10;
			//npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/BonyBeatdown");
		}

        public override void AI()
        {
            base.AI();
        }
    }
}
