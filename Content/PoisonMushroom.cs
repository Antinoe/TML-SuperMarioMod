using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class PoisonMushroom : PowerupSliding
	{
		public override string Texture => $"{Mod.Name}/Content/SMBLS/PoisonMushroom";
		private int frames = 1;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poison Mushroom");
			Main.npcFrameCount[NPC.type] = frames;
		}
		public override void SetDefaults()
		{
			NPC.damage = 100;
		}
		public override void Collect()
		{
			Main.NewText("Collected Poison Mushroom.");
		}
	}
}