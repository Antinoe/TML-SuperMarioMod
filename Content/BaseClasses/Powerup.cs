using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class Powerup : ModNPC
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
			NPC.aiStyle = NPCAIStyleID.Passive;
		}
		public override void AI()
		{
			if (NPC.Hitbox.Intersects(Main.LocalPlayer.Hitbox))
			{
				PreCollect();
			}
		}
		public void PreCollect()
		{
			var player = Main.LocalPlayer;
			var npc = this.NPC;
			npc.active = false;
			Collect();
		}
		public virtual void Collect()
		{
		}
	}
}