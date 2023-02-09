namespace Sticks.Players;

public interface IPlayer
{
	string Name { get; }

	/// <summary>
	/// Takes the player's turn, returning the number of sticks taken.
	/// </summary>
	/// <param name="sticksLeft">The number of sticks remaining in the pile.</param>
	/// <param name="maxTake">The maximum number of sticks a player can take on their turn.</param>
	/// <returns>The number of sticks taken by the player on their turn.</returns>
	int Take(int sticksLeft, int maxTake);
}
