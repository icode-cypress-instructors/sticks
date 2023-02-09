using System;
using Sticks.Players;

namespace Sticks;

public class SticksGame
{
	public const int MinTake = 1;
	private readonly int _maxTake;
	private int _sticks;
	private readonly IPlayer[] _players;
	private int _currentPlayerIdx;

	private IPlayer CurrentPlayer => _players[_currentPlayerIdx];

	// NOTE: This property changes the value of _currentPlayer
	private IPlayer SwitchPlayer =>
		_players[_currentPlayerIdx = (_currentPlayerIdx + 1) % _players.Length];

	public SticksGame(int sticks, int maxTake)
	{
		this._sticks = sticks;
		this._maxTake = maxTake;
		this._players = new IPlayer[]
		{
			new Human("Player 1"),
			new Human("Player 2"),
		};
	}

	public SticksGame(int sticks, int maxTake, IPlayer[] players)
	{
		this._sticks = sticks;
		this._maxTake = maxTake;
		this._players = players;
	}

	public static int Prompt(string prompt)
	{
		Console.Write(prompt);
		int result;
		while (!int.TryParse(Console.ReadLine()!, out result) || result <= 0)
		{
			Console.Write("Invalid input. Please enter a positive integer: ");
		}

		return result;
	}

	public void Play()
	{
		IPlayer player = CurrentPlayer;
		while (_sticks > 0)
		{
			Console.WriteLine($"{player.Name}'s turn. Sticks left: {_sticks}");

			int take = ValidateTurn(player, player.Take(_sticks, _maxTake));

			_sticks -= take;
			player = SwitchPlayer;
		}

		// The player that did not take the last stick is the winner
		IPlayer winner = player;
		Console.WriteLine($"{winner.Name} wins!");

		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}

	private int ValidateTurn(IPlayer player, int take)
	{
		if (take > _maxTake)
		{
			int min = Math.Min(_maxTake, _sticks);
			Console.WriteLine($"!! {player} tried to take {take} sticks, which is more than {_maxTake}. " +
			                  $"Limiting their move to {min} sticks.");
			return min;
		}

		if (take < MinTake)
		{
			Console.WriteLine($"!! {player} tried to take {take} sticks, which is less than {MinTake}. " +
			                  $"Limiting their move to {MinTake} sticks.");
			return MinTake;
		}

		if (take > _sticks)
		{
			Console.WriteLine($"!! {player} tried to take {take} sticks, which is more than " +
			                  $"the sticks remaining in the pile ({_sticks}). " +
			                  $"Limiting their move to {_sticks}");
			return _sticks;
		}

		return take;
	}
}
