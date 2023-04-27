using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SuperMarioMod
{
	public class SuperMarioModPlayer : ModPlayer
	{
		public override void PreUpdateMovement()
		{
			//	Shamelessly stolen from Metroid Mod.
			//	Dumb jokes aside, thank you for pointing this out, Joost.
			//	I probably won't use this code, though. NPCs/Projectiles switching to and from Tiles would
			//	probably be better for the goal I'm aiming for.
			for (int i = 0; i < 200; ++i)
			{
				NPC npc = Main.npc[i];
				if (npc.type == ModContent.NPCType<Content.TileNPC>())
				{
					if (npc.type != ModContent.NPCType<Content.TileNPC>()) { continue; }

					if (Player.position.X + Player.width >= npc.position.X && Player.position.X <= npc.position.X + npc.width && Player.position.Y + Player.height <= npc.position.Y && Player.position.Y + Player.velocity.Y + Player.height >= npc.position.Y)
					{
						Player.velocity.Y = 0;
						Player.position = Player.oldPosition;

						if (npc.type == ModContent.NPCType<Content.TileNPC>())
						{
							if ((npc.direction == 1 && npc.velocity.X < 2) || (npc.direction == -1 && npc.velocity.X > -2))
							{
								Player.position.X = Player.oldPosition.X + npc.velocity.X + (npc.direction * .08F);
							}
							else
							{
								Player.position.X = Player.oldPosition.X + npc.velocity.X;
							}
						}
					}
				}
			}
		}
    }
}
