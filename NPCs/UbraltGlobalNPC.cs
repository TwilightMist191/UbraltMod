using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UbraltMod.NPCs
{
    public class UbraltGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if(npc.type == NPCID.Golem)
            {
                if (Main.rand.Next(5) <= 1)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Summons.Boss.CursedSkull>(), 1);
                }
            }
        }
    }
}
