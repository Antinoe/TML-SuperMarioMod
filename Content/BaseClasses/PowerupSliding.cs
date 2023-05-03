using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class PowerupSliding : Powerup
	{
		public override string Texture => $"{Mod.Name}/Content/BaseClasses/Powerup";
		public override void SetDefaults()
		{
			base.SetDefaults();
			NPC.aiStyle = NPCAIStyleID.CritterWorm;
		}
		public override void AI()
		{
			base.AI();
			if (NPC.velocity.Y == 0)
			{
				NPC.velocity.X *= 5f;
			}
		}
	}
}