using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class PowerupGliding : Powerup
	{
		public override string Texture => $"{Mod.Name}/Content/BaseClasses/Powerup";
		public override void SetDefaults()
		{
			base.SetDefaults();
			NPC.aiStyle = NPCAIStyleID.Spore;
		}
	}
}