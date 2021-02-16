using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UbraltMod.Projectiles
{
    public class AcidicSpit : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acidic Spit");
        }

        public override void SetDefaults()
        {
            projectile.width = 192;
            projectile.height = 132;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.hostile = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
        }
    }
}
