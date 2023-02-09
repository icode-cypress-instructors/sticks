namespace Sticks.Players;

/// <summary>
/// Contains common implementation of bot players, i.e. their unique ID.
/// </summary>
public abstract class Bot : IPlayer
{
	/// <summary>
	/// The ID of the bot, to distinguish multiple instances of the same bot in a game.
	/// </summary>
	private static int _id;

	public string Name { get; }

	protected Bot()
	{
		Name = $"{GetType().Name} {++_id}";
	}

	public abstract int Take(int sticksLeft, int maxTake);
}
