using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class TileNPC : ModNPC
	{
		public override string Texture => $"{Mod.Name}/Content/Powerup";
		public override void SetDefaults()
		{
			NPC.width = 30;
			NPC.height = 30;
			NPC.dontTakeDamage = true;
			NPC.damage = 0;
			NPC.lifeMax = 1;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.noGravity = true;
			NPC.aiStyle = NPCAIStyleID.FaceClosestPlayer;
		}
	}
}