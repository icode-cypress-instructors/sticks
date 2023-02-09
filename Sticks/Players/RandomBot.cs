using System;

namespace Sticks.Players;

/// <summary>
/// A bot that makes random moves.
/// </summary>
public class RandomBot : Bot
{
	private readonly Random _random = new Random();

	public override int Take(int sticksLeft, int maxTake) => _random.Next(SticksGame.MinTake, maxTake + 1);
}
