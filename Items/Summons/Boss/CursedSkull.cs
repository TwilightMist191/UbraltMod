using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace UbraltMod.Items.Summons.Boss
{
    public class CursedSkull : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Blessed by the gods long ago, \nThis skull calls for the true guardians of this world.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(2, 6));
        }

        public override void SetDefaults()
        {
            item.width = 31;
            item.height = 36;
            item.maxStack = 20;
            item.rare = ItemRarityID.Cyan;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return NPC.downedGolemBoss && player.ZoneDesert && !NPC.AnyNPCs(ModContent.NPCType<NPCs.Boss.Sharlteron.Sharlteron>());
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.Boss.Sharlteron.Sharlteron>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}
