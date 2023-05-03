using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class OneUpMushroom : PowerupSliding
	{
		public override string Texture => $"{Mod.Name}/Content/SMBLS/1UpMushroom";
		private int frames = 2;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("1-Up Mushroom");
			Main.npcFrameCount[NPC.type] = frames;
		}
		public override void FindFrame(int frameHeight)
		{
			int maxFrame = 1;
			NPC.frameCounter++;
			if (NPC.frameCounter >= 15)
			{
				NPC.frameCounter = 0;
				if (NPC.frame.Y < maxFrame * frameHeight)	{	NPC.frame.Y += 1 * frameHeight;	}
				else {	NPC.frame.Y = 0 * frameHeight;	}
			}
		}
	}
}