using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class SuperMushroom : PowerupSliding
	{
		public override string Texture => $"{Mod.Name}/Content/SMBLS/SuperMushroom";
		private int frames = 1;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Mushroom");
			Main.npcFrameCount[NPC.type] = frames;
		}
		public override void Collect()
		{
			Main.NewText("Collected Super Mushroom.");
		}
	}
}