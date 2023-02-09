namespace Sticks.Players;

/// <summary>
/// A bot that tries to cheat the game.
/// </summary>
public class BadActor : Bot
{
	public override int Take(int sticksLeft, int maxTake) => sticksLeft - 1;
}
