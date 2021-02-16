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

namespace UbraltMod.NPCs.Boss.DragonFly
{
    public class DragonFly : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Fly");
			Main.npcFrameCount[npc.type] = 24;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = -1;
			npc.lifeMax = 4000;
			npc.damage = 30;
			npc.defense = 5;
			npc.knockBackResist = 0f;
			npc.width = 98;
			npc.height = 122;
			npc.value = Item.buyPrice(0, 5, 0, 0);
			npc.npcSlots = 10;
			//npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			music = MusicID.Boss1;
		}

        public override void AI()
        {
			Player player = Main.player[npc.target];
			Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;
			npc.netAlways = true;
			npc.TargetClosest(true);
		}
    }
}
