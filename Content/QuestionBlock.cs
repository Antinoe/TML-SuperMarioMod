using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod.Content
{
	public class QuestionBlock : TileNPC
	{
		public override string Texture => $"{Mod.Name}/Content/QuestionBlock";
		private int frames = 3;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Question Block");
			Main.npcFrameCount[NPC.type] = frames;
		}
		public override void FindFrame(int frameHeight)
		{
			int maxFrame = 2;
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